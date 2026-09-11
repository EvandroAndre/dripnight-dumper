using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudMultiTeamMatchResultTeamItemController : UIEasyListItemController
{
	protected UIHudLWMultiMatchResultTeamItemView m_View;

	private UIHudMultiTeamMatchResultController m_parentController;

	private List<UIHudMultiTeamMatchResultPlayerItemController> m_items;

	private static float playerItemHeight;

	private GameObject[] m_RankIcons;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	internal void SetParentController(UIHudMultiTeamMatchResultController parentController)
	{
	}

	protected override void OnUIInit()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	public static int CalculateContainerHeight(int numOfPlayerItem, int offy)
	{
		return 0;
	}

	protected virtual int SortPlayerData(Transform tr1, Transform tr2)
	{
		return 0;
	}

	protected void SetRank(uint rank)
	{
	}

	protected void SetTeamID(int teamIndex)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
