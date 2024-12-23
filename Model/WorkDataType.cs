// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable FieldCanBeMadeReadOnly.Global

namespace WorkDataStudio.Model;

/// <summary>
/// 加工ワークデータタイプクラス
/// </summary>
public partial class WorkDataType {
    /// <summary>
    /// Constructor
    /// </summary>
    public WorkDataType() {
    }

    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="dm"></param>
    /// <param name="ryaku"></param>
    /// <param name="meisyo"></param>
    /// <param name="nyuMode"></param>
    /// <param name="nyuTani"></param>
    /// <param name="tani"></param>
    /// <param name="devTensu"></param>
    /// <param name="haniMin"></param>
    /// <param name="haniMax"></param>
    /// <param name="zeroEntry"></param>
    /// <param name="keishiki"></param>
    /// <param name="biko"></param>
    /// <param name="karitsuke"></param>
    /// <param name="yosetu"></param>
    /// <param name="kyosei"></param>
    /// <param name="def"></param>
    /// <param name="haniMin2"></param>
    public WorkDataType(
        string dm,
        string ryaku,
        string meisyo,
        string nyuMode,
        decimal nyuTani,
        string tani,
        short devTensu,
        decimal haniMin,
        decimal haniMax,
        string zeroEntry,
        string keishiki,
        string biko,
        string karitsuke,
        string yosetu,
        string kyosei,
        string def,
        decimal haniMin2
    ) {
        _dm = dm;
        _ryaku = ryaku;
        _meisyo = meisyo;
        _nyuMode = nyuMode;
        _nyuTani = nyuTani;
        _tani = tani;
        _devTensu = devTensu;
        _haniMin = haniMin;
        _haniMax = haniMax;
        _zeroEntry = zeroEntry;
        _keishiki = keishiki;
        _biko = biko;
        _karituke = karitsuke;
        _yosetu = yosetu;
        _kyosei = kyosei;
        _def = NyuMode == NYU_MODE_NUM && _nyuTani.Equals(0.1m) ? def + "0" : def;
        _haniMin2 = NyuMode == NYU_MODE_NUM && _nyuTani.Equals(0.1m) ? haniMin2 : haniMin;
    }
}