using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Timer = System.Timers.Timer;

// ReSharper disable InconsistentNaming
namespace WorkDataStudio;

/// <summary>
/// ネットワーク状況確認フォーム
/// </summary>
public partial class Form10 {
    private Timer timer1;
    private Label label1;
    private Label label2;

    /// <summary>
    /// InitComponent
    /// </summary>
    private void InitComponent() {
        timer1 = new Timer();
        label1 = new Label();
        label2 = new Label();
        ((ISupportInitialize)(timer1)).BeginInit();
        SuspendLayout();
        // 
        // timer1
        // 
        timer1.Enabled = true;
        timer1.SynchronizingObject = this;
        timer1.Elapsed += timer1_Elapsed;
        // 
        // label1
        // 
        label1.Name = @"label1";
        label1.Text = @"ネットワークの状況を確認しています。";
        label1.Location = new Point(83, 115);
        label1.Size = new Size(623, 79);
        label1.TabIndex = 0;
        // 
        // label2
        // 
        label2.Name = @"label2";
        label2.Text = @"接続したら登録処理を再実行します。";
        label2.Location = new Point(83, 209);
        label2.Size = new Size(617, 80);
        label2.TabIndex = 1;
        // 
        // Form10
        // 
        Name = "Form10";
        Text = "Form10";
        ClientSize = new Size(800, 450);
        AutoScaleMode = AutoScaleMode.Font;
        AutoScaleDimensions = new SizeF(13F, 24F);
        Controls.Add(label1);
        Controls.Add(label2);
        Load += Form10_Load;
        Activated += Form10_Activated;
        ((ISupportInitialize)(timer1)).EndInit();
        ResumeLayout(false);
    }
}