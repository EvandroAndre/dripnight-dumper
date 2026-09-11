using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIPaymentSquadTreasureTeamListItemController : UIBaseController, UITable2.IUITable2Item
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<TopUpMember> _003C_003E9__11_0;

		internal int _003CRefreshTeamList_003Eb__11_0(TopUpMember a, TopUpMember b)
		{
			return 0;
		}
	}

	private UIPaymentSquadTreasureTeamListItemView m_View;

	private RecommendTopUpTeam m_Info;

	private UIModelSquadTreasure m_ModelSquadTreasure;

	private List<UIPaymentSquadTreasureTeammateItemSmallController> m_TeammateItemSmallList;

	private const int TEAMMATE_ITEM_DEPTH = 25;

	private ESquadTreasureTeamListType m_ListType;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetUIData(RecommendTopUpTeam info, ESquadTreasureTeamListType listType)
	{
	}

	private void InitSmallTemplate()
	{
	}

	private void RefreshInfo()
	{
	}

	private void RefreshTeamList()
	{
	}

	private void RefreshJoinAgainButton()
	{
	}

	private void OnBtnClick()
	{
	}

	private void OnBtnJoinAgainClick()
	{
	}

	public void JoinCurrentTeam()
	{
	}

	public object SetTable2ItemData(int index, object data, object viewState)
	{
		return null;
	}

	public void SetPosition(Vector2 position)
	{
	}

	public void SetTable2Visible(bool visible)
	{
	}

	private bool _003CRefreshInfo_003Eb__10_0(TopUpMember x)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
