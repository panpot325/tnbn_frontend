using System.Drawing;
using System.Windows.Forms;

namespace WorkDataStudio.Component;

/// <summary>
/// CustomGroupBox
/// </summary>
public class CustomGroupBox : GroupBox {
    private Rectangle _textRect;
    private Rectangle _frameRect;
    private readonly Color _borderColor = Color.Black;

    /// <summary>
    /// フレームRectangle
    /// </summary>
    public Rectangle TextRect {
        set => _textRect = value;
    }

    /// <summary>
    /// テキストRectangle
    /// </summary>
    public Rectangle FrameRect {
        set => _frameRect = value;
    }

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
        SetStyle(ControlStyles.UserPaint, true); // 描画をオーナードローにする
    }

    /// <summary>
    /// オーナードロー
    /// </summary>
    /// <param name="e"></param>
    protected override void OnPaint(PaintEventArgs e) {
        // 枠を描画
        ControlPaint.DrawBorder(e.Graphics, _frameRect, _borderColor, ButtonBorderStyle.Solid);

        // テキストを描画
        e.Graphics.FillRectangle(new SolidBrush(BackColor), _textRect);
        e.Graphics.DrawString(Text, Font, new SolidBrush(ForeColor), _textRect);
    }

    /// <summary>
    /// Virtual member call in constructor
    /// </summary>
    private void SetFont() {
        Font = new Font("ＭＳ Ｐゴシック", 10.875F, FontStyle.Regular,
            GraphicsUnit.Point, 128);
        DoubleBuffered = true;
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