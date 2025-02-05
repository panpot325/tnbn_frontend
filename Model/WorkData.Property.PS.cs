using System.Collections.Generic;

// ReSharper disable InconsistentNaming

namespace WorkDataStudio.Model;

/// <summary>
/// @WorkData.Property.PS
/// </summary>
public partial class WorkData {
    public static WorkData CreateBalance(WorkData data) {
        return Create()
            .Set(data)
            .Swap()
            .Head(data)
            .Pack()
            .Shift();
    }

    private WorkData Set(WorkData data) {
        Sno = data.Sno;
        Blk = data.Blk;
        Bzi = data.Bzi;
        Pcs = data.Pcs;
        SetGr(data.GrList);
        SetLk(data.LkList);
        L = data.L;
        B = data.B;
        Tmax = data.Tmax;
        SetT(data.TList);
        It1 = data.It1;
        It2 = data.It2;
        It3 = data.It3;
        It4 = data.It4;
        SetSp(data.SpList);
        SetLh(data.LhList);
        SetLt(data.LtList);
        SetLl(data.LlList);
        SetWl(data.WlList);
        It4 = data.It4;
        //sp.SetStp(data.StpList);

        return this;
    }

    private WorkData Swap() {
        SetLk(Swap(Longi, LkList));
        SetLh(Swap(Longi, LhList));
        SetLt(Swap(Longi, LtList));
        SetLl(Swap(Longi, LlList));
        SetWl(Swap(Longi, WlList));

        return this;
    }

    private WorkData Head(WorkData data) {
        switch (Longi) {
            case 5:
                Head1 = Dwidth - Abs5 - data.Lt5;
                Head2 = Dwidth - Abs4 - data.Lt4;
                Head3 = Dwidth - Abs3 - data.Lt3;
                Head4 = Dwidth - Abs2 - data.Lt2;
                Head5 = Dwidth - Abs1 - data.Lt1;
                Pitch1 = Head1;
                Pitch2 = Head2 - Head1;
                Pitch3 = Head3 - Head2;
                Pitch4 = Head4 - Head3;
                Pitch5 = Head5 - Head4;
                break;
            case 4:
                Head1 = Dwidth - Abs4 - data.Lt4;
                Head2 = Dwidth - Abs3 - data.Lt3;
                Head3 = Dwidth - Abs2 - data.Lt2;
                Head4 = Dwidth - Abs1 - data.Lt1;
                Head5 = Head4 + data.Sp5;
                Pitch1 = Head1;
                Pitch2 = Head2 - Head1;
                Pitch3 = Head3 - Head2;
                Pitch4 = Head4 - Head3;
                Pitch5 = C_HEAD_PITCH;
                break;
            case 3:
                Head1 = Dwidth - Abs3 - data.Lt3;
                Head2 = Dwidth - Abs2 - data.Lt2;
                Head3 = Dwidth - Abs1 - data.Lt1;
                Head4 = Head3 + data.Sp4;
                Head5 = Head4 + data.Sp5;
                Pitch1 = Head1;
                Pitch2 = Head2 - Head1;
                Pitch3 = Head3 - Head2;
                Pitch4 = C_HEAD_PITCH;
                Pitch5 = C_HEAD_PITCH;
                break;
            case 2:
                Head1 = Dwidth - Abs2 - data.Lt2;
                Head2 = Dwidth - Abs1 - data.Lt1;
                Head3 = Head2 + data.Sp3;
                Head4 = Head3 + data.Sp4;
                Head5 = Head4 + data.Sp5;
                Pitch1 = Head1;
                Pitch2 = Head2 - Head1;
                Pitch3 = C_HEAD_PITCH;
                ;
                Pitch4 = C_HEAD_PITCH;
                Pitch5 = C_HEAD_PITCH;
                break;
            case 1:
                Head1 = Dwidth - Abs1 - data.Lt1;
                Head2 = Head1 + data.Sp2;
                Head3 = Head2 + data.Sp3;
                Head4 = Head3 + data.Sp4;
                Head5 = Head4 + data.Sp5;
                Pitch1 = Head1;
                Pitch2 = C_HEAD_PITCH;
                Pitch3 = C_HEAD_PITCH;
                Pitch4 = C_HEAD_PITCH;
                Pitch5 = C_HEAD_PITCH;
                break;
        }

        return this;
    }

