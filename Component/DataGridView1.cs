using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WorkDataStudio.Model;
using WorkDataStudio.share;
using G = WorkDataStudio.share.Globals;

// ReSharper disable ConvertIfStatementToReturnStatement
namespace WorkDataStudio.Component;

/// <summary>
/// DataGridView1
/// </summary>
public class DataGridView1 : CustomDataGridView {
    private static List<Color> _tmpRowColor = [];

    /// <summary>
    /// GetTmpRowBackColor
    /// </summary>
    /// <returns></returns>
    public Color GetTmpRowBackColor() {
        return _tmpRowColor.Any() ? _tmpRowColor[RowIndex] : BgColor.DEFAULT;
    }

    /// <summary>
    /// SetTmpRowBackColor
    /// </summary>
    public void SetTmpRowBackColor() {
        _tmpRowColor = [];
        foreach (DataGridViewRow row in Rows) {
            _tmpRowColor.Add(row.DefaultCellStyle.BackColor);
        }
    }

    /// <summary>
    /// プロパティのセット
    /// </summary>
    protected override void Property() {
        Name = @"DataGrid1";
        Location = new Point(8, 34);
        Size = new Size(1100, 663);
        TabIndex = 0;
        RowTemplate.Height = 33;
        ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    }

    /// <summary>
    /// SetMode
    /// </summary>
    protected override void SetMode() {
        MultiSelect = false;
        ScrollBars = ScrollBars.Vertical;
        SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        DefaultCellStyle.SelectionBackColor = BgColor.CLEARED;
        DefaultCellStyle.SelectionForeColor = FgColor.DEFAULT;
        ColumnHeadersDefaultCellStyle.BackColor = Color.White;
        ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.White;

        RowHeadersVisible = true;
        RowHeadersWidth = 21;
        RowHeadersDefaultCellStyle.SelectionBackColor = BgColor.SELECTED;
    }

    /// <summary>
    /// SetColumn
    /// </summary>
    protected override void SetColumn() {
        ColumnCount = 6;
        ColumnHeadersVisible = true; //列ヘッダー表示
        ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False; //見出し行ワードラップ無効
        Columns.With(col => {
            col[0].HeaderText = @"船番";
            col[1].HeaderText = @"ブロック名";
            col[2].HeaderText = @"部材名(単板名)";
            col[3].HeaderText = @"舷(PCS)";
            col[4].HeaderText = @"仮付予定日";
            col[0].Width = 70;
            col[1].Width = 100;
            col[2].Width = 110;
            col[3].Width = 120;
            col[4].Width = 100;
            col[5].Width = 20;
            col[0].DataGridView.Width =
                col[0].Width + col[1].Width + col[2].Width + col[3].Width + col[4].Width + col[5].Width +
                SystemInformation.VerticalScrollBarWidth;
        });
        foreach (DataGridViewColumn c in Columns) {
            c.SortMode = DataGridViewColumnSortMode.NotSortable;
        }
    }

