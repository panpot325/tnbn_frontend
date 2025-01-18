using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using WorkDataStudio.Component;
using WorkDataStudio.share;
using Timer = System.Timers.Timer;

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

    private Timer timer2;
    private Timer timer1;

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
        var x = 15;
        var y = 0;
        var width = 90;
        var height = 22;
        const int step = 32;
        label1 = new CustomLabel("label1", x, y += step, width, height, BgColor.UPDATED, BorderStyle.FixedSingle);
        label2 = new CustomLabel("label2", x, y += step, width, height, BgColor.DELETED, BorderStyle.FixedSingle);
        label3 = new CustomLabel("label3", x, y += step, width, height, BgColor.INVALID, BorderStyle.FixedSingle);
        label4 = new CustomLabel("label4", x, y += step, width, height, BgColor.DISABLED, BorderStyle.FixedSingle);
        label5 = new CustomLabel("label5", x, y += step, width, height, BgColor.S_GUNWALE_N, BorderStyle.FixedSingle);
        label6 = new CustomLabel("label6", x, y += step, width, height, BgColor.S_GUNWALE_E, BorderStyle.FixedSingle);
        label7 = new CustomLabel("label7", x, y += step, width, height, BgColor.P_GUNWALE_W, BorderStyle.FixedSingle);
        label8 = new CustomLabel("label8", x, y += step, width, height, BgColor.P_GUNWALE_E, BorderStyle.FixedSingle);
        label9 = new CustomLabel("label9", x, y += step, width, height, BgColor.S_GUNWALE_W, BorderStyle.FixedSingle);
        label10 = new CustomLabel("label10", x, y += step, width, height, BgColor.SELECTED, BorderStyle.FixedSingle);
        x = 110;
        y = 0;
        width = 240;
        label11 = new CustomLabel("label11", x, y += step, width, height, @"：更新対象データ");
        label12 = new CustomLabel("label12", x, y += step, width, height, @"：削除対象データ");
        label13 = new CustomLabel("label13", x, y += step, width, height, @"：入力エラーまたはキー重複");
        label14 = new CustomLabel("label14", x, y += step, width, height, @"：入力不可");
        label15 = new CustomLabel("label15", x, y += step, width, height, @"：Ｓ舷を作成しない");
        label16 = new CustomLabel("label16", x, y += step, width, height, @"：Ｓ舷を作成(東基準)");
        label17 = new CustomLabel("label17", x, y += step, width, height, @"：Ｐ舷を作成(西基準)");
        label18 = new CustomLabel("label18", x, y += step, width, height, @"：Ｐ舷を作成(東基準)");
        label19 = new CustomLabel("label19", x, y += step, width, height, @"：Ｓ舷を作成(西)/Ｐ舷を作成しない");
        label20 = new CustomLabel("label20", x, y += step, width, height, @"選択行");

        label21 = new CustomLabel("label21", 750, 26, 90, 30, @"入力単位");
        Text3 = new CustomTextBox(3, "Text3", 750, 60, 90, 45); //入力単位

        label22 = new CustomLabel("label22", 850, 26, 90, 30, @"ゼロの入力");
        Text6 = new CustomTextBox(6, "Text6", 850, 60, 90, 45, HorizontalAlignment.Center); //ゼロの入力

        label23 = new CustomLabel("label23", 750, 86, 180, 30, @"入力範囲");
        Text2 = new CustomTextBox(2, "Text2", 750, 120, 190, 56, Color.Blue, true); //入力範囲

        label24 = new CustomLabel("label24", 750, 180, 175, 30, @"備考");
        Text1 = new CustomTextBox(1, "Text1", 750, 214, 360, 70, Color.Red, true); //備考
        Text4 = new CustomTextBox(4, "Text4", 750, 292, 360, 70, true); //備考(下）

        Frame1 = new CustomGroupBox(0, "Frame1", 750, 376, 360, 320, @"バックカラーの説明");
        Frame2 = new CustomGroupBox(0, "Frame2", 960, 50, 150, 100, @"対象データ");
        Option1_0 = new CustomRadioButton(0, "Option1_0", 6, 16, 120, 40, @"作成する");
        Option1_1 = new CustomRadioButton(1, "Option1_1", 6, 52, 120, 40, @"作成しない");

        timer1 = new Timer();
        timer2 = new Timer();

        Frame1.SuspendLayout();
        Frame2.SuspendLayout();
        ((ISupportInitialize)(timer1)).BeginInit();
        ((ISupportInitialize)(timer2)).BeginInit();
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
        Frame2.FlatStyle = FlatStyle.Standard;

        // timer1
        timer1.SynchronizingObject = this;
        timer1.Elapsed += timer1_Elapsed;

        // timer2
        timer2.Interval = 60000D;
        timer2.SynchronizingObject = this;
        timer2.Elapsed += timer2_Elapsed;

        // Form1
        Name = "Form1";
        //AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1124, 764);

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
        ControlBox = false;

        Load += Form1_Load;
        Activated += Form1_Activated;
        FormClosed += Form1_FormClosed;

        Frame2.ResumeLayout(false);
        Frame1.ResumeLayout(false);
        ((ISupportInitialize)(timer1)).EndInit();
        ((ISupportInitialize)(timer2)).EndInit();

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