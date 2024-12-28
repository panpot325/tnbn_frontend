using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WorkDataStudio.Model;
using WorkDataStudio.share;
using WorkDataStudio.type;
using G = WorkDataStudio.share.Globals;

// ReSharper disable MemberCanBeMadeStatic.Local
// ReSharper disable InvertIf
// ReSharper disable InterpolatedStringExpressionIsNotIFormattable
// ReSharper disable ConvertIfStatementToReturnStatement
namespace WorkDataStudio.Component;

/// <summary>
/// DataGridView3
/// </summary>
public class DataGridView3 : CustomDataGridView {
    /// <summary>
    /// プロパティのセット
    /// </summary>
    protected override void Property() {
        Name = @"DataGri3";
        Location = new Point(628, 34);
        Size = new Size(267, 663);
        TabIndex = 20;
        RowTemplate.Height = 33;
        ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
    }

    /// <summary>
    /// SetMode
    /// </summary>
    protected override void SetMode() {
        ScrollBars = ScrollBars.Vertical;
        DefaultCellStyle.SelectionBackColor = BgColor.DEFAULT;
        DefaultCellStyle.SelectionForeColor = FgColor.DEFAULT;
    }

    /// <summary>
    /// SetColumn
    /// </summary>
    protected override void SetColumn() {
        ColumnCount = 1;
        ColumnHeadersVisible = false; //列ヘッダー非表示
        ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False; //見出し行ワードラップ無効
        Columns[0].Width = 90;
        Columns[0].DataGridView.Width = Columns[0].Width + SystemInformation.VerticalScrollBarWidth;
    }

    /// <summary>
    /// DefaultSet
    /// </summary>
    protected override void SetDefault() {
        Rows.Clear();
    }

    /// <summary>
    /// WorkDataType
    /// </summary>
    public WorkDataType DataType {
        get {
            if (WorkDataType.Exists) {
                return WorkDataType.List[RowIndex];
            }

            return null;
        }
    }

    /// <summary>
    /// Select
    /// </summary>
    /// <param name="index"></param>
    public DataGridView3 Select(int index) {
        CurrentCell = this[0, index];
        return this;
    }

    /// <summary>
    /// ShowWorkData
    /// </summary>
    /// <param name="workData"></param>
    public DataGridView3 ShowWorkData(WorkData workData) {
        Console.WriteLine(@"ShowWorkData");
        Rows.Clear();
        foreach (var row in workData.GetValues().Select(value => Rows.Add(value))) {
            Rows[row].Cells[0].Style.Alignment = WorkDataType.List[row].Keishiki == WorkDataType.KEISHIKI_ASCII
                ? DataGridViewContentAlignment.TopLeft
                : DataGridViewContentAlignment.TopRight;
        }
        SelectRowBackColor(Color.White);

        return this;
    }

    /// <summary>
    /// @グリッド3入力不可バックカラー設定()
    /// </summary>
    public DataGridView3 SetBackColorGray() {
        switch (Mode.Value) {
            case Mode.NEW_1:
                RowIndex = 1;
                Rows[0].DefaultCellStyle.BackColor = BgColor.DISABLED; //薄灰
                //Rows[0].DefaultCellStyle.SelectionBackColor = BgColor.DISABLED;
                //Rows[0].DefaultCellStyle.SelectionBackColor = BgColor.CLEARED;
                break;
            case Mode.EDIT_1 or Mode.COPY_1:
                this[0, 0].Style.BackColor = BgColor.DISABLED;
                break;
            case Mode.EDIT_2 or Mode.EDIT_3:
                this[0, 0].Style.BackColor = BgColor.DISABLED;
                this[0, 1].Style.BackColor = BgColor.DISABLED;
                this[0, 2].Style.BackColor = BgColor.DISABLED;
                this[0, 3].Style.BackColor = BgColor.DISABLED;
                break;
        }

        Rows[0].DefaultCellStyle.SelectionBackColor = Rows[0].DefaultCellStyle.BackColor;
        return this;
    }

    /// <summary>
    /// BackColor_White
    /// @グリッド3バックカラー設定
    /// </summary>
    /// <param name="workData"></param>
    public DataGridView3 SetBackColor(WorkData workData) {
        Console.WriteLine(@"@グリッド3バックカラー設定");
        foreach (var data in WorkDataType.List
                     .Select((value, index) => new { value, index })) {
            var backColor = workData.ErrorValidation.Grid3[data.index] == WorkDataType.CROSS
                ? BgColor.INVALID
                : BgColor.DEFAULT;

            Rows[data.index].DefaultCellStyle.BackColor = backColor;
            Rows[data.index].DefaultCellStyle.SelectionBackColor = backColor;
            /*
            this[0, data.index].Style.BackColor =
                workData.ErrorValidation.Grid3[data.index] == WorkDataType.CROSS
                    ? BgColor.INVALID
                    : BgColor.DEFAULT;
            */
        }

        return this;
    }

