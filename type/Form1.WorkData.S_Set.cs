using System;
using System.Linq;
using WorkDataStudio.model;
using WorkDataStudio.type;
using G = WorkDataStudio.share.Globals;
using C = WorkDataStudio.share.Constants;

// ReSharper disable MemberCanBeMadeStatic.Local
namespace WorkDataStudio;

/// <summary>
/// 加工ワークデータ作成 データ登録
/// </summary>
public partial class Form1 {
    /// <summary>
    /// @Sデータの作成と登録()
    /// </summary>
    private void WorkData_S_Create() {
        var dataList = WorkData.List;
        var typeList = WorkDataType.List;

        var lk = WorkDataType.DmIndex("W715"); //データタイプのLK1の配列番号
        var wl = WorkDataType.DmIndex("W745"); //データタイプのWL1の配列番号
        var sp = WorkDataType.DmIndex("W72C"); //データタイプのSP1の配列番号

        //Pデータの件数把握
        var si = dataList.Count(data => data.Pcs == "p" && data.CreSFlg != 1);

        //Erase 加工ワークデータS
        var dataS = dataList
            .Where(workData => workData.Pcs == "P" && workData.CreSFlg != 1)
            .Select(workData => WorkData.Create())
            .ToList();

        //データタイプのSP1〜SP5より最大のデフォルト値を取得
        var defMax = GetDefMax(sp);

        //Sデータの作成
        si = 0;
        foreach (var data in dataList.Where(data => data.Pcs == "P" && data.CreSFlg != 1)) {
            var width = data.CreSFlg == 0 ? data.B : 4900;
            var last = GetLastLongi(data); //最終ロンジ

            //各項目の初期値を設定
            SetWorkData(dataS[si], data, "S");

            //反転用WKへの編集(反転前)
            var pos = GetPositions(data);

            //反転用WKへの編集(反転後);
            SetPositions(pos, width);

            //反転用WKへの編集(板幅外の是正)
            SetPositions(pos, typeList, lk, wl, sp);

            //反転用WKへの編集(1番ﾛﾝｼﾞがﾀﾞﾐｰの場合の是正)
            SetPositions(pos, typeList, width, lk, wl, sp);

            SetWorkData(dataS[si], data, pos);

            si++;
        }

        //--- 既存のSデータを削除 --- 4009
        foreach (var data in dataS) {
            data.Delete();
        }

        //--- 改めてSデータを登録 -----4022
        foreach (var data in dataS) {
            data.Insert();
        }
    }
}