// Vissoka.Core.DropShadow
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Vissoka.Core;

public class DropShadow
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public struct MARGINS
	{
		public int leftWidth;

		public int rightWidth;

		public int topHeight;

		public int bottomHeight;
	}

	private readonly bool _isAeroEnabled = false;

	private bool _isDraggingEnabled = false;

	private const int WM_NCHITTEST = 132;

	private const int WS_MINIMIZEBOX = 131072;

	private const int HTCLIENT = 1;

	private const int HTCAPTION = 2;

	private const int CS_DBLCLKS = 8;

	private const int CS_DROPSHADOW = 131072;

	private const int WM_NCPAINT = 133;

	private const int WM_ACTIVATEAPP = 28;

	[DllImport("dwmapi.dll")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);

	[DllImport("dwmapi.dll")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

	[DllImport("dwmapi.dll")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public static extern int DwmIsCompositionEnabled(ref int pfEnabled);

	[EditorBrowsable(EditorBrowsableState.Never)]
	public static bool IsCompositionEnabled()
	{
		if (Environment.OSVersion.Version.Major < 6)
		{
			return false;
		}
		DwmIsCompositionEnabled(out var enabled);
		return enabled;
	}

	[DllImport("Gdi32.dll")]
	public static extern bool DeleteObject(IntPtr hObject);

	[DllImport("dwmapi.dll")]
	private static extern int DwmIsCompositionEnabled(out bool enabled);

	[DllImport("Gdi32.dll")]
	private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

	private bool CheckIfAeroIsEnabled()
	{
		if (Environment.OSVersion.Version.Major >= 6)
		{
			int enabled = 0;
			DwmIsCompositionEnabled(ref enabled);
			return (enabled == 1) ? true : false;
		}
		return false;
	}

	public void ApplyShadows(Form form)
	{
		int v = 2;
		applyFormBorderRadius(form);
		DwmSetWindowAttribute(form.Handle, 2, ref v, 4);
		MARGINS mARGINS = default(MARGINS);
		mARGINS.bottomHeight = 1;
		mARGINS.leftWidth = 0;
		mARGINS.rightWidth = 0;
		mARGINS.topHeight = 0;
		MARGINS margins = mARGINS;
		DwmExtendFrameIntoClientArea(form.Handle, ref margins);
	}

	public void applyFormBorderRadius(Form form)
	{
	}
}
