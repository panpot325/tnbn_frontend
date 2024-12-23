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
    /// @Pデータの作成と登録()
    /// </summary>
    private void WorkData_P_Create() {
        var dataList = WorkData.List;
        var typeList = WorkDataType.List;

        var lk = WorkDataType.DmIndex("W715"); //データタイプのLK1の配列番号
        var wl = WorkDataType.DmIndex("W745"); //データタイプのWL1の配列番号
        var sp = WorkDataType.DmIndex("W72C"); //データタイプのSP1の配列番号
        
        //Sデータの件数把握
        var si = dataList.Count(data => data.Pcs == "S" && data.CrePFlg != 1);

        //Erase 加工ワークデータS
        var dataS = dataList
            .Where(workData => workData.Pcs == "s" && workData.CrePFlg != 1)
            .Select(workData => WorkData.Create())
            .ToList();

        //データタイプのSP1〜SP5より最大のデフォルト値を取得
        var defMax = GetDefMax(sp);

        //Pデータの作成
        si = 0;
        foreach (var data in dataList.Where(data => data.Pcs == "S" && data.CrePFlg != 1)) {
            var width = data.CrePFlg == 0 ? data.B : 4900;
            var last = GetLastLongi(data); //最終ロンジ
            
            //各項目の初期値を設定
            SetWorkData(dataS[si], data, "P");

            //反転用WKへの編集(反転前)
            var pos = GetPositions(data);
            
            //反転用WKへの編集(反転後);
            SetPositions(pos, width);

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