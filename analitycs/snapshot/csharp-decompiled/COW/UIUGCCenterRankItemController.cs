using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIUGCCenterRankItemController : UIBaseController, UITable2.IUITable2Item, IUIModelDataChangeObserver
{
	private UIUGCCenterRankItemView m_View;

	private UIModelSceneEdit m_Model;

	private WaterfallPoolData m_PoolData;

	private List<UIUGCUnifiedMapSlot1Controller> m_CachedMapItemList;

	private int m_ShownCount;

	private const int MaxPreviewCount = 4;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void SetViewData(WaterfallPoolData poolData)
	{
	}

	private string GetWaterfallLogInfo(int index)
	{
		return null;
	}

	private void OnMoreBtnClick()
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
}
