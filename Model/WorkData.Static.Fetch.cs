using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using WorkDataStudio.share;

namespace WorkDataStudio.Model;

/// <summary>
/// @WorkData.Static.Fetch
/// </summary>
public partial class WorkData {
    /// <summary>
    /// Fetch
    /// </summary>
    /// <returns></returns>
    private static List<WorkData> Fetch(string where = "") {
        var sb = new StringBuilder();
        sb.Append("SELECT * FROM tnbn_kakowk_data");
        if (string.IsNullOrEmpty(where)) {
            sb.Append(" WHERE 1 = 1");
            sb.Append(WorkDataFilter.HasSno ? $" AND sno = '{WorkDataFilter.Sno}'" : "");
            sb.Append(WorkDataFilter.HasBlk ? $" AND blk = '{WorkDataFilter.Blk}'" : "");
            sb.Append(WorkDataFilter.HasBzi ? $" AND bzi = '{WorkDataFilter.Bzi}'" : "");
            sb.Append(WorkDataFilter.HasPcs ? $" AND pcs = '{WorkDataFilter.Pcs}'" : "");
            sb.Append(WorkDataFilter.HasYotei ? $" AND yoteibi_kari = {WorkDataFilter.Yotei}" : "");
        }
        else {
            sb.Append($" WHERE {where}");
        }

        sb.Append(" ORDER BY sno, blk, bzi, pcs, yoteibi_kari");

        return (from DataRow row in PgOpen.PgSelect(sb.ToString()).Rows
            select new WorkData {
                Fsno = NewField(0, (string)row["sno"]),
                Fblk = NewField(1, (string)row["blk"]),
                Fbzi = NewField(2, (string)row["bzi"]),
                Fpcs = NewField(3, (string)row["pcs"]),
                Fgr1 = NewField(4, (short)row["gr1"]),
                Fgr2 = NewField(5, (short)row["gr2"]),
                Fgr3 = NewField(6, (short)row["gr3"]),
                Fgr4 = NewField(7, (short)row["gr4"]),
                Fgr5 = NewField(8, (short)row["gr5"]),
                Flk1 = NewField(9, (short)row["lk1"]),
                Flk2 = NewField(10, (short)row["lk2"]),
                Flk3 = NewField(11, (short)row["lk3"]),
                Flk4 = NewField(12, (short)row["lk4"]),
                Flk5 = NewField(13, (short)row["lk5"]),
                Fl = NewField(14, (decimal)row["l"]),
                Fb = NewField(15, (decimal)row["b"]),
                Ftmax = NewField(16, (decimal)row["tmax"]),
                Ft1 = NewField(17, (decimal)row["t1"]),
                Ft2 = NewField(18, (decimal)row["t2"]),
                Ft3 = NewField(19, (decimal)row["t3"]),
                Ft4 = NewField(20, (decimal)row["t4"]),
                Ft5 = NewField(21, (decimal)row["t5"]),
                Fit1 = NewField(22, (decimal)row["it1"]),
                Fit2 = NewField(23, (decimal)row["it2"]),
                Fit3 = NewField(24, (decimal)row["it3"]),
                Fit4 = NewField(25, (decimal)row["it4"]),
                Fsp1 = NewField(26, (decimal)row["sp1"]),
                Fsp2 = NewField(27, (decimal)row["sp2"]),
                Fsp3 = NewField(28, (decimal)row["sp3"]),
                Fsp4 = NewField(29, (decimal)row["sp4"]),
                Fsp5 = NewField(30, (decimal)row["sp5"]),
                Flh1 = NewField(31, (decimal)row["lh1"]),
                Flh2 = NewField(32, (decimal)row["lh2"]),
                Flh3 = NewField(33, (decimal)row["lh3"]),
                Flh4 = NewField(34, (decimal)row["lh4"]),
                Flh5 = NewField(35, (decimal)row["lh5"]),
                Flt1 = NewField(36, (decimal)row["lt1"]),
                Flt2 = NewField(37, (decimal)row["lt2"]),
                Flt3 = NewField(38, (decimal)row["lt3"]),
                Flt4 = NewField(39, (decimal)row["lt4"]),
                Flt5 = NewField(40, (decimal)row["lt5"]),
                Fll1 = NewField(41, (decimal)row["ll1"]),
                Fll2 = NewField(42, (decimal)row["ll2"]),
                Fll3 = NewField(43, (decimal)row["ll3"]),
                Fll4 = NewField(44, (decimal)row["ll4"]),
                Fll5 = NewField(45, (decimal)row["ll5"]),
                Fwl1 = NewField(46, (short)row["wl1"]),
                Fwl2 = NewField(47, (short)row["wl2"]),
                Fwl3 = NewField(48, (short)row["wl3"]),
                Fwl4 = NewField(49, (short)row["wl4"]),
                Fwl5 = NewField(50, (short)row["wl5"]),
                Fis1 = NewField(51, (decimal)row["is1"]),
                Fstp1 = NewField(52, (decimal)row["stp1"]),
                Fstp2 = NewField(53, (decimal)row["stp2"]),
                Fstp3 = NewField(54, (decimal)row["stp3"]),
                Fstp4 = NewField(55, (decimal)row["stp4"]),
                Fstp5 = NewField(56, (decimal)row["stp5"]),
                Forg = NewField(57, (short)row["org"]),
                FyoteibiKari = NewField(58, (int)row["yoteibi_kari"]),

                YoteibiHon = (int)row["yoteibi_hon"],
                YoteibiKyosei = (int)row["yoteibi_kyosei"],
                JissibiKari = (int)row["Jissibi_Kari"],
                JissibiHon = (int)row["jissibi_hon"],
                JissibiKyosei = (int)row["jissibi_kyosei"],
                _statusKari = (short)row["status_kari"],
                _statusHon = (short)row["status_hon"],
                _statusKyosei = (short)row["status_kyosei"],
                CreateDate = (int)row["create_date"],
                CreateSyain = (int)row["create_syain"],
                UpdateDate = (int)row["update_date"],
                UpdateSyain = (int)row["update_syain"],
                JissijknKari = (int)row["jissijkn_kari"],
                JissijknHon = (int)row["jissijkn_hon"],
                JissijknKyosei = (int)row["jissijkn_kyosei"],
                _creSFlg = (short)row["cres_flg"],
                _crePFlg = (short)row["crep_flg"],
                ChgFlg = DRAFT,
                ErrorValidation = new Validation()
            }).ToList();
    }
}