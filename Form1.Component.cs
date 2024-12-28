using WorkDataStudio.Component;
using WorkDataStudio.share;

// ReSharper disable InconsistentNaming
namespace WorkDataStudio;

/// <summary>
/// 加工ワークデータ作成フォーム
/// </summary>
public partial class Form1 {
    private DataGridView1 DataGrid1;
    private DataGridView2 DataGrid2;
    private DataGridView3 DataGrid3;

    private CustomLabel label1;
    private CustomLabel label2;
    private CustomLabel label3;
    private CustomLabel label4;
    private CustomLabel label5;
    private CustomLabel label6;
    private CustomLabel label7;
    private CustomLabel label8;
    private CustomLabel label9;
    private CustomLabel label10;
    private CustomLabel label11;
    private CustomLabel label12;
    private CustomLabel label13;
    private CustomLabel label14;
    private CustomLabel label15;
    private CustomLabel label16;
    private CustomLabel label17;
    private CustomLabel label18;
    private CustomLabel label19;
    private CustomLabel label20;
    private CustomLabel label21;
    private CustomLabel label22;
    private CustomLabel label23;
    private CustomLabel label24;

    private System.Timers.Timer timer2;
    private System.Timers.Timer timer1;

    private CustomTextBox Text1;
    private CustomTextBox Text2;
    private CustomTextBox Text3;
    private CustomTextBox Text4;
    private CustomTextBox Text6;
    private CustomGroupBox Frame1;
    private CustomGroupBox Frame2;
    private CustomRadioButton Option1_1;
    private CustomRadioButton Option1_0;

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitComponent() {
        label1 = new CustomLabel("label1", 15, 49, 159, 38, BgColor.UPDATED);
        label2 = new CustomLabel("label2", 15, 98, 159, 38, BgColor.DELETED);
        label3 = new CustomLabel("label3", 15, 149, 159, 38, BgColor.INVALID);
        label4 = new CustomLabel("label4", 15, 196, 159, 38, BgColor.DISABLED);
        label5 = new CustomLabel("label5", 15, 247, 159, 38, BgColor.S_GUNWALE_N);
        label6 = new CustomLabel("label6", 15, 298, 159, 38, BgColor.S_GUNWALE_E);
        label7 = new CustomLabel("label7", 15, 351, 159, 38, BgColor.P_GUNWALE_W);
        label8 = new CustomLabel("label8", 15, 399, 159, 38, BgColor.P_GUNWALE_E);
        label9 = new CustomLabel("label9", 15, 448, 159, 38, BgColor.S_GUNWALE_W);
        label10 = new CustomLabel("label10", 15, 501, 159, 38, BgColor.SELECTED);
        label11 = new CustomLabel("label11", 191, 49, 436, 38, @"更新対象データ");
        label12 = new CustomLabel("label12", 191, 98, 436, 38, @"削除対象データ");
        label13 = new CustomLabel("label13", 191, 149, 436, 38, @"入力エラーまたはキー重複");
        label14 = new CustomLabel("label14", 191, 196, 436, 38, @"入力不可");
        label15 = new CustomLabel("label15", 191, 247, 436, 38, @"：Ｓ舷を作成しない");
        label16 = new CustomLabel("label16", 191, 298, 436, 38, @"：Ｓ舷を作成(東基準)");
        label17 = new CustomLabel("label17", 191, 351, 436, 38, @"：Ｐ舷を作成(西基準)");
        label18 = new CustomLabel("label18", 191, 399, 436, 38, @"：Ｐ舷を作成(東基準)");
        label19 = new CustomLabel("label19", 191, 448, 436, 38, @"：Ｓ舷を作成(西)/Ｐ舷を作成しない");
        label20 = new CustomLabel("label20", 191, 501, 436, 38, @"選択行");
        label21 = new CustomLabel("label21", 1634, 82, 175, 38, @"入力単位");
        label22 = new CustomLabel("label22", 1825, 82, 175, 38, @"ゼロの入力");
        label23 = new CustomLabel("label23", 1634, 182, 436, 38, @"入力範囲");
        label24 = new CustomLabel("label24", 1634, 306, 175, 38, @"備考");

        Text1 = new CustomTextBox(1, "Text1", 1634, 350, 645, 146, true);
        Text2 = new CustomTextBox(2, "Text2", 1634, 226, 268, 62, true);
        Text3 = new CustomTextBox(3, "Text3", 1634, 126, 150, 36);
        Text4 = new CustomTextBox(4, "Text4", 1634, 519, 645, 146, true);
        Text6 = new CustomTextBox(6, "Text6", 1825, 124, 150, 36);

        Frame1 = new CustomGroupBox(0, "Frame1", 1634, 696, 645, 571, @"バックカラーの説明");
        Frame2 = new CustomGroupBox(0, "Frame2", 2039, 124, 248, 173, @"対象データ");

        Option1_0 = new CustomRadioButton(0, "Option1_0", 0, 27, 281, 69, @"作成する");
        Option1_1 = new CustomRadioButton(1, "Option1_1", 0, 83, 281, 55, @"作成しない");

        timer1 = new System.Timers.Timer();
        timer2 = new System.Timers.Timer();

        Frame1.SuspendLayout();
        Frame2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(timer1)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(timer2)).BeginInit();
        SuspendLayout();

