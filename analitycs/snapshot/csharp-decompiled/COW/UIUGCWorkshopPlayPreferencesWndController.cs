using System;
using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIUGCWorkshopPlayPreferencesWndController : UIPopupWindowController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<WorkShopPlayerStartTag> _003C_003E9__20_0;

		internal int _003COnUIInit_003Eb__20_0(WorkShopPlayerStartTag a, WorkShopPlayerStartTag b)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass36_0
	{
		public UIUGCWorkshopPlayPreferencesWndController _003C_003E4__this;

		public UINetworkTexture tex;

		internal void _003CSetCdnTexture_003Eb__0()
		{
		}
	}

	private const string ANIM_TIP_IN = "UIFX_UIUGCWorkshopPlayPreferencesWnd_TipIcon_In";

	private const string ANIM_TIP_OUT = "UIFX_UIUGCWorkshopPlayPreferencesWnd_TipIcon_Out";

	private const string ANIM_SELECTION_IN = "UIFX_UIUGCWorkshopPlayPreferencesWnd_SelectionCon_In";

	private const string ANIM_SELECTION_LEFT = "UIFX_UIUGCWorkshopPlayPreferencesWnd_SelectionCon_Left";

	private const string ANIM_SELECTION_RIGHT = "UIFX_UIUGCWorkshopPlayPreferencesWnd_SelectionCon_Right";

	private const string LOC_SKIP = "T_17_O_WEBVIEWCRASH_SKIP";

	private const string LOC_SKIP_WITHPARAM = "T_53_SQF_WS_PLAYER_PREFERENCES_SKIP";

	private int m_CurrentIndex;

	private int m_SkipCountDown;

	private uint m_SkipDelayCall;

	private UIUGCWorkshopPlayPreferencesWndView m_View;

	private UIModelSceneEdit m_Model;

	private EventLogger.EventTypeUGCPlatformStartSurveySubmitTriggerReason m_Trigger_reason;

	private EventLogger.EventTypeUGCPlatformStartSurveySubmitChoice m_CurrentChoice;

	private List<WorkShopPlayerStartTag> m_DataList;

	private List<EventLogger.UGCPlatformStartSurveySubmitDetail> m_SelectedDetails;

	private List<UIUGCWorkshopPlayPreferencesProgressItemController> m_ProgressItems;

	private WorkShopPlayerStartTag CurrentData => null;

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

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void InitView()
	{
	}

	private void RefreshView()
	{
	}

	private void RefreshViewInternal()
	{
	}

	private void RefreshProgress()
	{
	}

	private void OnSkipBtnClick()
	{
	}

	private void OnFullScreenBtnClick()
	{
	}

	private void OnLeftBtnClick()
	{
	}

	private void OnRightBtnClick()
	{
	}

	private void Select(EventLogger.EventTypeUGCPlatformStartSurveySubmitChoice choice)
	{
	}

	private void PlaySelectionEnter()
	{
	}

	private void PlaySelectionExit(string animName)
	{
	}

	private void RefreshSkipCountDown()
	{
	}

	private void SetCdnTexture(UINetworkTexture tex, string url)
	{
	}

	private void SetInputEnabled(bool enabled)
	{
	}

	public void SetViewData(EventLogger.EventTypeUGCPlatformStartSurveySubmitTriggerReason reason)
	{
	}

	private void _003COnFullScreenBtnClick_003Eb__29_0()
	{
	}

	private void _003CPlaySelectionEnter_003Eb__33_0()
	{
	}

	private void _003CPlaySelectionExit_003Eb__34_0()
	{
	}

	private void _003CRefreshSkipCountDown_003Eb__35_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
