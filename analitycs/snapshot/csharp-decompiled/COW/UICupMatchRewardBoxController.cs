using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UICupMatchRewardBoxController : UIBaseController, IUIModelDataChangeObserver
{
	private UICupMatchRewardBoxView m_View;

	private List<Transform> m_ResultTrans;

	private List<CupMatchRewardBoxResultItem> m_ResultItems;

	private UIModelCupMatch m_ModelCupMatch;

	private uint m_CupMatchType;

	private uint m_CupMatchID;

	private int m_CupMatchKey;

	private CupChestDesc m_CacheReward;

	private bool m_CanShowReward;

	private List<GameObject> m_BoxEffects;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void Init(int key, bool top, bool showReward = true)
	{
	}

	public void RefreshBox()
	{
	}

	private void RefreshBoxState()
	{
	}

	private void CreateResultItem()
	{
	}

	private void UpdateResultItem()
	{
	}

	private void OnRewardClick()
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
