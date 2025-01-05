namespace WorkDataStudio.Model;

/// <summary>
/// @WorkData.Member
/// </summary>
public partial class WorkData {
    private short _statusKari; //status_kari smallint
    private short _statusHon; //status_hon smallint
    private short _statusKyosei; //status_kyosei smallint

    private short _creSFlg; //cres_flg smallint S舷ﾃﾞｰﾀを 0:作成(西)、1:作成しない、2:作成(東)
    private short _crePFlg; //crep_flg smallint P舷ﾃﾞｰﾀを 0:作成(西)、1:作成しない、2:作成(東)

    private short _chgFlg; //@Transient 
    private int _err1Flg; //@Transient 入力ﾁｪｯｸｴﾗｰﾌﾗｸﾞ 0:無  1:有 
    private int _err2Flg; //@Transient 重複ﾁｪｯｸｴﾗｰﾌﾗｸﾞ 0:無  1:有 

    public Validation ErrorValidation;

    /// <summary>
    /// Validation
    /// </summary>
    public struct Validation() {
        public bool Change = false;
        public bool Grid1 = false;
        public readonly bool[] Grid3 = new bool[WorkDataType.Count];
    }
}