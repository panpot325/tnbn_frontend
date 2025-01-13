using System;
using System.Drawing;
using System.Windows.Forms;

namespace WorkDataStudio.Component;

/// <summary>
/// CustomTextBox
/// </summary>
public sealed class CustomTextBox : TextBox {
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="index"></param>
    /// <param name="name"></param>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <param name="width"></param>
    /// <param name="height"></param>
    /// <param name="multiline"></param>
    public CustomTextBox(int index, string name, int x, int y, int width, int height, bool multiline = false) {
        Name = name;
        TabIndex = index;
        Location = new Point(x, y);
        Size = new Size(width, height);
        SetFont();
        Margin = new Padding(6);
        SetMultiLine(multiline);
        BorderColor = Color.Gray;
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
    /// <param name="alignment"></param>
    public CustomTextBox(int index, string name, int x, int y, int width, int height, HorizontalAlignment alignment) {
        Name = name;
        TabIndex = index;
        Location = new Point(x, y);
        Size = new Size(width, height);
        SetFont();
        Margin = new Padding(6);
        TextAlign = alignment;
        BorderColor = Color.Gray;
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
    /// <param name="foreColor"></param>
    /// <param name="multiline"></param>
    public CustomTextBox(int index, string name, int x, int y, int width, int height, Color foreColor,
        bool multiline = false) {
        Name = name;
        TabIndex = index;
        Location = new Point(x, y);
        Size = new Size(width, height);
        SetFont();
        Margin = new Padding(6);
        ForeColor = foreColor;
        SetMultiLine(multiline);
        BorderColor = Color.Gray;
        //SetStyle(ControlStyles.UserPaint, true);
    }

    /// <summary>
    /// Virtual member call in constructor
    /// </summary>
    private void SetFont() {
        Font = new Font("ＭＳ Ｐゴシック", 10.875F, FontStyle.Regular,
            GraphicsUnit.Point, ((byte)(128)));
        Enabled = false;
    }

    /// <summary>
    /// Virtual member call in constructor
    /// </summary>
    private void SetMultiLine(bool multiline) {
        Multiline = multiline;
    }

    /// <summary>
    /// 枠線
    /// </summary>
    private Color BorderColor { get; set; }

    /// <summary>
    /// OnEnabledChanged
    /// </summary>
    /// <param name="e"></param>
    protected override void OnEnabledChanged(EventArgs e) {
        base.OnEnabledChanged(e);
        //EnabledがFalseの時だけ自分で描画する
        SetStyle(ControlStyles.UserPaint, !Enabled);

        //再描画
        Invalidate();
    }

    /// <summary>
    /// TextBoxを描画する
    /// </summary>
    /// <param name="e"></param>
    protected override void OnPaint(PaintEventArgs e) {
        base.OnPaint(e);
        Brush brush = new SolidBrush(this.ForeColor);

        if (Multiline) {
            e.Graphics.DrawString(this.Text, this.Font, brush, new Rectangle(4, 4, Width - 6, Height - 6));
        }
        else {
            if (TextAlign == HorizontalAlignment.Center) {
                var format = new StringFormat();
                format.Alignment = StringAlignment.Center;
                e.Graphics.DrawString(this.Text, this.Font, brush, new Rectangle(-4, 0, Width, Height), format);
            }
            else {
                e.Graphics.DrawString(this.Text, this.Font, brush, 0, 0);
            }
        }

        brush.Dispose();
        BackColor = Color.White;
    }

    /// <summary>
    /// Windowsメッセージを処理する。
    /// </summary>
    /// <param name="m">処理するメッセージ。</param>
    protected override void WndProc(ref Message m) {
        if (m.Msg == 0x85) //WM_NCPAINT
        {
            var graphics = Parent.CreateGraphics();
            var rectangle = new Rectangle(Location, Size);
            rectangle.Inflate(1, 1);

            ControlPaint.DrawBorder(graphics, rectangle, BorderColor, ButtonBorderStyle.Solid);
        }

        base.WndProc(ref m);
    }
}