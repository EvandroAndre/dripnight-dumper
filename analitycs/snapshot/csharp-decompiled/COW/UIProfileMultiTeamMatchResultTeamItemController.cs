using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIProfileMultiTeamMatchResultTeamItemController : UIHudMultiTeamMatchResultTeamItemController
{
	private UIProfileLWMultiMatchResultController m_parentController;

	private List<UIProfileMultiTeamMatchResultPlayerItemController> m_items;

	private static float playerItemHeight;

	private int m_Rank;

	private int m_TeamIndex;

	public int Rank => 0;

	public int TeamIndex => 0;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public void SetParentController(UIProfileLWMultiMatchResultController parentController)
	{
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(List<TeammateStats> teamStats, MatchStats state, ulong mid)
	{
	}

	protected override int SortPlayerData(Transform tr1, Transform tr2)
	{
		return 0;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public int _003C_003EiFixBaseProxy_SortPlayerData(Transform P0, Transform P1)
	{
		return 0;
	}
}
