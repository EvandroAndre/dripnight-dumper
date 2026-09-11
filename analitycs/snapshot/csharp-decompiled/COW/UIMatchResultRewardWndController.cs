using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIMatchResultRewardWndController : UIPopupWindowController, IUIModelDataChangeObserver
{
	public enum EMatchResultState
	{
		None,
		Reward,
		Challenge,
		Both
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<MatchResultTaskInfo> _003C_003E9__40_0;

		internal bool _003CAddBpDailyChestMissionNoProgress_003Eb__40_0(MatchResultTaskInfo o)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass37_0
	{
		public ActivityInfo item;

		internal bool _003CAddNewPlayerMissionNoProgress_003Eb__0(MatchResultTaskInfo o)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass38_0
	{
		public ClientVeteranTaskDesc item;

		internal bool _003CAddVeteranMissionNoProgress_003Eb__0(MatchResultTaskInfo o)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass39_0
	{
		public EPChallengeInfo info;

		internal bool _003CAddBpDailyMissionNoProgress_003Eb__0(MatchResultTaskInfo o)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass41_0
	{
		public EPWeeklyQuestInfo info;

		internal bool _003CAddBpWeeklyMissionNoProgress_003Eb__0(MatchResultTaskInfo o)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass43_0
	{
		public KeyValuePair<uint, ClientActivityDesc> item;

		internal bool _003CAddBigEventMissonNoProgress_003Eb__0(MatchResultTaskInfo o)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass43_1
	{
		public KeyValuePair<uint, ClientActivityDesc> item;

		internal bool _003CAddBigEventMissonNoProgress_003Eb__1(MatchResultTaskInfo o)
		{
			return false;
		}
	}

	private const int MaxShowRewardItemCount = 5;

	private const int ScrollViewPanelExtraWidth = 26;

	private UIMatchResultRewardWndView m_View;

	private UIModelBooyahPass m_ModelBooyahPass;

	private UIModelMatch m_ModelMatch;

	private UIModelProfile m_ModelProfile;

	private UIMatchResultRewardBonusIconController m_MatchResultRewardBonusIconController;

	private UIBooyahBountyMatchResultRewardController m_BooyahBountyReward;

	private UILimitedTimeRankResultItemController m_LimitedTimeRankResultItemCtrl;

	private readonly List<UIStandardItemMiniController> m_MatchResultRewardItems;

	private UIWeaponExpContentController m_WeaponExpContentController;

	private uint m_DelayCallISkipAni;

	private uint m_DelayCallTaskSkipAni;

	private bool m_CanClaimAward;

	private ulong m_StartShowTime;

	private const float DELAYTIMESKIPMASK = 4f;

	private const float DELAYTASKTIMESKIPANI = 1.5f;

	private uint m_GetBpExpAfterMatchResult;

	private Vector2 TASK_ITEM_SIZE;

	private float m_DefaultPanelY;

	private float m_ShowVFXThreshold;

	private UIBigEventTokenMatchResultRewardController m_UIBigEventTokenMatchResultRewardController;

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

	private void SetVeteranLogs()
	{
	}

	private void InitLabel()
	{
	}

	private void SetBottomLabelAndAwardsToClaim()
	{
	}

	public void HackTestAddBpExp(uint bpExp)
	{
	}

	public uint GetBpExp()
	{
		return 0u;
	}

	public void SetContent()
	{
	}

	private void SetBaseReward()
	{
	}

	public void SetRewards()
	{
	}

	public void AddTaskInfo(List<MatchResultTaskInfo> curShowTaskInfo, List<MatchResultTaskInfo> taskList)
	{
	}

	public void SetTasks()
	{
	}

	private void InitRewardItemTemplate()
	{
	}

	private void RefreshTable2View(List<MatchResultTaskInfo> curShowTaskInfo)
	{
	}

	public void AddNewPlayerMissionNoProgress(List<MatchResultTaskInfo> curShowTaskInfo)
	{
	}

	public void AddVeteranMissionNoProgress(List<MatchResultTaskInfo> curShowTaskInfo)
	{
	}

	public void AddBpDailyMissionNoProgress(List<MatchResultTaskInfo> curShowTaskInfo)
	{
	}

	public void AddBpDailyChestMissionNoProgress(List<MatchResultTaskInfo> curShowTaskInfo)
	{
	}

	public void AddBpWeeklyMissionNoProgress(List<MatchResultTaskInfo> curShowTaskInfo)
	{
	}

	public void AddAvatarAwakenMissonNoProgress(List<MatchResultTaskInfo> curShowTaskInfo)
	{
	}

	public void AddBigEventMissonNoProgress(List<MatchResultTaskInfo> curShowTaskInfo)
	{
	}

	private void CalculateAllTaskAddBpExp(List<MatchResultTaskInfo> taskInfoList)
	{
	}

	private int CompareMatchresultTaskInfo(MatchResultTaskInfo a, MatchResultTaskInfo b)
	{
		return 0;
	}

	private uint GetProgressOrderId(MatchResultTaskInfo info)
	{
		return 0u;
	}

	private uint GetTaskTypeOrderId(MatchResultTaskInfo info)
	{
		return 0u;
	}

	public void ShowVFX()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void StartBooyahPassPurchasedProcedure(bool success, bool isPremiumPlus)
	{
	}

	private void Update()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public override int GlassDelay()
	{
		return 0;
	}

	private void CloseWnd(object[] data)
	{
	}

	private void OnSkipMaskClick()
	{
	}

	private void OnClanActivenessBtnClick()
	{
	}

	private bool ShowBigEventRewardTrans()
	{
		return false;
	}

	private void RefreshBooyahBountyMatchResultReward()
	{
	}

	private void RefreshBigEventTakenGetReward()
	{
	}

	private void RefreshLimitedTimeRankResult()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void _003COnUIInit_003Eb__23_0()
	{
	}

	private void _003CSetTasks_003Eb__34_0()
	{
	}

	private UITable2.IUITable2Item _003CInitRewardItemTemplate_003Eb__35_1()
	{
		return null;
	}

	private UITable2.IUITable2Item _003CInitRewardItemTemplate_003Eb__35_0()
	{
		return null;
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

	public int _003C_003EiFixBaseProxy_GlassDelay()
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
