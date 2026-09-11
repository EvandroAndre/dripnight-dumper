using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UILadderMatchWinPassPreheatItemController : UIBaseController
{
	private UILadderMatchWinPassPreheatItemView m_View;

	private UIStandardItemMiniController m_RewardItemCtrl;

	private ResourceID m_FinalRewardUIFXResID;

	private GameObject m_FinalRewardUIFX;

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

	public void LoadFinalRewardUIFX()
	{
	}

	public void SetViewData(AwardDesc award)
	{
	}

	public void SetFinalRewardUIFX(bool isFinalReward)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
