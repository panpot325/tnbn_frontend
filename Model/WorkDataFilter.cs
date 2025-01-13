namespace WorkDataStudio.Model;

/// <summary>
/// WorkDataFilter
/// </summary>
public class WorkDataFilter {
    /// <summary>
    ///  Static Instance
    /// </summary>
    private static readonly WorkDataFilter _instance = new();

    /// <summary>
    /// Property
    /// </summary>
    public static string Sno => _instance._sno;

    public static bool HasSno => !string.IsNullOrEmpty(_instance._sno);

    /// <summary>
    /// Property
    /// </summary>
    public static string Blk => _instance._blk;

    public static bool HasBlk => !string.IsNullOrEmpty(_instance._blk);

    /// <summary>
    /// Property
    /// </summary>
    public static string Bzi => _instance._bzi;

    public static bool HasBzi => !string.IsNullOrEmpty(_instance._bzi);

    /// <summary>
    /// Property
    /// </summary>
    public static string Pcs => _instance._pcs;

    public static bool HasPcs => !string.IsNullOrEmpty(_instance._pcs);

    /// <summary>
    /// Property
    /// </summary>
    public static int Yotei => _instance._yotei;

    public static bool HasYotei => _instance._yotei > 0;

    /// <summary>
    /// Clear
    /// </summary>
    public static WorkDataFilter New() {
        _instance._sno = "";
        _instance._blk = "";
        _instance._bzi = "";
        _instance._pcs = "";
        _instance._yotei = 0;

        return _instance;
    }

    /// <summary>
    /// SetSno
    /// </summary>
    /// <param name="sno"></param>
    /// <returns></returns>
    public WorkDataFilter _Sno(string sno) {
        _sno = sno;
        return this;
    }

    /// <summary>
    /// SetBlk
    /// </summary>
    /// <param name="blk"></param>
    /// <returns></returns>
    public WorkDataFilter _Blk(string blk) {
        _blk = blk;
        return this;
    }

    /// <summary>
    /// SetBzi
    /// </summary>
    /// <param name="bzi"></param>
    /// <returns></returns>
    public WorkDataFilter _Bzi(string bzi) {
        _bzi = bzi;
        return this;
    }

    /// <summary>
    /// SetPcs
    /// </summary>
    /// <param name="pcs"></param>
    /// <returns></returns>
    public WorkDataFilter _Pcs(string pcs) {
        _pcs = pcs;
        return this;
    }

    /// <summary>
    /// SetYotei
    /// </summary>
    /// <param name="yotei"></param>
    /// <returns></returns>
    public WorkDataFilter _Yotei(int yotei) {
        _yotei = yotei;
        return this;
    }

    /// <summary>
    /// Private Constructor
    /// </summary>
    private WorkDataFilter() {
    }

    // Private Member
    private string _sno; //sno char(6)
    private string _blk; //blk char(8)
    private string _bzi; //bzi char(16)
    private string _pcs; //pcs char
    private int _yotei; //yoteibi_kari integer
}