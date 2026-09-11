using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UICommonCodeInputWindowController : UIPopupWindowController
{
	private UIModelQRCode m_ModelQRCode;

	private UICommonCodeInputWindowView m_View;

	protected CodeInputPopupData m_Data;

	protected List<string> m_CodeList;

	private List<UILabel> m_CodeLabels;

	private List<UIToggleButton> m_ToggleList;

	private List<GameObject> m_Items;

	private Color m_TextColor;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetUIData(CodeInputPopupData data)
	{
	}

	public void OnToggleClick(object data)
	{
	}

	protected void SetToggleColor(int idx, bool colorHight = true)
	{
	}

	private void ShowCursorAtIndex(int idx)
	{
	}

	protected void ShowTextAtIndex(int idx, string text)
	{
	}

	private void SetCodePasteBtnState()
	{
	}

	protected virtual void OnCodePasteBtnClick()
	{
	}

	private void OnQRCodeScanBtnClick()
	{
	}

	protected bool IsNumber(string str)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
