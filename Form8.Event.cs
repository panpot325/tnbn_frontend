using System;
using System.Windows.Forms;

namespace WorkDataStudio;

/// <summary>
/// 船番単位フォーム
/// </summary>
public partial class Form8  {
    /// <summary>
    /// @Form_Load()
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Form8_Load(object sender, EventArgs e) {
        Console.WriteLine(@"Form8_Load");
    }

    /// <summary>
    /// comboBox1_KeyUp
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void comboBox1_KeyUp(object sender, KeyEventArgs e) {
        switch (e.KeyValue) {
            case (char)Keys.Enter:
                Console.WriteLine(@"「決定」が選択されました。");
                Process();
                break;
        }
    }

    /// <summary>
    /// comboBox1でEnterを押してもビープ音が鳴らないようにする
    /// </summary>
    /// <param name="keyData"></param>
    /// <returns></returns>
    protected override bool ProcessDialogKey(Keys keyData) {
        if (comboBox1.Focused &&
            (keyData & Keys.KeyCode) == Keys.Enter) {
            return true;
        }

        return base.ProcessDialogKey(keyData);
    }
}