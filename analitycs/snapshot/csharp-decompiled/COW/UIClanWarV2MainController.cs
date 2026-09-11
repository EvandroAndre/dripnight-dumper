using System;
using GCommon;

namespace COW;

public class UIClanWarV2MainController : UIBaseController, IUIModelDataChangeObserver
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<string> _003C_003E9__30_0;

		public static Func<string> _003C_003E9__30_1;

		public static LocalNotificationManager.NotifyInfo.ReturnUrl _003C_003E9__30_2;

		public static Func<int> _003C_003E9__30_3;

		internal string _003CGetNotifyInfo_003Eb__30_0()
		{
			return null;
		}

		internal string _003CGetNotifyInfo_003Eb__30_1()
		{
			return null;
		}

		internal string _003CGetNotifyInfo_003Eb__30_2(object[] parameters)
		{
			return null;
		}

		internal int _003CGetNotifyInfo_003Eb__30_3()
		{
			return 0;
		}
	}

	private const uint WEB_VIEW_CONFIG_SUBTYPE = 1u;

	private const string WEBTUTORIAL_CLANWAR = "WEBTUTORIAL_CLANWAR_{0}";

	private const string BR_CURRENT_ROUND_LABEL = "BR {0}";

	private const string CS_CURRENT_ROUND_LABEL = "CS {0}";

	private const string LW_CURRENT_ROUND_LABEL = "LW {0}";

	private const string SEASON_LABEL = "S{0}";

	private UIClanWarV2MainView m_View;

	private UIClanWarV2InfoController m_InfoCtrl;

	private UIModelClanWarV2 m_ModelWar;

	private UIModelLeaderBoard m_ModelLeaderBoard;

	private ClanWarV2Stage m_Stage;

	private uint m_NotifyID;

	private ELeaderBoardTitleRegionType m_SelectedRegion;

	private const string KEY_CLANWAR_FIRST_ENTER = "ClanWarV2_FirstEnter_";

	private const string KEY_CLANWAR_SCHEDULE = "ClanWarV2_Schedule_";

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

	public void RefreshView()
	{
	}

	private void RefreshCDBanner()
	{
	}

	private void RefreshMatchStateBtn()
	{
	}

	private void CheckMatchStateReddot()
	{
	}

	private void RefreshTitle()
	{
	}

	private void RefreshViewBySelectedRegion()
	{
	}

	public void OnMatchStatusBtn()
	{
	}

	private void OnShareBtnClick()
	{
	}

	private void ShowTipsWeb()
	{
	}

	private void RefreshScheduleToggle()
	{
	}

	public void OnScheduleToggleChange()
	{
	}

	private void ScheduleClanWarNotifications()
	{
	}

	public LocalNotificationManager.NotifyInfo GetNotifyInfo()
	{
		return null;
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public void RefreshLeaderBoard()
	{
	}

	private void CheckAreaInfo()
	{
	}

	private void OnRegionLeaderboardReady(object[] param)
	{
	}

	public override void BeforeScreenshot()
	{
	}

	public override void AfterScreenshot()
	{
	}

	private void CheckAndPopWebTutorial()
	{
	}

	private bool GetHasShowedClanWarTutorialInPlayerPrefs()
	{
		return false;
	}

	private bool GetHasShowedClanWarTutorialInBackend()
	{
		return false;
	}

	private void SyncClanWarTutorialShownStateToBackendIfNeeded()
	{
	}

	private void SetHasShowedClanWarTutorial()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	public void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}
}
