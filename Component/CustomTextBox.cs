using System.Drawing;
using System.Windows.Forms;

namespace WorkDataStudio.Component;

/// <summary>
/// CustomTextBox
/// </summary>
public class CustomTextBox : TextBox {
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
    /// Virtual member call in constructor
    /// </summary>
    private void SetFont() {
        Font = new Font("ＭＳ Ｐゴシック", 10.875F, FontStyle.Regular,
            GraphicsUnit.Point, ((byte)(128)));
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
    public Color BorderColor { get; set; }

    /// <summary>
    /// OnPaint イベント。
    /// </summary>
    /// <param name="pe">イベントデータ。</param>
    protected override void OnPaint(PaintEventArgs pe) {
        base.OnPaint(pe);
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