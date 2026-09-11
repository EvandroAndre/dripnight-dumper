using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIChampionshipReviewRewardItemController : UIEasyListItemController
{
	private UIChampionshipReviewRewardItemView m_View;

	private ChampionshipScoreRewardDesc m_AwardData;

	private List<UIStandardItemMiniController> m_RewardCtrlCache;

	private Dictionary<uint, string> m_CupIconDict;

	private Dictionary<uint, GameObject> m_BGDict;

	private UIModelChampionship m_ModelChampionship;

	private uint m_ChampionshipType;

	private ChampionshipSettingDesc m_ChampionshipSetting;

	private uint m_LocalSize;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	private void RefreshView()
	{
	}

	private void RefreshRewardList()
	{
	}

	private void RefreshLevel()
	{
	}

	private void HighLightBg()
	{
	}

	private void HideUI()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
