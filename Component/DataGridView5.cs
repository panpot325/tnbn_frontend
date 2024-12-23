using System.Drawing;
using System.Windows.Forms;
using WorkDataStudio.share;
using WorkDataStudio.type.index;

namespace WorkDataStudio.Component;

/// <summary>
/// DataGridView5
/// </summary>
public class DataGridView5 : CustomDataGridView {
    /// <summary>
    /// プロパティのセット
    /// </summary>
    protected override void Property() {
        RowTemplate.Height = 33;
        ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    }

    /// <summary>
    /// SetMode
    /// </summary>
    protected override void SetMode() {
        Name = @"DataGridView5";
        Location = new Point(40, 40);
        Size = new Size(300, 600);
        TabIndex = 0;
        MultiSelect = false;
        ScrollBars = ScrollBars.Vertical;
        SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        DefaultCellStyle.SelectionBackColor = BgColor.SELECTED;
        DefaultCellStyle.SelectionForeColor = FgColor.DEFAULT;
        ColumnHeadersDefaultCellStyle.BackColor = Color.White;
        ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.White;
    }

    /// <summary>
    /// SetColumn
    /// </summary>
    protected override void SetColumn() {
        ColumnCount = 2; //4
        ColumnHeadersVisible = true; //列ヘッダー表示
        ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False; //見出し行ワードラップ無効
        Columns.With(col => {
            col[0].HeaderText = @"SNO";
            col[1].HeaderText = @"状態";
            //col[2].HeaderText = @"";
            //col[3].HeaderText = @"";
            col[0].Width = 100;
            col[1].Width = 100;
            //col[2].Width = 100;
            //col[3].Width = 100;
            col[0].DataGridView.Width =
                col[0].Width + col[1].Width +
                SystemInformation.VerticalScrollBarWidth;
        });
        foreach (DataGridViewColumn c in Columns) {
            c.SortMode = DataGridViewColumnSortMode.NotSortable;
            c.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
    }

    /// <summary>
    /// DefaultSet
    /// </summary>
    protected override void SetDefault() {
        Rows.Clear();
        foreach (var workInfo in WorkInfo.List) {
            Rows.Add(workInfo.Sno, workInfo.Ret
                //, workInfo.Date
                //, workInfo.Syain
            );
        }
    }

    /// <summary>
    /// WorkInfo
    /// </summary>
    public WorkInfo WorkInfo {
        get {
            // ReSharper disable once ConvertIfStatementToReturnStatement
            if (WorkInfo.Exists) {
                return WorkInfo.List[RowIndex];
            }

            return null;
        }
    }
}