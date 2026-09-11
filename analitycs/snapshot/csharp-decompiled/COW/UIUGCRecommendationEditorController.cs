using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIUGCRecommendationEditorController : UIBaseController, UITable2.IUITable2Item
{
	public class SideRecItem
	{
		public int Index;

		public GameObject CDNGo;

		public UINetworkTexture CDN;

		public UIButton Button;

		public GameObject DotGo;

		public UISprite DotSprite;

		public GameObject HotGo;

		public UIUGCHotIndicatorController hotCtrl;

		public WorkshopBasicInfo WorkshopInfo;

		public string FromInfo;

		public bool IsExposureRequested;

		public bool IsExposed;
	}

	public class MainSideRecItem
	{
		public int Index;

		public UIUGCMainSideRecItemController Controller;

		public GameObject DotGo;

		public UISprite DotSprite;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<WorkshopEditorChoiceDesc> _003C_003E9__24_0;

		public static Comparison<WorkshopEditorChoiceDesc> _003C_003E9__24_1;

		internal int _003CRefreshEditorChoiceInfo_003Eb__24_0(WorkshopEditorChoiceDesc a, WorkshopEditorChoiceDesc b)
		{
			return 0;
		}

		internal int _003CRefreshEditorChoiceInfo_003Eb__24_1(WorkshopEditorChoiceDesc a, WorkshopEditorChoiceDesc b)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass20_0
	{
		public GameObject centerGo;

		internal bool _003COnCenterChild_003Eb__0(SideRecItem e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass21_0
	{
		public GameObject centerGo;

		internal bool _003COnMainCenterChild_003Eb__0(MainSideRecItem e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass27_0
	{
		public SideRecItem item;

		public UIUGCRecommendationEditorController _003C_003E4__this;

		public WorkshopEditorChoiceDesc data;

		public string fromInfo;

		public Action<SceneEditSlotInfo> _003C_003E9__3;

		internal void _003CProcessSideRecItem_003Eb__0()
		{
		}

		internal void _003CProcessSideRecItem_003Eb__1(WorkshopBasicInfo res)
		{
		}

		internal void _003CProcessSideRecItem_003Eb__2()
		{
		}

		internal void _003CProcessSideRecItem_003Eb__3(SceneEditSlotInfo slotInfo)
		{
		}
	}

	private UIUGCRecommendationEditorView m_View;

	private UIModelSceneEdit m_Model;

	private bool m_HasEditorRec;

	private List<WorkshopEditorChoiceDesc> m_SideEditorChoiceDescList;

	private List<WorkshopEditorChoiceDesc> m_MainSideEditorChoiceDescList;

	private WorkshopEditorChoiceDesc m_SideDownChoiceDesc;

	private SideRecItem m_SideDownRecItem;

	private int m_CurSideItemIndex;

	private List<SideRecItem> m_CachedSideRecItemList;

	private List<MainSideRecItem> m_CachedMainSideItemList;

	private int m_CurMainSideItemIndex;

	private float m_MainTimeElapsed;

	private const string SideEditorChoiceTopLogName = "SideEditorChoiceTop";

	private const string SideEditorChoiceBottomLogName = "SideEditorChoiceBottom";

	private bool m_IsExposed;

	private bool m_IsInitialized;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnCenterChild(GameObject centerGo)
	{
	}

	private void OnMainCenterChild(GameObject centerGo)
	{
	}

	private void RefreshDot()
	{
	}

	private void RefreshMainDot()
	{
	}

	public void RefreshEditorChoiceInfo()
	{
	}

	private void RefreshMainEditorChoiceInfo()
	{
	}

	private void RefreshSideEditorChoiceInfo()
	{
	}

	private void ProcessSideRecItem(SideRecItem item, WorkshopEditorChoiceDesc data)
	{
	}

	private string GetSideEditorChoiceFromInfo(SideRecItem item, WorkshopEditorChoiceDesc data)
	{
		return null;
	}

	private string GetSideEditorChoiceLogName(WorkshopEditorChoiceDesc data)
	{
		return null;
	}

	private void ShowSideHot(SideRecItem item, WorkshopBasicInfo res)
	{
	}

	private void RefreshSideDownEditorChoiceInfo()
	{
	}

	public void CheckExposure()
	{
	}

	private void RequestSideItemExposure(SideRecItem item)
	{
	}

	private void TryRecordSideItemExposure(SideRecItem item)
	{
	}

	private void OnGoPosCallback(uint series_id)
	{
	}

	private void Update()
	{
	}

	private void UpdateMainSideItem()
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
