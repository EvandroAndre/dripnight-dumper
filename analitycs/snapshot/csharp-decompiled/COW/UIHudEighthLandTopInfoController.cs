using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using message;

namespace COW;

public class UIHudEighthLandTopInfoController : UIBaseController
{
	public const uint VISIBILITY_AfterLandWelcomeOrGetReward = 1073741824u;

	public const uint VISIBILITY_STATE_Hide_All = 536870912u;

	public const uint VISIBILITY_STATE_MatchEnd_Hide = 268435456u;

	private int Const_MaxMemberCount;

	private int m_CurTeamMemberCount;

	private UIHudEighthLandTopInfoView m_View;

	private List<UIHudCSPlayerStateInfoView> m_MyTeamViews;

	private List<UIHudCSPlayerStateInfoView> m_OppoTeamViews;

	private Dictionary<BHGGAEEHJCO, CMEBHBDFONJ> m_JoinPlayerStateMap;

	private UITimeLabelHelper m_PhaseTimeLabelHelper;

	private CNMBPAKNBME m_CurPhase;

	private List<int> m_MyTeamStates;

	private List<int> m_OppoTeamStates;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void RegistEvent()
	{
	}

	private void OnPlayerDead(object[] data)
	{
	}

	private void OnPlayerQuit(object[] data)
	{
	}

	private void OnPlayerKnockDown(object[] data)
	{
	}

	public void InitShowData(uint infiniteItem, int oneSideMemberMaxCount)
	{
	}

	private void OnPlayerJoin(object[] data)
	{
	}

	private void RefreshPlayerStateView()
	{
	}

	private void SetLeftStatesUI(List<UIHudCSPlayerStateInfoView> views, List<int> states)
	{
	}

	private void SetRightStatesUI(List<UIHudCSPlayerStateInfoView> views, List<int> states)
	{
	}

	private void OnPhaseChange(object[] data)
	{
	}

	private void Update()
	{
	}

	protected override void OnUIActiveGroupSwitch(UInt128 activeGroup)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIActiveGroupSwitch(UInt128 P0)
	{
	}
}
