using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIClanWarChampionshipMathPoolController : UIPopupWindowController, IEasyList, IUIModelDataChangeObserver
{
	private UIClanWarChampionshipMathPoolView m_View;

	private UIModelClanWarChampionship m_ModelClanWarChampionship;

	private UIModelClanWarV2 m_ModelClanWarV2;

	private UIModelLeaderBoard m_ModelLeaderBoard;

	private List<LeaderBoardInfo> m_Data;

	private uint m_SeasonId;

	private ClanWarChampionshipStage m_Stage;

	private LeaderBoardIDV2 m_BoardV2;

	private UIClanWarChampionshipGuildItemController m_Self;

	private UIClickMask m_ClickMask;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override bool UseCustomizedAnimation()
	{
		return false;
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	public void RefreshView()
	{
	}

	public void ShowClanBriefBox(ClanInfo info)
	{
	}

	private void OnCloseBtnClick()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
