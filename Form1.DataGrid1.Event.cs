﻿using System;
using System.Windows.Forms;
using WorkDataStudio.Model;
using WorkDataStudio.share;

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
        if (DataGrid1.RowCount == 0) return;
        DataGrid3.ShowWorkData(DataGrid1.WorkData);
        //DataGrid1.WorkData.Valid();
        DataGrid3.SetBackColor(DataGrid1.WorkData);
    }

    /// <summary>
    /// @MSFlexGrid1_DblClick()
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    /// <exception cref="NotImplementedException"></exception>
    private void DataGrid1_DoubleClick(object sender, EventArgs e) {
        if (DataGrid1.RowCount == 0) return;
        if (string.IsNullOrEmpty(DataGrid1[0, DataGrid1.RowIndex].Value.ToString())) {
            return;
        }

        switch (Mode.Value) {
            case Mode.EDIT_1 or Mode.COPY_1:
                //case SMode.NEW_1:
                //|| G.selMode == SMode.NEW_1 は仮
                //WorkData.Add(WorkData.snoName);
                //WorkData.List.Last().Sno = WorkData.snoName;
                DataGrid1.Add(WorkData.snoName);
                DataGrid1.ShowWorkData(); //グリッド1の表示
                DataGrid1.Select(WorkData.Count - 1);
                DataGrid3.ShowWorkData(DataGrid1.WorkData);
                //DataGrid1.SetSData(); //グリッド1_Sデータ作成色設定_読込時
                //DataGrid1.SetPData();//グリッド1_Pデータ作成色設定_読込時
                break;
        }
    }
}