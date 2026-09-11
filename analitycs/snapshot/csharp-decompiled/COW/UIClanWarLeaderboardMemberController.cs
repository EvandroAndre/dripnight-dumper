using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIClanWarLeaderboardMemberController : UIBaseController
{
	private UIClanWarLeaderboardMemberView m_View;

	private UIModelClan m_ModelClan;

	private List<GameObject> m_RankIconList;

	private ClanMember m_MemberInfo;

	private bool m_IsClanWarMember;

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	private void OnMemberClick()
	{
	}

	public void RefreshClanWarView(GuildWarMemberInfo info, int rank)
	{
	}

	public void RefreshClanWarView(TournamentMemberInfo info, int rank)
	{
	}

	public void RefreshClanActivenessView(ClanMember info, int rank)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
