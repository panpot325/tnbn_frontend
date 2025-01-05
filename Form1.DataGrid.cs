using System;
using System.Windows.Forms;
using WorkDataStudio.Model;
using WorkDataStudio.share;
using WorkDataStudio.type;

namespace WorkDataStudio;

/// <summary>
/// Form1.DataGrid
/// </summary>
public partial class Form1 {
    /// <summary>
    /// Call From DataGrid3_KeyDown
    /// </summary>
    /// <param name="key"></param>
    private void Grid_Edit(int key) {
        if (DataGrid3.ColIndex != 0) {
            return;
        }

        DataGrid3.Text = DataGrid3.StrValue;
        switch (key) {
            case (char)Keys.F5: // vbKeyF5
                Log.WriteLine(@"[F5]");
                Grid_Shift();
                return;
            case (char)Keys.Delete: //vbKeyDelete
                Log.WriteLine(@"[Delete]");
                DataGrid3.CursorEdit((int)Keys.Back);
                return;
            case (char)Keys.F2: // vbKeyF2
                Log.WriteLine(@"[Enter]");
                DataGrid3.CursorEdit((int)Keys.Enter);
                return;
            case > 127: //> 127
                Log.WriteLine(@"[> 127]");
                DataGrid3.CursorEdit((int)Keys.Space);
                return;
        }
    }

    /// <summary>
    /// Call From DataGrid3_KeyPress
    /// </summary>
    /// <param name="key"></param>
    private void Grid_Edit(char key) {
        if (DataGrid3.CanEdit(DataGrid1.WorkData)) {
            DataGrid3.CursorEdit(key);
            return;
        }

        switch (Mode.IsCopy2) {
            case true:
                Text4.Text = @"先ず、キーを変更して下さい。";
                Text4.ForeColor = FgColor.INVALID;
                break;
        }
    }

    /// <summary>
    /// Grid_Shift
    /// Grid3からGrid1にデータを移行
    /// </summary>
    private void Grid_Shift() {
        switch (Mode.Value) {
            case Mode.NEW_2:
                MessageBox.Show(@"新規・登録(対象)でＦ５は、利用できません。");
                return;

            case Mode.NEW_1:
                DataGrid1.SetGridData(DataGrid3); //ワークデータにgrid3をセットしてgrid1に表示
                DataGrid1.ShowWorkData();
                if (DataGrid1.IsLast) {
                    DataGrid1.Add(DataGrid1.WorkData.Sno);
                }

                DataGrid1.SetTmpRowBackColor();
                DataGrid1.SetValidation();
                DataGrid3.ShowWorkData(DataGrid1.WorkData);
                Grid_Change();

                return;
            case Mode.EDIT_1 or Mode.COPY_1 or Mode.COPY_2 or Mode.EMode.EDIT_3:
                DataGrid1.SetGridData(DataGrid3);
                DataGrid1.ShowWorkData();
                DataGrid1.SetValidation();
                DataGrid3.ShowWorkData(DataGrid1.WorkData);
                Grid_Change();
                break;
            case Mode.EMode.NEW_3:
            case Mode.EMode.EDIT_2:
            default:
                return;
        }
    }

    /// <summary>
    /// Grid_Change
    /// Call From DataGrid3_SelectionChanged
    /// Call From Grid_Shift
    /// Call From Grid_Shift
    /// </summary>
    private void Grid_Change() {
        DataGrid2.Select(DataGrid3.RowIndex);
        ShowMessage(DataGrid3.DataType); //各メッセージを表示
        DataGrid3.SetMaxLength();
    }

    /// <summary>
    /// Grid_Scroll
    /// Grid2をGrid3に追従させる
    /// Call From DataGrid3_Scroll
    /// </summary>
    private void Grid_Scroll() {
        DataGrid2.Visible = false;
        DataGrid2.FirstDisplayedScrollingRowIndex = DataGrid3.FirstDisplayedScrollingRowIndex;
        DataGrid2.Visible = true;
    }
}