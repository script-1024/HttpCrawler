﻿namespace Windows.Win32.Foundation;

/// <summary>
///     Special window handles
/// </summary>
public readonly struct SPECIAL_WINDOW_HANDLES
{
    /// <summary>
    ///     Places the window at the top of the Z order.
    /// </summary>
    public static readonly HWND HWND_TOP = new(0);
    /// <summary>
    ///     Places the window at the bottom of the Z order. If the hWnd parameter identifies a topmost window, the window loses its topmost status and is placed at the bottom of all other windows.
    /// </summary>
    public static readonly HWND HWND_BOTTOM = new(1);
    /// <summary>
    ///     Places the window above all non-topmost windows. The window maintains its topmost position even when it is deactivated.
    /// </summary>
    public static readonly HWND HWND_TOPMOST = new(-1);
    /// <summary>
    ///     Places the window above all non-topmost windows (that is, behind all topmost windows). This flag has no effect if the window is already a non-topmost window.
    /// </summary>
    public static readonly HWND HWND_NOTOPMOST = new(-2);
}