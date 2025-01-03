using System;
using WorkDataStudio.type;

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
        Log.WriteLine(@"「戻る」が選択されました。");
        Close();
    }

    /// <summary>
    /// Enter_Click
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void MenuItem_Enter_Click(object sender, EventArgs e) {
        Log.WriteLine(@"「決定」が選択されました。");
        Process();
    }
}