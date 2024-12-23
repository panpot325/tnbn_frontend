using System.Text;

namespace WorkDataStudio.Model;

/// <summary>
/// @WorkData.Sql.Common
/// </summary>
public partial class WorkData {
    /// <summary>
    /// Columns
    /// </summary>
    /// <returns>string</returns>
    // ReSharper disable once MemberCanBeMadeStatic.Local
    private string SqlColumns() {
        var sb = new StringBuilder();
        sb.Append(" gr1, gr2, gr3, gr4, gr5,");
        sb.Append(" lk1, lk2, lk3, lk4, lk5,");
        sb.Append(" l, b, tmax,");
        sb.Append(" t1, t2, t3, t4, t5,");
        sb.Append(" it1, it2, it3, it4,");
        sb.Append(" sp1, sp2, sp3, sp4, sp5,");
        sb.Append(" lh1, lh2, lh3, lh4, lh5,");
        sb.Append(" lt1, lt2, lt3, lt4, lt5,");
        sb.Append(" ll1, ll2, ll3, ll4, ll5,");
        sb.Append(" wl1, wl2, wl3, wl4, wl5,");
        sb.Append(" is1,");
        sb.Append(" stp1, stp2, stp3, stp4, stp5,");
        sb.Append(" org,");
        sb.Append(" yoteibi_kari, yoteibi_hon, yoteibi_kyosei,");
        sb.Append(" jissibi_kari, jissibi_hon, jissibi_kyosei,");
        sb.Append(" status_kari, status_hon, status_kyosei,");
        sb.Append(" jissijkn_kari, jissijkn_hon, jissijkn_kyosei,");
        sb.Append(" create_date, create_syain,");
        sb.Append(" update_date, update_syain,");
        sb.Append(" cres_flg, crep_flg");

        return sb.ToString();
    }

    /// <summary>
    /// Values
    /// </summary>
    /// <returns>string</returns>
    private string SqlValues() {
        var sb = new StringBuilder();
        sb.Append($" {Gr1}, {Gr2}, {Gr3}, {Gr4}, {Gr5},");
        sb.Append($" {Lk1}, {Lk2}, {Lk3}, {Lk4}, {Lk5},");
        sb.Append($" {L}, {B}, {Tmax},");
        sb.Append($" {T1}, {T2}, {T3}, {T4}, {T5},");
        sb.Append($" {It1}, {It2}, {It3}, {It4},");
        sb.Append($" {Sp1}, {Sp2}, {Sp3}, {Sp4}, {Sp5},");
        sb.Append($" {Lh1}, {Lh2}, {Lh3}, {Lh4}, {Lh5},");
        sb.Append($" {Lt1}, {Lt2}, {Lt3}, {Lt4}, {Lt5},");
        sb.Append($" {Ll1}, {Ll2}, {Ll3}, {Ll4}, {Ll5},");
        sb.Append($" {Wl1}, {Wl2}, {Wl3}, {Wl4}, {Wl5},");
        sb.Append($" {Is1},");
        sb.Append($" {Stp1}, {Stp2}, {Stp3}, {Stp4}, {Stp5},");
        sb.Append($" {Org},");
        sb.Append($" {YoteibiKari}, {YoteibiHon}, {YoteibiKyosei},");
        sb.Append($" {JissibiKari}, {JissibiHon}, {JissibiKyosei},");
        sb.Append($" {_statusKari}, {_statusHon}, {_statusKyosei},");
        sb.Append($" {JissijknKari}, {JissijknHon}, {JissijknKyosei},");
        sb.Append($" {CreateDate}, {CreateSyain},");
        sb.Append($" {UpdateDate}, {UpdateSyain},");
        sb.Append($" {_creSFlg}, {_crePFlg}");

        return sb.ToString();
    }

    /// <summary>
    /// Where
    /// </summary>
    /// <returns>string</returns>
    private string SqlWhere() {
        var sb = new StringBuilder();
        sb.Append($" WHERE sno = '{Sno}'");
        sb.Append($" AND blk = '{Blk}'");
        sb.Append($" AND bzi = '{Bzi}'");
        sb.Append($" AND pcs = '{Pcs}'");

        return sb.ToString();
    }
}