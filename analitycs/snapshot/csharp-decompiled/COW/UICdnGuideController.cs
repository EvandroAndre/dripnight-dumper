using System;
using System.Collections.Generic;
using GCommon;

namespace COW;

public class UICdnGuideController : UIPopupWindowController
{
	private UICdnGuideView m_View;

	private int m_CurIndex;

	private List<string> m_Urls;

	private List<string> m_Keys;

	private Action m_CloseAction;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetUrl(List<string> urls, ECdnGuideBGType bgType, int defaultIndex = 0, List<string> keys = null)
	{
	}

	private void SetCDNBG(ECdnGuideBGType bgType)
	{
	}

	private void OnBtnLeftClick()
	{
	}

	private void OnBtnRightClick()
	{
	}

	private void UpdateLabelTip(int index)
	{
	}

	private void OnCloseClick()
	{
	}

	public void SetCloseCallback(Action action)
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
