using System;
using System.Collections.Generic;
using WorkDataStudio.Model;
using WorkDataStudio.type;

// ReSharper disable InvertIf
// ReSharper disable MemberCanBeMadeStatic.Local
namespace WorkDataStudio;

/// <summary>
/// @加工ワークデータ作成 データ登録
/// </summary>
public partial class Form1 {
    /// <summary>
    /// GetDefMax
    /// @データタイプのSP1〜SP5より最大のデフォルト値を取得
    /// </summary>
    /// <param name="sp"></param>
    /// <returns></returns>
    private string GetDefMax(int sp) {
        var typeList = WorkDataType.List;
        var defMax = typeList[sp].Def;
        if (string.Compare(defMax, typeList[sp + 1].Def, StringComparison.Ordinal) < 0) {
            defMax = typeList[sp + 1].Def;
        }

        if (string.Compare(defMax, typeList[sp + 2].Def, StringComparison.Ordinal) < 0) {
            defMax = typeList[sp + 2].Def;
        }

        if (string.Compare(defMax, typeList[sp + 3].Def, StringComparison.Ordinal) < 0) {
            defMax = typeList[sp + 3].Def;
        }

        if (string.Compare(defMax, typeList[sp + 4].Def, StringComparison.Ordinal) < 0) {
            defMax = typeList[sp + 4].Def;
        }

        return defMax;
    }

    /// <summary>
    /// GetLastLongi
    /// @最終ロンジを取得
    /// </summary>
    /// <param name="data"></param>
    /// <returns>最終ロンジ</returns>
    private int GetLastLongi(WorkData data) {
        var last = 0;
        if (data.Lh1 > 0) {
            last = 1;
        }

        if (data.Lh2 > 0) {
            last = 2;
        }

        if (data.Lh3 > 0) {
            last = 3;
        }

        if (data.Lh4 > 0) {
            last = 4;
        }

        if (data.Lh5 > 0) {
            last = 5;
        }

        return last;
    }

    /// <summary>
    /// SetWorkData
    /// @各項目の初期値を設定
    /// </summary>
    /// <param name="dataS"></param>
    /// <param name="data"></param>
    /// <param name="pcs"></param>
    /// <returns></returns>
    private WorkData SetWorkData(WorkData dataS, WorkData data, string pcs) {
        dataS.Sno = data.Sno;
        dataS.Blk = data.Blk;
        dataS.Bzi = data.Bzi;
        dataS.Pcs = pcs;
        dataS.Gr1 = data.Gr1;
        dataS.Gr2 = data.Gr2;
        dataS.Gr3 = data.Gr3;
        dataS.Gr4 = data.Gr4;
        dataS.Gr5 = data.Gr5;
        dataS.L = data.L;
        dataS.B = data.B;
        dataS.Tmax = data.Tmax;

        dataS.T1 = data.T1;
        dataS.T2 = data.T2;
        dataS.T3 = data.T3;
        dataS.T4 = data.T4;
        dataS.T5 = data.T5;

        dataS.It1 = data.It1;
        dataS.It2 = data.It2;
        dataS.It3 = data.It3;
        dataS.It4 = data.It4;

        dataS.Lk1 = data.Lk1;
        dataS.Lk2 = data.Lk2;
        dataS.Lk3 = data.Lk3;
        dataS.Lk4 = data.Lk4;
        dataS.Lk5 = data.Lk5;

        dataS.Sp1 = data.Sp1;
        dataS.Sp2 = data.Sp2;
        dataS.Sp3 = data.Sp3;
        dataS.Sp4 = data.Sp4;
        dataS.Sp5 = data.Sp5;

        dataS.Lh1 = data.Lh1;
        dataS.Lh2 = data.Lh2;
        dataS.Lh3 = data.Lh3;
        dataS.Lh4 = data.Lh4;
        dataS.Lh5 = data.Lh5;

        dataS.Lt1 = data.Lt1;
        dataS.Lt2 = data.Lt2;
        dataS.Lt3 = data.Lt3;
        dataS.Lt4 = data.Lt4;
        dataS.Lt5 = data.Lt5;

        dataS.Ll1 = data.Ll1;
        dataS.Ll2 = data.Ll2;
        dataS.Ll3 = data.Ll3;
        dataS.Ll4 = data.Ll4;
        dataS.Ll5 = data.Ll5;

        dataS.Wl1 = data.Wl1;
        dataS.Wl2 = data.Wl2;
        dataS.Wl3 = data.Wl3;
        dataS.Wl4 = data.Wl4;
        dataS.Wl5 = data.Wl5;

        return dataS;
    }

