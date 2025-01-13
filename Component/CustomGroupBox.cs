using System.Drawing;
using System.Windows.Forms;

namespace WorkDataStudio.Component;

/// <summary>
/// CustomGroupBox
/// </summary>
public class CustomGroupBox : GroupBox {
    private readonly Color _borderColor = Color.Black;

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="index"></param>
    /// <param name="name"></param>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <param name="width"></param>
    /// <param name="height"></param>
    /// <param name="text"></param>
    public CustomGroupBox(int index, string name, int x, int y, int width, int height, string text = "") {
        Name = name;
        TabIndex = index;
        Location = new Point(x, y);
        Size = new Size(width, height);
        SetFont();
        SetText(text);
        TabStop = false;
        Padding = new Padding(10);
        FlatStyle = FlatStyle.Standard;
        SetBackColor(SystemColors.ButtonFace);
        //FlatStyle = System.Windows.Forms.FlatStyle.System;
        // グループボックスの描画をオーナードローにする
        SetStyle(ControlStyles.UserPaint, true);
    }

    // OnPrintイベント
    protected override void OnPaint(PaintEventArgs e) {
        // テキストサイズを取得
        var tTextSize = TextRenderer.MeasureText(this.Text, this.Font);

        // グループボックスの領域を取得
        var tBorderRect = e.ClipRectangle;

        // テキストを考慮（グループボックス枠線がテキスト（高さ）の真ん中に来るように）して枠を描画
        tBorderRect.Y += tTextSize.Height / 2;
        tBorderRect.Height -= tTextSize.Height / 2;
        ControlPaint.DrawBorder(e.Graphics, tBorderRect, _borderColor, ButtonBorderStyle.Solid);

        // テキストを描画
        var tTextRect = e.ClipRectangle;
        tTextRect.X += 6; // テキストの描画開始位置(X)をグループボックスの領域から6ドットずらす
        tTextRect.Width = tTextSize.Width;
        tTextRect.Height = tTextSize.Height;
        e.Graphics.FillRectangle(new SolidBrush(this.BackColor), tTextRect);
        e.Graphics.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor), tTextRect);
    }

    /// <summary>
    /// Virtual member call in constructor
    /// </summary>
    private void SetFont() {
        Font = new Font("ＭＳ Ｐゴシック", 10.875F, FontStyle.Regular,
            GraphicsUnit.Point, 128);
    }

    /// <summary>
    /// Virtual member call in constructor
    /// </summary>
    private void SetText(string text) {
        Text = text;
    }

    /// <summary>
    /// Virtual member call in constructor
    /// </summary>
    private void SetBackColor(Color color) {
        BackColor = color;
    }
}