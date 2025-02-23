﻿using System.Drawing;
using System.Windows.Forms;
using WorkDataStudio.Component;

// ReSharper disable InconsistentNaming
namespace WorkDataStudio;

/// <summary>
/// 操作説明フォーム
/// </summary>
public partial class Form6 {
    private TextBox textBox1;

    /// <summary>
    /// InitComponent
    /// </summary>
    private void InitComponent() {
        textBox1 = new CustomTextBox(0, "Text1", 50, 50, 620, 620, Color.Black, true);
        SuspendLayout();
        // 
        // textBox1
        // 
        textBox1.Font = new Font("ＭＳ Ｐゴシック", 12F, FontStyle.Bold);
        // 
        // Form6
        // 
        Name = @"Form6";
        Text = @"Form6";
        ClientSize = new Size(720, 720);
        Controls.Add(textBox1);
        Load += Form6_Load;
        Activated += Form6_Activated;
        ResumeLayout(false);
        PerformLayout();
    }
}