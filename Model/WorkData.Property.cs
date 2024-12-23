// ReSharper disable MemberCanBePrivate.Global

namespace WorkDataStudio.Model;

/// <summary>
/// @WorkData.Property
/// </summary>
public partial class WorkData {
    //yoteibi_kari integer
    public int YoteibiHon { get; set; }

    //yoteibi_kyosei integer
    public int YoteibiKyosei { get; set; }

    //yoteibi_kari integer
    public int JissibiKari { get; set; }

    //yoteibi_kari integer
    public int JissibiHon { get; set; }

    //yoteibi_kyosei integer
    public int JissibiKyosei { get; set; }

    //status_kari smallint
    public int StatusKari {
        get => _statusKari;
        set => _statusKari = (short)value;
    }

    //Status_Hon smallint
    public int StatusHon {
        get => _statusHon;
        set => _statusHon = (short)value;
    }

    //Status_Kyosei smallint
    public int StatusKyosei {
        get => _statusKyosei;
        set => _statusKyosei = (short)value;
    }

    //create_date integer
    public int CreateDate { get; set; }

    //create_syain integer
    public int CreateSyain { get; set; }

    //create_date integer
    public int UpdateDate { get; set; }

    //create_syain integer
    public int UpdateSyain { get; set; }

    //jissijkn_kari integer
    public int JissijknKari { get; set; }

    //Jissijkn_Hon integer
    public int JissijknHon { get; set; }

    //Jissijkn_Kyosei integer
    public int JissijknKyosei { get; set; }

    //cres_flg smallint
    public int CreSFlg {
        get => _creSFlg;
        set => _creSFlg = (short)value;
    }

    //crep_flg smallint
    public int CrePFlg {
        get => _crePFlg;
        set => _crePFlg = (short)value;
    }

    //@Transient
    public int ChgFlg {
        get => _chgFlg;
        set => _chgFlg = (short)value;
    }

    //@Transient 入力ﾁｪｯｸｴﾗｰﾌﾗｸﾞ 0:無  1:有
    public int Err1Flg {
        get => _err1Flg;
        set => _err1Flg = (short)value;
    }

    //@Transient 重複ﾁｪｯｸｴﾗｰﾌﾗｸﾞ 0:無  1:有
    public int Err2Flg {
        get => _err2Flg;
        set => _err2Flg = (short)value;
    }
}