// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable FieldCanBeMadeReadOnly.Global

namespace WorkDataStudio.Model;

/// <summary>
/// 加工ワークデータタイプクラス Member
/// </summary>
public partial class WorkDataType {
    private string _dm; //char(4) not null
    private string _ryaku; //char(6)
    private string _meisyo; //varchar(80)
    private string _nyuMode; //char(4) ANUM:英数字／NUM:数値／A:英字
    private decimal _nyuTani; //numeric(6, 2) 1／0.1 等 (NYU_MODE=NUMの時のみ使用)
    private string _tani; //varchar(2)
    private short _devTensu; //smallint 16bit単位(16bit→1／32bit→2／・・・)
    private decimal _haniMin; //numeric(10, 2)
    private decimal _haniMax; //numeric(10, 2)
    private string _zeroEntry; //char(2) OK／NG (HANI_MIN～HANI_MAX が｢0｣を経由しない時のみ使用)
    private string _keishiki; //char(8) ASCII／16bitB／32bitB／m16bitB
    private string _biko; //varchar(120)
    private string _karituke; //varchar(2) ○：使用／△：どちらでも／－：不使用
    private string _yosetu; //varchar(2) ○：使用／△：どちらでも／－：不使用
    private string _kyosei; //varchar(2) ○：使用／△：どちらでも／－：不使用
    private string _def; //varchar(32)
    private decimal _haniMin2; //@Transient
    private int _index; //@Transient
}