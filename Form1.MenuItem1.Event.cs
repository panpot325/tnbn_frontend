using System;
using WorkDataStudio.share;

namespace WorkDataStudio;

/// <summary>
/// メニュー項目1 イベントハンドラ
/// </summary>
public partial class Form1 {
    /// <summary>
    /// @sm1_Click(1)
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void MenuItem_SM1_1_Click(object sender, EventArgs e) {
        Console.WriteLine(@"「新規・登録」が選択されました。");
        Mode.SetNew1();
        Process_New();
        Frame2.Enabled = true;
        Option1_0.Checked = true;
    }

    /// <summary>
    /// @sm1_Click(2)
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void MenuItem_SM1_2_Click(object sender, EventArgs e) {
        Console.WriteLine(@"「新規・登録（対象）」が選択されました。");
        Mode.SetNew2(); //新規2
        Process_New();
        Frame2.Enabled = false;
        Option1_1.Checked = true;
    }

    /// <summary>
    /// @sm1_Click(3)
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void MenuItem_SM1_3_Click(object sender, EventArgs e) {
        Console.WriteLine(@"「終了」が選択されました。");
        Close();
    }
}