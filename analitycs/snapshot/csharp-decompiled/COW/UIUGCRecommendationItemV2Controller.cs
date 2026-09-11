using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIUGCRecommendationItemV2Controller : UIBaseController, UITable2.IUITable2Item
{
	private UIUGCRecommendationItemV2View m_View;

	private UIModelSceneEdit m_Model;

	private List<UIUGCUnifiedMapSlot1Controller> m_CachedMapItemList;

	private uint m_SourceMapPoolType;

	private ERecommendationType m_Type;

	private EUGCScene m_LogFromScene;

	private uint m_Id;

	private int m_DisplayCount;

	private int m_DisplayNum;

	private string m_DefaultSeriesName;

	public List<UIUGCUnifiedMapSlot1Controller> CachedMapItemList => null;

	public uint SeriesID => 0u;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetDescriptionData(WorkshopRecommendSeriesDesc desc)
	{
	}

	public void SetViewData(List<SceneEditSlotInfo> data)
	{
	}

	private void SetTitleIcon(string name)
	{
	}

	private void OnMoreBtnClick()
	{
	}

	private static bool IsLeaderboardPool(uint poolType)
	{
		return false;
	}

	private int GetLeaderboardConfigIdByPoolType(uint poolType)
	{
		return 0;
	}

	public Vector2 GetItemLocalPosition(Transform itemTransform)
	{
		return default(Vector2);
	}

	public void Reposition()
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

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
