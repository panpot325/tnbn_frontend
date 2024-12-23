using System;

namespace WorkDataStudio;

/// <summary>
/// 船番単位フォーム
/// </summary>
public partial class Form8 {
    /// <summary>
    /// Cancel_Click
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void MenuItem_Cancel_Click(object sender, EventArgs e) {
        Console.WriteLine(@"「戻る」が選択されました。");
        Close();
    }

    /// <summary>
    /// Enter_Click
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void MenuItem_Enter_Click(object sender, EventArgs e) {
        Console.WriteLine(@"「決定」が選択されました。");
        Process();
    }
}