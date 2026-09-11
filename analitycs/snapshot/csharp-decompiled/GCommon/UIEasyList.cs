using System;
using System.Collections.Generic;
using UnityEngine;

namespace GCommon;

public class UIEasyList : MonoBehaviour
{
	public delegate void OnDataListShowFinished();

	public class UIEasyListFakeItem
	{
		public GameObject FakeItem;

		public int CreateFrameCnt;
	}

	private sealed class _003C_003Ec__DisplayClass44_0
	{
		public UIEasyList _003C_003E4__this;

		public bool Restrictflag;

		public Action onFinished;

		internal void _003CScrollToAnim_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass67_0
	{
		public UIEasyList _003C_003E4__this;

		public int index;

		public bool Restrictflag;

		internal void _003CSelectItem_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass68_0
	{
		public UIEasyList _003C_003E4__this;

		public int index;

		public bool Restrictflag;

		internal void _003CUnSelectItem_003Eb__0()
		{
		}
	}

	public UIScrollView m_ListScrollView;

	public GameObject m_ListContainer;

	public float m_ItemWidth;

	public float m_ItemHeight;

	public int m_Columns;

	private bool m_DisableRefreshWhenInvisible;

	private IEasyList m_EasyListCallBack;

	private UIWrapContentExtend m_WrapContent;

	private List<object> m_DataList;

	private Vector2 m_PanelSize;

	private Vector2 m_ItemSize;

	private UIPanel m_ScrollViewPanel;

	public int m_RealIndexInList;

	private int m_LastIndexClicked;

	private Dictionary<object, int> m_DataWrapIndexDict;

	public OnDataListShowFinished onDataListShowFinished;

	private bool m_ReverseItem;

	private bool m_ReverseData;

	private Queue<UIEasyListFakeItem> m_FakeItems;

	private Action m_OnCreateFinish;

	private UIEasyListItemController[] m_CreatedItemCache;

	private bool m_IsInited;

	private float m_LineCountPerPage;

	protected UIPanel ScrollViewPanel => null;

	public Action OnCreateFinish
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public UIEasyListItemController[] CreatedItemCache => null;

	public int MaxCachedCount => 0;

	public void InitEasyList(IEasyList eastlistCallBack, bool disableRefreshWhenInvisible = false, bool reverseItem = false, bool reverseData = false, bool cullContent = true)
	{
	}

	private bool CheckInitial()
	{
		return false;
	}

	private void OnDragExcessBounds()
	{
	}

	private void PrepareQuickChildControllers(bool createCache = false)
	{
	}

	public bool CreateFinish()
	{
		return false;
	}

	private void Update()
	{
	}

	private void PrepareChildControllers(bool useCache = false, bool useFraming = false, int framingInterval = 1, int framingCreatePerFrame = 1, bool framingCreateInFirstFrame = true)
	{
	}

	private void onWrapInitializeItem(GameObject go, int wrapIndex, int realIndex)
	{
	}

	private UIEasyListItemController GetItemControllerFromCache(GameObject go, int wrapIndex)
	{
		return null;
	}

	public bool ScrollTo(int index, bool Restrictflag = true, float offset = 0f)
	{
		return false;
	}

	public bool ScrollToAnim(int index, float strength = 8f, bool Restrictflag = true, float offset = 0f, Action onFinished = null, float maxDuration = 0f)
	{
		return false;
	}

	public void FinishScrollToAnim(bool Restrictflag = true)
	{
	}

	private float CalculateScrollAnimStrength(float distance, float maxDuration, float fallbackStrength)
	{
		return 0f;
	}

	public bool ScrollToNext(int index, float moveTime = 0.1f)
	{
		return false;
	}

	public void ForceUpdateWrapContent()
	{
	}

	public int GetCurrentRealIndex(out float offset)
	{
		offset = default(float);
		return 0;
	}

	public void ClearAllEasyListItem(bool clearItemCache = false)
	{
	}

	public void ClearFakeItems()
	{
	}

	public void ClearCreatedItemCache()
	{
	}

	public int GetDataListCount()
	{
		return 0;
	}

	public void RefreshEasyListView<DataType>(List<DataType> dataList, int columns = 1, float itemWidth = 0f, float itemHeight = 0f, int defaultScrollIndex = 0, bool resetScroll = true, bool framing = false, int framingInterval = 1, int framingCreatePerFrame = 1, bool framingCreateInFirstFrame = true, bool disableItemAnim = false)
	{
	}

	public void TryPlayItemAnimQueue(bool disableItemAnim = false)
	{
	}

	public void TryIntervalShowItem(UIEasyListIntervalShowHelper intervalHelper, IntervalItemStyle style = IntervalItemStyle.Default, bool newShow = false)
	{
	}

	public void RefreshOnlyData<DataType>(List<DataType> dataList)
	{
	}

	public void RefreshEasyListViewNoClear<DataType>(List<DataType> dataList, int columns = 1, float itemWidth = 0f, float itemHeight = 0f, int defaultScrollIndex = 0, bool resetScroll = true, bool framing = false, int framingInterval = 1, int framingCreatePerFrame = 1, bool framingCreateInFirstFrame = true, bool disableItemAnim = false, bool needRestrictWithinBoundsWhenNotResetScroll = false, bool reactivateAllChildren = false)
	{
	}

	public void RefreshEasyListViewQuickNoClear<DataType>(List<DataType> dataList, int columns = 1, float itemWidth = 0f, float itemHeight = 0f, int defaultScrollIndex = 0, bool resetScroll = true, bool createCache = false)
	{
	}

	private void SetItemsCount(int count, bool resetScroll)
	{
	}

	public object GetItemData(int index)
	{
		return null;
	}

	public T GetItemController<T>(object data, bool needScroll = true, bool Restrictflag = true) where T : UIEasyListItemController
	{
		return null;
	}

	public UIEasyListItemController[] GetItemControllersInCurrentPage()
	{
		return null;
	}

	public UIEasyListItemController GetFirstItemControllerInCurrentPage()
	{
		return null;
	}

	public UIEasyListItemController GetLastItemControllerInCurrentPage()
	{
		return null;
	}

	public T GetItemController<T>(int index, bool needScroll = true, bool Restrictflag = true) where T : UIEasyListItemController
	{
		return null;
	}

	public void SelectItem(int index, bool Restrictflag = true, bool needScroll = true)
	{
	}

	public void UnSelectItem(int index, bool Restrictflag = true)
	{
	}

	public int GetLastIndexClick()
	{
		return 0;
	}

	public void SetLastClickIndex(int click)
	{
	}

	public Transform GetItemTransform(int index, bool needScroll = true)
	{
		return null;
	}

	private void ItemSelectCallBack(int index)
	{
	}

	private void ItemClickCallBack(int index)
	{
	}

	public void GetFirstAndLastItemIdx(out int first, out int last)
	{
		first = default(int);
		last = default(int);
	}

	public void RefreshEasyListViewClear<DataType>(List<DataType> dataList, int columns = 1, float itemWidth = 0f, float itemHeight = 0f, int defaultScrollIndex = 0, bool resetScroll = true, bool framing = false, int framingInterval = 1, int framingCreatePerFrame = 1, bool framingCreateInFirstFrame = true)
	{
	}

	public bool IsItemWholeShow(int index)
	{
		return false;
	}
}
