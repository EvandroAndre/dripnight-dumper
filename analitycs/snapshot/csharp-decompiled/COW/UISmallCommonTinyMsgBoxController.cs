using System;
using GCommon;

namespace COW;

public class UISmallCommonTinyMsgBoxController : UIPopupWindowController
{
	public enum EUIStyle
	{
		EUIStyleNormal,
		EUIStyleTips,
		EUIStyleIcon
	}

	public class Config
	{
		public string Title;

		public string Content;

		public string OKTxt;

		public string CancelTxt;

		public string TipsTxt;

		public ResourceID iconRes;

		public Action OnOk;

		public Action OnCancel;

		public Action OnClose;

		public EUIStyle Style;
	}

	private UISmallCommonTinyMsgBoxView m_View;

	private Action m_OnOK;

	private Action m_OnCancel;

	private Action m_OnClose;

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

	public void SetUIData(Config config)
	{
	}

	private void SetUIStyle(EUIStyle style)
	{
	}

	private void OnBtnOKClick()
	{
	}

	private void OnBtnCancelClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
