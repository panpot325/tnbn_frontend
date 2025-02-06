using System;
using System.Globalization;

// ReSharper disable ConvertToAutoPropertyWhenPossible
namespace WorkDataStudio.Model;

/// <summary>
/// 加工ワークデータタイプクラス Property
/// </summary>
public partial class WorkDataType {
    //char(4)
    public string Dm => _dm.Trim();

    //char(6)
    public string Ryaku => _ryaku.Trim();

    //varchar(80)
    public string Meisyo => _meisyo.Trim();

    //char(4)
    public string NyuMode => _nyuMode.Trim();

    //numeric(6, 2)
    public string Tani => _tani.Trim();

    //char(8)
    public string Keishiki => _keishiki.Trim();

    //char(2)
    public string ZeroEntry => _zeroEntry.Trim();

    //varchar(120)
    public string Biko => _biko.Trim();

    //varchar(2)
    public string Karituke => _karituke.Trim();

    //varchar(2)
    public string Yosetu => _yosetu.Trim();

    //varchar(2)
    public string StrKyosei => _kyosei.Trim();

    //varchar(32)
    public string Def => _def.Trim();

    //smallint
    public int DevTensu => Convert.ToInt32(_devTensu);

    //numeric(6, 2)
    public int IntNyuTani => Convert.ToInt32(_nyuTani);
    public decimal DecNyuTani => _nyuTani;

    //numeric(10, 2)
    public int IntHaniMax => Convert.ToInt32(_haniMax);
    public string StrHaniMax => _haniMax.ToString(CultureInfo.InvariantCulture);
    public decimal DecHaniMax => _haniMax;
    public int LenHaniMax => _haniMax.ToString(CultureInfo.InvariantCulture).Length;

    //numeric(10, 2)
    public int IntHaniMin => Convert.ToInt32(_haniMin);
    public string StrHaniMin => _haniMin.ToString(CultureInfo.InvariantCulture);
    public decimal DecHaniMin => _haniMin;
    public int LenHaniMin => _haniMin.ToString(CultureInfo.InvariantCulture).Length;

    //numeric(10, 2)
    public int IntHaniMin2 => Convert.ToInt32(_haniMin2);
    public string StrHaniMin2 => _haniMin2.ToString(CultureInfo.InvariantCulture);
    public decimal DecHaniMin2 => _haniMin2;
    public int LenHaniMin2 => _haniMin2.ToString(CultureInfo.InvariantCulture).Length;

    public int LenHaniMaxNewTani => (_haniMax + _nyuTani).ToString(CultureInfo.InvariantCulture).Length;
    public int LenHaniMinNewTani => (_haniMin + _nyuTani).ToString(CultureInfo.InvariantCulture).Length;

    public int Index => _index;

    public bool isNyu_Mode(string nyuMode) {
        return NyuMode == nyuMode;
    }
}