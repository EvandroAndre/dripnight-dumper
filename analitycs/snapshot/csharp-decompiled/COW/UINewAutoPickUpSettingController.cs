using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UINewAutoPickUpSettingController : UISettingContentBase, ICommonSettingDragParent
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<CSVBaseData, AutoPickupMappingConfigData> _003C_003E9__36_0;

		internal AutoPickupMappingConfigData _003CBuildNotInGameSettingGroupTitleGrid_003Eb__36_0(CSVBaseData data)
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass29_0
	{
		public AutoPickupConfigData configData;

		internal void _003CCreateAutoPickupSpeedSetBtnGroup_003Eb__1()
		{
		}

		internal void _003CCreateAutoPickupSpeedSetBtnGroup_003Eb__2()
		{
		}

		internal int _003CCreateAutoPickupSpeedSetBtnGroup_003Eb__0()
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass30_0
	{
		public AutoPickupConfigData configData;

		public UINewAutoPickUpSettingController _003C_003E4__this;

		internal void _003CCreateAutoPickupItemToggleBtnGroup_003Eb__1()
		{
		}

		internal void _003CCreateAutoPickupItemToggleBtnGroup_003Eb__2()
		{
		}

		internal int _003CCreateAutoPickupItemToggleBtnGroup_003Eb__0()
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass31_0
	{
		public AutoPickupConfigData configData;

		internal void _003CCreateAutoPickupSliderItem_003Eb__0(float x)
		{
		}

		internal float _003CCreateAutoPickupSliderItem_003Eb__1()
		{
			return 0f;
		}

		internal float _003CCreateAutoPickupSliderItem_003Eb__2()
		{
			return 0f;
		}

		internal float _003CCreateAutoPickupSliderItem_003Eb__3()
		{
			return 0f;
		}
	}

	private sealed class _003CAutoScrollCo_003Ed__71 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UINewAutoPickUpSettingController _003C_003E4__this;

		public int value;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CAutoScrollCo_003Ed__71(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CDelayRefreshScrollView_003Ed__39 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UINewAutoPickUpSettingController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDelayRefreshScrollView_003Ed__39(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CRepositionMenuLayout_003Ed__46 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UINewAutoPickUpSettingController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CRepositionMenuLayout_003Ed__46(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private const string FAST_AUTO_PICKUP_KEY = "T_21_C_AUTOPICKUP_FAST";

	private const string DEFAULT_AUTO_PICKUP_KEY = "T_21_C_AUTOPICKUP_AVERAGE";

	private const string AUTO_PICKUP_ITEM_CLOSE_LABEL_KEY = "TXT_SETTING_CLOSE";

	private const string AUTO_PICKUP_ITEM_OPEN_LABEL_KEY = "TXT_SETTING_OPEN";

	private static readonly List<string> ShowTipsParam;

	private int m_CurrentTypeID;

	private Coroutine m_RefreshScrollViewCoroutine;

	private Coroutine m_RefreshMenuLayoutCoroutine;

	private Coroutine m_ExchangePriorityAndRefreshCoroutine;

	private UINewAutoPickUpSettingView m_View;

	private UICommonSettingContentController m_CommonSettingContentController;

	private UICommonSettingDragableItemController m_DragableItemCtrl;

	private UICommonSettingDragableSliderItemController m_DragableSliderItemCtrl;

	private UICommonSettingItemController m_PickupSpeedCtrl;

	private UITutorialIndicatorHandController m_DragGuide;

	private const string DRAG_GUIDE = "DRAGGUIDE_{0}";

	private readonly List<UIBaseController> m_PriorityActiveItemControllers;

	private readonly List<UICommonSettingDragableItemController> m_DragItemCtrls;

	private readonly List<UIBaseController> m_PriorityFreezeItemControllers;

	private UIHudPopupController m_SelfManagedPopupController;

	private readonly Dictionary<UIToggleButton, int> m_ToggleTypeIDMap;

	private Coroutine m_AutoScrollCo;

	private float DragScrollDelta;

	private uint m_DragItemId;

	private uint m_SliderItemId;

	private uint m_DragingId;

	private bool m_InsertUppon;

	private SettingDragItemType m_DragingType;

	private bool IsInGame => false;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	public override void RefreshContent(object[] param)
	{
	}

	private void TryShowGuide()
	{
	}

	private static CommonSettingItemDataToggleBtns CreateAutoPickupSpeedSetBtnGroup(AutoPickupConfigData configData)
	{
		return null;
	}

	private CommonSettingItemDataToggleBtns CreateAutoPickupItemToggleBtnGroup(AutoPickupConfigData configData)
	{
		return null;
	}

	private static CommonSettingDragableSliderItemData CreateAutoPickupSliderItem(AutoPickupConfigData configData)
	{
		return null;
	}

	private CommonSettingDragableItemData CreateDragDropItemViewData(AutoPickupConfigData configData)
	{
		return null;
	}

	private static void TransferPlayerPrefsVersion()
	{
	}

	private static void SetTitleToggleBtnText(UIToggleButton toggleButton, string text)
	{
	}

	private bool BuildInGameSettingGroupTitleGrid()
	{
		return false;
	}

	private bool BuildNotInGameSettingGroupTitleGrid()
	{
		return false;
	}

	private bool BuildSettingGroupTitleGrid()
	{
		return false;
	}

	private void ResetScrollViewState()
	{
	}

	private IEnumerator DelayRefreshScrollView()
	{
		return null;
	}

	private void OnDisplayContentChanged()
	{
	}

	private void CloseAllContent()
	{
	}

	private int DisplayPriorityActiveSettingContent()
	{
		return 0;
	}

	private int DisplayPriorityFreezeSettingContent()
	{
		return 0;
	}

	private void DisplaySettingContent(bool repositionAll = true)
	{
	}

	public void OnMenuItemLayoutChanged()
	{
	}

	private IEnumerator RepositionMenuLayout()
	{
		return null;
	}

	public void OnPrioritySettingItemInsert()
	{
	}

	private void AddEventDelegates()
	{
	}

	private void OnSettingTypeTitleSelect(UIToggleButton button)
	{
	}

	private void OnResetConfirmed()
	{
	}

	public override void ResetToDefault()
	{
	}

	private void OnSettingTypeHelpBtn()
	{
	}

	public void OnItemDragStart(uint itemId, uint itemFromWhere)
	{
	}

	private void CloseSubItems()
	{
	}

	public void OnItemDragRelease()
	{
	}

	public void OnItemDragMove(Vector3 pos)
	{
	}

	private void UpdateInsertUpponValue(UIBaseController ctrl, UIBaseController dragingCtrl)
	{
	}

	private void ShowDragItem(bool show)
	{
	}

	private void ShowDragSliderItem(bool show)
	{
	}

	public GameObject GetDragItem(uint itemid)
	{
		return null;
	}

	public UIWidget GetDragBounds(uint itemId, uint itemType)
	{
		return null;
	}

	public void OnItemDragHover(int index)
	{
	}

	private void TryStartAutoScroll(int index)
	{
	}

	private IEnumerator AutoScrollCo(int value)
	{
		return null;
	}

	private void ResetDragingCacheValue()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshContent(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_ResetToDefault()
	{
	}
}
