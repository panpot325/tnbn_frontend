using System.Net;
using System.Net.Sockets;

namespace WorkDataStudio.share;

/// <summary>
/// Globals
/// </summary>
public static partial class Globals {
    /// <summary>
    /// NullZero
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    private static decimal DecNullZero(string str) {
        return str is null || str.Length == 0 ? 0m : decimal.Parse(str);
    }

    /// <summary>
    /// ホスト名取得
    /// </summary>
    /// <returns></returns>
    // ReSharper disable once MemberCanBePrivate.Global
    public static string GetHostName() {
        return Dns.GetHostName();
    }

    /// <summary>
    /// IPアドレス取得
    /// </summary>
    /// <returns></returns>
    public static string GetIpAddress() {
        foreach (var ip in Dns.GetHostAddresses(GetHostName())) {
            if (ip.AddressFamily == AddressFamily.InterNetwork) {
                return ip.ToString();
            }
        }

        return "";
    }
}