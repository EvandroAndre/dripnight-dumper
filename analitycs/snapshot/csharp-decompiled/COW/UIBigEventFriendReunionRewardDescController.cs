using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIBigEventFriendReunionRewardDescController : UIBaseController
{
	private enum BtnOperateType
	{
		GoTo,
		GetReward,
		RewardFinished,
		RewardUnfinish,
		Exchange,
		ExchangeNo,
		ExchangeNoFinished,
		Forcast,
		Callback
	}

	private UIBigEventFriendReunionRewardDescView m_View;

	private List<UIStandardItemMiniController> m_List;

	private UIStandardItemMiniController m_ExchangeRewardItem;

	private ClientActivityDesc m_Desc;

	private BtnOperateType m_curOperation;

	private UIModelActivity m_ModelActivity;

	private bool m_ExchangeFinished;

	private bool m_ExchangeItemLack;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetData(ClientActivityDesc desc, ActivityClientInfo info)
	{
	}

	private void OnGetRewardClick()
	{
	}

	private void OnGoToClick()
	{
	}

	private void OnExchangeClick()
	{
	}

	private void OnExchangeNoClick()
	{
	}

	private void OnBtnOperate()
	{
	}

	private void UpdateBtnOperateStatus()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
