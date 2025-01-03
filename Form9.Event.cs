using System;
using System.Windows.Forms;
using WorkDataStudio.type;

namespace WorkDataStudio;

/// <summary>
/// 船番単位削除フォーム
/// </summary>
public partial class Form9 {
    /// <summary>
    /// Form9_Load
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Form9_Load(object sender, EventArgs e) {
        Log.WriteLine(@"Form9_Load");
    }

    /// <summary>
    /// Form9_Activated
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Form9_Activated(object sender, EventArgs e) {
        Log.WriteLine(@"Form9_Activated");
    }

    /// <summary>
    /// comboBox1_KeyUp
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void comboBox1_KeyUp(object sender, KeyEventArgs e) {
        if (e.KeyValue == (char)Keys.Enter) {
            Process();
        }
    }
}