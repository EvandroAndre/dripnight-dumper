using System;
using System.Collections.Generic;
using System.IO;
using GCommon;
using UnityEngine;

namespace COW;

public class UIReplayNodeController : UIBaseController, IEasyList, IUIModelDataChangeObserver
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<MobileReplayInfo> _003C_003E9__17_0;

		internal bool _003CRefershReplayView_003Eb__17_0(MobileReplayInfo v)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass17_0
	{
		public ulong pendingMatchId;

		internal bool _003CRefershReplayView_003Eb__1(MobileReplayInfo v)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass25_0
	{
		public MobileReplayInfo replayInfo;

		internal bool _003CTryRepairReplayInfo_003Eb__0(MatchRecordPersonal v)
		{
			return false;
		}
	}

	private UIReplayNodeView m_View;

	private const string FIRST_OPEN_KEY = "FIRST_OPEN_REPLAY_NODE";

	private bool m_IsFirstOpenController;

	private bool m_ReplayEnableWhenOpen;

	private EReplayNodeShowType m_ReplayNodeShowType;

	private List<ReplayMatchAchievementData> mlistReplayMatchAchievementData;

	private uint mCurSelectedAchievementGroup;

	private UIPopMenuSmallControler m_ModeAchievementPopMenuController;

	private List<MobileReplayInfo> replayListData;

	private bool m_IsOnlyShowHighLight;

	private FileInfo m_ZipFileInfo;

	private int m_ReplayUploadIndex;

	private bool m_ShowReplayUploadToggle;

	public int ReplayUploadIndex => 0;

	public bool ShowReplayUploadToggle => false;

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	private void GenerateAchievementMenuData()
	{
	}

	private void OnModeHobbySelected(object obj)
	{
	}

	private void RefershAchievementPopMenu()
	{
	}

	private bool HasReplayMatchAchievementData(uint group, List<ReplayMatchAchievementData> list)
	{
		return false;
	}

	public void RefreshReplayData(object[] data = null)
	{
	}

	private void RefershReplayView(bool isResetScroll = true)
	{
	}

	private void UpdateReplayMemory()
	{
	}

	private float FormatPlatformMemory(long value)
	{
		return 0f;
	}

	private void OnClickTipsBtn()
	{
	}

	private void OnToggleBtnClick()
	{
	}

	private void OnShowReplayTypeClick()
	{
	}

	private void OnHighLightCheckboxBtnClick()
	{
	}

	public void TryRepairReplayInfo()
	{
	}

	private bool CheckIsReplayInfoNotMatchResult(MobileReplayInfo replayInfo)
	{
		return false;
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	void IUIModelDataChangeObserver.OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	uint IUIModelDataChangeObserver.GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void InitDebugReplayUpload()
	{
	}

	private void OnEnableUpload()
	{
	}

	private void OnCannotUpload()
	{
	}

	private void OnUploadReplayIndexChange(int index)
	{
	}

	private void RefreshDebugUploadBtns()
	{
	}

	private void OnUploadClick()
	{
	}

	private void GenerateZip()
	{
	}

	private void _003COnUIInit_003Eb__9_0(object[] data)
	{
	}

	private bool _003COnModeHobbySelected_003Eb__13_0(ReplayMatchAchievementData x)
	{
		return false;
	}

	private bool _003CRefershAchievementPopMenu_003Eb__14_0(ReplayMatchAchievementData x)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
