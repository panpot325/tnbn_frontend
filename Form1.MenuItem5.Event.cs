using System;

// ReSharper disable MemberCanBeMadeStatic.Local
namespace WorkDataStudio;

/// <summary>
/// メニュー項目5 イベントハンドラ
/// </summary>
public partial class Form1 {
    /// <summary>
    /// @sm5_Click(1)
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void MenuItem_SM5_1_Click(object sender, EventArgs e) {
        Console.WriteLine(@"「[P]データ > 自動作成しない」が選択されました。");
        Process_SP(1, 1);
    }

    /// <summary>
    /// @sm5_Click(2)
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void MenuItem_SM5_2_Click(object sender, EventArgs e) {
        Console.WriteLine(@"「[P]データ > 自動作成する（西基準）」が選択されました。");
        Process_SP(1, 2);
    }

    /// <summary>
    /// @sm5_Click(3)
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void MenuItem_SM5_3_Click(object sender, EventArgs e) {
        Console.WriteLine(@"「[P]データ > 自動作成する（東基準）」が選択されました。");
        Process_SP(1, 3);
    }
}