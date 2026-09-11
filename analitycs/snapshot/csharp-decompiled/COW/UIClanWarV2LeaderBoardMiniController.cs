using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIClanWarV2LeaderBoardMiniController : UIBaseController, IUIModelDataChangeObserver
{
	private UIClanWarV2LeaderboardMiniView m_View;

	private UIModelClanWarV2 m_ModelWar;

	private List<UIClanWarLeaderboardMemberController> m_MemberList;

	private const int MAX_COUNT = 3;

	private UIModelClan m_ModelClan;

	private bool m_HasLeaderBoardData;

	public bool IfClanWarChampionshipEliminatorSettlement;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void RefreshMembers()
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public void CloseTitleArea()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
