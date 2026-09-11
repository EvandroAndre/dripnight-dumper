using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UILobbyV2GameAssistantSquadTreasureItemController : UILobbyV2GameAssistNormalItemController
{
	private UILobbyV2GameAssistantSquadTreasureItemView m_View;

	private AssistSquadTreasureInfo m_Info;

	private TopUpTeamInvitation m_TopUpTeam;

	private UIModelSquadTreasure m_ModelSquadTreasure;

	private UIModelFriends m_ModelFriends;

	private List<GameObject> m_ItemList;

	private List<GameObject> m_ItemActiveList;

	private List<GameObject> m_ItemUnactiveList;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void SetViewData(object data, int index)
	{
	}

	private void RefreshInfo()
	{
	}

	private void RefreshProgress()
	{
	}

	private void OnBtnCancelClick()
	{
	}

	private void OnBtnAcceptClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_SetViewData(object P0, int P1)
	{
	}
}
