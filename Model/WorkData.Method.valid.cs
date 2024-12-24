using WorkDataStudio.share;

namespace WorkDataStudio.Model;

/// <summary>
/// @WorkData.Method.Valid
/// </summary>
public partial class WorkData {
    /// <summary>
    /// Duplicate
    /// @キー重複チェック
    /// </summary>
    /// <returns></returns>
    public int Duplicate() {
        var existsCount = Find();
        // ReSharper disable once InvertIf
        if (existsCount > 0) {
            ErrorValidation.Grid1 = WorkDataType.CROSS;
            ErrorValidation.Grid3[0] = WorkDataType.CROSS;
            ErrorValidation.Grid3[1] = WorkDataType.CROSS;
            ErrorValidation.Grid3[2] = WorkDataType.CROSS;
            ErrorValidation.Grid3[3] = WorkDataType.CROSS;
        }

        return existsCount;
    }

    /// <summary>
    /// Valid
    /// @DB更新前各項目チェック
    /// </summary>
    /// <returns></returns>
    public int Valid() {
        var errCnt = 0;

        Check(ref errCnt, Tsno, string.IsNullOrEmpty(Sno)); //船番(半角ｽﾍﾟｰｽ6桁はｴﾗｰ)0
        Check(ref errCnt, Tblk, string.IsNullOrEmpty(Blk)); //ブロック名(半角ｽﾍﾟｰｽ8桁はｴﾗｰ)1
        Check(ref errCnt, Tbzi, string.IsNullOrEmpty(Bzi)); //部材名（単板名）(半角ｽﾍﾟｰｽ16桁はｴﾗｰ)2
        Check(ref errCnt, Tpcs, string.IsNullOrEmpty(Pcs)); //舷（PCS）(半角ｽﾍﾟｰｽ1桁はｴﾗｰ)3

        Check(ref errCnt, Tgr1, Gr1); //GR1 規格（材質）4
        Check(ref errCnt, Tgr2, Gr2); //GR2 規格（材質）5
        Check(ref errCnt, Tgr3, Gr3); //GR3 規格（材質）6
        Check(ref errCnt, Tgr4, Gr4); //GR4 規格（材質）7
        Check(ref errCnt, Tgr5, Gr5); //GR5 規格（材質）8

        Check(ref errCnt, Tlk1, Lk1); //LK1 ロンジ形状（第１ロンジ）9
        Check(ref errCnt, Tlk2, Lk2); //LK2 ロンジ形状（第２ロンジ）10
        Check(ref errCnt, Tlk3, Lk3); //LK3 ロンジ形状（第３ロンジ）11
        Check(ref errCnt, Tlk4, Lk4); //LK4 ロンジ形状（第４ロンジ）12
        Check(ref errCnt, Tlk5, Lk5); //LK5 ロンジ形状（第５ロンジ）13

        Check(ref errCnt, Tl, L); //L 皮板全長 14

        if (B == 0) {
            //B 皮板全幅 ********
            Check(ref errCnt, Tb, Tb.ZeroEntry == WorkDataType.ZERO_ENTRY_NG);
        }
        else {
            if (Mode.Value == Mode.NEW_2) {
                Check(ref errCnt, Tb, B > 2400);
            }
            else {
                Check(ref errCnt, Tb,
                    B < Tb.DecHaniMin || B > Tb.DecHaniMax);
            }
        }

        Check(ref errCnt, Ttmax, Tmax); //TMAX 皮板最大板厚 15

        Check(ref errCnt, Tt1, T1); //T1 皮板板厚１
        Check(ref errCnt, Tt2, T2); //T2 皮板板厚２
        Check(ref errCnt, Tt3, T3); //T3 皮板板厚３
        Check(ref errCnt, Tt4, T4); //T4 皮板板厚４
        Check(ref errCnt, Tt5, T5); //T5 皮板板厚５

        Check(ref errCnt, Tit1, It1); //IT1 板継位置１
        Check(ref errCnt, Tit2, It2); //IT2 板継位置２
        Check(ref errCnt, Tit3, It3); //IT3 板継位置３
        Check(ref errCnt, Tit4, It4); //IT4 板継位置４

        if (Org == 0) {
            Check(ref errCnt, Tsp1, Sp1); //第１ロンジ距離（板耳〜第１ロンジ）
        }
        else {
            //反基準の時：SP1チェック（minより小を可とする）
            Check(ref errCnt, Tsp1, Sp1 > Tsp1.DecHaniMax);
        }

        Check(ref errCnt, Tsp2, Sp2); //SP2 ロンジスペース（第１〜第２）
        Check(ref errCnt, Tsp3, Sp3); //SP3 ロンジスペース（第２〜第３）
        Check(ref errCnt, Tsp4, Sp4); //SP4 ロンジスペース（第３〜第４）
        Check(ref errCnt, Tsp5, Sp5); //SP5 ロンジスペース（第４〜第５）

        Check(ref errCnt, Tlh1, Lh1); //LH1 ロンジ高さ（第１ロンジ）
        Check(ref errCnt, Tlh2, Lh2); //LH2 ロンジ高さ（第２ロンジ）
        Check(ref errCnt, Tlh3, Lh3); //LH3 ロンジ高さ（第３ロンジ）
        Check(ref errCnt, Tlh4, Lh4); //LH4 ロンジ高さ（第４ロンジ）
        Check(ref errCnt, Tlh5, Lh5); //LH5 ロンジ高さ（第５ロンジ）

        Check(ref errCnt, Tlt1, Lt1); //LT1 ロンジウェブ板厚（第１ロンジ）
        Check(ref errCnt, Tlt2, Lt2); //LT2 ロンジウェブ板厚（第２ロンジ）
        Check(ref errCnt, Tlt3, Lt3); //LT3 ロンジウェブ板厚（第３ロンジ）
        Check(ref errCnt, Tlt4, Lt4); //LT4 ロンジウェブ板厚（第４ロンジ）
        Check(ref errCnt, Tlt5, Lt5); //LT5 ロンジウェブ板厚（第５ロンジ）

        Check(ref errCnt, Tll1, Ll1); //LL1 ロンジ全長（第１ロンジ）
        Check(ref errCnt, Tll2, Ll2); //LL2 ロンジ全長（第２ロンジ）
        Check(ref errCnt, Tll3, Ll3); //LL3 ロンジ全長（第３ロンジ）
        Check(ref errCnt, Tll4, Ll4); //LL4 ロンジ全長（第４ロンジ）
        Check(ref errCnt, Tll5, Ll5); //LL5 ロンジ全長（第５ロンジ）

        Check(ref errCnt, Twl1, Wl1); //WL1 溶接脚長（第１ロンジ）
        Check(ref errCnt, Twl2, Wl2); //WL1 溶接脚長（第１ロンジ）
        Check(ref errCnt, Twl3, Wl3); //WL3 溶接脚長（第３ロンジ）
        Check(ref errCnt, Twl4, Wl4); //WL4 溶接脚長（第４ロンジ）
        Check(ref errCnt, Twl5, Wl5); //WL5 溶接脚長（第５ロンジ）

        Check(ref errCnt, Tis1, Is1); //IS1 ロンジシフト量

        Check(ref errCnt, Tstp1, Stp1); //STP1 一時停止位置−１
        Check(ref errCnt, Tstp2, Stp2); //STP2 一時停止位置−２
        Check(ref errCnt, Tstp3, Stp3); //STP3 一時停止位置−３
        Check(ref errCnt, Tstp4, Stp4); //STP4 一時停止位置−４
        Check(ref errCnt, Tstp5, Stp5); //STP5 一時停止位置−５

        Check(ref errCnt, Torg, Org); //ORG 基準
        Check(ref errCnt, TyoteibiKari, YoteibiKari); //YOTEIBI_KARI 仮付け予定日

        if (errCnt > 0) {
            ErrorValidation.Grid1 = WorkDataType.CROSS;
        }

        return errCnt;
    }

    private void Check(ref int errCnt, WorkDataType type, bool pattern) {
        // ReSharper disable once InvertIf
        if (pattern) {
            ErrorValidation.Grid3[type.Index] = WorkDataType.CROSS;
            errCnt++;
        }
    }

    private void Check(ref int errCnt, WorkDataType type, decimal data) {
        if (data == 0) {
            Check(ref errCnt, type, type.ZeroEntry == WorkDataType.ZERO_ENTRY_NG);
        }
        else {
            Check(ref errCnt, type, data < type.DecHaniMin || data > type.DecHaniMax);
        }
    }
}