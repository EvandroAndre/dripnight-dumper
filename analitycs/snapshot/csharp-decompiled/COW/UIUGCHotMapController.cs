using System;
using GCommon;
using proto;

namespace COW;

public class UIUGCHotMapController : UIBaseController, IUIModelDataChangeObserver
{
	private sealed class _003C_003Ec__DisplayClass16_0
	{
		public UGCMapLabelConfig mapLabelConfig;

		internal void _003CSetViewData_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass17_0
	{
		public UGCMapLabelConfig mapLabelConfig;

		internal void _003CSetViewData_003Eb__0()
		{
		}
	}

	private UIUGCHotMapView m_View;

	private uint m_SeriesID;

	private UIModelSceneEdit m_Model;

	private SceneEditSlotInfo m_SlotInfo;

	private ERecommendationType m_RecType;

	private EUGCScene m_Scene;

	private bool m_MainEditorChoice;

	private EUGCWndFrom m_WndFrom;

	private UIUGCHotIndicatorController m_IndicatorCtrl;

	private UIUGCLikeIndicatorController m_LikeIndicatorCtrl;

	private bool m_IsExposed;

	public Action<SceneEditSlotInfo> OnClickMap;

	public SceneEditSlotInfo SlotInfo => null;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(UISceneEditRecommendationItemInfo info, ERecommendationType type, EUGCWndFrom wndFrom = EUGCWndFrom.EUGCWndFrom_None, uint series_id = 0u)
	{
	}

	public void SetViewData(WorkshopEditorChoiceInfo info, bool isMain)
	{
	}

	public void OnExposure()
	{
	}

	private void SetTagInfo(SceneEditSlotInfo SlotInfo)
	{
	}

	private void RefreshSpecialState(SceneEditSlotInfo info, bool isNormal = false)
	{
	}

	private void ReSizeMapSize()
	{
	}

	private void RefreshCDNMapIcon(string url)
	{
	}

	private void RefreshCDNMapIcon(SceneEditSlotInfo info)
	{
	}

	private void OnBtnClick()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void _003CRefreshCDNMapIcon_003Eb__22_0()
	{
	}

	private void _003CRefreshCDNMapIcon_003Eb__23_0()
	{
	}

	private void _003CRefreshCDNMapIcon_003Eb__23_1()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
