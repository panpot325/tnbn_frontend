using System;
using WorkDataStudio.Model;
using WorkDataStudio.share;
using WorkDataStudio.type;

// ReSharper disable MemberCanBeMadeStatic.Local
namespace WorkDataStudio;

/// <summary>
/// データ登録
/// </summary>
public partial class Form1 {
    /// <summary>
    ///  新規登録
    /// </summary>
    private void Save_New_1() {
        if (WorkData.ValidAll() > 0) {
            ValidMessage(); //入力エラーのデータを表示
            return;
        }

        if (WorkData.DuplicateAll() > 0) {
            DuplicateMessage();
            //DataGrid1.RowIndex = 0;
            //DataGrid3.ShowWorkData(DataGrid1.WorkData);
            return;
        }

        WorkData.UpdateAll(true); //加工ワークデータの更新
        WorkData_S_Create(); // @Sデータの作成と登録
        WorkData_S_Update(); // @加工ワークデータSの更新
        WorkData_P_Create(); // @Pデータの作成と登録
        WorkData_PS_Update(); // @CrePSFlgの更新
        WorkDataExclusive.Delete(); //Del_排他情報
        Mode.SetNew1();
        Process_New();
    }

    /// <summary>
    ///  新規登録2
    /// </summary>
    private void Save_New_2() {
        DataGrid1.SetGridData(DataGrid3);
        WorkData_E_W_Edit(); // 西東対象データ編集
        WorkData.List[0].ChgFlg = WorkData.UPDATE;
        WorkData.List[0].Err1Flg = 0;
        WorkData.List[0].Err2Flg = 0;
        //WorkData.List[0].E_W_Edit();
        
        if (WorkData.ValidAll() > 0) {
            ValidMessage(); //入力エラーのデータを表示
            return;
        }

        if (WorkData.DuplicateAll() > 0) {
            DuplicateMessage();
            //DataGrid1.RowIndex = 0;
            //DataGrid3.ShowWorkData(DataGrid1.WorkData);
            return;
        }

        WorkData.UpdateAll(true); //加工ワークデータの更新
        WorkData_S_Create(); // @Sデータの作成と登録
        WorkData_S_Update(); // @加工ワークデータSの更新
        WorkData_P_Create(); // @Pデータの作成と登録
        WorkData_PS_Update(); // @CrePSFlgの更新
        WorkDataExclusive.Delete(); //Del_排他情報
        Mode.SetNew2();

        
        
        Process_New();
    }

    /// <summary>
    ///  船番指定 船番コピー
    /// </summary>
    private void Save_Edit_Copy_1() {
        WorkData.DeleteAll(WorkData.snoName); //加工ワークデータの削除_船番
        WorkData.UpdateAll(); //加工ワークデータの更新
        WorkData_S_Create(); // @Sデータの作成と登録
        WorkData_S_Update(); // @加工ワークデータSの更新
        WorkData_P_Create(); // @Pデータの作成と登録
        WorkData_PS_Update(); // @CrePSFlgの更新
        WorkDataExclusive.Delete(); //Del_排他情報
        Mode.SetNew1();
        Process_New();
    }

    /// <summary>
    /// キーコピー
    /// </summary>
    private void Save_Copy_2() {
        if (WorkData.ValidAll() > 0) {
            ValidMessage();
            return;
        }

        if (WorkData.DuplicateAll(true) > WorkData.Count) {
            DuplicateMessage();
            return;
        }

        WorkData.InsertAll(); //Ins_加工ワークデータ(i)
        WorkDataExclusive.Delete(); //Del_排他情報
        Mode.SetNew1();
        Process_New();
    }

    /// <summary>
    /// 今日予定
    /// </summary>
    private void Save_Edit_3() {
        if (WorkData.ValidAll() > 0) {
            ValidMessage();
            return;
        }

        WorkData.UpdateAll(true); //加工ワークデータの更新
        WorkDataExclusive.Delete(); //Del_排他情報
        Mode.SetNew1();
        Process_New();
    }

    /// <summary>
    /// 重複メッセージ
    /// </summary>
    private void DuplicateMessage() {
        Text4.Text = $@"キーが重複しています。{Environment.NewLine}";
        Text4.Text += $@"登録処理を中断します。{Environment.NewLine}";
        Text4.Text += $@"正しいキーを入力し直してください。{Environment.NewLine}";
        Text4.ForeColor = FgColor.INVALID;
        DataGrid3.SetBackColor(DataGrid1.WorkData);
        DataGrid3.CurrentCell = DataGrid3[0, DataGrid3.RowIndex];
    }

    /// <summary>
    /// エラーメッセージ
    /// </summary>
    private void ValidMessage() {
        Text4.Text = $@"入力値が正しくないデータがある為{Environment.NewLine}";
        Text4.Text += $@"登録処理を中断します。{Environment.NewLine}";
        Text4.Text += $@"正しい値を入力し直してください。{Environment.NewLine}";
        Text4.ForeColor = FgColor.INVALID;
        DataGrid3.SetBackColor(DataGrid1.WorkData);
        DataGrid3.CurrentCell = DataGrid3[0, DataGrid3.RowIndex];
    }
}