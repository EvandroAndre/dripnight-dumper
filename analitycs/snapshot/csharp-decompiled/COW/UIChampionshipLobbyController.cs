using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIChampionshipLobbyController : UINavigationController
{
	private UIChampionshipLobbyView m_View;

	private UIModelChampionship m_ModelChampionship;

	private UIModelCupMatch m_ModelCupMatch;

	private AutoPopup m_AutoPopup;

	private List<UIOnlineMatchEntranceItemController> m_EntranceList;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected void Update()
	{
	}

	public void RefreshUI()
	{
	}

	private int SortEntranceItem(UIOnlineMatchEntranceItemController a, UIOnlineMatchEntranceItemController b)
	{
		return 0;
	}

	private int SortEntranceItem(Transform a, Transform b)
	{
		return 0;
	}

	private void CreateChampionshipEntrance()
	{
	}

	private void CreateCupMatchEntrance()
	{
	}

	public void OnEntranceItemShowDetail(bool forward, int index)
	{
	}

	private void OnGridReposition()
	{
	}

	public int GetEntranceCount()
	{
		return 0;
	}

	protected void OnRuleButtonClick()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}
}
