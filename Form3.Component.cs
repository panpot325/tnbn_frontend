using System.Drawing;
using System.Windows.Forms;

// ReSharper disable InconsistentNaming
namespace WorkDataStudio;

/// <summary>
/// 社員番号入力フォーム
/// </summary>
public partial class Form3 {
    private TextBox textBox1;
    private Label label1;

    /// <summary>
    /// InitComponent
    /// </summary>
    private void InitComponent() {
        label1 = new Label();
        textBox1 = new TextBox();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Name = @"label1";
        label1.Text = @"社員番号入力";
        label1.Location = new Point(27, 50);
        label1.Size = new Size(253, 78);
        label1.TabIndex = 0;
        label1.Font = new Font("ＭＳ Ｐゴシック", 11F, FontStyle.Bold,
            GraphicsUnit.Point, ((byte)(128)));
        // 
        // textBox1
        // 
        textBox1.Name = @"textBox1";
        textBox1.Location = new Point(327, 50);
        textBox1.Size = new Size(287, 37);
        textBox1.Font = new Font("ＭＳ Ｐゴシック", 11F, FontStyle.Regular,
            GraphicsUnit.Point, ((byte)(128)));
        textBox1.TabIndex = 1;
        textBox1.TextChanged += textBox1_TextChanged;
        textBox1.KeyUp += textBox1_KeyUp;
        // 
        // Form3
        // 
        Name = @"Form3";
        Text = @"Form3";
        ClientSize = new Size(800, 450);
        AutoScaleMode = AutoScaleMode.Font;
        AutoScaleDimensions = new SizeF(13F, 24F);
        Controls.Add(label1);
        Controls.Add(textBox1);
        ResumeLayout(false);
        PerformLayout();
    }
}