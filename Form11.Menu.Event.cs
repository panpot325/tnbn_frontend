using System;

namespace WorkDataStudio;

/// <summary>
/// 完了情報フォーム
/// </summary>
public partial class Form11 {
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
        Console.WriteLine(@"「データ更新」が選択されました。");
        Process();
    }
}