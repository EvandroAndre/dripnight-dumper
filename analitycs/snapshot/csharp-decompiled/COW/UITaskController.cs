using System;
using System.Collections.Generic;
using GCommon;

namespace COW;

public class UITaskController : UIPreviewNavigationController
{
	public enum TaskTab
	{
		None,
		ElitePass,
		DailySignin,
		LadderRank
	}

	public class TaskData
	{
		public TaskTab m_TaskTab;

		public string m_Title;

		public ETipsType m_RedDot;

		public Func<UIBaseController> m_OnSelect;

		public bool hasRedDot;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action _003C_003E9__28_0;

		public static Predicate<TaskData> _003C_003E9__28_4;

		internal void _003COnUIInit_003Eb__28_0()
		{
		}

		internal bool _003COnUIInit_003Eb__28_4(TaskData e)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass35_0
	{
		public UITaskController _003C_003E4__this;

		public TaskData data;

		internal void _003CCreateTabs_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass36_0
	{
		public TaskTab tab;

		public TaskData data;

		internal bool _003CGotoTab_003Eb__0(TaskData x)
		{
			return false;
		}

		internal bool _003CGotoTab_003Eb__1(StandardTopTabItemViewData x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass39_0
	{
		public TaskTab tab;

		internal bool _003COnSelectTab_003Eb__0(TaskData temp)
		{
			return false;
		}
	}

	private UIModelActivity m_ModelActivity;

	private UIModelAnnouncement m_ModelAnnouncement;

	private UIModelBooyahPass m_ModelBP;

	private UIModelMapOpeningInfo m_ModelMapOpeningInfo;

	private UIModelUser m_ModelUser;

	private UITaskView m_View;

	private List<TaskData> m_TaskDatas;

	private Dictionary<int, UIBaseController> m_CtrlDict;

	private List<StandardTopTabItemViewData> m_TabDataList;

	private UIStandardTopTabController m_TabCtrl;

	private FrontendPreviewType m_LastPreviewUIType;

	private EEPTaskTab m_GoposLeftTab;

	public ELadderRankTaskSubTab LadderRankTaskSubTab;

	public uint SelectedRewardPoints;

	private int m_CurShowEPMaxRewardIndex;

	private int m_CurShowFPMaxRewardIndex;

	private bool m_IsForbid;

	private TaskTab _003CCurTab_003Ek__BackingField;

	public int CurShowMaxRewardIndex => 0;

	public TaskTab CurTab
	{
		get
		{
			return _003CCurTab_003Ek__BackingField;
		}
		set
		{
			_003CCurTab_003Ek__BackingField = value;
		}
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override FrontendPreviewType GetPreviewUIType()
	{
		return FrontendPreviewType.Lobby;
	}

	protected override UIWidget GetFrontEndPreviewBorder()
	{
		return null;
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	public void ChangeForbidEscState(bool isForbid)
	{
	}

	public override bool OverwriteBackButtonLogic()
	{
		return false;
	}

	protected override void OnPopupWindowListChange()
	{
	}

	protected override void OnUIClose()
	{
	}

	private void OnClickClose()
	{
	}

	private void CreateTabs(TaskData data)
	{
	}

	public void GotoTab(TaskTab tab)
	{
	}

	public void SetGoposLeftTab(EEPTaskTab tab)
	{
	}

	public EEPTaskTab GetGoposLeftTab()
	{
		return EEPTaskTab.Daily;
	}

	private void OnSelectTab(TaskTab tab)
	{
	}

	public void SetBgBySelectLadderRankTask(bool showTips = false)
	{
	}

	public void SetBgEffectBySelectCSPeak()
	{
	}

	public new void HideBgEffect()
	{
	}

	private void SetLadderRankTaskSubTab()
	{
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	protected override bool DelayPreview()
	{
		return false;
	}

	protected override float DelayPreviewTime()
	{
		return 0f;
	}

	public void ShowChallengeMaxRewardView(bool isShow, bool isFP = false, bool showDesc = true, BaseItemInfo dailyFPInfo = null)
	{
	}

	private FrontendPreviewType GetPreviewType(EEPTaskTab tabType, bool isFreePass)
	{
		return FrontendPreviewType.Lobby;
	}

	public void ChangePreviewType(EEPTaskTab tabType, bool isFreePass)
	{
	}

	public void HideWPProgressBarAndProperty()
	{
	}

	public void ShowWPProgressBarAndProperty()
	{
	}

	private void HandleDebugConsoleKeyCode()
	{
	}

	private void OnEPTaskTabSelect(object[] data)
	{
	}

	private UIBaseController _003COnUIInit_003Eb__28_1()
	{
		return null;
	}

	private UIBaseController _003COnUIInit_003Eb__28_2()
	{
		return null;
	}

	private UIBaseController _003COnUIInit_003Eb__28_3()
	{
		return null;
	}

	private void _003CHideWPProgressBarAndProperty_003Eb__50_0(object[] _)
	{
	}

	private void _003CHideWPProgressBarAndProperty_003Eb__50_1(object[] _)
	{
	}

	private void _003CShowWPProgressBarAndProperty_003Eb__51_0(object[] _)
	{
	}

	private void _003CShowWPProgressBarAndProperty_003Eb__51_1(object[] _)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public bool _003C_003EiFixBaseProxy_OverwriteBackButtonLogic()
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnPopupWindowListChange()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public bool _003C_003EiFixBaseProxy_DelayPreview()
	{
		return false;
	}

	public float _003C_003EiFixBaseProxy_DelayPreviewTime()
	{
		return 0f;
	}
}
