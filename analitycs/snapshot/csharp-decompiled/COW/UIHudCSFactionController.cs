using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using proto;

namespace COW;

internal class UIHudCSFactionController : UIBaseController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<int> _003C_003E9__14_1;

		internal int _003CCalculateWeightedCSPeakPoints_003Eb__14_1(int a, int b)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass14_0
	{
		public List<int> playerPoints;

		internal bool _003CCalculateWeightedCSPeakPoints_003Eb__0(CSPeakPreTeamPointDesc x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass16_0
	{
		public int localODFactionId;

		internal void _003CSetODFaction_003Eb__0()
		{
		}
	}

	private UIHudCSFactionView m_View;

	private uint m_DelayCallId;

	private uint m_DelayCallIdShow;

	private bool m_IsSetSelfTeamInfo;

	private bool m_IsSetOppoTeamInfo;

	private int m_LocalPlayerTeamId;

	private int m_OppoPlayerTeamId;

	private UIModelClanWarV2 m_ModelClanWarV2;

	private bool mLocalPlayerJoined;

	private bool mLoadingMaskClosed;

	private bool mCupMatchIntroFinish;

	private bool mFPPCSIntroFinish;

	private VisualInstanceHolder m_SurpriseShopContainer;

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

	private void SetUIData()
	{
	}

	private void RefreshCSPeak()
	{
	}

	private void RefreshCSPeakAVGPoints()
	{
	}

	private int CalculateWeightedCSPeakPoints(List<int> playerPoints, UIModelCSPeakTournamentLadderMatch modelCSPeakTournament)
	{
		return 0;
	}

	private void RefreshClanUIInfo(Player player)
	{
	}

	private void SetODFaction(int localODFactionId, bool updateByFactionChange)
	{
	}

	private bool IsFactionChangeRound()
	{
		return false;
	}

	private void OnODFactionChanged(object[] data)
	{
	}

	private void OnLocalPlayerJoin(object[] data)
	{
	}

	private void OnPlayerJoin(GEvent data)
	{
	}

	private void OnCSPeakAVGNotify(object[] data)
	{
	}

	private void OnLoadingMaskClosed(object[] data)
	{
	}

	private void OnCupMatchIntroFinish(object[] data)
	{
	}

	private void OnFPPCSMatchIntroFinish()
	{
	}

	private void CheckStartDelayShow()
	{
	}

	private bool CheckGameModeShowCSFaction()
	{
		return false;
	}

	private void OnPhaseChanged(object[] data)
	{
	}

	private void ShowAndPlaySound()
	{
	}

	private void OnSurpriseShopStateChanged(bool show)
	{
	}

	private void RefreshSurpriseShop(bool show)
	{
	}

	private bool IsTeamOnLeft(BHGGAEEHJCO pId)
	{
		return false;
	}

	private void RefreshUISkinChange()
	{
	}

	private void OnPlayerFFWSFlagChange(object[] data)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