    /// <summary>
    /// SetWorkData
    /// @反転用WKのセット
    /// </summary>
    /// <param name="dataS"></param>
    /// <param name="data"></param>
    /// <param name="pos"></param>
    /// <returns></returns>
    private WorkData SetWorkData(WorkData dataS, WorkData data, List<Position> pos) {
        dataS.Lk1 = pos[0].B_Lk;
        dataS.Lk2 = pos[1].B_Lk;
        dataS.Lk3 = pos[2].B_Lk;
        dataS.Lk4 = pos[3].B_Lk;
        dataS.Lk5 = pos[4].B_Lk;

        dataS.Sp1 = pos[0].B_Sp + 0.04m;
        dataS.Sp2 = pos[1].B_Sp + 0.04m;
        dataS.Sp3 = pos[2].B_Sp + 0.04m;
        dataS.Sp4 = pos[3].B_Sp + 0.04m;
        dataS.Sp5 = pos[4].B_Sp + 0.04m;

        dataS.Lh1 = pos[0].B_Lh + 0.04m;
        dataS.Lh2 = pos[1].B_Lh + 0.04m;
        dataS.Lh3 = pos[2].B_Lh + 0.04m;
        dataS.Lh4 = pos[3].B_Lh + 0.04m;
        dataS.Lh5 = pos[4].B_Lh + 0.04m;

        dataS.Lt1 = pos[0].B_Lt + 0.04m;
        dataS.Lt2 = pos[1].B_Lt + 0.04m;
        dataS.Lt3 = pos[2].B_Lt + 0.04m;
        dataS.Lt4 = pos[3].B_Lt + 0.04m;
        dataS.Lt5 = pos[4].B_Lt + 0.04m;

        dataS.Ll1 = pos[0].B_Ll + 0.04m;
        dataS.Ll2 = pos[1].B_Ll + 0.04m;
        dataS.Ll3 = pos[2].B_Ll + 0.04m;
        dataS.Ll4 = pos[3].B_Ll + 0.04m;
        dataS.Ll5 = pos[4].B_Ll + 0.04m;

        dataS.Wl1 = (short)(pos[0].B_Wl + 0.04m);
        dataS.Wl2 = (short)(pos[1].B_Wl + 0.04m);
        dataS.Wl3 = (short)(pos[2].B_Wl + 0.04m);
        dataS.Wl4 = (short)(pos[3].B_Wl + 0.04m);
        dataS.Wl5 = (short)(pos[4].B_Wl + 0.04m);
        dataS.Is1 = data.Is1;
        dataS.Stp1 = data.Stp1;
        dataS.Stp2 = data.Stp2;
        dataS.Stp3 = data.Stp3;
        dataS.Stp4 = data.Stp4;
        dataS.Stp5 = data.Stp5;
        dataS.Org = 0;
        dataS.YoteibiKari = data.YoteibiKari;
        dataS.YoteibiHon = data.YoteibiHon;
        dataS.YoteibiKyosei = data.YoteibiKyosei;
        dataS.JissibiKari = data.JissibiKari;
        dataS.JissibiHon = data.JissibiHon;
        dataS.JissibiKyosei = data.JissibiKyosei;
        dataS.StatusKari = data.StatusKari;
        dataS.StatusHon = data.StatusHon;
        dataS.StatusKyosei = data.StatusKyosei;
        dataS.ChgFlg = data.ChgFlg;
        dataS.CreSFlg = 0; //Sを作成(西)
        dataS.CrePFlg = 1; //Pを作成しない

        return dataS;
    }

    /// <summary>
    /// GetPositions
    /// @反転用WKへの編集(反転前)
    /// </summary>
    /// <param name="data"></param>
    /// <returns></returns>
    private List<Position> GetPositions(WorkData data) {
        var front = data.Sp1;
        Position.Init();
        Position.Add(front, data.Lk1, data.Sp1, data.Lh1, data.Lt1, data.Ll1, data.Wl1);
        front = front + data.Sp2 + 0.04m;
        Position.Add(front, data.Lk2, data.Sp2, data.Lh2, data.Lt2, data.Ll2, data.Wl2);
        front = front + data.Sp3 + 0.04m;
        Position.Add(front, data.Lk3, data.Sp3, data.Lh3, data.Lt3, data.Ll3, data.Wl3);
        front = front + data.Sp4 + 0.04m;
        Position.Add(front, data.Lk4, data.Sp4, data.Lh4, data.Lt4, data.Ll4, data.Wl4);
        front = front + data.Sp5 + 0.04m;
        Position.Add(front, data.Lk5, data.Sp5, data.Lh5, data.Lt5, data.Ll5, data.Wl5);

        return Position.List;
    }

