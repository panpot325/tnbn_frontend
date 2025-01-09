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
    /// <param name="sp"></param>
    /// <param name="data"></param>
    /// <param name="pcs"></param>
    /// <returns></returns>
    private WorkData SetWorkData(WorkData sp, WorkData data, string pcs) {
        sp.Sno = data.Sno;
        sp.Blk = data.Blk;
        sp.Bzi = data.Bzi;
        sp.Pcs = pcs;
        sp.Gr1 = data.Gr1;
        sp.Gr2 = data.Gr2;
        sp.Gr3 = data.Gr3;
        sp.Gr4 = data.Gr4;
        sp.Gr5 = data.Gr5;
        sp.L = data.L;
        sp.B = data.B;
        sp.Tmax = data.Tmax;

        sp.T1 = data.T1;
        sp.T2 = data.T2;
        sp.T3 = data.T3;
        sp.T4 = data.T4;
        sp.T5 = data.T5;

        sp.It1 = data.It1;
        sp.It2 = data.It2;
        sp.It3 = data.It3;
        sp.It4 = data.It4;

        sp.Lk1 = data.Lk1;
        sp.Lk2 = data.Lk2;
        sp.Lk3 = data.Lk3;
        sp.Lk4 = data.Lk4;
        sp.Lk5 = data.Lk5;

        sp.Sp1 = data.Sp1;
        sp.Sp2 = data.Sp2;
        sp.Sp3 = data.Sp3;
        sp.Sp4 = data.Sp4;
        sp.Sp5 = data.Sp5;

        sp.Lh1 = data.Lh1;
        sp.Lh2 = data.Lh2;
        sp.Lh3 = data.Lh3;
        sp.Lh4 = data.Lh4;
        sp.Lh5 = data.Lh5;

        sp.Lt1 = data.Lt1;
        sp.Lt2 = data.Lt2;
        sp.Lt3 = data.Lt3;
        sp.Lt4 = data.Lt4;
        sp.Lt5 = data.Lt5;

        sp.Ll1 = data.Ll1;
        sp.Ll2 = data.Ll2;
        sp.Ll3 = data.Ll3;
        sp.Ll4 = data.Ll4;
        sp.Ll5 = data.Ll5;

        sp.Wl1 = data.Wl1;
        sp.Wl2 = data.Wl2;
        sp.Wl3 = data.Wl3;
        sp.Wl4 = data.Wl4;
        sp.Wl5 = data.Wl5;

        return sp;
    }

    /// <summary>
    /// SetWorkData
    /// @反転用WKのセット
    /// </summary>
    /// <param name="sp"></param>
    /// <param name="data"></param>
    /// <param name="pos"></param>
    /// <returns></returns>
    private WorkData SetWorkData(WorkData sp, WorkData data, List<Position> pos) {
        sp.Lk1 = pos[0].B_Lk;
        sp.Lk2 = pos[1].B_Lk;
        sp.Lk3 = pos[2].B_Lk;
        sp.Lk4 = pos[3].B_Lk;
        sp.Lk5 = pos[4].B_Lk;

        sp.Sp1 = pos[0].B_Sp + 0.04m;
        sp.Sp2 = pos[1].B_Sp + 0.04m;
        sp.Sp3 = pos[2].B_Sp + 0.04m;
        sp.Sp4 = pos[3].B_Sp + 0.04m;
        sp.Sp5 = pos[4].B_Sp + 0.04m;

        sp.Lh1 = pos[0].B_Lh + 0.04m;
        sp.Lh2 = pos[1].B_Lh + 0.04m;
        sp.Lh3 = pos[2].B_Lh + 0.04m;
        sp.Lh4 = pos[3].B_Lh + 0.04m;
        sp.Lh5 = pos[4].B_Lh + 0.04m;

        sp.Lt1 = pos[0].B_Lt + 0.04m;
        sp.Lt2 = pos[1].B_Lt + 0.04m;
        sp.Lt3 = pos[2].B_Lt + 0.04m;
        sp.Lt4 = pos[3].B_Lt + 0.04m;
        sp.Lt5 = pos[4].B_Lt + 0.04m;

        sp.Ll1 = pos[0].B_Ll + 0.04m;
        sp.Ll2 = pos[1].B_Ll + 0.04m;
        sp.Ll3 = pos[2].B_Ll + 0.04m;
        sp.Ll4 = pos[3].B_Ll + 0.04m;
        sp.Ll5 = pos[4].B_Ll + 0.04m;

        sp.Wl1 = (short)(pos[0].B_Wl + 0.04m);
        sp.Wl2 = (short)(pos[1].B_Wl + 0.04m);
        sp.Wl3 = (short)(pos[2].B_Wl + 0.04m);
        sp.Wl4 = (short)(pos[3].B_Wl + 0.04m);
        sp.Wl5 = (short)(pos[4].B_Wl + 0.04m);
        sp.Is1 = data.Is1;
        sp.Stp1 = data.Stp1;
        sp.Stp2 = data.Stp2;
        sp.Stp3 = data.Stp3;
        sp.Stp4 = data.Stp4;
        sp.Stp5 = data.Stp5;
        sp.Org = 0;
        sp.YoteibiKari = data.YoteibiKari;
        sp.YoteibiHon = data.YoteibiHon;
        sp.YoteibiKyosei = data.YoteibiKyosei;
        sp.JissibiKari = data.JissibiKari;
        sp.JissibiHon = data.JissibiHon;
        sp.JissibiKyosei = data.JissibiKyosei;
        sp.StatusKari = data.StatusKari;
        sp.StatusHon = data.StatusHon;
        sp.StatusKyosei = data.StatusKyosei;
        sp.ChgFlg = data.ChgFlg;
        sp.CreSFlg = 0; //Sを作成(西)
        sp.CrePFlg = 1; //Pを作成しない

        return sp;
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