using System.Drawing;
using System.Windows.Forms;

namespace WorkDataStudio.Component;

/// <summary>
/// CustomLabel
/// </summary>
public sealed class CustomLabel : Label {
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="name"></param>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <param name="width"></param>
    /// <param name="height"></param>
    /// <param name="text"></param>
    public CustomLabel(string name, int x, int y, int width, int height, string text = "") {
        Name = name;
        Location = new Point(x, y);
        Size = new Size(width, height);
        SetFont();
        SetText(text);
        SetAlign();
    }

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="name"></param>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <param name="width"></param>
    /// <param name="height"></param>
    /// <param name="color"></param>
    /// <param name="text"></param>
    public CustomLabel(string name, int x, int y, int width, int height, Color color, string text = "") {
        Name = name;
        Location = new Point(x, y);
        Size = new Size(width, height);
        SetFont();
        SetAlign();
        SetText(text);
        SetBackColor(color);
    }

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="name"></param>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <param name="width"></param>
    /// <param name="height"></param>
    /// <param name="backColor"></param>
    /// <param name="borderStyle"></param>
    public CustomLabel(string name, int x, int y, int width, int height, Color backColor, BorderStyle borderStyle) {
        Name = name;
        Location = new Point(x, y);
        Size = new Size(width, height);
        SetFont();
        SetAlign();
        SetBackColor(backColor);
        BorderStyle = borderStyle;
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
    private void SetAlign() {
        TextAlign = ContentAlignment.MiddleLeft;
    }

    /// <summary>
    /// Virtual member call in constructor
    /// </summary>
    private void SetBackColor(Color color) {
        BackColor = color;
    }
}