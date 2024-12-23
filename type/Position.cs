using System.Collections.Generic;

// ReSharper disable MemberCanBePrivate.Global
namespace WorkDataStudio.type;

/// <summary>
/// @位置WK_Data
/// </summary>
public class Position {
    //Member
    public decimal Front; //@W前位置
    public int F_Lk; //@W前Lk 
    public decimal F_Sp; //@W前Sp
    public decimal F_Lh; //@W前Lh
    public decimal F_Lt; //@W前Lt
    public decimal F_Ll; //@W前Ll
    public decimal F_Wl; //@W前Wl

    public decimal Back; //@W後位置
    public int B_Lk; //@W後Lk
    public decimal B_Sp; //@W後Sp
    public decimal B_Lh; //@W後Lh
    public decimal B_Lt; //@W後Lt
    public decimal B_Ll; //@W後Ll
    public decimal B_Wl; //@W後Wl

    public static List<Position> List = [];
    public static int Count => List.Count;
    public static bool Exists => Count > 0;

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public static List<Position> Init() {
        List = [];

        return List;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="front"></param>
    /// <param name="fLk"></param>
    /// <param name="fSp"></param>
    /// <param name="fLh"></param>
    /// <param name="fLt"></param>
    /// <param name="fLl"></param>
    /// <param name="fWl"></param>
    /// <returns></returns>
    public static List<Position> Add(
        decimal front,
        int fLk,
        decimal fSp,
        decimal fLh,
        decimal fLt,
        decimal fLl,
        decimal fWl
    ) {
        List.Add(new Position {
                Front = front,
                F_Lk = fLk,
                F_Sp = fSp,
                F_Lh = fLh,
                F_Lt = fLt,
                F_Ll = fLl,
                F_Wl = fWl
            }
        );
        return List;
    }

    /// <summary>
    /// Private Constructor
    /// </summary>
    private Position() {
    }
}