    /// <summary>
    /// DefaultSet
    /// </summary>
    protected override void SetDefault() {
        Rows.Clear();
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
    /// Clear
    /// </summary>
    public DataGridView1 Clear() {
        Rows.Clear();
        return this;
    }

    /// <summary>
    /// Add
    /// </summary>
    /// <param name="sno"></param>
    public DataGridView1 Add(string sno = "") {
        WorkData.Add(sno);
        RowIndex = Rows.Add();
        SelectRowBackColor(BgColor.DEFAULT);
        ShowWorkData();
        return this;
    }

    /// <summary>
    /// SetGridData
    /// </summary>
    /// <param name="grid"></param>
    public DataGridView1 SetGridData(DataGridView3 grid) {
        ShowWorkData(WorkData.SetGridData(grid));
        return this;
    }

    /// <summary>
    /// ShowWorkData
    /// </summary>
    /// <param name="workData"></param>
    // ReSharper disable once MemberCanBePrivate.Global
    public DataGridView1 ShowWorkData(WorkData workData) {
        this[0, RowIndex].Value = workData.Sno;
        this[1, RowIndex].Value = workData.Blk;
        this[2, RowIndex].Value = workData.Bzi;
        this[3, RowIndex].Value = workData.Pcs;
        this[4, RowIndex].Value = workData.YoteibiKari;
        this[5, RowIndex].Value = workData.ChgFlg;
        SelectRowBackColor(RowBackColor);
        Enabled = true;
        return this;
    }

    /// <summary>
    /// @グリッド1の表示()
    /// </summary>
    public DataGridView1 ShowWorkData(int row = -1) {
        if (WorkData is null) {
            return this;
        }

        row = row == -1 ? RowIndex : row;
        this[0, row].Value = WorkData.Sno;
        this[1, row].Value = WorkData.Blk;
        this[2, row].Value = WorkData.Bzi;
        this[3, row].Value = WorkData.Pcs;
        this[4, row].Value = WorkData.YoteibiKari;
        this[5, row].Value = WorkData.ChgFlg;
        Enabled = true;
        return this;
    }

    /// <summary>
    /// @グリッド1の表示()
    /// </summary>
    public DataGridView1 ShowWorkDataList() {
        G.Out(@"@グリッド1 データ表示");
        Rows.Clear();
        foreach (var row in WorkData.List.Select(workData => Rows.Add(
                     workData.Sno,
                     workData.Blk,
                     workData.Bzi,
                     workData.Pcs,
                     workData.YoteibiKari,
                     workData.ChgFlg
                 ))) {
            Rows[row].DefaultCellStyle.BackColor = Color.RosyBrown;
            SelectRowBackColor(Color.RosyBrown);
        }

        Enabled = true;
        return this;
    }

    /// <summary>
    /// Select
    /// </summary>
    /// <param name="index"></param>
    public DataGridView1 Select(int index) {
        CurrentCell = this[0, index];
        return this;
    }

    /// <summary>
    /// @グリッド1_Sデータ作成色設定
    /// </summary>
    /// <param name="pIdx"></param>
    /// <param name="text"></param>
    public DataGridView1 SetSData(int pIdx, TextBox text) {
        Console.WriteLine(@"@グリッド1_Sデータ作成色設定");
        var workData = WorkData;
        if (workData.Pcs == "P") {
            Visible = false;
            workData.CreSFlg = pIdx switch {
                1 => 1, //作成しない 薄橙
                2 => 0, //作成する(西基準) 白
                3 => 2, //作成する(東基準) 薄紫
                _ => workData.CreSFlg
            };

            SelectRowBackColor(pIdx switch {
                1 => BgColor.S_GUNWALE_N,
                2 => BgColor.S_GUNWALE_W,
                3 => BgColor.S_GUNWALE_E,
                _ => RowBackColor
            });

            Visible = true;
        }
        else {
            text.Text = @"P舷を指定してください。";
        }

        return this;
    }

    /// <summary>
    /// @グリッド1_Pデータ作成色設定
    /// </summary>
    /// <param name="pIdx"></param>
    /// <param name="text"></param>
    public DataGridView1 SetPData(int pIdx, TextBox text) {
        Console.WriteLine(@"@グリッド1_Pデータ作成色設定");
        var workData = WorkData;
        if (workData.Pcs == "S") {
            Visible = false;
            workData.CrePFlg = pIdx switch {
                1 => 1, //作成しない 白
                2 => 0, //作成する(西基準) 濃橙
                3 => 2, //作成する(東基準) 濃青
                _ => workData.CrePFlg
            };

            SelectRowBackColor(pIdx switch {
                1 => BgColor.P_GUNWALE_N,
                2 => BgColor.P_GUNWALE_W,
                3 => BgColor.P_GUNWALE_E,
                _ => RowBackColor
            });

            Visible = true;
        }
        else {
            text.Text = @"S舷を指定してください。";
        }

        return this;
    }

    /// <summary>
    /// @グリッド1_Sデータ作成色設定_読込時()
    /// </summary>
    public DataGridView1 SetSData() {
        Console.WriteLine(@"@グリッド1_Sデータ作成色設定_読込時");

        Visible = false;
        foreach (var data in WorkData.List.Select((value, index) => new { value, index })) {
            switch (data.value.CreSFlg) {
                case 1:
                    Rows[data.index].DefaultCellStyle.BackColor = BgColor.S_GUNWALE_N; //Sを作成しない 薄橙
                    SelectRowBackColor(RowBackColor);
                    break;
                case 2:
                    Rows[data.index].DefaultCellStyle.BackColor = BgColor.S_GUNWALE_E; //Sを作成(東) 薄紫
                    SelectRowBackColor(RowBackColor);
                    break;
            }
        }

        Visible = true;

        return this;
    }

    /// <summary>
    /// グリッド1_Pデータ作成色設定_読込時()
    /// </summary>
    public DataGridView1 SetPData() {
        Console.WriteLine(@"@グリッド1_Pデータ作成色設定_読込時");

        Visible = false;
        foreach (var data in WorkData.List.Select((value, index) => new { value, index })) {
            switch (data.value.CrePFlg) {
                case 0:
                    Rows[data.index].DefaultCellStyle.BackColor = BgColor.P_GUNWALE_W; //Pを作成(西) 濃橙
                    SelectRowBackColor(RowBackColor);
                    break;
                case 2:
                    Rows[data.index].DefaultCellStyle.BackColor = BgColor.P_GUNWALE_E; //Pを作成(東) 濃青
                    SelectRowBackColor(RowBackColor);
                    break;
            }
        }

        Visible = true;

        return this;
    }

    /// <summary>
    /// SetValidation
    /// </summary>
    public DataGridView1 SetValidation() {
        foreach (var workData in WorkData.List.Select((value, index) => new { value, index })) {
            if (workData.value.ErrorValidation.Grid1 == WorkDataType.CROSS) {
                Rows[workData.index].DefaultCellStyle.BackColor = BgColor.INVALID;
            }
        }

        return this;
    }
}