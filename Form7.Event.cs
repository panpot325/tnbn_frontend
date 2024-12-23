using System;
using System.Windows.Forms;

namespace WorkDataStudio;

/// <summary>
/// コピー船番選択フォーム
/// </summary>
public partial class Form7 {
    /// <summary>
    ///  Form7_Load
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Form7_Load(object sender, EventArgs e) {
        Console.WriteLine(@"Form7_Load");
    }

    /// <summary>
    /// Form7_Activated
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Form7_Activated(object sender, EventArgs e) {
        Console.WriteLine(@"Form7_Activated");
    }

    /// <summary>
    /// textBox1_KeyUp
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    /// <exception cref="NotImplementedException"></exception>
    private void textBox1_KeyUp(object sender, KeyEventArgs e) {
        if (e.KeyValue == (char)Keys.Enter) {
            Process();
        }
    }

    /// <summary>
    /// comboBox1_KeyUp
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void comboBox1_KeyUp(object sender, KeyEventArgs e) {
        if (e.KeyValue == (char)Keys.Enter) {
            textBox1.Focus();
        }
    }
}