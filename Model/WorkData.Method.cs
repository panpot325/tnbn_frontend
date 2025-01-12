using System.Collections.Generic;
using System.Windows.Forms;
using WorkDataStudio.Component;

namespace WorkDataStudio.Model;

/// <summary>
/// @WorkData.Methodス
/// </summary>
public partial class WorkData {
    /// <summary>
    /// SetGridData
    /// </summary>
    /// <param name="grid"></param>
    /// <returns>WorkData</returns>
    public WorkData SetGridData(CustomDataGridView grid) {
        Sno = grid.StrData(0);
        Blk = grid.StrData(1);
        Bzi = grid.StrData(2);
        Pcs = grid.StrData(3);

        Gr1 = grid.IntData(4);
        Gr2 = grid.IntData(5);
        Gr3 = grid.IntData(6);
        Gr4 = grid.IntData(7);
        Gr5 = grid.IntData(8);

        Lk1 = grid.IntData(9);
        Lk2 = grid.IntData(10);
        Lk3 = grid.IntData(11);
        Lk4 = grid.IntData(12);
        Lk5 = grid.IntData(13);

        L = grid.DecData(14);
        B = grid.DecData(15);
        Tmax = grid.DecData(16);

        T1 = grid.DecData(17);
        T2 = grid.DecData(18);
        T3 = grid.DecData(19);
        T4 = grid.DecData(20);
        T5 = grid.DecData(21);

        It1 = grid.DecData(22);
        It2 = grid.DecData(23);
        It3 = grid.DecData(24);
        It4 = grid.DecData(25);

        Sp1 = grid.DecData(26);
        Sp2 = grid.DecData(27);
        Sp3 = grid.DecData(28);
        Sp4 = grid.DecData(29);
        Sp5 = grid.DecData(30);

        Lh1 = grid.DecData(31);
        Lh2 = grid.DecData(32);
        Lh3 = grid.DecData(33);
        Lh4 = grid.DecData(34);
        Lh5 = grid.DecData(35);

        Lt1 = grid.DecData(36);
        Lt2 = grid.DecData(37);
        Lt3 = grid.DecData(38);
        Lt4 = grid.DecData(39);
        Lt5 = grid.DecData(40);

        Ll1 = grid.DecData(41);
        Ll2 = grid.DecData(42);
        Ll3 = grid.DecData(43);
        Ll4 = grid.DecData(44);
        Ll5 = grid.DecData(45);

        Wl1 = grid.IntData(46);
        Wl2 = grid.IntData(47);
        Wl3 = grid.IntData(48);
        Wl4 = grid.IntData(49);
        Wl5 = grid.IntData(50);

        Is1 = grid.DecData(51);

        Stp1 = grid.DecData(52);
        Stp2 = grid.DecData(53);
        Stp3 = grid.DecData(54);
        Stp4 = grid.DecData(55);
        Stp5 = grid.DecData(56);

        Org = grid.IntData(57);

        YoteibiKari = grid.IntData(58);
        YoteibiHon = 0;
        YoteibiKyosei = 0;
        JissibiKari = 0;
        JissibiHon = 0;
        JissibiKyosei = 0;
        StatusKari = 0;
        StatusHon = 0;
        StatusKyosei = 0;
        ChgFlg = UPDATE;

        return this;
    }


    /// <summary>
    /// 西東対象データ編集
    /// </summary>
    public void E_W_Edit() {
        Lk3 = 1;
        Lk4 = Lk2;
        Lk5 = Lk1;
        var w2 = Sp1 + Sp2;
        var w5 = 4900 - (Sp1 + Lt1);
        var w4 = 4900 - (w2 + Lt2);
        var w3 = (w4 - w2) / 2 + w2;
        Sp3 = decimal.Parse((w3 - w2 + 0.04m).ToString("F1"));
        Sp4 = decimal.Parse((w4 - w3 + 0.04m).ToString("F1"));
        Sp5 = decimal.Parse((w5 - w4 + 0.04m).ToString("F1"));
        Lh3 = 0;
        Lh4 = Lh2;
        Lh5 = Lh1;
        Lt3 = 0;
        Lt4 = Lt2;
        Lt5 = Lt1;
        Ll3 = 0;
        Ll4 = Ll2;
        Ll5 = Ll1;
        Wl3 = 0;
        Wl4 = Wl2;
        Wl5 = Wl1;
        Stp3 = 0;
        Stp4 = Stp2;
        Stp5 = Stp1;
    }

