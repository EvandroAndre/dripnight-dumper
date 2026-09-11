using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIPaymentTotalItemController : UIBaseController
{
	private enum BtnOperateType
	{
		GetReward,
		RewardFinished,
		RewardUnfinish,
		Forcast
	}

	private UIPaymentTotalItemView m_View;

	private BtnOperateType m_curOperation;

	private ClientActivityDesc m_Data;

	private List<UIPaymentTotalContentItemController> m_ContentItems;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void SetData(ClientActivityDesc desc)
	{
	}

	private void OnGetRewardClick()
	{
	}

	private void UpdateBtnOperateStatus()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
