using System;
using System.Windows.Forms;
using WorkDataStudio.Model;
using WorkDataStudio.share;
using WorkDataStudio.type;

namespace WorkDataStudio;

/// <summary>
/// Form1.Process
/// </summary>
public partial class Form1 {
    /// <summary>
    /// Process_New
    /// </summary>
    private void Process_New() {
        Log.WriteLine(@"Process_New");
        WorkData.Clear();
        WorkData.copySelectCnt = 0;
        WorkDataExclusive.Delete();

        MessageClear();
        Text4.Text = @"新規登録は、そのまま右側の明細を入力して下さい。";
        Text4.ForeColor = FgColor.VALID;

        DataGrid1.Clear().Add();
        DataGrid3
            .ShowWorkData(DataGrid1.WorkData)
            .Select(0)
            .Focus();
        
        Frame2.Enabled = true;
        Option1_0.Checked = false;
        Option1_1.Checked = true;
    }

    /// <summary>
    /// 船番指定
    /// </summary>
    private void Process_Edit() {
        if (!WorkData.Exists) return;
        DataGrid1.ShowWorkDataList(); //グリッド1の表示
        //グリッド1_Sデータ作成色設定_読込時
        //グリッド1_Pデータ作成色設定_読込時
        DataGrid1.SP_BackColor();
        DataGrid1.SetTmpRowBackColor();
        DataGrid3.ShowWorkData(DataGrid1.WorkData);

        Frame2.Enabled = true;
        Option1_0.Checked = false;
        Option1_1.Checked = true;
    }

    /// <summary>
    /// 船番コピー キーコピー
    /// </summary>
    private void Process_Copy() {
        if (!WorkData.Exists) return;
        DataGrid1.ShowWorkDataList(); //グリッド1の表示
        DataGrid1.SetTmpRowBackColor();
        DataGrid3.ShowWorkData(DataGrid1.WorkData);

        Frame2.Enabled = false;
        Option1_0.Checked = false;
        Option1_1.Checked = true;
    }

    /// <summary>
    /// 今日予定
    /// </summary>
    private void Process_Yotei() {
        WorkData.Filter._Yotei(Convert.ToInt32(DateTime.Now.ToString("yyyyMMdd")));
        if (WorkData.GetCount() < 1) {
            Text4.Text = $@"{DateTime.Now:MM/dd}の予定データはありません。";
            return;
        }

        WorkData.Clear();
        Mode.SetEdit3();
        OptionSet(false);
        ViewNameText();
        MessageClear();
        WorkDataExclusive.Delete();
        WorkData.GetAll();
        DataGrid1.Clear();
        DataGrid1.ShowWorkDataList();
        DataGrid3.ShowWorkData(DataGrid1.WorkData).Focus();

        Frame2.Enabled = false;
        Option1_0.Checked = false;
        Option1_1.Checked = true;
    }

    /// <summary>
    /// Process_Save
    /// </summary>
    private void Process_Save() {
        Text4.Text = "";
        foreach (var workData in WorkData.List) {
            workData.Err1Flg = 0; //入力ﾁｪｯｸｴﾗｰﾌﾗｸﾞ
            workData.Err2Flg = 0; //重複ﾁｪｯｸｴﾗｰﾌﾗｸﾞ
        }

        switch (Mode.Value) {
            case Mode.NEW_1: //新規登録
                Save_New_1();
                return;

            case Mode.EDIT_1: //船番指定
                Save_Edit_Copy_1();
                return;

            case Mode.COPY_1: //船番コピー
                Save_Edit_Copy_1();
                return;

            case Mode.COPY_2: //キーコピー
                Save_Copy_2();
                return;

            case Mode.EDIT_3: //今日予定
                Save_Edit_3();
                return;

            case Mode.EMode.NEW_2:
            case Mode.EMode.NEW_3:
            case Mode.EMode.EDIT_2:
            default:
                return;
        }
    }

    /// <summary>
    /// Process_Delete
    /// </summary>
    private void Process_Delete(int deleteMode) {
        if (Mode.IsCopy2) {
            MessageBox.Show(@"コピー(キー単位)中は、削除できません。");
            return;
        }

        var workData = DataGrid1.WorkData;

        switch (workData.ChgFlg) {
            case WorkData.UPDATE:
                if (deleteMode != WorkData.DELETE) return;
                break;
            case WorkData.DELETE:
                if (deleteMode != WorkData.UPDATE) return;
                break;
            default:
                return;
        }

        switch (deleteMode) {
            case WorkData.DELETE:
                if (WorkDataExclusive.Count(workData.Sno) == 0) {
                    if (WorkDataExclusive.Count(workData.Sno, 1) == 0) {
                        WorkDataExclusive.Insert(workData.Sno);
                    }
                }

                //DataGrid1.RowBackColor = BgColor.DELETED;
                DataGrid1.SelectRowBackColor(BgColor.DELETED);
                break;

            default:
                WorkDataExclusive.Delete(workData.Sno);
                //DataGrid1.RowBackColor = BgColor.DEFAULT;
                DataGrid1.SelectRowBackColor(DataGrid1.GetTmpRowBackColor());


                break;
        }

        workData.ChgFlg = deleteMode;
        DataGrid1.ShowWorkData();
    }

    /// <summary>
    /// Process_SP
    /// </summary>
    /// <param name="sp"></param>
    /// <param name="index"></param>
    private void Process_SP(int sp, int index) {
        if (Frame2.Enabled) {
            switch (sp) {
                case 0:
                    DataGrid1.S_BackColor(index, Text4);
                    break;
                case 1:
                    DataGrid1.P_BackColor(index, Text4);
                    break;
            }

            return;
        }

        Text4.Text = @"現在のモードでは、使用できません。";
    }
}