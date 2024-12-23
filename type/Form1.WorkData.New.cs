using System.Linq;
using WorkDataStudio.model;
using WorkDataStudio.type;
using G = WorkDataStudio.share.Globals;
using C = WorkDataStudio.share.Constants;

namespace WorkDataStudio;

/// <summary>
/// 加工ワークデータ作成 データ登録
/// </summary>
public partial class Form1 {
    /// <summary>
    /// 新規, 新規2
    /// </summary>
    private void WorkData_Mode_New_1_2() {
        //キー重複チェック
        if (!WorkData_Duplicate()) {
            WorkDataDuplicateMessage();
            DataGrid3.SetBackColor(DataGrid1.WorkData);
            DataGrid3.CurrentCell = DataGrid3[0, DataGrid3.RowIndex];

            if (DataGrid1.Enabled) {
                DataGrid1.Focus();
            }
            else {
                DataGrid3.Focus();
            }

            return;
        }

        //@加工ワークデータの更新()
        //画面のＰ、Ｃ、Ｓ を登録
        WorkData_Update();

        //Ｐ⇒Ｓを作成するか否か
        if (Frame2.Enabled && Option1_0.Checked) {
            // @Sデータの作成と登録()
            WorkData_S_Create();
        }

        // @加工ワークデータSの更新()
        WorkData_S_Update();

        //Ｓ⇒Ｐを作成するか否か
        if (Frame2.Enabled && Option1_0.Checked) {
            // @Pデータの作成と登録()
            WorkData_P_Create();

            // @CrePSFlgの更新()
            WorkData_PS_Update();
        }

        //Del_排他情報
        WorkDataExclusive.Delete(G.staffId, G.pcName);

        G.copyDataSelCnt = 0;
        ClearVariables();

        if (G.Mode == C.MODE_NEW_2) {
            Frame2.Enabled = false;
            Option1_1.Checked = true;
        }
        else {
            G.Mode = C.MODE_NEW_1;
        }
    }

    /// <summary>
    /// キーコピー
    /// </summary>
    private void WorkData_Mode_Copy_2() {
        //キー重複チェック
        if (!WorkData_Duplicate() && G.duplicateErrCnt >= G.workDataCnt) {
            WorkDataDuplicateMessage();
            var r = DataGrid1.RowIndex;
            DataGrid3.SetBackColor(DataGrid1.WorkData);
            DataGrid3.CurrentCell = DataGrid3[0, r];

            if (DataGrid1.Enabled) {
                DataGrid1.Focus();
            }
            else {
                DataGrid3.Focus();
            }

            return;
        }

        foreach (var workData in WorkData.List.Where(
                     workData => workData.ChgFlg == C.UPDATE
                                 && workData.Err1Flg == 0
                                 && workData.Err2Flg == 0)) {
            workData.Insert();
        }

        //Del_排他情報
        WorkDataExclusive.Delete(G.staffId, G.pcName);
        G.copyDataSelCnt = 0;
        ClearVariables();
        G.Mode = C.MODE_NEW_1;
    }

   /// <summary>
   /// 今日以降, 今日予定
   /// </summary>
    private void WorkData_Mode_Edit_2_3() {
        //加工ワークデータの更新
        WorkData_Update();
        //Del_排他情報
        WorkDataExclusive.Delete(G.staffId, G.pcName);
        ClearVariables();
        G.Mode = C.MODE_NEW_1;
    }

    /// <summary>
    /// 船番指定, 船番コピー
    /// </summary>
    private void WorkData_Mode_Edit_1_Copy_1() {
        //Delete処理
        //Call 加工ワークデータの削除_船番

        //画面のＰ、Ｃ、Ｓ を登録
        WorkData_Update();//@加工ワークデータの更新
        
        //Ｐ⇒Ｓを作成するか否か
        if (Frame2.Enabled && Option1_0.Checked) {
            WorkData_S_Create();//@Sデータの作成と登録
        }

        //画面のＳを登録(Pを作成するモノのみ) 
        WorkData_S_Update(); //@加工ワークデータSの更新

        //Ｓ⇒Ｐを作成するか否か
        if (Frame2.Enabled && Option1_0.Checked) {
            WorkData_P_Create();//@Pデータの作成と登録()
        }

        //CreS_Flg, CreP_Flg を画面の状況で更新
        if (Frame2.Enabled && Option1_0.Checked) {
            WorkData_PS_Update(); // @CrePSFlgの更新()
        }

        //Del_排他情報
        WorkDataExclusive.Delete(G.staffId, G.pcName);
        G.copyDataSelCnt = 0;
        ClearVariables();
        G.Mode = C.MODE_NEW_1;
    }

    /// <summary>
    /// Default
    /// </summary>
    private void WorkData_Mode_Default() {
        WorkDataValidMessage();
        var r = DataGrid1.RowIndex;
        DataGrid3.SetBackColor(DataGrid1.WorkData);
        DataGrid3.CurrentCell = DataGrid3[0, r];

        if (DataGrid1.Enabled) {
            DataGrid1.Focus();
        }
        else {
            DataGrid3.Focus();
        }
    }
}