    /// <summary>
    /// SetOfGrid
    /// </summary>
    /// <param name="grid"></param>
    /// <returns></returns>
    public WorkData SetOfGrid(DataGridView grid) {
        Sno = grid[0, 0].Value.ToString();
        Blk = grid[0, 1].Value.ToString();
        Bzi = grid[0, 2].Value.ToString();
        Pcs = grid[0, 3].Value.ToString();

        Gr1 = short.Parse(grid[0, 4].Value.ToString());
        Gr2 = short.Parse(grid[0, 5].Value.ToString());
        Gr3 = short.Parse(grid[0, 6].Value.ToString());
        Gr4 = short.Parse(grid[0, 7].Value.ToString());
        Gr5 = short.Parse(grid[0, 8].Value.ToString());

        Lk1 = short.Parse(grid[0, 9].Value.ToString());
        Lk2 = short.Parse(grid[0, 10].Value.ToString());
        Lk3 = short.Parse(grid[0, 11].Value.ToString());
        Lk4 = short.Parse(grid[0, 12].Value.ToString());
        Lk5 = short.Parse(grid[0, 13].Value.ToString());

        L = decimal.Parse(grid[0, 14].Value.ToString());
        B = decimal.Parse(grid[0, 15].Value.ToString());
        Tmax = decimal.Parse(grid[0, 16].Value.ToString());

        T1 = decimal.Parse(grid[0, 17].Value.ToString());
        T2 = decimal.Parse(grid[0, 18].Value.ToString());
        T3 = decimal.Parse(grid[0, 19].Value.ToString());
        T4 = decimal.Parse(grid[0, 20].Value.ToString());
        T5 = decimal.Parse(grid[0, 21].Value.ToString());

        It1 = decimal.Parse(grid[0, 22].Value.ToString());
        It2 = decimal.Parse(grid[0, 23].Value.ToString());
        It3 = decimal.Parse(grid[0, 24].Value.ToString());
        It4 = decimal.Parse(grid[0, 25].Value.ToString());

        Sp1 = decimal.Parse(grid[0, 26].Value.ToString());
        Sp2 = decimal.Parse(grid[0, 27].Value.ToString());
        Sp3 = decimal.Parse(grid[0, 28].Value.ToString());
        Sp4 = decimal.Parse(grid[0, 29].Value.ToString());
        Sp5 = decimal.Parse(grid[0, 30].Value.ToString());

        Lh1 = decimal.Parse(grid[0, 31].Value.ToString());
        Lh2 = decimal.Parse(grid[0, 32].Value.ToString());
        Lh3 = decimal.Parse(grid[0, 33].Value.ToString());
        Lh4 = decimal.Parse(grid[0, 34].Value.ToString());
        Lh5 = decimal.Parse(grid[0, 35].Value.ToString());

        Lt1 = decimal.Parse(grid[0, 36].Value.ToString());
        Lt2 = decimal.Parse(grid[0, 37].Value.ToString());
        Lt3 = decimal.Parse(grid[0, 38].Value.ToString());
        Lt4 = decimal.Parse(grid[0, 39].Value.ToString());
        Lt5 = decimal.Parse(grid[0, 40].Value.ToString());

        Ll1 = decimal.Parse(grid[0, 41].Value.ToString());
        Ll2 = decimal.Parse(grid[0, 42].Value.ToString());
        Ll3 = decimal.Parse(grid[0, 43].Value.ToString());
        Ll4 = decimal.Parse(grid[0, 44].Value.ToString());
        Ll5 = decimal.Parse(grid[0, 45].Value.ToString());

        Wl1 = short.Parse(grid[0, 46].Value.ToString());
        Wl2 = short.Parse(grid[0, 47].Value.ToString());
        Wl3 = short.Parse(grid[0, 48].Value.ToString());
        Wl4 = short.Parse(grid[0, 49].Value.ToString());
        Wl5 = short.Parse(grid[0, 50].Value.ToString());

        Is1 = decimal.Parse(grid[0, 51].Value.ToString());

        Stp1 = decimal.Parse(grid[0, 52].Value.ToString());
        Stp2 = decimal.Parse(grid[0, 53].Value.ToString());
        Stp3 = decimal.Parse(grid[0, 54].Value.ToString());
        Stp4 = decimal.Parse(grid[0, 55].Value.ToString());
        Stp5 = decimal.Parse(grid[0, 56].Value.ToString());

        Org = short.Parse(grid[0, 57].Value.ToString());

        YoteibiKari = int.Parse(grid[0, 58].Value.ToString());
        YoteibiHon = 0;
        YoteibiKyosei = 0;
        JissibiKari = 0;
        JissibiHon = 0;
        JissibiKyosei = 0;
        _statusKari = 0;
        _statusHon = 0;
        _statusKyosei = 0;
        _chgFlg = UPDATE;

        return this;
    }

    /// <summary>
    /// GetValues
    /// </summary>
    /// <returns></returns>
    public List<object> GetValues() {
        return [
            Sno,
            Blk,
            Bzi,
            Pcs,
            Gr1,
            Gr2,
            Gr3,
            Gr4,
            Gr5,
            Lk1,
            Lk2,
            Lk3,
            Lk4,
            Lk5,
            L,
            B,
            Tmax,
            T1,
            T2,
            T3,
            T4,
            T5,
            It1,
            It2,
            It3,
            It4,
            Sp1,
            Sp2,
            Sp3,
            Sp4,
            Sp5,
            Lh1,
            Lh2,
            Lh3,
            Lh4,
            Lh5,
            Lt1,
            Lt2,
            Lt3,
            Lt4,
            Lt5,
            Ll1,
            Ll2,
            Ll3,
            Ll4,
            Ll5,
            Wl1,
            Wl2,
            Wl3,
            Wl4,
            Wl5,
            Is1,
            Stp1,
            Stp2,
            Stp3,
            Stp4,
            Stp5,
            Org,
            YoteibiKari
        ];
    }
}