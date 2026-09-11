using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UILootBoxCustomWndController : UIPopupWindowController, IEasyList
{
	private sealed class _003CResetOptionalMixedScrollNextFrame_003Ed__62 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UILootBoxCustomWndController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CResetOptionalMixedScrollNextFrame_003Ed__62(int _003C_003E1__state)
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

	private UILootBoxCustomWndView m_View;

	private UIModelCollectionCustom m_ModelCollectionCustom;

	private uint m_CollectionId;

	private ELootBoxCustomWndSource m_Source;

	private GameObject m_EnableBg;

	private ResourceID m_InfoVfx;

	private uint m_CloseDelayCallId;

	private const int SelectedWordColumns = 3;

	private const float SelectedWordItemWidth = 200f;

	private const float SelectedWordItemHeight = 60f;

	private const int OptionalWordColumns = 5;

	private const float OptionalWordItemWidth = 140f;

	private const float OptionalWordItemHeight = 80f;

	private const float OptionalTableEmoteItemHorizontalGap = 10f;

	private bool m_IsSaveBtnEnabled;

	private Action m_CloseCallback;

	private uint[] m_DefaultSortIdOrders;

	private List<UILootBoxCustomSelectedWordSlotData> m_SelectedWordSlotDataList;

	private Dictionary<uint, UILootBoxCustomItemData> m_OptionalWordDataDict;

	private int m_SelectedWordItemIndex;

	private bool m_UseExperimentalOptionalScroll;

	private Coroutine m_ResetOptionalMixedScrollCoroutine;

	private float m_ExperimentalOptionalEmoteItemWidth;

	private float m_ExperimentalOptionalEmoteItemHeight;

	private bool m_IsConfirmProcessing;

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

	private void OnCloseButtonClick()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void OnConfirmButtonClick()
	{
	}

	private void ScheduleCloseAfterConfirm()
	{
	}

	private void CancelCloseDelayCall()
	{
	}

	public void SetCollectionID(uint collectionId, ELootBoxCustomWndSource source, Action closeCallback = null)
	{
	}

	private bool IsCurrentCollectionOwned()
	{
		return false;
	}

	private string GetLocalCustomData()
	{
		return null;
	}

	private void SaveLocalCustomData(string customData, List<ItemCollectionCustomLog> customContent)
	{
	}

	private bool IsCurrentSortIdOrderDefault(List<uint> selectedSortIdList)
	{
		return false;
	}

	public void InitEasyList()
	{
	}

	public void RefreshView()
	{
	}

	private void BuildSelectedWordData(uint[] sortIdOrders)
	{
	}

	private void BuildOptionalWordData(uint[] sortIdOrders)
	{
	}

	private void RefreshSelectedWordEasyListView()
	{
	}

	private void CollectOptionalItemDataLists(List<UILootBoxCustomItemData> optionalWordDataList, List<UILootBoxCustomItemData> optionalEmoteDataList)
	{
	}

	private void RefreshSlotsCounter()
	{
	}

	private void OnClearButtonClick()
	{
	}

	private void RefreshSelectedWordItemControllers()
	{
	}

	private void RefreshWordSelectionRelatedViews()
	{
	}

	private void RefreshOptionalTable2View(bool resetScroll)
	{
	}

	private int GetSelectedWordCount()
	{
		return 0;
	}

	public bool IsSelectedWordSlotsFull()
	{
		return false;
	}

	private void ClearSelectedWordSlotData()
	{
	}

	private bool TryAddSelectedWord(UILootBoxCustomItemData itemData, out int selectedIndex)
	{
		selectedIndex = default(int);
		return false;
	}

	private bool TryReplaceSelectedWord(UILootBoxCustomItemData itemData, out int selectedIndex)
	{
		selectedIndex = default(int);
		return false;
	}

	private bool HasSelectedWordItemForReplacement()
	{
		return false;
	}

	private bool IsSelectedWordItemSelectable(int index)
	{
		return false;
	}

	private void UpdateOptionalWordItemIndexes()
	{
	}

	private List<int> GetOptionalWordIndexsList(uint sortID)
	{
		return null;
	}

	private void InitExperimentalOptionalEasyList()
	{
	}

	private UITable2.IUITable2Item CreateOptionalTableWordItem()
	{
		return null;
	}

	private UITable2.IUITable2Item CreateOptionalTableEmoteItem()
	{
		return null;
	}

	private void DelayResetOptionalMixedScrollPosition()
	{
	}

	private IEnumerator ResetOptionalMixedScrollNextFrame()
	{
		return null;
	}

	private void InitSelectedWordEasyList()
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public void OnOptionalWordItemClicked(UILootBoxCustomItemData itemData)
	{
	}

	public void OnSelectedWordItemClicked(int index)
	{
	}

	private void SelectSelectedWordItem(int index)
	{
	}

	private void ClearSelectedWordItemSelection()
	{
	}

	private int GetLastSelectedWordItemIndex()
	{
		return 0;
	}

	public void OnSelectedWordItemRemoved(int index)
	{
	}

	private UILootBoxCustomSelectedWordSlotData CreateEmptySelectedWordSlotData()
	{
		return null;
	}

	private void _003CScheduleCloseAfterConfirm_003Eb__31_0()
	{
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
