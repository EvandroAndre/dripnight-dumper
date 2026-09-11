using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UICupMatchReviewRewardWndController : UIPopupWindowController, IUIModelDataChangeObserver
{
	private UICupMatchReviewRewardWndView m_View;

	private UIModelCupMatch m_ModelCupMatch;

	private int m_CupMatchKey;

	private uint m_CupMatchType;

	private uint m_CupMatchID;

	private List<GameObject> LeftRewards;

	private List<GameObject> RightRewards;

	private List<GameObject> CenterRewards;

	private CupSettingDesc m_CupSettingDesc;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetData(int key)
	{
	}

	private void RefreshView()
	{
	}

	private void RefreshChampionReward(List<GameObject> rewards, bool isTicket)
	{
	}

	private void OnToggleChange()
	{
	}

	private void RefreshUseLabel(bool use)
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
