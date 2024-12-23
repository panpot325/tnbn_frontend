using System;

namespace WorkDataStudio;

/// <summary>
/// コピー船番選択フォーム
/// </summary>
public partial class Form7 {
    /// <summary>
    /// 戻る
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void MenuItem_Cancel_Click(object sender, EventArgs e) {
        Console.WriteLine(@"「戻る」が選択されました。");
        Close();
    }

    /// <summary>
    /// 決定
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void MenuItem_Enter_Click(object sender, EventArgs e) {
        Console.WriteLine(@"「決定」が選択されました。");
        Process();
    }
}