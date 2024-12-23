using System.Drawing;
using System.Windows.Forms;

// ReSharper disable InconsistentNaming
namespace WorkDataStudio;

/// <summary>
/// 仮付け予定日選択フォーム
/// </summary>
public partial class Form5 {
    private Label label1;
    private Label label2;
    private ComboBox comboBox1;
    private ComboBox comboBox2;

    /// <summary>
    /// InitComponent
    /// </summary>
    private void InitComponent() {
        label1 = new Label();
        label2 = new Label();
        comboBox1 = new ComboBox();
        comboBox2 = new ComboBox();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Name = @"label1";
        label1.Text = @"仮付け予定日";
        label1.Location = new Point(55, 146);
        label1.Size = new Size(251, 33);
        label1.TabIndex = 2;
        // 
        // label2
        // 
        label2.Name = @"label2";
        label2.Text = @"～";
        label2.Location = new Point(358, 182);
        label2.Size = new Size(64, 36);
        label2.TextAlign = ContentAlignment.MiddleCenter;
        label2.TabIndex = 3;
        // 
        // comboBox1
        // 
        comboBox1.Name = @"comboBox1";
        comboBox1.FormattingEnabled = true;
        comboBox1.Location = new Point(78, 182);
        comboBox1.Size = new Size(280, 32);
        comboBox1.TabIndex = 0;
        // 
        // comboBox2
        // 
        comboBox2.Name = @"comboBox2";
        comboBox2.FormattingEnabled = true;
        comboBox2.Location = new Point(428, 182);
        comboBox2.Size = new Size(280, 32);
        comboBox2.TabIndex = 1;
        // 
        // Form5
        // 
        Name = @"Form5";
        Text = @"Form5";
        ClientSize = new Size(800, 450);
        AutoScaleDimensions = new SizeF(13F, 24F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(comboBox2);
        Controls.Add(comboBox1);
        Load += Form5_Load;
        Activated += Form5_Activated;
        ResumeLayout(false);
    }
}