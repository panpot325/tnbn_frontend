using System.Drawing;
using System.Windows.Forms;

// ReSharper disable InconsistentNaming
namespace WorkDataStudio;

/// <summary>
/// コピー船番単位フォーム
/// </summary>
public partial class Form4 {
    private Label label2;
    private Label label1;
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
        label1.Text = @"船番";
        label1.Location = new Point(20, 52);
        label1.Size = new Size(60, 40);
        label1.Font = new Font("ＭＳ Ｐゴシック", 11F, FontStyle.Bold);
        label1.TabIndex = 2;
        // 
        // comboBox1
        // 
        comboBox1.Name = @"comboBox1";
        comboBox1.Location = new Point(80, 50);
        comboBox1.Size = new Size(140, 40);
        comboBox1.FormattingEnabled = true;
        comboBox1.Font = new Font("ＭＳ Ｐゴシック", 11F, FontStyle.Bold);
        comboBox1.TabIndex = 0;
        comboBox1.KeyUp += comboBox1_KeyUp;
        // 
        // label2
        // 
        label2.Name = @"label2";
        label2.Text = @"～";
        label2.Location = new Point(226, 52);
        label2.Size = new Size(20, 40);
        label2.Font = new Font("ＭＳ Ｐゴシック", 11F, FontStyle.Bold);
        label2.TabIndex = 3;
        // 
        // comboBox2
        // 
        comboBox2.Name = @"comboBox2";
        comboBox2.Location = new Point(260, 50);
        comboBox2.Size = new Size(140, 40);
        comboBox2.FormattingEnabled = true;
        comboBox2.Font = new Font("ＭＳ Ｐゴシック", 11F, FontStyle.Bold);
        comboBox2.TabIndex = 1;
        comboBox2.KeyUp += comboBox2_KeyUp;
        // 
        // Form4
        // 
        Name = @"Form4";
        Text = @"Form4";
        ClientSize = new Size(440, 140);
        Controls.Add(label1);
        Controls.Add(label2);
        Controls.Add(comboBox1);
        Controls.Add(comboBox2);
        Load += Form4_Load;
        Activated += Form4_Activated;
        ResumeLayout(false);
    }
}