    /// <summary>
    /// SetPositions
    /// @反転用WKへの編集(反転後)
    /// </summary>
    /// <param name="pos"></param>
    /// <param name="width"></param>
    /// <returns></returns>
    private List<Position> SetPositions(List<Position> pos, decimal width) {
        var ix = 4;
        for (var i = 0; i < 5; i++) {
            pos[i].Back = width - pos[ix].Front + pos[ix].F_Lt;
            pos[i].B_Lk = pos[ix].F_Lk;
            pos[i].B_Lh = pos[ix].F_Lh;
            pos[i].B_Lt = pos[ix].F_Lt;
            pos[i].B_Ll = pos[ix].F_Ll;
            pos[i].B_Wl = pos[ix].F_Wl;
            ix--;
        }

        pos[0].B_Sp = pos[0].Back;
        pos[1].B_Sp = pos[1].Back - pos[0].Back;
        pos[2].B_Sp = pos[2].Back - pos[1].Back;
        pos[3].B_Sp = pos[3].Back - pos[2].Back;
        pos[4].B_Sp = pos[4].Back - pos[3].Back;

        return pos;
    }

    /// <summary>
    /// SetPositions
    /// @反転用WKへの編集(板幅外の是正)
    /// </summary>
    /// <param name="pos"></param>
    /// <param name="typeList"></param>
    /// <param name="lk"></param>
    /// <param name="wl"></param>
    /// <param name="sp"></param>
    /// <returns></returns>
    private List<Position> SetPositions(List<Position> pos, List<WorkDataType> typeList, int lk, int wl, int sp) {
        var ix = 0;
        while (pos[0].Back <= 0
               && pos[0].B_Lt <= 0
               && ix != 1) {
            if (pos[4].Back + decimal.Parse(typeList[sp + 4].Def) > 4750) {
                ix = 1;
            }
            else {
                for (var i = 0; i < 4; i++) {
                    pos[i].Back = pos[i + 1].Back;
                    pos[i].B_Lk = pos[i + 1].B_Lk;
                    pos[i].B_Sp = i == 0 ? pos[i].Back : pos[i + 1].B_Sp;
                    pos[i].B_Lh = pos[i + 1].B_Lh;
                    pos[i].B_Lt = pos[i + 1].B_Lt;
                    pos[i].B_Ll = pos[i + 1].B_Ll;
                    pos[i].B_Wl = pos[i + 1].B_Wl;
                }

                pos[4].Back = pos[3].Back + decimal.Parse(typeList[sp + 4].Def);
                pos[4].B_Lk = short.Parse(typeList[lk + 4].Def);
                pos[4].B_Sp = decimal.Parse(typeList[sp + 4].Def);
                pos[4].B_Lh = 0;
                pos[4].B_Lt = 0;
                pos[4].B_Ll = 0;
                pos[4].B_Wl = decimal.Parse(typeList[wl + 4].Def);
                ;
            }
        }

        return pos;
    }

    /// <summary>
    /// SetPositions
    /// @反転用WKへの編集(1番ﾛﾝｼﾞがﾀﾞﾐｰの場合の是正)
    /// </summary>
    /// <param name="pos"></param>
    /// <param name="typeList"></param>
    /// <param name="width"></param>
    /// <param name="lk"></param>
    /// <param name="wl"></param>
    /// <param name="sp"></param>
    /// <returns></returns>
    private List<Position> SetPositions(List<Position> pos, List<WorkDataType> typeList, decimal width, int lk, int wl,
        int sp) {
        if (pos[0].B_Lt == 0
            && pos[4].Back > width
            && pos[4].Back + decimal.Parse(typeList[sp + 4].Def) <= 4750) {
            for (var i = 0; i < 4; i++) {
                pos[i].Back = pos[i + 1].Back;
                pos[i].B_Lk = pos[i + 1].B_Lk;
                pos[i].B_Sp = i == 0 ? pos[i].Back : pos[i + 1].B_Sp;
                pos[i].B_Lh = pos[i + 1].B_Lh;
                pos[i].B_Lt = pos[i + 1].B_Lt;
                pos[i].B_Ll = pos[i + 1].B_Ll;
                pos[i].B_Wl = pos[i + 1].B_Wl;
            }

            pos[4].Back = pos[3].Back + decimal.Parse(typeList[sp + 4].Def);
            pos[4].B_Lk = short.Parse(typeList[lk + 4].Def);
            pos[4].B_Sp = decimal.Parse(typeList[sp + 4].Def);
            pos[4].B_Lh = 0;
            pos[4].B_Lt = 0;
            pos[4].B_Ll = 0;
            pos[4].B_Wl = decimal.Parse(typeList[wl + 4].Def);
            ;
        }

        return pos;
    }
}