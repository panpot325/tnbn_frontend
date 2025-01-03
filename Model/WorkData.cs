namespace WorkDataStudio.Model;

/// <summary>
/// @WorkData
/// </summary>
public partial class WorkData {
    //Globals
    public static string snoName; //@船番 
    public static int workDataCnt; //@加工ワークデータ数
    public static int copySelectCnt; //@Cpy選択数 
    public static int copyDataCnt; //@Cpy抽出該当件数 
    public static int duplicateCnt; //@P_重複ErrCnt 重複ﾁｪｯｸｴﾗｰｶｳﾝﾄ
    public static bool selected; //@条件選択 

    /// <summary>
    /// Constructor
    /// </summary>
    private WorkData() {
    }
}