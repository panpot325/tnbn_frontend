using System;

namespace WorkDataStudio;

/// <summary>
/// 船番単位削除フォーム
/// </summary>
public partial class Form9 {
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
    /// 抽出
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void MenuItem_Enter_Click(object sender, EventArgs e) {
        Console.WriteLine(@"「削除実行」が選択されました。");
        Process();
    }
}