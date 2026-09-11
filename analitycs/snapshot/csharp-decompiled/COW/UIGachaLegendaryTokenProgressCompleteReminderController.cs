using System;
using GCommon;
using proto;

namespace COW;

public class UIGachaLegendaryTokenProgressCompleteReminderController : UIPopupWindowController
{
	private UIGachaLegendaryTokenProgressCompleteReminderView m_View;

	private UIModelGacha m_ModelGacha;

	private Action m_ContinueAction;

	private uint m_ChestID;

	private int m_ExtraIndex;

	private ExtraRewardDesc m_SuperPrizeItem;

	private UIGachaLengendaryExtraListItemController m_LegendaryItemCtrl;

	private bool m_IsNB2;

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

	public void SetViewData(uint chestID, Action continueAction, bool isNB2 = false)
	{
	}

	private void RefreshSuperPrize()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
