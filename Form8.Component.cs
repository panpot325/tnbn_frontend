using System.Drawing;
using System.Windows.Forms;

// ReSharper disable InconsistentNaming
namespace WorkDataStudio;

/// <summary>
/// 船番単位フォーム
/// </summary>
public partial class Form8 {
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
        label1.Location = new Point(40, 42);
        label1.Size = new Size(60, 40);
        label1.Font = new Font("ＭＳ Ｐゴシック", 11F, FontStyle.Bold);
        label1.TabIndex = 1;
        // 
        // comboBox1
        // 
        comboBox1.Name = @"comboBox1";
        comboBox1.Location = new Point(140, 40);
        comboBox1.Size = new Size(180, 40);
        comboBox1.FormattingEnabled = true;
        comboBox1.Font = new Font("ＭＳ Ｐゴシック", 11F, FontStyle.Bold);
        comboBox1.TabIndex = 0;
        comboBox1.KeyUp += comboBox1_KeyUp;
        // 
        // Form8
        // 
        Name = @"Form8";
        Text = @"Form8";
        ClientSize = new Size(400, 160);
        Controls.Add(label1);
        Controls.Add(comboBox1);
        Load += Form8_Load;
        ResumeLayout(false);
    }
}