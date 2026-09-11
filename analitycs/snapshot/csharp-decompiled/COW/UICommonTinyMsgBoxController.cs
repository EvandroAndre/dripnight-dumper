using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UICommonTinyMsgBoxController : UIPopupWindowController
{
	public enum EUIStyle
	{
		EUIStyleNormal,
		EUIStyleTips,
		EUIStyleIcon,
		EUIStyleItems
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

		public List<BaseItemInfo> Items;

		public string ItemLabel;
	}

	private UICommonTinyMsgBoxView m_View;

	private Action m_OnOK;

	private Action m_OnCancel;

	private Action m_OnClose;

	private List<BaseItemInfo> m_Items;

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

	public void SetContentPosition(Vector3 position)
	{
	}

	public void SetContentFontSize(int fontSize)
	{
	}

	public void SetContentAlignment(NGUIText.Alignment alignment)
	{
	}

	public void SetContentOverflow(UILabel.Overflow overflow)
	{
	}

	public void SetContentMaxLines(int maxLines)
	{
	}

	public void SetContentPivot(UIWidget.Pivot pivot)
	{
	}

	public void SetContentMaxWidth(int maxWidth)
	{
	}

	public void ShowTipIcon()
	{
	}

	private void SetUIStyle(EUIStyle style)
	{
	}

	public void SetOnCloseCallback(Action callback)
	{
	}

	private void OnBtnOKClick()
	{
	}

	private void OnBtnCancelClick()
	{
	}

	public void OnPauseCheck(object[] data)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
