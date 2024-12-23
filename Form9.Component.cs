using System.Drawing;
using System.Windows.Forms;

// ReSharper disable InconsistentNaming
namespace WorkDataStudio;

/// <summary>
/// 船番単位削除フォーム
/// </summary>
public partial class Form9  {
    private Label label1;
    private ComboBox comboBox1;

    /// <summary>
    /// InitComponent
    /// </summary>
    private void InitComponent() {
        label1 = new Label();
        comboBox1 = new ComboBox();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Name = @"label1";
        label1.Text = @"船番";
        label1.Location = new Point(105, 121);
        label1.Size = new Size(128, 27);
        label1.TabIndex = 1;
        // 
        // comboBox1
        // 
        comboBox1.Name = @"comboBox1";
        comboBox1.Location = new Point(217, 116);
        comboBox1.Size = new Size(280, 32);
        comboBox1.FormattingEnabled = true;
        comboBox1.TabIndex = 0;
        comboBox1.KeyUp += comboBox1_KeyUp;
        // 
        // Form9
        // 
        Name = @"Form9";
        Text = @"Form9";
        ClientSize = new Size(800, 450);
        AutoScaleMode = AutoScaleMode.Font;
        AutoScaleDimensions = new SizeF(13F, 24F);
        Controls.Add(label1);
        Controls.Add(comboBox1);
        Load += Form9_Load;
        Activated += Form9_Activated;
        ResumeLayout(false);
    }
}