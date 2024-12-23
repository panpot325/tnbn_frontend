using System;
using System.Windows.Forms;

namespace WorkDataStudio;

/// <summary>
/// コピー船番単位フォーム
/// </summary>
public partial class Form4 {
    /// <summary>
    /// Form4_Load
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Form4_Load(object sender, EventArgs e) {
        Console.WriteLine(@"Form4_Load");
    }

    /// <summary>
    /// Form4_Activated
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Form4_Activated(object sender, EventArgs e) {
        Console.WriteLine(@"Form4_Activated");
    }

    /// <summary>
    /// comboBox1_KeyUp
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void comboBox1_KeyUp(object sender, KeyEventArgs e) {
        if (e.KeyValue == (char)Keys.Enter) {
            comboBox2.Focus();
        }
    }

    /// <summary>
    /// comboBox2_KeyUp
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void comboBox2_KeyUp(object sender, KeyEventArgs e) {
        if (e.KeyValue == (char)Keys.Enter) {
            Process();
        }
    }
}