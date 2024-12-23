using System.Windows.Forms;

// ReSharper disable MemberCanBeMadeStatic.Local

namespace WorkDataStudio;

/// <summary>
/// 加工ワークデータ作成フォーム
/// </summary>
public partial class Form1 : Form {
    /// <summary>
    /// CreateMenuStrip
    /// </summary>
    private void MenuStrip() {
        var menuStrip = new MenuStrip();
        SuspendLayout();
        menuStrip.SuspendLayout();

        menuStrip.Items.AddRange(new ToolStripItem[] {
            GetMenuItem1(),
            GetMenuItem2(),
            GetMenuItem3(),
            GetMenuItem4(),
            GetMenuItem5()
        });

        Controls.Add(menuStrip);
        MainMenuStrip = menuStrip;
        menuStrip.ResumeLayout(false);
        menuStrip.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }
}