using System.Drawing;
using System.Windows.Forms;

namespace WorkDataStudio.Component;

/// <summary>
/// CustomRadioButton
/// </summary>
public class CustomRadioButton : RadioButton {
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
    public CustomRadioButton(int index, string name, int x, int y, int width, int height, string text = "") {
        Name = name;
        TabIndex = index;
        Location = new Point(x, y);
        Size = new Size(width, height);
        SetFont();
        SetText(text);
        TabStop = true;
        UseVisualStyleBackColor = true;
        Padding = new Padding(10);
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
}