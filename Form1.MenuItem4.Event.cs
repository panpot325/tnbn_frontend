using System;
using WorkDataStudio.type;

// ReSharper disable MemberCanBeMadeStatic.Local
namespace WorkDataStudio;

/// <summary>
/// メニュー項目4 イベントハンドラ
/// </summary>
public partial class Form1 {
    /// <summary>
    /// @sm4_Click(1)
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void MenuItem_SM4_1_Click(object sender, EventArgs e) {
        Log.WriteLine(@"「[S]データ > 自動作成しない」が選択されました。");
        Process_SP(0, 1);
    }

    /// <summary>
    /// @sm4_Click(2)
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void MenuItem_SM4_2_Click(object sender, EventArgs e) {
        Log.WriteLine(@"「[S]データ > 自動作成する（西基準）」が選択されました。");
        Process_SP(0, 2);
    }

    /// <summary>
    /// @sm4_Click(3)
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void MenuItem_SM4_3_Click(object sender, EventArgs e) {
        Log.WriteLine(@"「[S]データ > 自動作成する（東基準）」が選択されました。");
        Process_SP(0, 3);
    }
}