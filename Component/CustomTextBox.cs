using System.Drawing;
using System.Windows.Forms;

namespace WorkDataStudio.Component;

/// <summary>
/// CustomTextBox
/// </summary>
public class CustomTextBox : System.Windows.Forms.TextBox {
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
        Margin = new System.Windows.Forms.Padding(6);
        SetMultiLine(multiline);
    }

    /// <summary>
    /// Virtual member call in constructor
    /// </summary>
    private void SetFont() {
        Font = new Font("ＭＳ Ｐゴシック", 10.875F, System.Drawing.FontStyle.Regular,
            GraphicsUnit.Point, ((byte)(128)));
    }

    /// <summary>
    /// Virtual member call in constructor
    /// </summary>
    private void SetMultiLine(bool multiline) {
        Multiline = multiline;
    }
}