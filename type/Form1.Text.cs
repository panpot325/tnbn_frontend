using System;
using System.Linq;
using System.Windows.Forms;
using WorkDataStudio.model;
using G = WorkDataStudio.share.Globals;
using C = WorkDataStudio.share.Constants;

namespace WorkDataStudio;

/// <summary>
/// 加工ワークデータ作成フォーム Text
/// </summary>
public partial class Form1 : Form {
    /// <summary>
    /// @Text5_Change()
    /// @Deprecated
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    /// <exception cref="NotImplementedException"></exception>
    private void Text5_TextChanged(object sender, EventArgs e) {
    }

    /// <summary>
    /// @Text5_GotFocus()
    /// @Deprecated
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    /// <exception cref="NotImplementedException"></exception>
    private void Text5_Enter(object sender, EventArgs e) {
    }

    /// <summary>
    /// @Text5_KeyDown(KeyCode As Integer, Shift As Integer)
    /// @Deprecated
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    /// <exception cref="NotImplementedException"></exception>
    private void Text5_KeyDown(object sender, KeyEventArgs e) {
        switch (e.KeyValue) {
            case (char)Keys.Escape:
                Text5.Visible = false;
                DataGrid3.Focus();
                break;
            case (char)Keys.Enter:
                DataGrid3.Focus();
                break;
            case (char)Keys.Up: // 0x00000026
                DataGrid3.Focus();
                DataGrid3_SelectionChanged(sender, null);
                break;
        }
    }

    /// <summary>
    /// @Text5_KeyPress(KeyAscii As Integer)
    /// @Deprecated
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    /// <exception cref="NotImplementedException"></exception>
    private void Text5_KeyPress(object sender, KeyPressEventArgs e) {
    }

    /// <summary>
    /// @Text5_LostFocus()
    /// @Deprecated
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    /// <exception cref="NotImplementedException"></exception>
    private void Text5_Leave(object sender, EventArgs e) {
    }
}