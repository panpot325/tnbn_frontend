﻿using System;
using WorkDataStudio.Model;
using WorkDataStudio.share;
using WorkDataStudio.type;

// ReSharper disable MemberCanBeMadeStatic.Local
namespace WorkDataStudio;

/// <summary>
/// データ登録
/// </summary>
public partial class Form1 {
    /// <summary>
    ///  新規登録
    /// </summary>
    private void Save_New_1() {
        if (!WorkData.ValidAll()) {
            ValidMessage();
            return;
        }

        if (!WorkData.DuplicateAll()) {
            DuplicateMessage();
            return;
        }

        WorkData.UpdateAll(true);
        WorkData_S_Create(); // @Sデータの作成と登録
        WorkData_S_Update(); // @加工ワークデータSの更新
        WorkData_P_Create(); // @Pデータの作成と登録
        WorkData_PS_Update(); // @CrePSFlgの更新
        WorkDataExclusive.Delete();
        Mode.SetNew1();
        Process_New();
    }

    /// <summary>
    ///  船番指定
    /// </summary>
    private void Save_Edit_1() {
        WorkData.DeleteOfSno(WorkData.snoName);
        WorkData.UpdateAll(false);
        WorkData_S_Create(); // @Sデータの作成と登録
        WorkData_S_Update(); // @加工ワークデータSの更新
        WorkData_P_Create(); // @Pデータの作成と登録
        WorkData_PS_Update(); // @CrePSFlgの更新
        WorkDataExclusive.Delete();
        Mode.SetNew1();
        Process_New();
    }

    /// <summary>
    ///  船番コピー
    /// </summary>
    private void Save_Copy_1() {
        WorkData.DeleteOfSno(WorkData.snoName);
        WorkData.UpdateAll(false);
        WorkData_S_Create(); // @Sデータの作成と登録
        WorkData_S_Update(); // @加工ワークデータSの更新
        WorkData_P_Create(); // @Pデータの作成と登録
        WorkData_PS_Update(); // @CrePSFlgの更新
        WorkDataExclusive.Delete();
        Mode.SetNew1();
        Process_New();
    }

    /// <summary>
    /// キーコピー
    /// </summary>
    private void Save_Copy_2() {
        if (!WorkData.ValidAll()) {
            ValidMessage();
            return;
        }

        if (!WorkData.DuplicateAll()) {
            DuplicateMessage();
            return;
        }

        WorkData.InsertAll();
        WorkDataExclusive.Delete();
        Mode.SetNew1();
        Process_New();
    }

    /// <summary>
    /// 今日予定
    /// </summary>
    private void Save_Edit_3() {
        if (!WorkData.ValidAll()) {
            ValidMessage();
            return;
        }

        WorkData.UpdateAll(true);
        WorkDataExclusive.Delete();
        Mode.SetNew1();
        Process_New();
    }

    /// <summary>
    /// 重複メッセージ
    /// </summary>
    private void DuplicateMessage() {
        Text4.Text = $@"キーが重複しています。{Environment.NewLine}";
        Text4.Text += $@"登録処理を中断します。{Environment.NewLine}";
        Text4.Text += $@"正しいキーを入力し直してください。{Environment.NewLine}";
        Text4.ForeColor = FgColor.INVALID;
        DataGrid3.SetBackColor(DataGrid1.WorkData);
        DataGrid3.CurrentCell = DataGrid3[0, DataGrid3.RowIndex];
    }

    /// <summary>
    /// エラーメッセージ
    /// </summary>
    private void ValidMessage() {
        Text4.Text = $@"入力値が正しくないデータがある為{Environment.NewLine}";
        Text4.Text += $@"登録処理を中断します。{Environment.NewLine}";
        Text4.Text += $@"正しい値を入力し直してください。{Environment.NewLine}";
        Text4.ForeColor = FgColor.INVALID;
        DataGrid3.SetBackColor(DataGrid1.WorkData);
        DataGrid3.CurrentCell = DataGrid3[0, DataGrid3.RowIndex];
    }
}