using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WorkDataStudio.Model;
using WorkDataStudio.share;

namespace WorkDataStudio.Component;

/// <summary>
/// DataGridView4
/// </summary>
public class DataGridView4 : CustomDataGridView {
    /// <summary>
    /// プロパティのセット
    /// </summary>
    protected override void Property() {
        RowTemplate.Height = 33;
    }

    /// <summary>
    /// SetMode
    /// </summary>
    protected override void SetMode() {
        ScrollBars = ScrollBars.Both;
        SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        DefaultCellStyle.SelectionBackColor = BgColor.SELECTED;
        DefaultCellStyle.SelectionForeColor = FgColor.DEFAULT;
        ColumnHeadersDefaultCellStyle.BackColor = Color.White;
        ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.White;
        ColumnCount = WorkDataType.Count;
    }

    /// <summary>
    /// SetColumn
    /// </summary>
    protected override void SetColumn() {
        ColumnCount = WorkDataType.Count;
        ColumnHeadersVisible = true; //列ヘッダー表示

        foreach (DataGridViewColumn c in Columns) {
            c.SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        Columns.With(col => {
            foreach (var dataType in WorkDataType.List) {
                col[dataType.Index].With(c => {
                    c.HeaderText = dataType.Ryaku;
                    c.Width = dataType.Index switch {
                        0 => 80,
                        1 => 130,
                        2 => 180,
                        3 => 100,
                        _ => 70
                    };
                    c.DefaultCellStyle.Alignment = dataType.Keishiki == WorkDataType.KEISHIKI_ASCII
                        ? DataGridViewContentAlignment.TopLeft
                        : DataGridViewContentAlignment.TopRight;
                });
            }
        });
        Width = 720;
    }

    /// <summary>
    /// DefaultSet
    /// </summary>
    protected override void SetDefault() {
        Rows.Clear();
        RowCount = 32;
    }

    /// <summary>
    /// WorkData
    /// </summary>
    public WorkData WorkData =>
        WorkData.Exists
        && RowIndex < WorkData.Count
            ? WorkData.List[RowIndex]
            : null;

    /// <summary>
    /// @グリッド4の表示()
    /// </summary>
    public void ShowWorkDataList() {
        Console.WriteLine(@"@グリッド4 データ表示");
        Rows.Clear();
        foreach (var row in WorkData.List.Select(workData => Rows.Add(
                     workData.Sno, workData.Blk, workData.Bzi, workData.Pcs + $"[{workData.ChgFlg}]", //For Debug
                     workData.Gr1, workData.Gr2, workData.Gr3, workData.Gr4, workData.Gr5,
                     workData.Lk1, workData.Lk2, workData.Lk3, workData.Lk4, workData.Lk5,
                     workData.L, workData.B, workData.Tmax,
                     workData.T1, workData.T2, workData.T3, workData.T4, workData.T5,
                     workData.It1, workData.It2, workData.It3, workData.It4,
                     workData.Sp1, workData.Sp2, workData.Sp3, workData.Sp4, workData.Sp5,
                     workData.Lh1, workData.Lh2, workData.Lh3, workData.Lh4, workData.Lh5,
                     workData.Lt1, workData.Lt2, workData.Lt3, workData.Lt4, workData.Lt5,
                     workData.Ll1, workData.Ll2, workData.Ll3, workData.Ll4, workData.Ll5,
                     workData.Wl1, workData.Wl2, workData.Wl3, workData.Wl4, workData.Wl5,
                     workData.Is1,
                     workData.Stp1, workData.Stp2, workData.Stp3, workData.Stp4, workData.Stp5,
                     workData.Org, workData.YoteibiKari
                 ))) {
        }

        Enabled = true;
    }

    /// <summary>
    /// ShowWorkData
    /// </summary>
    public void ShowWorkData() {
        Row.SetValues(WorkData.GetValues().ToArray());
        this[3, RowIndex].Value = WorkData.Pcs + $"[{WorkData.ChgFlg}]"; //For Debug
        RowBackColor = WorkData.ChgFlg == WorkData.UPDATE
            ? BgColor.UPDATED
            : BgColor.DEFAULT;
    }
}