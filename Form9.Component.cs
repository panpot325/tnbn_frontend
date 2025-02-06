using System.Drawing;
using System.Windows.Forms;

// ReSharper disable InconsistentNaming
namespace WorkDataStudio;

/// <summary>
/// 船番単位削除フォーム
/// </summary>
public partial class Form9 {
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
        label1.Location = new Point(50, 56);
        label1.Size = new Size(60, 40);
        label1.Font = new Font("ＭＳ Ｐゴシック", 11F, FontStyle.Bold);
        label1.TabIndex = 1;
        // 
        // comboBox1
        // 
        comboBox1.Name = @"comboBox1";
        comboBox1.Location = new Point(140, 54);
        comboBox1.Size = new Size(160, 40);
        comboBox1.FormattingEnabled = true;
        comboBox1.Font = new Font("ＭＳ Ｐゴシック", 11F, FontStyle.Bold);
        comboBox1.TabIndex = 0;
        comboBox1.KeyUp += comboBox1_KeyUp;
        // 
        // Form9
        // 
        Name = @"Form9";
        Text = @"Form9";
        ClientSize = new Size(360, 160);
        Controls.Add(label1);
        Controls.Add(comboBox1);
        Load += Form9_Load;
        Activated += Form9_Activated;
        ResumeLayout(false);
    }
}