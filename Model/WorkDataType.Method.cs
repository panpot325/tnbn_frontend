using System;

namespace WorkDataStudio.Model;

/// <summary>
/// 加工ワークデータタイプクラス
/// </summary>
public partial class WorkDataType {
    /// <summary>
    /// GetBiko
    /// </summary>
    /// <returns></returns>
    public string GetBiko() {
        return $"{Meisyo}\r\n{Biko}";
    }

    /// <summary>
    /// GetTani
    /// </summary>
    /// <returns></returns>
    public string GetTani() {
        return Tani == HYPHEN ? "" : $"{DecNyuTani: 0.0}{Tani}";
    }

    /// <summary>
    /// GetZero
    /// </summary>
    /// <returns></returns>
    public string GetZero() {
        return ZeroEntry == ZERO_ENTRY_OK ? "可" : "不可";
    }

    /// <summary>
    /// GetHani
    /// </summary>
    /// <returns></returns>
    public string GetHani() {
        switch (NyuMode) {
            case NYU_MODE_NUM: {
                var min = "";
                var max = "";
                if (DecNyuTani == 0.1m) {
                    min = $"{DecHaniMin: #,##0.0}";
                    max = $"{DecHaniMax: #,##0.0}";
                }
                else {
                    if (Dm[0] == 'W') {
                        min = $"{DecHaniMin: #,##.0}";
                        max = $"{DecHaniMax: #,##.0}";
                    }
                    else {
                        min = StrHaniMin;
                        max = StrHaniMax;
                    }
                }

                var sa = max.Length - min.Length;
                switch (sa) {
                    case > 0: {
                        for (var j = 0; j < sa; j++) {
                            min = " " + min;
                        }

                        break;
                    }
                    case < 0: {
                        for (var j = 0; j < Math.Abs(sa); j++) {
                            max = " " + max;
                        }

                        break;
                    }
                }

                return $"Min: {min}\r\nMax: {max}";
            }
            default:
                return NyuMode == NYU_MODE_ANUM ? "英数字" : "英字";
        }
    }
}