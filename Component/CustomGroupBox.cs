using System.Drawing;
using System.Windows.Forms;

namespace WorkDataStudio.Component;

/// <summary>
/// CustomGroupBox
/// </summary>
public class CustomGroupBox : GroupBox {
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
        SetBackColor(SystemColors.ButtonFace);
        //FlatStyle = System.Windows.Forms.FlatStyle.System;
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