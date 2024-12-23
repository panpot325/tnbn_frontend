﻿using System.Drawing;
using System.Windows.Forms;

// ReSharper disable InconsistentNaming
namespace WorkDataStudio;

/// <summary>
/// コピー船番選択フォーム
/// </summary>
public partial class Form7 {
    private Label label1;
    private Label label2;
    private TextBox textBox1;
    private ComboBox comboBox1;

    /// <summary>
    /// InitComponent
    /// </summary>
    private void InitComponent() {
        label1 = new Label();
        label2 = new Label();
        textBox1 = new TextBox();
        comboBox1 = new ComboBox();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Name = @"label1";
        label1.Text = @"船番";
        label1.Location = new Point(16, 117);
        label1.Size = new Size(93, 26);
        label1.TextAlign = ContentAlignment.MiddleRight;
        label1.TabIndex = 2;
        // 
        // label2
        // 
        label2.Name = @"label2";
        label2.Text = @"→";
        label2.Location = new Point(414, 121);
        label2.Size = new Size(54, 23);
        label2.TextAlign = ContentAlignment.MiddleCenter;
        label2.TabIndex = 3;
        // 
        // textBox1
        // 
        textBox1.Name = @"textBox1";
        textBox1.Location = new Point(474, 112);
        textBox1.Size = new Size(214, 31);
        textBox1.TabIndex = 1;
        textBox1.KeyUp += textBox1_KeyUp;
        // 
        // comboBox1
        // 
        comboBox1.Name = @"comboBox1";
        comboBox1.Location = new Point(118, 112);
        comboBox1.Size = new Size(281, 32);
        comboBox1.FormattingEnabled = true;
        comboBox1.TabIndex = 0;
        comboBox1.KeyUp += comboBox1_KeyUp;
        // 
        // Form7
        // 
        Name = @"Form7";
        Text = @"Form7";
        ClientSize = new Size(1074, 368);
        AutoScaleMode = AutoScaleMode.Font;
        AutoScaleDimensions = new SizeF(13F, 24F);
        Controls.Add(label1);
        Controls.Add(label2);
        Controls.Add(textBox1);
        Controls.Add(comboBox1);
        Load += Form7_Load;
        Activated += Form7_Activated;
        ResumeLayout(false);
        PerformLayout();
    }
}