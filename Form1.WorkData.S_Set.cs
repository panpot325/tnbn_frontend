using System;
using System.Linq;
using WorkDataStudio.Model;
using WorkDataStudio.share;

// ReSharper disable MemberCanBeMadeStatic.Local
namespace WorkDataStudio;

/// <summary>
/// 加工ワークデータ作成 データ登録
/// </summary>
public partial class Form1 {
    /// <summary>
    /// WorkData_S_Create
    /// @Sデータの作成と登録()
    /// </summary>
    private void WorkData_S_Create() {
        if (!Frame2.Enabled || !Option1_0.Checked) return;

        var lk = WorkDataType.DmIndex("W715"); //データタイプのLK1の配列番号
        var wl = WorkDataType.DmIndex("W745"); //データタイプのWL1の配列番号
        var sp = WorkDataType.DmIndex("W72C"); //データタイプのSP1の配列番号
        foreach (var data in WorkData.List
                     .Where(data => data.Pcs == "P" && data.CreSFlg != 1 && data.ChgFlg == WorkData.UPDATE)) {
            var sData = WorkData.Create();
            var width = data.CreSFlg == 0 ? data.B : 4900;

            //各項目の初期値を設定
            SetWorkData(sData, data, "S");

            //反転用WKへの編集(反転前)
            var pos = GetPositions(data);

            //反転用WKへの編集(反転後);
            SetPositions(pos, width);

            //反転用WKへの編集(板幅外の是正)
            SetPositions(pos, WorkDataType.List, lk, wl, sp);

            //反転用WKへの編集(1番ﾛﾝｼﾞがﾀﾞﾐｰの場合の是正)
            SetPositions(pos, WorkDataType.List, width, lk, wl, sp);

            //反転用WKのセット
            SetWorkData(sData, data, pos);

            //既存のSデータを削除
            sData.Delete();

            sData.YoteibiHon = 0;
            sData.YoteibiKyosei = 0;
            sData.JissibiKari = 0;
            sData.JissibiHon = 0;
            sData.JissibiKyosei = 0;
            sData.StatusKari = 0;
            sData.StatusHon = 0;
            sData.StatusKyosei = 0;
            sData.CreateDate = Convert.ToInt32(DateTime.Now.ToString("yyyyMMdd"));
            sData.CreateSyain = Globals.staffId;
            sData.UpdateDate = 0;
            sData.UpdateSyain = 0;
            sData.JissijknKari = 0;
            sData.JissijknHon = 0;
            sData.JissijknKyosei = 0;

            //改めてSデータを登録
            sData.Insert();
        }
    }
}