        // 
        // Frame1
        // 
        Frame1.Controls.Add(label1);
        Frame1.Controls.Add(label2);
        Frame1.Controls.Add(label3);
        Frame1.Controls.Add(label4);
        Frame1.Controls.Add(label5);
        Frame1.Controls.Add(label6);
        Frame1.Controls.Add(label7);
        Frame1.Controls.Add(label8);
        Frame1.Controls.Add(label9);
        Frame1.Controls.Add(label11);
        Frame1.Controls.Add(label12);
        Frame1.Controls.Add(label13);
        Frame1.Controls.Add(label10);
        Frame1.Controls.Add(label14);
        Frame1.Controls.Add(label15);
        Frame1.Controls.Add(label16);
        Frame1.Controls.Add(label17);
        Frame1.Controls.Add(label18);
        Frame1.Controls.Add(label19);
        Frame1.Controls.Add(label20);

        // 
        // Frame2
        // 
        Frame2.Controls.Add(Option1_0);
        Frame2.Controls.Add(Option1_1);
        Frame2.FlatStyle = System.Windows.Forms.FlatStyle.System;

        // timer1
        timer1.SynchronizingObject = this;
        timer1.Elapsed += timer1_Elapsed;

        // timer2
        timer2.Interval = 60000D;
        timer2.SynchronizingObject = this;
        timer2.Elapsed += timer2_Elapsed;

        // Form1
        Name = "Form1";
        //AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        //ClientSize = new System.Drawing.Size(2374, 1429);

        Controls.Add(Text1);
        Controls.Add(Text2);
        Controls.Add(Text3);
        Controls.Add(Text4);
        Controls.Add(Text6);
        Controls.Add(label21);
        Controls.Add(label22);
        Controls.Add(label23);
        Controls.Add(label24);
        Controls.Add(Frame1);
        Controls.Add(Frame2);

        Load += Form1_Load;
        Activated += Form1_Activated;
        FormClosed += Form1_FormClosed;

        Frame2.ResumeLayout(false);
        Frame1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)(timer1)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(timer2)).EndInit();

        ResumeLayout(false);
        PerformLayout();
    }
    
    private void DataGrid1_Initialize() {
        DataGrid1 = new DataGridView1();
        DataGrid1.MouseClick += DataGrid1_MouseClick;
        DataGrid1.DoubleClick += DataGrid1_DoubleClick;
        DataGrid1.SelectionChanged += DataGrid1_SelectionChanged;
        Controls.Add(DataGrid1);
    }

    private void DataGrid2_Initialize() {
        DataGrid2 = new DataGridView2();
        DataGrid2.SelectionChanged += DataGrid2_SelectionChanged;
        Controls.Add(DataGrid2);
    }

    private void DataGrid3_Initialize() {
        DataGrid3 = new DataGridView3();
        DataGrid3.Scroll += DataGrid3_Scroll;
        DataGrid3.KeyDown += DataGrid3_KeyDown;
        DataGrid3.KeyPress += DataGrid3_KeyPress;
        DataGrid3.CellEndEdit += DataGrid3_CellEndEdit;
        DataGrid3.SelectionChanged += DataGrid3_SelectionChanged;
        DataGrid3.CurrentCellChanged += DataGrid3_CurrentCellChanged;
        DataGrid3.EditingControlShowing += DataGrid3_EditingControlShowing;
        Controls.Add(DataGrid3);
    }
}