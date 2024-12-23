using System;
using WorkDataStudio.model;
using G = WorkDataStudio.share.Globals;
using C = WorkDataStudio.share.Constants;

// ReSharper disable MemberCanBeMadeStatic.Local
namespace WorkDataStudio;

/// <summary>
/// メニュー項目3 イベントハンドラ
/// </summary>
public partial class Form1 {
    /// <summary>
    /// @sm3_Click(1)
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void MenuItem_SM3_1_Click(object sender, EventArgs e) {
        Console.WriteLine(@"「その他 > 今日の予定」が選択されました。");
        ViewNameText();
        ClearExclusive();
        ClearVariables();
        G.Mode = C.MODE_EDIT_3;
        ViewNameText();
        WorkData.Filter._Yotei(Convert.ToInt32(DateTime.Now.ToString("yyyyMMdd")));
        WorkData.GetAll();
        if (WorkData.Exists) {
            DataGrid1.ShowWorkDataList();
            DataGrid3.ShowWorkData(DataGrid1.WorkData);
            DataGrid3.Focus();
            DataGrid1.Enabled = true;
            return;
        }

        Text4.Text = $@"{DateTime.Now:MM/dd}の予定データはありません。";
    }

    /// <summary>
    /// @sm3_Click(2)
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void MenuItem_SM3_2_Click(object sender, EventArgs e) {
        Console.WriteLine(@"「その他 > 操作説明」が選択されました。");
    }

    /// <summary>
    /// @sm3_Click(3)
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void MenuItem_SM3_3_Click(object sender, EventArgs e) {
        Console.WriteLine(@"「その他 > 完了情報」が選択されました。");
    }
}