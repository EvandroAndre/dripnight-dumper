using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIActivityPopWindowBase : UINaviPopController
{
	private class GoToArgs
	{
		public int categoryType;

		public uint id;
	}

	protected delegate UIActivityBaseController ContentCreator();

	protected class CategoryTabData
	{
		public ContentCreator content;

		public string title;

		public string icon;

		public ETipsType redPoint;

		public object data;

		public string colorValue;

		public string selectLine;

		public uint prioritySelectItemID;

		public int optActivityCategory;

		public uint sort_id;

		public string iconCdnUrl;

		public string selectBgCdnUrl;

		public uint SortIdRedTips;

		public uint table_type;

		public ulong start_time;

		public uint event_id;
	}

	private sealed class _003C_003Ec__DisplayClass29_0
	{
		public int categoryType;

		internal bool _003CGotoSpecificCategory_003Eb__0(CategoryTabData e)
		{
			return false;
		}
	}

	private UIActivityMasterView m_View;

	private Dictionary<int, UIActivityBaseController> m_Contents;

	private int m_CurrentTabIndex;

	protected Dictionary<uint, int> m_TabTypeActivityCategoryMap;

	public static ResourceID m_UIResourceID;

	protected float m_RequestTimeout;

	protected int m_CurrentType;

	private int m_TabSpace;

	protected List<CategoryTabData> m_CategoryDatas;

	private GoToArgs m_GoToArgs;

	private string _003CCurrentCategoryTitle_003Ek__BackingField;

	private List<StandardTopTabItemViewData> m_TabDataList;

	private UIStandardTopTabController m_TabCtrl;

	public string CurrentCategoryTitle
	{
		get
		{
			return _003CCurrentCategoryTitle_003Ek__BackingField;
		}
		private set
		{
			_003CCurrentCategoryTitle_003Ek__BackingField = value;
		}
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected Transform ContentMountPoint()
	{
		return null;
	}

	public virtual void UpdateUI()
	{
	}

	public virtual void UpdateUIByRefresh()
	{
	}

	public virtual void PrepareTopTabData()
	{
	}

	private void CreateTopTabs(bool isRefresh = false)
	{
	}

	protected virtual int GetDefaultTabIndex()
	{
		return 0;
	}

	public void UpdateTabs()
	{
	}

	protected CategoryTabData GetCurCategoryData()
	{
		return null;
	}

	public void GotoSpecificCategory(int categoryType, uint id, bool needScroll = true)
	{
	}

	public void GotoSpecificTCategoryByTabType(uint tabTabType, uint id)
	{
	}

	private void TopTabSelected(int index)
	{
	}

	protected virtual void OnMainTabSelect(CategoryTabData data)
	{
	}

	private void HideCurrentContent()
	{
	}

	protected UIActivityBaseController GetCurrentContent()
	{
		return null;
	}

	private bool IsCategoryDailyFirstOpen()
	{
		return false;
	}

	private void SaveCategoryDailyFirstOpen()
	{
	}

	private bool HasCategoryTabTips()
	{
		return false;
	}

	private void ShowHighestPriorityTab()
	{
	}

	protected virtual int GetTabPriority(CategoryTabData tabData)
	{
		return 0;
	}

	private void OnActivityGotoClick(object[] data)
	{
	}

	public int TabType2ActivityCategory(uint tabType)
	{
		return 0;
	}

	public uint ActivityCategory2TabType(int category)
	{
		return 0u;
	}

	protected override void OnVisibilityChanged()
	{
	}

	protected override void OnPopupWindowListChange()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnPopupWindowListChange()
	{
	}
}
