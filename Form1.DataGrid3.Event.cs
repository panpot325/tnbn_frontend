using System;
using System.Windows.Forms;
using WorkDataStudio.Component;
using WorkDataStudio.share;
using G = WorkDataStudio.share.Globals;

// ReSharper disable InvertIf
// ReSharper disable InterpolatedStringExpressionIsNotIFormattable
// ReSharper disable MemberCanBeMadeStatic.Local
namespace WorkDataStudio;

/// <summary>
/// DataGridView3
/// イベントハンドラ
/// </summary>
public partial class Form1 {
    /// <summary>
    /// @MSFlexGrid3_KeyDown(KeyCode As Integer, Shift As Integer)
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    /// <exception cref="NotImplementedException"></exception>
    private void DataGrid3_KeyDown(object sender, KeyEventArgs e) { G.Out("DataGrid3_KeyDown Event");
        Grid_Edit(e.KeyValue);
    }

    /// <summary>
    /// @MSFlexGrid3_KeyPress(KeyAscii As Integer)
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    /// <exception cref="NotImplementedException"></exception>
    private void DataGrid3_KeyPress(object sender, KeyPressEventArgs e) {
        G.Out(@"DataGrid3_KeyPress");
        Grid_Edit(e.KeyChar);
    }

    /// <summary>
    /// @MSFlexGrid3_Scroll()
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    /// <exception cref="NotImplementedException"></exception>
    private void DataGrid3_Scroll(object sender, ScrollEventArgs e) {
        G.Out("@DataGrid3_Scroll");
        Grid_Scroll();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void DataGrid3_CurrentCellChanged(object sender, EventArgs e) {
    }

    /// <summary>
    /// @MSFlexGrid3_SelChange()
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    /// <exception cref="NotImplementedException"></exception>
    private void DataGrid3_SelectionChanged(object sender, EventArgs e) {
        G.Out("DataGrid3_SelectionChanged Event");
        DataGrid3.DefaultCellStyle.SelectionBackColor = BgColor.CLEARED;
        Grid_Change();
    }

    /// <summary>
    /// EditingControlShowingイベントハンドラ
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void DataGrid3_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e) {
        if (e.Control is DataGridViewTextBoxEditingControl tb) {
            DataGrid3.Tag = DataGrid3.StrValue;
            tb.Text = DataGrid3.Text;
            tb.GotFocus += DataGridViewTextBox_GotFocus;
            tb.TextChanged += DataGridViewTextBox_TextChanged;
        }
    }

    /// <summary>
    /// CellEndEdit
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    /// <exception cref="NotImplementedException"></exception>
    private void DataGrid3_CellEndEdit(object sender, DataGridViewCellEventArgs e) {
        G.Out($"DataGrid3_CellEndEdit Event: {DataGrid3.StrValue}");
        Text4.Text = "";
        DataGrid3.TextEdit(DataGrid1, Text4);
    }

    /// <summary>
    /// </summary>
    /// <param name="keyData"></param>
    /// <returns></returns>
    protected override bool ProcessDialogKey(Keys keyData) {
        if ((keyData & Keys.KeyCode) == Keys.Enter) {
            var currentCell = DataGrid3.CurrentCell;
            DataGrid3.EndEdit();
            DataGrid3.CurrentCell = null;
            DataGrid3.CurrentCell = currentCell;
            return true;
        }

        return base.ProcessDialogKey(keyData);
    }
}