    //ヘッド５が東限を超えたら空きヘッドを詰める[R332]=H5東限位置
    private WorkData Pack() {
        while (Head1 >= 1000 && Lh5 == 0
               || Head5 > C_HEAD_LIMIT) {
            (Lk5, Lk4, Lk3, Lk2, Lk1) = (Lk4, Lk3, Lk2, Lk1, 0);
            (Lh5, Lh4, Lh3, Lh2, Lh1) = (Lh4, Lh3, Lh2, Lh1, 0);
            (Lt5, Lt4, Lt3, Lt2, Lt1) = (Lt4, Lt3, Lt2, Lt1, 0);
            (Ll5, Ll4, Ll3, Ll2, Ll1) = (Ll4, Ll3, Ll2, Ll1, 0);
            (Wl5, Wl4, Wl3, Wl2, Wl1) = (Wl4, Wl3, Wl2, Wl1, 0);

            (Pitch5, Pitch4, Pitch3, Pitch2, Pitch1) =
                (Pitch4, Pitch3, Pitch2,
                    Head1 - Pitch1 - C_HEAD_PITCH,
                    Pitch1 - C_HEAD_PITCH);

            Head1 = Pitch1;
            Head5 = Pitch1 + Pitch2 + Pitch3 + Pitch4 + Pitch5;
        }

        Sp1 = Pitch1;
        Sp2 = Pitch2;
        Sp3 = Pitch3;
        Sp4 = Pitch4;
        Sp5 = Pitch5;

        return this;
    }

    private WorkData Shift() {
        if (Lh1 == 0 && Sp1 > 7000) {
            var sp = Sp1 - 4000;
            Sp1 = Sp1 - sp;
            Sp2 = Sp2 + sp;
        }

        if (Lh2 == 0 && Sp2 > 7000) {
            var sp = Sp2 - 7000;
            Sp2 = Sp2 - sp;
            Sp3 = Sp3 + sp;
        }

        if (Lh3 == 0 && Sp3 > 7000) {
            var sp = Sp3 - 7000;
            Sp3 = Sp3 - sp;
            Sp4 = Sp4 + sp;
        }

        if (Lh4 == 0 && Sp4 > 7000) {
            var sp = Sp4 - 7000;
            Sp4 = Sp4 - sp;
            Sp5 = Sp5 + sp;
        }

        // ReSharper disable once InvertIf
        if (Lh5 == 0 && Sp5 > 7000) {
            var sp = Sp5 - 7000;
            Sp5 = Sp5 - sp;
        }

        Org = 0;

        return this;
    }

    // Gr1 - gr5
    private List<int> GrList => [Gr1, Gr2, Gr3, Gr4, Gr5];

    private void SetGr(List<int> list) {
        Gr1 = list[0];
        Gr2 = list[1];
        Gr3 = list[2];
        Gr4 = list[3];
        Gr5 = list[4];
    }

    // Lk1 - Lk5
    private List<int> LkList => [Lk1, Lk2, Lk3, Lk4, Lk5];

    private void SetLk(List<int> list) {
        Lk1 = list[0];
        Lk2 = list[1];
        Lk3 = list[2];
        Lk4 = list[3];
        Lk5 = list[4];
    }

    // T1 - T5
    private List<decimal> TList => [T1, T2, T3, T4, T5];

    private void SetT(List<decimal> list) {
        T1 = list[0];
        T2 = list[1];
        T3 = list[2];
        T4 = list[3];
        T5 = list[4];
    }

