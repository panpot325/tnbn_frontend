using WorkDataStudio.Component;

namespace WorkDataStudio {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.DataGrid1 = new DataGridView1();
            this.DataGrid2 = new DataGridView2();
            this.DataGrid3 = new DataGridView3();
            this.Frame2 = new System.Windows.Forms.GroupBox();
            this.Option1_1 = new System.Windows.Forms.RadioButton();
            this.Option1_0 = new System.Windows.Forms.RadioButton();
            this.Frame1 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Text3 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.Text6 = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.Text2 = new System.Windows.Forms.TextBox();
            this.Text1 = new System.Windows.Forms.TextBox();
            this.Text4 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.Text5 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Timers.Timer();
            this.timer2 = new System.Timers.Timer();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid1)).BeginInit();
            this.Frame2.SuspendLayout();
            this.Frame1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timer2)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGrid1
            // 
            this.DataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid1.Location = new System.Drawing.Point(12, 67);
            this.DataGrid1.Name = "DataGrid1";
            this.DataGrid1.RowTemplate.Height = 33;
            this.DataGrid1.Size = new System.Drawing.Size(1121, 1326);
            this.DataGrid1.TabIndex = 0;
            this.DataGrid1.DoubleClick += new System.EventHandler(this.DataGrid1_DoubleClick);
            this.DataGrid1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DataGrid1_MouseClick);
            // 
            // Frame2
            // 
            this.Frame2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Frame2.Controls.Add(this.Option1_1);
            this.Frame2.Controls.Add(this.Option1_0);
            this.Frame2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Frame2.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Frame2.Location = new System.Drawing.Point(2039, 124);
            this.Frame2.Name = "Frame2";
            this.Frame2.Padding = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.Frame2.Size = new System.Drawing.Size(248, 173);
            this.Frame2.TabIndex = 1;
            this.Frame2.TabStop = false;
            this.Frame2.Text = "対象データ";
            // 
            // Option1_1
            // 
            this.Option1_1.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Option1_1.Location = new System.Drawing.Point(0, 83);
            this.Option1_1.Name = "Option1_1";
            this.Option1_1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Option1_1.Size = new System.Drawing.Size(281, 55);
            this.Option1_1.TabIndex = 1;
            this.Option1_1.TabStop = true;
            this.Option1_1.Text = "作成しない";
            this.Option1_1.UseVisualStyleBackColor = true;
            // 
            // Option1_0
            // 
            this.Option1_0.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Option1_0.Location = new System.Drawing.Point(0, 27);
            this.Option1_0.Name = "Option1_0";
            this.Option1_0.Padding = new System.Windows.Forms.Padding(10);
            this.Option1_0.Size = new System.Drawing.Size(281, 69);
            this.Option1_0.TabIndex = 0;
            this.Option1_0.TabStop = true;
            this.Option1_0.Text = "作成する";
            this.Option1_0.UseVisualStyleBackColor = true;
            // 
            // Frame1
            // 
            this.Frame1.Controls.Add(this.label20);
            this.Frame1.Controls.Add(this.label19);
            this.Frame1.Controls.Add(this.label18);
            this.Frame1.Controls.Add(this.label17);
            this.Frame1.Controls.Add(this.label16);
            this.Frame1.Controls.Add(this.label15);
            this.Frame1.Controls.Add(this.label14);
            this.Frame1.Controls.Add(this.label13);
            this.Frame1.Controls.Add(this.label12);
            this.Frame1.Controls.Add(this.label11);
            this.Frame1.Controls.Add(this.label10);
            this.Frame1.Controls.Add(this.label9);
            this.Frame1.Controls.Add(this.label8);
            this.Frame1.Controls.Add(this.label7);
            this.Frame1.Controls.Add(this.label6);
            this.Frame1.Controls.Add(this.label5);
            this.Frame1.Controls.Add(this.label4);
            this.Frame1.Controls.Add(this.label3);
            this.Frame1.Controls.Add(this.label2);
            this.Frame1.Controls.Add(this.label1);
            this.Frame1.Font = new System.Drawing.Font("ＭＳ ゴシック", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Frame1.Location = new System.Drawing.Point(1634, 696);
            this.Frame1.Name = "Frame1";
            this.Frame1.Size = new System.Drawing.Size(645, 571);
            this.Frame1.TabIndex = 2;
            this.Frame1.TabStop = false;
            this.Frame1.Text = "バックカラーの説明";
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label20.Location = new System.Drawing.Point(191, 501);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(436, 38);
            this.label20.TabIndex = 18;
            this.label20.Text = "：選択行";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label19.Location = new System.Drawing.Point(191, 448);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(436, 38);
            this.label19.TabIndex = 17;
            this.label19.Text = "：Ｓ舷を作成(西)/Ｐ舷を作成しない";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label18.Location = new System.Drawing.Point(191, 399);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(436, 38);
            this.label18.TabIndex = 16;
            this.label18.Text = "：Ｐ舷を作成(東基準)";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label17.Location = new System.Drawing.Point(191, 351);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(436, 38);
            this.label17.TabIndex = 15;
            this.label17.Text = "：Ｐ舷を作成(西基準)";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label16.Location = new System.Drawing.Point(191, 298);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(436, 38);
            this.label16.TabIndex = 14;
            this.label16.Text = "：Ｓ舷を作成(東基準)";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label15.Location = new System.Drawing.Point(191, 247);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(436, 38);
            this.label15.TabIndex = 12;
            this.label15.Text = "：Ｓ舷を作成しない";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label14.Location = new System.Drawing.Point(191, 196);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(436, 38);
            this.label14.TabIndex = 13;
            this.label14.Text = "：入力不可";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label13.Location = new System.Drawing.Point(191, 149);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(436, 38);
            this.label13.TabIndex = 12;
            this.label13.Text = "：入力エラーまたはキー重複";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label12.Location = new System.Drawing.Point(191, 98);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(436, 38);
            this.label12.TabIndex = 11;
            this.label12.Text = "：削除対象データ";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label11.Location = new System.Drawing.Point(191, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(436, 38);
            this.label11.TabIndex = 10;
            this.label11.Text = "：更新対象データ";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label10.Location = new System.Drawing.Point(15, 501);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(159, 38);
            this.label10.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(15, 448);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 38);
            this.label9.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label8.Location = new System.Drawing.Point(15, 399);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 38);
            this.label8.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.label7.Location = new System.Drawing.Point(15, 351);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 38);
            this.label7.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label6.Location = new System.Drawing.Point(15, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 38);
            this.label6.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(15, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 38);
            this.label5.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Location = new System.Drawing.Point(15, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 38);
            this.label4.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(15, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 38);
            this.label3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(15, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 38);
            this.label2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(15, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 38);
            this.label1.TabIndex = 0;
            // 
            // Text3
            // 
            this.Text3.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Text3.Location = new System.Drawing.Point(1634, 126);
            this.Text3.Margin = new System.Windows.Forms.Padding(6);
            this.Text3.Name = "Text3";
            this.Text3.Size = new System.Drawing.Size(150, 36);
            this.Text3.TabIndex = 3;
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label21.Location = new System.Drawing.Point(1634, 82);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(175, 38);
            this.label21.TabIndex = 11;
            this.label21.Text = "入力単位";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label22.Location = new System.Drawing.Point(1825, 82);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(183, 38);
            this.label22.TabIndex = 12;
            this.label22.Text = "ゼロの入力";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Text6
            // 
            this.Text6.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Text6.Location = new System.Drawing.Point(1825, 124);
            this.Text6.Margin = new System.Windows.Forms.Padding(6);
            this.Text6.Name = "Text6";
            this.Text6.Size = new System.Drawing.Size(150, 36);
            this.Text6.TabIndex = 13;
            // 
            // label23
            // 
            this.label23.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label23.Location = new System.Drawing.Point(1634, 182);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(175, 38);
            this.label23.TabIndex = 14;
            this.label23.Text = "入力範囲";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Text2
            // 
            this.Text2.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Text2.Location = new System.Drawing.Point(1634, 226);
            this.Text2.Margin = new System.Windows.Forms.Padding(6);
            this.Text2.Multiline = true;
            this.Text2.Name = "Text2";
            this.Text2.Size = new System.Drawing.Size(268, 62);
            this.Text2.TabIndex = 15;
            // 
            // Text1
            // 
            this.Text1.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Text1.Location = new System.Drawing.Point(1634, 350);
            this.Text1.Margin = new System.Windows.Forms.Padding(6);
            this.Text1.Multiline = true;
            this.Text1.Name = "Text1";
            this.Text1.Size = new System.Drawing.Size(645, 146);
            this.Text1.TabIndex = 16;
            // 
            // Text4
            // 
            this.Text4.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Text4.Location = new System.Drawing.Point(1634, 519);
            this.Text4.Margin = new System.Windows.Forms.Padding(6);
            this.Text4.Multiline = true;
            this.Text4.Name = "Text4";
            this.Text4.Size = new System.Drawing.Size(645, 146);
            this.Text4.TabIndex = 17;
            // 
            // label24
            // 
            this.label24.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label24.Location = new System.Drawing.Point(1634, 306);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(175, 38);
            this.label24.TabIndex = 18;
            this.label24.Text = "備考";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DataGrid2
            // 
            this.DataGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid2.Location = new System.Drawing.Point(1150, 67);
            this.DataGrid2.Name = "DataGrid2";
            this.DataGrid2.RowTemplate.Height = 33;
            this.DataGrid2.Size = new System.Drawing.Size(178, 1326);
            this.DataGrid2.TabIndex = 19;
            this.DataGrid2.SelectionChanged += new System.EventHandler(this.DataGrid2_SelectionChanged);
            // 
            // DataGrid3
            // 
            this.DataGrid3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid3.Location = new System.Drawing.Point(1346, 67);
            this.DataGrid3.Name = "DataGrid3";
            this.DataGrid3.RowTemplate.Height = 33;
            this.DataGrid3.Size = new System.Drawing.Size(267, 1326);
            this.DataGrid3.TabIndex = 20;
            this.DataGrid3.Scroll += new System.Windows.Forms.ScrollEventHandler(this.DataGrid3_Scroll);
            this.DataGrid3.SelectionChanged += new System.EventHandler(this.DataGrid3_SelectionChanged);
            this.DataGrid3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataGrid3_KeyDown);
            this.DataGrid3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DataGrid3_KeyPress);
            this.DataGrid3.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.DataGrid3_EditingControlShowing);
            this.DataGrid3.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid3_CellEndEdit);
            this.DataGrid3.CurrentCellChanged += new System.EventHandler(this.DataGrid3_CurrentCellChanged);
            // 
            // Text5
            // 
            this.Text5.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Text5.Location = new System.Drawing.Point(1396, 15);
            this.Text5.Margin = new System.Windows.Forms.Padding(6);
            this.Text5.Name = "Text5";
            this.Text5.Size = new System.Drawing.Size(150, 36);
            this.Text5.TabIndex = 21;
            this.Text5.TextChanged += new System.EventHandler(this.Text5_TextChanged);
            this.Text5.Enter += new System.EventHandler(this.Text5_Enter);
            this.Text5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Text5_KeyDown);
            this.Text5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Text5_KeyPress);
            this.Text5.Leave += new System.EventHandler(this.Text5_Leave);
            // 
            // timer1
            // 
            this.timer1.SynchronizingObject = this;
            this.timer1.Elapsed += new System.Timers.ElapsedEventHandler(this.timer1_Elapsed);
            // 
            // timer2
            // 
            this.timer2.Interval = 60000D;
            this.timer2.SynchronizingObject = this;
            this.timer2.Elapsed += new System.Timers.ElapsedEventHandler(this.timer2_Elapsed);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2374, 1429);
            this.Controls.Add(this.Text5);
            this.Controls.Add(this.DataGrid3);
            this.Controls.Add(this.DataGrid2);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.Text4);
            this.Controls.Add(this.Text1);
            this.Controls.Add(this.Text2);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.Text6);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.Text3);
            this.Controls.Add(this.Frame1);
            this.Controls.Add(this.Frame2);
            this.Controls.Add(this.DataGrid1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid1)).EndInit();
            this.Frame2.ResumeLayout(false);
            this.Frame1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timer2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Timers.Timer timer2;

        private System.Timers.Timer timer1;

        private System.Windows.Forms.TextBox Text5;

        private DataGridView1 DataGrid1;
        private DataGridView3 DataGrid3;
        private DataGridView2 DataGrid2;

        private System.Windows.Forms.TextBox Text1;
        private System.Windows.Forms.TextBox Text4;
        private System.Windows.Forms.Label label24;

        private System.Windows.Forms.TextBox Text2;

        private System.Windows.Forms.TextBox Text6;
        private System.Windows.Forms.Label label23;

        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;

        private System.Windows.Forms.TextBox Text3;

        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;

        private System.Windows.Forms.Label label12;

        private System.Windows.Forms.Label label11;

        private System.Windows.Forms.Label label10;

        private System.Windows.Forms.Label label9;

        private System.Windows.Forms.Label label8;

        private System.Windows.Forms.Label label7;

        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.GroupBox Frame1;

        private System.Windows.Forms.RadioButton Option1_1;

        private System.Windows.Forms.RadioButton Option1_0;

        private System.Windows.Forms.GroupBox Frame2;

        #endregion
    }
}