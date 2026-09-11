using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UICSPeakTournamentInvitationController : UIPopupWindowController
{
	private UICSPeakTournamentInvitationView m_View;

	private UICSPeakTournamentRankIconController m_UICSPeakTournamentRankIconController;

	private GameObject m_SquadRecruitAvailableGO;

	private uint m_DelayCall;

	private List<UISprite> m_RewardSprites;

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

	private void SetViewData()
	{
	}

	private void OnReadyBtnClick()
	{
	}

	private void OnGoMatchBtnClick()
	{
	}

	private void OnCloseBtnClick()
	{
	}

	private void _003COnReadyBtnClick_003Eb__9_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