    /// <summary>
    /// @入力テキストMaxLength設定()
    /// </summary>
    public DataGridView3 SetMaxLength() {
        var dataType = DataType;

        switch (dataType.NyuMode) {
            case WorkDataType.NYU_MODE_A or WorkDataType.NYU_MODE_ANUM:
                MaxInputLength = dataType.IntHaniMax;
                return this;
            case WorkDataType.NYU_MODE_NUM:
                int lenMax, lenMin;
                if (dataType.IntNyuTani == 1) {
                    lenMax = dataType.LenHaniMax;
                    lenMin = dataType.LenHaniMin;
                    MaxInputLength = lenMax >= lenMin ? lenMax : lenMin;
                    return this;
                }

                lenMax = dataType.LenHaniMaxNewTani;
                lenMin = dataType.LenHaniMinNewTani;
                if (dataType.Keishiki == WorkDataType.KEISHIKI_M16_B) {
                    lenMin--;
                }


                MaxInputLength = lenMax >= lenMin ? lenMax : lenMin;
                return this;
        }

        return this;
    }

    /// <summary>
    /// CursorEdit
    /// </summary>
    /// <param name="keyAscii"></param>
    public DataGridView3 CursorEdit(int keyAscii) {
        switch (keyAscii) {
            case (char)Keys.Enter:
                BeginEdit(false);
                break;
            case (char)Keys.Back:
                CurrentCell.Value = "";
                BeginEdit(false);
                break;
            case (char)Keys.Space:
                BeginEdit(false);
                break;
            case < 32:
                return this;
            default:
                Text = ((char)keyAscii).ToString();
                BeginEdit(false);
                //CurrentCell.Value = "A";
                break;
        }

        return this;
    }

    /// <summary>
    /// TextEdit
    /// </summary>
    public DataGridView3 TextEdit(DataGridView1 dataGridView1, TextBox textBox) {
        var text = StrValue;
        var workData = dataGridView1.WorkData;

        switch (DataType.Keishiki) {
            case WorkDataType.KEISHIKI_ASCII:
                break;
            default:
                text = string.IsNullOrEmpty(text) ? @"0" : text;
                switch (Mode.Value) {
                    case Mode.NEW_1 or Mode.NEW_2:
                        break;
                    default:
                        if (text == Tag.ToString()) {
                            return this;
                        }

                        break;
                }

                break;
        }

        //入力チェック前処理
        if (InputCheck(text, workData, textBox)) {
            //入力チェック排他処理
            if (!Exclude_Check1(workData)
                || !Exclude_Check2(workData, text)) {
                textBox.Text = @"排他中のため変更できません";
                textBox.ForeColor = FgColor.INVALID;
                StrValue = Tag.ToString();
                return this;
            }

            CellBackColor = BgColor.DEFAULT;
            if (DataType.NyuMode == WorkDataType.NYU_MODE_NUM) {
                StrValue = DataType.DecNyuTani switch {
                    0.1m => DecimalFormat(text),
                    1 => IntFormat(text),
                    _ => StrValue
                };
            }
            else {
                StrValue = text.ToUpper();
            }

            if (DataType.Dm == "W71E") {
                //MAX(皮板最大板厚)
                this[ColIndex, RowIndex + 1].Value = text;
            }

            workData.ChgFlg = WorkData.UPDATE;
            if (Mode.IsCopy2) {
                if (RowIndex < 4) {
                    workData.ErrorValidation.Change = true; //入力エラー判定(MSFlexGrid1.Row).キー変更
                }
            }

            if (Mode.Value != Mode.NEW_1
                && Mode.Value != Mode.NEW_2
                && Mode.Value != Mode.EDIT_1
                && Mode.Value != Mode.COPY_1) {
                //dataGridView1.CellBackColor = BgColor.SELECTED;
            }

            return this;
        }

        StrValue = Tag.ToString();

        return this;
    }

