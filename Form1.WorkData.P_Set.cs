﻿using System;
using System.Linq;
using WorkDataStudio.Model;

// ReSharper disable MemberCanBeMadeStatic.Local
namespace WorkDataStudio;

/// <summary>
/// 加工ワークデータ作成 データ登録
/// </summary>
public partial class Form1 {
    /// <summary>
    /// WorkData_P_Create
    /// @Pデータの作成と登録()
    /// </summary>
    private void WorkData_P_Create() {
        if (!Frame2.Enabled || !Option1_0.Checked) return;

        var lk = WorkDataType.DmIndex("W715"); //データタイプのLK1の配列番号
        var wl = WorkDataType.DmIndex("W745"); //データタイプのWL1の配列番号
        var sp = WorkDataType.DmIndex("W72C"); //データタイプのSP1の配列番号
        foreach (var data in WorkData.List
                     .Where(data => data.Pcs == "S" && data.CrePFlg != 1 && data.ChgFlg == WorkData.UPDATE)) {
            var sData = WorkData.Create();
            var width = data.CrePFlg == 0 ? data.B : 4900;
            var last = GetLastLongi(data); //最終ロンジ

            //各項目の初期値を設定
            SetWorkData(sData, data, "P");

            //反転用WKへの編集(反転前)
            var pos = GetPositions(data);

            //反転用WKへの編集(反転後);
            SetPositions(pos, width);

            //反転用WKへの編集(1番ﾛﾝｼﾞがﾀﾞﾐｰの場合の是正)
            SetPositions(pos, WorkDataType.List, width, lk, wl, sp);

            //反転用WKのセット
            SetWorkData(sData, data, pos);

            //既存のSデータを削除
            sData.Delete();

            //改めてSデータを登録
            sData.Insert();
        }
    }
}