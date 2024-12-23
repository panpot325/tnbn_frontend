using System;

namespace WorkDataStudio.share;

/// <summary>
/// Extension
/// </summary>
public static class Extension {
    public static void With<T>(this T me, Action<T> action) => action(me);
}