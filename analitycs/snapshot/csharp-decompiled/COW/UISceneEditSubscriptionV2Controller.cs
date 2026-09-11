using System;
using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UISceneEditSubscriptionV2Controller : UIPopupWindowController, IUIModelDataChangeObserver
{
	private enum SortFilterType
	{
		NumberOfPlays,
		SubscribeTime,
		UpdateTime
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<SceneEditSlotInfo, UISceneEditSubscriptionV2Item> _003C_003E9__23_1;

		internal UISceneEditSubscriptionV2Item _003CRefreshUI_003Eb__23_1(SceneEditSlotInfo temp)
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass23_0
	{
		public List<WorkshopHistoryInfo> historyInfo;

		public UISceneEditSubscriptionV2Controller _003C_003E4__this;

		internal UISceneEditSubscriptionV2Item _003CRefreshUI_003Eb__2(SceneEditSlotInfo temp)
		{
			return null;
		}
	}

	private UISceneEditSubscriptionV2View m_View;

	private UIModelSceneEdit m_Model;

	private List<UISceneEditSubscriptionV2ItemController> m_CachedSubscriptionList;

	private string m_Code;

	private Action m_OnCloseCB;

	private EUGCScene m_Source;

	private int m_IsDescendOrder;

	private SortFilterType m_SortFilterType;

	private uint m_SelectedSlotID;

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

	protected override void OnUIDestroy()
	{
	}

	protected override void OnUIClose()
	{
	}

	public void SetCode(string code, EUGCScene source, Action onCloseCB = null)
	{
	}

	private void SetOverWirteState(bool state)
	{
	}

	private void OnSortTypeFilterBtnClick(UIToggleButton selectButton)
	{
	}

	private void OnSortDireFilterBtnClick()
	{
	}

	private void OnItemSelected(object[] data)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private uint GetRecentlyPlayTimes(List<WorkshopHistoryInfo> historyInfo, UISceneEditSubscriptionV2Item itemInfo)
	{
		return 0u;
	}

	private void RefreshUI()
	{
	}

	private void OnOverwriteBtnClick()
	{
	}

	private void OnSelectedClick()
	{
	}

	private void OnCannelClick()
	{
	}

	private int OnSortByNumberOfPlays(UISceneEditSubscriptionV2Item a, UISceneEditSubscriptionV2Item b)
	{
		return 0;
	}

	private int OnSortBySubscribeTime(UISceneEditSubscriptionV2Item a, UISceneEditSubscriptionV2Item b)
	{
		return 0;
	}

	private int OnSortByUpdateTime(UISceneEditSubscriptionV2Item a, UISceneEditSubscriptionV2Item b)
	{
		return 0;
	}

	public string GetTimeAgo(ulong timestamp, ulong currentTime)
	{
		return null;
	}

	private UISceneEditSubscriptionV2Item _003CRefreshUI_003Eb__23_0(SceneEditSlotInfo temp)
	{
		return null;
	}

	private bool _003COnSelectedClick_003Eb__25_0(SceneEditSlotInfo temp)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
