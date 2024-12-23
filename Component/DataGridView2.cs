using System.Drawing;
using System.Windows.Forms;
using WorkDataStudio.Model;
using WorkDataStudio.share;

namespace WorkDataStudio.Component;

/// <summary>
/// DataGridView2
/// </summary>
public class DataGridView2 : CustomDataGridView {
    /// <summary>
    /// プロパティのセット
    /// </summary>
    protected override void Property() {
        Name = @"DataGrid2";
        Location = new Point(544, 34);
        Size = new Size(178, 663);
        TabIndex = 19;
        RowTemplate.Height = 33;
        ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    }

    /// <summary>
    /// SetMode
    /// </summary>
    protected override void SetMode() {
        Enabled = false;
        ScrollBars = ScrollBars.None;
        DefaultCellStyle.SelectionBackColor = BgColor.SELECTED;
        DefaultCellStyle.SelectionForeColor = FgColor.DEFAULT;
    }

    /// <summary>
    /// SetColumn
    /// </summary>
    protected override void SetColumn() {
        ColumnCount = 1;
        ColumnHeadersVisible = false; //列ヘッダー非表示
        ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False; //見出し行ワードラップ無効
        Columns[0].Width = 80;
        Columns[0].DataGridView.Width = Columns[0].Width;
    }

    /// <summary>
    /// DefaultSet
    /// データタイプのRyakuをセット
    /// </summary>
    protected override void SetDefault() {
        Rows.Clear();
        foreach (var workDataType in WorkDataType.List) {
            Rows.Add(workDataType.Ryaku);
        }
    }

    /// <summary>
    /// Select
    /// </summary>
    /// <param name="index"></param>
    public DataGridView2 Select(int index) {
        CurrentCell = this[0, index];
        return this;
    }
}