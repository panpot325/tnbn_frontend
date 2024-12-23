using System;
using System.Windows.Forms;
using G = WorkDataStudio.share.Globals;
using C = WorkDataStudio.share.Constants;

// ReSharper disable InterpolatedStringExpressionIsNotIFormattable
// ReSharper disable InvertIf
// ReSharper disable MemberCanBeMadeStatic.Local
namespace WorkDataStudio;

/// <summary>
/// DataGridView3
/// TextBox
/// </summary>
public partial class Form1 {
    /// <summary>
    /// GotFocus
    /// </summary>
    /// <param name="sender"></param>   
    /// <param name="e"></param>
    private void DataGridViewTextBox_GotFocus(object sender, EventArgs e) {
        G.Out("dataGridViewTextBox_GotFocus EVENT");
        ((DataGridViewTextBoxEditingControl)sender).ImeMode = ImeMode.Disable;
    }

    /// <summary>
    /// TextChanged
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void DataGridViewTextBox_TextChanged(object sender, EventArgs e) {
        G.Out("dataGridViewTextBox_TextChanged EVENT");
        if (DataGrid3.DataType.NyuMode == C.NYU_MODE_NUM) {
            Grid3_TextBox_Value_Check((DataGridViewTextBoxEditingControl)sender);
        }
    }
    /// <summary>
    /// 数値チェック
    /// </summary>
    /// <param name="tb"></param>
    private void Grid3_TextBox_Value_Check(DataGridViewTextBoxEditingControl tb) {
        for (var i = 0; i < tb.Text.Length; i++) {
            switch (i, tb.Text[i]) {
                case (> 0, '-'): //最初の１文字目以外に−が入っていたら削除
                case (_, <= ' '):
                case (_, > '9'):
                case (_, '/'):
                    tb.Text = tb.Text.Remove(i, 1);
                    tb.Select(tb.Text.Length, 0); //カーソル位置をテキストの末尾へ
                    tb.Focus();
                    return;
            }
        }
    }
}