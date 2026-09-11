using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIUGCNewPlayerRecommendationItemController : UIBaseController, UITable2.IUITable2Item
{
	private UIUGCNewPlayerRecommendationItemView m_View;

	private UIModelNewPlayerRecommendation m_Model;

	private List<UIUGCUnifiedMapSlot1Controller> m_CachedMapItemList;

	private bool m_IsInitialized;

	private uint m_DisplayCount;

	private int m_DisplayNum;

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

	public void CheckExposure(UITable2 table, Vector2 size)
	{
	}

	private Vector2 GetItemLocalPosition(Transform itemTransform)
	{
		return default(Vector2);
	}

	public void RefreshNewPlayerRecommendation()
	{
	}

	private void RefreshMapItems(List<SceneEditSlotInfo> dataList)
	{
	}

	private void OnShowTutorial(bool openMoreGuide = true)
	{
	}

	private void OnShowMoreGuideEvent()
	{
	}

	private void OnShowMoreGuideFinished()
	{
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

	private void _003COnUIInit_003Eb__7_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
