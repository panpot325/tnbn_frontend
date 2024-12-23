using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using WorkDataStudio.Component;

// ReSharper disable InconsistentNaming

namespace WorkDataStudio;

/// <summary>
/// コピー船番一覧フォーム
/// </summary>
public partial class Form2 {
    private DataGridView4 DataGridView4;
    
    /// <summary>
    /// InitComponent
    /// </summary>
    private void InitComponent() {
        DataGridView4 = new DataGridView4();
        ((ISupportInitialize)DataGridView4).BeginInit();
        SuspendLayout();
        // 
        // DataGridView4
        // 
        DataGridView4.Name = "DataGridView4";
        DataGridView4.Location = new Point(40, 80);
        DataGridView4.Size = new Size(800, 800);
        DataGridView4.RowTemplate.Height = 33;
        DataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        DataGridView4.TabIndex = 0;
        DataGridView4.MouseClick += DataGrid4_MouseClick;
        DataGridView4.Width = 800;
        // 
        // Form2
        // 
        Name = @"Form2";
        Text = @"Form2";
        AutoScaleDimensions = new SizeF(13F, 24F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(DataGridView4);
        Activated += Form2_Activated;
        Load += Form2_Load;
        ((ISupportInitialize)DataGridView4).EndInit();
        ResumeLayout(false);
    }
}