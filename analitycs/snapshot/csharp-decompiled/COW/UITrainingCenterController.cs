using System;
using System.Collections.Generic;
using COW.Gameplay.UGC;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UITrainingCenterController : UINavigationController, IEasyList, IUIModelDataChangeObserver
{
	public enum TabType
	{
		Technique = 1,
		Skill,
		Prop
	}

	public class TrainingCourseData
	{
		public int Id;

		public string ShareCode;

		public TabType Tab;

		public string TabDescLocKey;

		public int Difficulty;

		public double SortOrder;

		public uint ActivityId;

		public SceneEditSlotInfo SlotInfo;

		public UGCSimpleDownloadTask DownloadTask;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<TrainingCourseData> _003C_003E9__66_0;

		internal int _003CRefreshList_003Eb__66_0(TrainingCourseData a, TrainingCourseData b)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass47_0
	{
		public TabType tabType;

		public UITrainingCenterController _003C_003E4__this;

		internal bool _003CAddTabIfHasData_003Eb__0(TrainingCourseData l)
		{
			return false;
		}

		internal void _003CAddTabIfHasData_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass77_0
	{
		public TrainingCourseData courseData;

		public UITrainingCenterController _003C_003E4__this;

		internal void _003CEnterTrainingCourse_003Eb__0(bool success)
		{
		}
	}

	private const string TRAINING_CENTER_BG_FALLBACK_URL = "OB53/CSH/Background/0a9dc78597f3ca54c9f9580862627043.png";

	private const string TAB_TECHNIQUE_LOC_KEY = "T_54_P_TC_TAB_TECH";

	private const string TAB_SKILL_LOC_KEY = "T_54_P_TC_TAB_SKILL";

	private const string TAB_PROP_LOC_KEY = "T_54_P_TC_TAB_TOOL";

	public const string CLICK_LOG_ENTER_TRAIN_MAPS_BTN = "Entrance/UILobbyV2SubSystem/TrainMapsBtn";

	public const string CLICK_LOG_ENTER_NEW_PLAYER_BTN = "Entrance/UINewPlayerV3/BtnNewBieTrain";

	public const string CLICK_LOG_ENTER_BANNER = "Entrance/UILobbyV2StartGame/TrainingIslandBanner";

	public const string CLICK_LOG_TAB = "TabClick";

	public const string CLICK_LOG_COURSE = "CourseClick";

	public const string CLICK_LOG_SMALL_THUNDER = "Download/SmallThunderClick";

	public const string CLICK_LOG_SMALL_THUNDER_CONFIRM = "Download/SmallThunderConfirmClick";

	public const string CLICK_LOG_SMALL_THUNDER_CANCEL = "Download/SmallThunderCancelClick";

	public const string CLICK_LOG_SMALL_THUNDER_CLOSE = "Download/SmallThunderCloseClick";

	private UITrainingCenterView m_View;

	private List<UINewPlayerV3TrainingCenterTabController> m_TabCtrlList;

	private List<StandardTabItemViewData> m_TabDataList;

	private UIModelSceneEdit m_ModelSceneEdit;

	private UIModelMapOpeningInfo m_ModelMapInfo;

	private UIModelGroup m_ModelGroup;

	private UIModelCustomRoom m_ModelCustomRoom;

	private UIModelActivity m_ModelActivity;

	private TabType m_CurrentTab;

	private List<TrainingCourseData> m_AllCourses;

	private List<TrainingCourseData> m_FilteredCourses;

	private int m_SelectedIndex;

	private int m_GoposTargetId;

	private bool m_NeedCheckDismiss;

	private string m_TabPageName;

	private Dictionary<string, int> m_TabViewTimeCache;

	private bool m_HasSetNaviBar;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public static bool CanShowTrainingCenter()
	{
		return false;
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override void OnUIClose()
	{
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	private void SetNaviBar()
	{
	}

	private void UpdateCdnBG()
	{
	}

	public override void OnNavigationClosed()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private bool IsTrainingCenterDescChanged(object[] param)
	{
		return false;
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void RefreshCompletionStates()
	{
	}

	private void CreateTabs()
	{
	}

	private void AddTabIfHasData(TabType tabType, string locKey)
	{
	}

	private void SelectMainTabByIndex(int index)
	{
	}

	private void RepositionTabs()
	{
	}

	private void SelectDefault()
	{
	}

	private void OnTabSelected(TabType tabType)
	{
	}

	private void RefreshTabDescription()
	{
	}

	private string GetBottomDescription()
	{
		return null;
	}

	private string GetSelectedMapDescription()
	{
		return null;
	}

	private string GetCurrentTabDescription()
	{
		return null;
	}

	private string GetMapDescription(TrainingCourseData courseData)
	{
		return null;
	}

	private void LoadCourseData(List<NewbieTrainingCenterDesc> descs)
	{
	}

	private bool IsValidTabType(uint tabType)
	{
		return false;
	}

	private string NormalizeWorkshopCode(string code)
	{
		return null;
	}

	private int ParseDifficulty(string tag)
	{
		return 0;
	}

	private void OnCourseDataReady()
	{
	}

	private void SelectInitialCourse()
	{
	}

	private void RequestAllSlotInfo()
	{
	}

	private void OnWaterfallSlotInfoChanged()
	{
	}

	private void FillSlotInfoFromCacheAndRefresh()
	{
	}

	private void RefreshList()
	{
	}

	private void ScrollToCourse(int courseId)
	{
	}

	private void SelectCourseByIndex(int index)
	{
	}

	public void OnCourseSelected(int index)
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	private void UpdateBtnPlayState()
	{
	}

	private bool IsSelectedMapDownloaded()
	{
		return false;
	}

	private void OnBtnPlayClick()
	{
	}

	private void StartMapDownload()
	{
	}

	public void OnDownloadStateChanged()
	{
	}

	private void EnterTrainingCourse(TrainingCourseData courseData)
	{
	}

	private void DoEnterTrainingCourse(TrainingCourseData courseData, bool autoLeaveGroup = false)
	{
	}

	private int GetCompletedCourseCount(TabType tabType)
	{
		return 0;
	}

	private bool IsCourseCompleted(TrainingCourseData courseData)
	{
		return false;
	}

	private void OnGroupDismissNtf(object[] data)
	{
	}

	private void OnBtnGotoTrainingLandClick()
	{
	}

	private void SwitchTabViewTime(TabType nextTab)
	{
	}

	private void FlushCurrentTabViewTime()
	{
	}

	private void FlushAllTabViewTime()
	{
	}

	private string GetTrainingCenterPageName(TabType tabType)
	{
		return null;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}
}
