using System;
using System.Drawing;
using System.Windows.Forms;
using WorkDataStudio.model;
using WorkDataStudio.type;
using G = WorkDataStudio.share.Globals;
using C = WorkDataStudio.share.Constants;
// ReSharper disable InvertIf

namespace WorkDataStudio;

/// <summary>
/// Form1.Process
/// </summary>
public partial class Form1 {
    /// <summary>
    /// Process_New
    /// </summary>
    private void Process_New() {
        WorkData.Clear();
        WorkDataExclusive.Delete(G.staffId, G.pcName);
        WorkData.Add();

        Text1.Text = "";
        Text2.Text = "";
        Text3.Text = "";
        Text6.Text = "";
        Text4.Text = @"新規登録は、そのまま右側の明細を入力して下さい。";
        Text4.ForeColor = Color.Blue;

        DataGrid1.Init(); //@グリッド1の初期化
        DataGrid2.Init(); //@グリッド2の初期化
        DataGrid3.Init(); //@グリッド3の初期化

        DataGrid3.ShowWorkData(DataGrid1.WorkData);
        DataGrid3.Focus();
        DataGrid3.Select(0);
    }

    /// <summary>
    /// Process_Edit
    /// </summary>
    private void Process_Edit() {
        //ワークデータが存在
        if (WorkData.Exists) {
            DataGrid1.ShowWorkDataList(); //グリッド1の表示
            DataGrid1.SetSData(); //グリッド1_Sデータ作成色設定_読込時
            DataGrid1.SetPData(); //グリッド1_Pデータ作成色設定_読込時
            DataGrid3.ShowWorkData(DataGrid1.WorkData);
        }
    }

    /// <summary>
    /// Process_Copy
    /// </summary>
    private void Process_Copy() {
        ClearVariables();
        DataGrid1.Visible = false;
        DataGrid2.Visible = false;
        DataGrid3.Visible = false;

        DataGrid1.Enabled = true;
        DataGrid1.Init();
        DataGrid2.Init();
        DataGrid3.Init();

        //DataGrid1.Height = DataGrid1.Columns * 44.2;
        DataGrid2.ScrollBars = ScrollBars.Vertical;
        DataGrid2.FirstDisplayedScrollingRowIndex = DataGrid3.FirstDisplayedScrollingRowIndex;
        DataGrid2.ScrollBars = ScrollBars.None;
        DataGrid2.Height = DataGrid1.Height;
        DataGrid3.Height = DataGrid1.Height;

        DataGrid1.ShowWorkDataList();
        DataGrid3.ShowWorkData(DataGrid1.WorkData);

        DataGrid1.Visible = false;
        DataGrid2.Visible = false;
        DataGrid3.Visible = false;

        DataGrid3.Focus();
        DataGrid3.CurrentCell = DataGrid3[0, 0];

        DataGrid1.Enabled = true;

        //Grid1.SetFocus
        Frame2.Enabled = false;
        Option1_1.Checked = true;
    }
}