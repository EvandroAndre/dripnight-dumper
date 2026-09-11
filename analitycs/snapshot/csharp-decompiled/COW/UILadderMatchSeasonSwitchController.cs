using System.Collections.Generic;
using GCommon;
using UnityEngine;
using message;

namespace COW;

public class UILadderMatchSeasonSwitchController : UIBaseController
{
	private UILadderMatchSeasonSwitchView m_View;

	private UIModelLadderMatch m_ModelLadderBR;

	private UIModelCSLadderMatch m_ModelLadderCS;

	private ResourceID m_SeasonSwitchUIFXResID;

	private GameObject m_SeasonSwitchUIFX;

	private ResourceID m_WinPassUIFXResID;

	private GameObject m_WinPassUIFX;

	private List<UILadderMatchWinPassPreheatItemController> m_RewardItemCtrlList;

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

	private void LoadSeasonSwitchUIFX()
	{
	}

	private void LoadWinPassUIFX()
	{
	}

	public void SetSeasonSwitchView(DLBMPCCFKKM matchMode, bool isWinPass = false)
	{
	}

	public void SetWinPassPreheatView(DLBMPCCFKKM matchMode, int openSeasonID)
	{
	}

	private void SetUIFXView(bool isWinpass)
	{
	}

	private void ShowNextWinPassReward(DLBMPCCFKKM matchMode)
	{
	}

	private void _003CSetSeasonSwitchView_003Eb__13_0()
	{
	}

	private void _003CSetSeasonSwitchView_003Eb__13_1()
	{
	}

	private void _003CSetWinPassPreheatView_003Eb__14_0()
	{
	}

	private void _003CSetWinPassPreheatView_003Eb__14_1()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