    /// <summary>
    /// 入力チェック前処理
    /// </summary>
    /// <param name="text"></param>
    /// <param name="workData"></param>
    /// <param name="textBox"></param>
    /// <returns></returns>
    private bool InputCheck(string text, WorkData workData, TextBox textBox) {
        workData.ErrorValidation.Grid1 = "";
        workData.ErrorValidation.Grid3[RowIndex] = "";
        if (text == "") {
            CellBackColor = BgColor.DEFAULT;
            return true;
        }

        if (InputCheck(text, textBox)) {
            CellBackColor = BgColor.DEFAULT;
            return true;
        }

        return false;
    }

    /// <summary>
    /// 入力チェック
    /// </summary>
    /// <param name="text"></param>
    /// <param name="textBox"></param>
    /// <returns></returns>
    private bool InputCheck(string text, TextBox textBox) {
        var a = RowIndex;
        switch (DataType.NyuMode) {
            case WorkDataType.NYU_MODE_NUM:
                if (!decimal.TryParse(text, out var num)) {
                    textBox.Text = @"入力値エラー：文字不可";
                    textBox.ForeColor = FgColor.INVALID;
                    return false;
                }

                var dec = DecNullZero(text);
                if (dec == 0 && DataType.ZeroEntry == WorkDataType.ZERO_ENTRY_OK) {
                    break;
                }

                if (DataType.Dm == "W72C") {
                    //[SP1]か否か判定
                    var rIndex = WorkDataType.List.TakeWhile(type => type.Dm != "W756").Count();
                    if (Convert.ToInt32(this[0, rIndex].Value) == 0) {
                        if (dec < DataType.DecHaniMin || DataType.DecHaniMax < dec) {
                            textBox.Text = @"入力値エラー：範囲外";
                            textBox.ForeColor = FgColor.INVALID;
                            return false;
                        }
                    }

                    if (DataType.DecHaniMax < dec) {
                        textBox.Text = @"入力値エラー：範囲外";
                        textBox.ForeColor = FgColor.INVALID;
                        return false;
                    }
                }

                if (dec < DataType.DecHaniMin || DataType.DecHaniMax < dec) {
                    textBox.Text = @"入力値エラー：範囲外";
                    textBox.ForeColor = FgColor.INVALID;
                    return false;
                }

                break;
            case WorkDataType.NYU_MODE_A:
                if (int.TryParse(text, out _)) {
                    textBox.Text = @"入力値エラー：数値不可";
                    textBox.ForeColor = FgColor.INVALID;
                    return false;
                }

                break;
        }

        return true;
    }

    /// <summary>
    /// Exclude_Check1
    /// </summary>
    /// <param name="workData"></param>
    /// <returns></returns>
    private bool Exclude_Check1(WorkData workData) {
        if (workData.Sno == "") {
            return true;
        }

        if (WorkDataExclusive.Count(workData.Sno) == 0) {
            //他の人が使用中でない場合
            if (WorkDataExclusive.Count(workData.Sno, 1) == 0) {
                //自分が排他中でない場合
                WorkDataExclusive.Insert(workData.Sno); //排他中に更新
            }

            return true;
        }

        return false;
    }

    /// <summary>
    /// Exclude_Check2
    /// </summary>
    /// <param name="workData"></param>
    /// <param name="text"></param>
    /// <returns></returns>
    private bool Exclude_Check2(WorkData workData, string text) {
        if (Mode.Value != Mode.COPY_2 || RowIndex != 0) {
            return true;
        }

        WorkDataExclusive.Delete(text);
        if (WorkDataExclusive.Count(text, 0) == 0) {
            if (WorkDataExclusive.Count(text, 1) == 0) {
                WorkDataExclusive.Insert(text); //排他中に更新
            }

            return true;
        }

        return false;
    }

    /// <summary>
    /// DecNullZero
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    private decimal DecNullZero(string str) {
        return str is null || str.Length == 0 ? 0m : decimal.Parse(str);
    }

    /// <summary>
    /// DecimalFormat
    /// </summary>
    /// <param name="str"></param>
    /// <param name="format"></param>
    /// <returns></returns>
    private string DecimalFormat(string str, string format = "F1") {
        if (decimal.TryParse(str, out _)) {
            return Convert.ToDecimal(str).ToString(format);
        }

        return str;
    }

    /// <summary>
    /// IntFormat
    /// </summary>
    /// <param name="str"></param>
    /// <param name="format"></param>
    /// <returns></returns>
    private string IntFormat(string str, string format = "0") {
        if (int.TryParse(str, out _)) {
            return Convert.ToInt32(str).ToString(format);
        }

        return str;
    }
}