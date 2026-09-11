using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIUGCUnifiedMapSlot1Controller : UIUGCUnifiedMapSlotBaseController, UITable2.IUITable2Item, IUIModelDataChangeObserver
{
	private UIUGCUnifiedMapSlot1View m_View;

	private int m_GameModeLabelMaxWidth;

	private int m_GameModePadding;

	private WaterfallValidData m_ValidData;

	private uint m_PoolType;

	private int m_RankIndex;

	private static readonly Dictionary<int, string> TopSpriteMap;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnSlotInit()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public WaterfallValidData GetValidData()
	{
		return null;
	}

	public void SetValidData(WaterfallValidData data)
	{
	}

	public void SetMapContainerSize(int width, int height)
	{
	}

	private void ShowLoadingState(bool show)
	{
	}

	private void UpdateMapContainerAnchors()
	{
	}

	private bool TopNeedShow()
	{
		return false;
	}

	private void ShowTop()
	{
	}

	private static bool IsLeaderboardPool(uint poolType)
	{
		return false;
	}

	public string GetWorkshopCode()
	{
		return null;
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

	public void ShowHighlightState()
	{
	}

	private void _003COnSlotInit_003Eb__8_0()
	{
	}

	private void _003COnSlotInit_003Eb__8_1()
	{
	}

	private void _003COnSlotInit_003Eb__8_2()
	{
	}

	private void _003COnSlotInit_003Eb__8_3()
	{
	}

	private void _003COnSlotInit_003Eb__8_4()
	{
	}

	private void _003COnSlotInit_003Eb__8_5()
	{
	}

	private void _003COnSlotInit_003Eb__8_6()
	{
	}

	private void _003COnSlotInit_003Eb__8_7()
	{
	}

	private bool _003COnSlotInit_003Eb__8_8()
	{
		return false;
	}

	private void _003COnSlotInit_003Eb__8_9()
	{
	}

	private void _003COnSlotInit_003Eb__8_10()
	{
	}

	private bool _003COnSlotInit_003Eb__8_11()
	{
		return false;
	}

	private void _003COnSlotInit_003Eb__8_12()
	{
	}

	private void _003COnSlotInit_003Eb__8_13()
	{
	}

	private bool _003COnSlotInit_003Eb__8_14()
	{
		return false;
	}

	private void _003COnSlotInit_003Eb__8_15()
	{
	}

	private void _003COnSlotInit_003Eb__8_16()
	{
	}

	public void _003C_003EiFixBaseProxy_OnSlotInit()
	{
	}
}
