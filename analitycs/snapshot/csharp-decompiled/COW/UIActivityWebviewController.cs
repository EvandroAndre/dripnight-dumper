using System;
using GCommon;
using proto;

namespace COW;

public class UIActivityWebviewController : UIActivityContentController
{
	public class ActivityWebViewData
	{
		public uint id;

		public uint groupId;

		public uint goPos;

		public string subGoPos;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<WebExternalBrowserLimit, string> _003C_003E9__27_0;

		internal string _003CSetData_003Eb__27_0(WebExternalBrowserLimit t)
		{
			return null;
		}
	}

	private UIActivityWebviewView m_View;

	private WebView m_WebView;

	private ActivityWebViewData m_Data;

	private bool m_IsCoveredByPopupWnd;

	private const int RIGHTBUTTONWIDTH = 56;

	private const int LEFTTABWIDTH = 227;

	private const int TOPTABHEIGHT = 56;

	private uint m_UpdateDelayCallId;

	private float m_LastProgress;

	private float m_NextProgress;

	private long m_LastProgressTicks;

	private long m_LastLoadTicks;

	private long m_BeginLoadTicks;

	private bool m_ProgressLoading;

	private bool m_ProgressLoaded;

	private long m_OpenTicks;

	private WebView.Rect m_WebViewRect;

	private float ProgressAnimationDuration => 0f;

	private void UpdateProgress(float progress)
	{
	}

	private float SmoothProgress()
	{
		return 0f;
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public override void OnVisibilityChange(bool isVisible, bool needRefresh)
	{
	}

	public override void SetData(object data)
	{
	}

	public override void OnPopUpWindowListChange(bool isCovered)
	{
	}

	private void OnReturnBtnClick()
	{
	}

	private void OnRefreshBtnClick()
	{
	}

	private void OnExternalBtnClick()
	{
	}

	private void RefreshReturnButton(bool enabled)
	{
	}

	private void UpdateScreenshotInfo()
	{
	}

	private void _003COnUIInit_003Eb__23_0()
	{
	}

	private void _003COnUIInit_003Eb__23_1(int id, bool canGoBackward)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChange(bool P0, bool P1)
	{
	}

	public void _003C_003EiFixBaseProxy_SetData(object P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnPopUpWindowListChange(bool P0)
	{
	}
}
