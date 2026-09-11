using GCommon;
using UnityEngine;

namespace COW;

public class UILadderWinRewardItemController : UIBaseController
{
	private UILadderWinRewardItemView m_View;

	private UIStandardItemMiniController m_RewardItemCtrl;

	private WinRewardData m_CurData;

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

	private void OnItemButtonClick()
	{
	}

	public void SetViewData(WinRewardData winRewardData)
	{
	}

	public void LoadFinalRewardUIFX()
	{
	}

	public void SetSelectedState(bool isSelect)
	{
	}

	private void SetClaimView()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
