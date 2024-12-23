using System;
using System.Linq;
using System.Windows.Forms;
using WorkDataStudio.model;
using G = WorkDataStudio.share.Globals;
using C = WorkDataStudio.share.Constants;

namespace WorkDataStudio;

/// <summary>
/// DataGridView1
/// イベントハンドラ
/// </summary>
public partial class Form1 {
    /// <summary>
    /// 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void DataGrid1_MouseClick(object sender, MouseEventArgs e) {
        Console.WriteLine(@"MouseClick");
        DataGrid3.ShowWorkData(DataGrid1.WorkData);
    }

    /// <summary>
    /// @MSFlexGrid1_DblClick()
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    /// <exception cref="NotImplementedException"></exception>
    private void DataGrid1_DoubleClick(object sender, EventArgs e) {
        if (string.IsNullOrEmpty(DataGrid1[0, DataGrid1.RowIndex].Value.ToString())) {
            return;
        }

        switch (G.Mode) {
            case C.MODE_EDIT_1:
            case C.MODE_COPY_1:
                //case C.MODE_NEW_1:
                //|| G.selMode == C.MODE_NEW_1 は仮
                //WorkData.Add(G.snoName);
                //WorkData.List.Last().Sno = G.snoName;
                DataGrid1.Add(G.snoName);
                DataGrid1.ShowWorkData(); //グリッド1の表示
                DataGrid1.Select(WorkData.Count - 1);
                DataGrid3.ShowWorkData(DataGrid1.WorkData);
                //DataGrid1.SetSData(); //グリッド1_Sデータ作成色設定_読込時
                //DataGrid1.SetPData();//グリッド1_Pデータ作成色設定_読込時
                break;
        }
    }
}