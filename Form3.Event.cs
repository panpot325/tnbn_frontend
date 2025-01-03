using System;
using System.Windows.Forms;
using WorkDataStudio.share;
using WorkDataStudio.type;
using G = WorkDataStudio.share.Globals;

// ReSharper disable InvertIf
namespace WorkDataStudio;

public partial class Form3 {
    /// <summary>
    /// Form3_Load
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Form3_Load(object sender, EventArgs e) {
        Log.WriteLine(@"STEP1: Form3_Load");
    }

    /// <summary>
    /// Changed Event 入力文字チェック
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void textBox1_TextChanged(object sender, EventArgs e) {
        for (var i = 0; i < textBox1.Text.Length; i++) {
            if (i > 0 && textBox1.Text[i] == '-'
                || textBox1.Text[i] >= ' ' && textBox1.Text[i] < '-'
                || textBox1.Text[i] > '9' || textBox1.Text[i] == '/'
               ) {
                textBox1.Text = textBox1.Text.Substring(0, i)
                                + textBox1.Text.Substring(i + 1, textBox1.Text.Length - i - 1);
                textBox1.Select(textBox1.Text.Length, 0);
                return;
            }
        }
    }

    /// <summary>
    /// Key Up Event
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void textBox1_KeyUp(object sender, KeyEventArgs e) {
        if (e.KeyValue == (char)Keys.Enter) {
            if (textBox1.Text == "") {
                MessageBox.Show(@"社員番号を入力してください。", @"社員番号", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else {
                G.staffId = int.Parse(textBox1.Text);
                Program.ShowForm(FormType.Form1);
                Close();
            }
        }
    }

    /// <summary>
    /// TextBox1でEnterを押してもビープ音が鳴らないようにする
    /// </summary>
    /// <param name="keyData"></param>
    /// <returns></returns>
    protected override bool ProcessDialogKey(Keys keyData) {
        if (textBox1.Focused &&
            (keyData & Keys.KeyCode) == Keys.Enter) {
            return true;
        }

        return base.ProcessDialogKey(keyData);
    }
}