    // Sp1 - Sp5
    private List<decimal> SpList => [Sp1, Sp2, Sp3, Sp4, Sp5];

    private void SetSp(List<decimal> list) {
        Sp1 = list[0];
        Sp2 = list[1];
        Sp3 = list[2];
        Sp4 = list[3];
        Sp5 = list[4];
    }

    // Lh1 - Lh5
    private List<decimal> LhList => [Lh1, Lh2, Lh3, Lh4, Lh5];

    private void SetLh(List<decimal> list) {
        Lh1 = list[0];
        Lh2 = list[1];
        Lh3 = list[2];
        Lh4 = list[3];
        Lh5 = list[4];
    }

    // Lt1 - Lt5
    private List<decimal> LtList => [Lt1, Lt2, Lt3, Lt4, Lt5];

    private void SetLt(List<decimal> list) {
        Lt1 = list[0];
        Lt2 = list[1];
        Lt3 = list[2];
        Lt4 = list[3];
        Lt5 = list[4];
    }

    // Ll1 - Ll5
    private List<decimal> LlList => [Ll1, Ll2, Ll3, Ll4, Ll5];

    private void SetLl(List<decimal> list) {
        Ll1 = list[0];
        Ll2 = list[1];
        Ll3 = list[2];
        Ll4 = list[3];
        Ll5 = list[4];
    }

    // Wl1 - Wl5
    private List<int> WlList => [Wl1, Wl2, Wl3, Wl4, Wl5];

    private void SetWl(List<int> list) {
        Wl1 = list[0];
        Wl2 = list[1];
        Wl3 = list[2];
        Wl4 = list[3];
        Wl5 = list[4];
    }

    // Stp1 - Stp5
    private List<decimal> StpList => [Stp1, Stp2, Stp3, Stp4, Stp5];

    private void SetStp(List<decimal> list) {
        Stp1 = list[0];
        Stp2 = list[1];
        Stp3 = list[2];
        Stp4 = list[3];
        Stp5 = list[4];
    }

   /// <summary>
    /// Swap
    /// </summary>
    /// <param name="i"></param>
    /// <param name="list"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    private static List<T> Swap<T>(int i, List<T> list) {
        (list[0], list[1], list[2], list[3], list[4]) = i switch {
            5 => (list[4], list[3], list[2], list[1], list[0]),
            4 => (list[3], list[2], list[1], list[0], list[4]),
            3 => (list[2], list[1], list[0], list[3], list[4]),
            2 => (list[1], list[0], list[2], list[3], list[4]),
            _ => (list[0], list[1], list[2], list[3], list[4])
        };

        return list;
    }

    //Abs1 - Abs5 
    private decimal Abs1 => Sp1;
    private decimal Abs2 => Abs1 + Sp2;
    private decimal Abs3 => Abs2 + Sp3;
    private decimal Abs4 => Abs3 + Sp4;
    private decimal Abs5 => Abs4 + Sp5;

    //ヘッド絶対値
    private decimal Head1 { get; set; } = 0;
    private decimal Head2 { get; set; } = 0;
    private decimal Head3 { get; set; } = 0;
    private decimal Head4 { get; set; } = 0;
    private decimal Head5 { get; set; } = 0;

    //ヘッド絶対値
    private decimal Pitch1 { get; set; } = 0;
    private decimal Pitch2 { get; set; } = 0;
    private decimal Pitch3 { get; set; } = 0;
    private decimal Pitch4 { get; set; } = 0;
    private decimal Pitch5 { get; set; } = 0;

    //Longi
    private int Longi {
        get {
            if (Lh5 > 0) return 5;
            if (Lh4 > 0) return 4;
            if (Lh3 > 0) return 3;
            if (Lh2 > 0) return 2;
            return Lh1 > 0 ? 1 : 0;
        }
    }

    private decimal Dwidth => Org == 1 ? B : C_WIDTH;
}