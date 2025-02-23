﻿using System;
using System.Windows.Forms;
using WorkDataStudio.Model;
using WorkDataStudio.share;
using WorkDataStudio.type;

namespace WorkDataStudio;

/// <summary>
/// コピー船番一覧フォーム
/// </summary>
public partial class Form2 {
    /// <summary>
    /// Form2_Load
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Form2_Load(object sender, EventArgs e) {
        Log.WriteLine(@"Form2_Load");
        _activate = true;
        WorkData.Clear();
        //ScreenInit();
    }

    /// <summary>
    /// Form2_Activated
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Form2_Activated(object sender, EventArgs e) {
        if (!_activate) return;
        _activate = false;

        Log.WriteLine(@"Form2_Activated");
        DataGridView4.ShowWorkDataList();
    }

    /// <summary>
    /// DataGrid4_MouseClick
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void DataGrid4_MouseClick(object sender, MouseEventArgs e) {
        Log.WriteLine(@"MouseClick");
        var workData = DataGridView4.WorkData;
        if (workData is null) {
            return;
        }

        workData.ChgFlg = workData.ChgFlg == WorkData.DRAFT
            ? WorkData.UPDATE
            : WorkData.DRAFT;
        DataGridView4.ShowWorkData();
    }

    /// <summary>
    /// SelectionChanged
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void DataGrid4_SelectionChanged(object sender, EventArgs e) {
        Log.WriteLine("DataGrid4_SelectionChanged Event");
        DataGridView4.DefaultCellStyle.SelectionBackColor = BgColor.CLEARED;
    }

    /// <summary>
    /// 画面初期化
    /// </summary>
    private void ScreenInit() {
        DataGridView4.Init();
    }
}