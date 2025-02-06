using System.ComponentModel;
using System.Drawing;
using WorkDataStudio.Component;

// ReSharper disable InconsistentNaming
namespace WorkDataStudio;

/// <summary>
/// 完了情報フォーム
/// </summary>
public partial class Form11 {
    private DataGridView5 DataGridView5;

    /// <summary>
    /// InitComponent
    /// </summary>
    private void InitComponent() {
        DataGridView5 = new DataGridView5();
        ((ISupportInitialize)(DataGridView5)).BeginInit();
        SuspendLayout();
        // 
        // DataGridView5
        // 
        DataGridView5.DoubleClick += DataGridView5_DoubleClick;
        // 
        // Form11
        // 
        Name = @"Form11";
        Text = @"Form11";
        ClientSize = new Size(360, 720);
        Controls.Add(DataGridView5);
        Activated += Form11_Activated;
        ((ISupportInitialize)(DataGridView5)).EndInit();
        ResumeLayout(false);
    }
}