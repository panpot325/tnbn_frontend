using System;
using System.Drawing;
using System.Windows.Forms;

// ReSharper disable MemberCanBeProtected.Global
// ReSharper disable MemberCanBePrivate.Global
namespace WorkDataStudio.Component;

/// <summary>
/// CustomDataGridView
/// </summary>
public class CustomDataGridView : DataGridView {
    public const int FONT_SIZE = 10; //@cFontSize
    public const string FONT_FAMILY = "ＭＳ ゴシック"; //@

    /// <summary>
    /// グリッド初期化
    /// </summary>
    public void Init() {
        Property();
        RowHeadersVisible = false; //行ヘッダー非表示
        AllowUserToAddRows = false; //行追加オプション非表示
        EnableHeadersVisualStyles = false;
        EditMode = DataGridViewEditMode.EditProgrammatically;
        DefaultCellStyle.Font = new Font(FONT_FAMILY, FONT_SIZE);
        AllowUserToResizeRows = false;
        AllowUserToResizeColumns = false;
        SetMode();
        SetColumn();
        SetDefault();
    }

    /// <summary>
    /// プロパティのセット
    /// </summary>
    protected virtual void Property() {
    }

    /// <summary>
    /// virtual SetMode
    /// </summary>
    protected virtual void SetMode() {
    }

    /// <summary>
    /// virtual SetColumn
    /// </summary>
    protected virtual void SetColumn() {
    }

    /// <summary>
    /// virtual SetDefault
    /// </summary>
    protected virtual void SetDefault() {
    }

    /// <summary>
    /// カレントCellの行インデックス
    /// </summary>
    public int RowIndex {
        get => CurrentCell?.RowIndex ?? 0;
        set => CurrentCell = this[0, value];
    }

    /// <summary>
    /// カレントCellの列インデックス
    /// </summary>
    public int ColIndex => CurrentCell?.ColumnIndex ?? 0;

    /// <summary>
    /// 最終行を判定
    /// </summary>
    public bool IsLast => RowIndex == RowCount - 1;

    /// <summary>
    /// カレントRow
    /// </summary>
    public DataGridViewRow Row => Rows[RowIndex];

    /// <summary>
    /// StrValue
    /// </summary>
    public string StrValue {
        get => CurrentCell.Value is null ? "" : CurrentCell.Value.ToString();
        set => CurrentCell.Value = value;
    }

    /// <summary>
    /// カレントCellのBackColor
    /// </summary>
    public Color CellBackColor {
        get => CurrentCell.Style.BackColor;
        set => CurrentCell.Style.BackColor = value;
    }

    /// <summary>
    /// カレントRowのBackColor
    /// </summary>
    public Color RowBackColor {
        get => Row.DefaultCellStyle.BackColor;
        set => Row.DefaultCellStyle.BackColor = value;
    }

    /// <summary>
    /// SelectionRowBackColor
    /// </summary>
    /// <param name="color"></param>
    public void SelectRowBackColor(Color color) {
        RowBackColor = color;
        DefaultCellStyle.SelectionBackColor = color;
    }

    /// <summary>
    /// 入力文字数の設定
    /// </summary>
    public int MaxInputLength {
        get => ((DataGridViewTextBoxColumn)Columns[CurrentCell.ColumnIndex]).MaxInputLength;
        set => ((DataGridViewTextBoxColumn)Columns[CurrentCell.ColumnIndex]).MaxInputLength = value;
    }

    /// <summary>
    /// StrData
    /// </summary>
    /// <param name="row"></param>
    /// <returns></returns>
    public string StrData(int row) {
        return Rows[row].Cells[0].Value is null
            ? ""
            : Rows[row].Cells[0].Value.ToString();
    }

    /// <summary>
    /// IntData
    /// </summary>
    /// <param name="row"></param>
    /// <returns></returns>
    public int IntData(int row) {
        var value = StrData(row);
        return int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
    }

    /// <summary>
    /// DecData
    /// </summary>
    /// <param name="row"></param>
    /// <returns></returns>
    public decimal DecData(int row) {
        var value = StrData(row);
        return decimal.TryParse(value, out _) ? Convert.ToDecimal(value) : 0;
    }
}