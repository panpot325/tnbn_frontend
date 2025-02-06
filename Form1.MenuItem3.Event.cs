using System;
using WorkDataStudio.share;
using WorkDataStudio.type;

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
        Log.WriteLine(@"「その他 > 今日の予定」が選択されました。");
        Process_Yotei();
    }

    /// <summary>
    /// @sm3_Click(2)
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void MenuItem_SM3_2_Click(object sender, EventArgs e) {
        Log.WriteLine(@"「その他 > 操作説明」が選択されました。");
        OpenDialog(FormType.Form6);
    }

    /// <summary>
    /// @sm3_Click(3)
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void MenuItem_SM3_3_Click(object sender, EventArgs e) {
        Log.WriteLine(@"「その他 > 完了情報」が選択されました。");
        OpenDialog(FormType.Form11);
    }
}