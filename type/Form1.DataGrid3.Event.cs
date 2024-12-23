using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WorkDataStudio.model;
using G = WorkDataStudio.share.Globals;
using C = WorkDataStudio.share.Constants;

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
    private void DataGrid3_KeyDown(object sender, KeyEventArgs e) {
        G.Out("DataGrid3_KeyDown Event");
        G.Out(e.KeyValue.ToString());
        if (DataGrid3.ColIndex != 0) {
            return;
        }

        DataGrid3.Text = DataGrid3.StrValue;
        switch (e.KeyValue) {
            case (char)Keys.Delete: //vbKeyDelete
                G.Out(@"[Delete]");
                DataGrid3.CursorEdit((int)Keys.Back);
                return;
            case (char)Keys.F2: // vbKeyF2
                G.Out(@"[Enter]");
                DataGrid3.CursorEdit((int)Keys.Enter);
                return;
            case (char)Keys.F5: // vbKeyF5
                G.Out(@"[F5]");
                switch (G.Mode) {
                    case C.MODE_NEW_2:
                        MessageBox.Show(@"新規・登録(対象)でＦ５は、利用できません。");
                        return;
                    case C.MODE_NEW_1:
                        DataGrid3.SetWorkData(DataGrid1.WorkData);
                        DataGrid1.ShowWorkData();

                        if (DataGrid1.IsLast) {
                            DataGrid1.Add(DataGrid1.WorkData.Sno);
                            //WorkData.Add();
                            //WorkData.List.Last().Sno = DataGrid1.WorkData.Sno;
                        }

                        //DataGrid1.ShowWorkDataList();
                        DataGrid1.SetValidation();

                        //Grid3_Show();
                        DataGrid3.Rows[0].DefaultCellStyle.BackColor = Color.Gray; //薄灰

                        DataGrid3.Focus();

                        return;
                }

                return;
            case > 127: //> 127
                G.Out(@"[> 127]");
                DataGrid3.CursorEdit((int)Keys.Space);
                return;
        }
    }

    /// <summary>
    /// @MSFlexGrid3_KeyPress(KeyAscii As Integer)
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    /// <exception cref="NotImplementedException"></exception>
    private void DataGrid3_KeyPress(object sender, KeyPressEventArgs e) {
        G.Out(@"DataGrid3_KeyPress");
        var key = e.KeyChar;
        var grid3Col = DataGrid3.ColIndex;
        var grid3Row = DataGrid3.RowIndex;
        var grid1Row = DataGrid1.RowIndex;

        switch (G.Mode) {
            //新規, 新規2 新規入力＋1件目の時は、全項目入力可
            case C.MODE_NEW_1 or C.MODE_NEW_2:
                if (grid3Col == 0 && WorkData.Count <= 1 || grid3Row > 0) {
                    DataGrid3.CursorEdit(key);
                    //Grid3_Cursor_Edit(DataGrid3, Text5, key);
                }

                return;
            //船番指定, 船番コピー 船番指定修正または、船番単位コピー時、船番以外を入力可
            case C.MODE_EDIT_1 or C.MODE_COPY_1:
                if (grid3Col == 0 && grid3Row > 0) {
                    DataGrid3.CursorEdit(key);
                    //Grid3_Cursor_Edit(DataGrid3, Text5, key);
                }

                return;
            //今日以降, 今日予定 今日以降修正または、今日予定修正時、キー項目以外のみ入力可
            case C.MODE_EDIT_2 or C.MODE_EDIT_3:
                if (grid3Col == 0 && grid3Row > 3) {
                    DataGrid3.CursorEdit(key);
                    //Grid3_Cursor_Edit(DataGrid3, Text5, key);
                }

                return;
            //キーコピー キーコピー時は、全項目入力可。但し、優先的にキー項目を変更させる。
            case C.MODE_COPY_2:
                if (DataGrid1[0, grid1Row].Value.ToString() == "") {
                    return;
                }

                if (WorkData.List[grid1Row].ErrorValidation.Change) {
                    if (grid3Col == 0) {
                        DataGrid3.CursorEdit(key);
                        //Grid3_Cursor_Edit(DataGrid3, Text5, key);
                    }

                    return;
                }

                if (grid3Col == 0 && grid3Row < 4) {
                    DataGrid3.CursorEdit(key);
                    //Grid3_Cursor_Edit(DataGrid3, Text5, key);
                    return;
                }

                Text4.Text = @"先ず、キーを変更して下さい。";
                Text4.ForeColor = Color.Red;
                return;
        }
    }

    /// <summary>
    /// @MSFlexGrid3_Scroll()
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    /// <exception cref="NotImplementedException"></exception>
    private void DataGrid3_Scroll(object sender, ScrollEventArgs e) {
        G.Out("@DataGrid3_Scroll");
        DataGrid2.Visible = false;
        DataGrid2.FirstDisplayedScrollingRowIndex = DataGrid3.FirstDisplayedScrollingRowIndex;
        DataGrid2.Visible = true;
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
        DataGrid2.Select(DataGrid3.RowIndex);
        ShowMessage(DataGrid3.DataType); //各メッセージを表示
        DataGrid3.SetMaxLength();
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