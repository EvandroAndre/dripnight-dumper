using System;
using System.Collections.Generic;
using GCommon;

namespace COW;

internal class UINewPlayerV3SignController : UIPopupWindowController, IUIModelDataChangeObserver
{
	private UINewPlayerV3SignView m_View;

	private UIModelNewPlayerV3 m_ModelNewPlayer;

	private readonly List<UINewPlayerV3SignItemController> m_SignRewardItemCtrlList;

	private Action m_SignPopWndCloseAction;

	private Action<int> m_BigRewardGotoAction;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public override int GlassDelay()
	{
		return 0;
	}

	public void ClaimSignRewards()
	{
	}

	public void SetSignPopWndCloseAction(Action signPopWndCloseAction)
	{
	}

	public void SetBigRewardGotoAction(Action<int> bigRewardGotoAction)
	{
	}

	private void LoadStaticContent()
	{
	}

	private void RefreshSignDynamicContent()
	{
	}

	private void RefreshView()
	{
	}

	private void OnCloseBtnClick()
	{
	}

	public void BigRewardClick(int day)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public int _003C_003EiFixBaseProxy_GlassDelay()
	{
		return 0;
	}
}
