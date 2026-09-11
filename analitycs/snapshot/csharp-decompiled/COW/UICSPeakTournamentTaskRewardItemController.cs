using GCommon;
using UnityEngine;

namespace COW;

public class UICSPeakTournamentTaskRewardItemController : UIBaseController
{
	private UICSPeakTournamentTaskRewardItemView m_View;

	private UIStandardItemMiniController m_RewardItemCtrl;

	private CSPeakTaskRewardData m_CurData;

	public bool IsSelected;

	private UICSPeakTournamentRankIconController m_RankIconCtrl;

	private GameObject m_AvatarFrameEffect;

	public CSPeakTaskRewardData CurData => null;

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

	private void OnItemButtonClick()
	{
	}

	public void SetViewData(CSPeakTaskRewardData taskRewardData)
	{
	}

	public void UnSelectItem()
	{
	}

	public void SelectItem()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
