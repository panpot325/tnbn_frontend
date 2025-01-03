using System;
using WorkDataStudio.type;

namespace WorkDataStudio;

/// <summary>
/// 操作説明フォーム
/// </summary>
public partial class Form6  {
    /// <summary>
    /// 戻る
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void MenuItem_Cancel_Click(object sender, EventArgs e) {
        Log.WriteLine(@"「戻る」が選択されました。");
        Close();
    }
}