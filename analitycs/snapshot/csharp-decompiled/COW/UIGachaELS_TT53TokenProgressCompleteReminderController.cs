using System;
using GCommon;
using proto;

namespace COW;

public class UIGachaELS_TT53TokenProgressCompleteReminderController : UIPopupWindowController
{
	private UIGachaELS_TT53TokenProgressCompleteReminderView m_View;

	private UIModelGacha m_ModelGacha;

	private Action m_ContinueAction;

	private uint m_ChestID;

	private int m_ExtraIndex;

	private ExtraRewardDesc m_SuperPrizeItem;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnContinueBtnClick()
	{
	}

	private void OnClaimBtnClick()
	{
	}

	public void SetViewData(uint chestID, Action continueAction)
	{
	}

	private void SetCDNBG()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
