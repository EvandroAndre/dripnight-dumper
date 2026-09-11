using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIModelBigEvent_Milestone : UIBaseModel
{
	public enum ProgressStatus
	{
		Lock,
		Explore,
		Claimable,
		Claimed
	}

	public enum ProgressType : uint
	{
		Normal,
		GrandPrize,
		Cycle
	}

	public interface IProgressInfo
	{
		uint stage_id { get; }

		uint unlock_progress { get; }

		uint progress { get; }

		uint value { get; }

		uint type { get; }

		ProgressStatus status { get; }

		float GetFillAmount(uint cur_progress);

		uint GetNextValue(uint cur_progress);

		uint GetValue(uint cur_progress);

		int Init(uint cur_progress, uint[] claimed_stages, uint claimed_circle_progress);

		int SetProgress(uint cur_progress);

		bool SetStatus(uint[] claimed_stages, uint claimed_circle_progress);
	}

	public interface IProgressAnimation
	{
		bool isPlaying { get; }

		void PlayAnimation(uint old_stage_id, uint cur_stage_id, uint add_mileage);
	}

	public interface IGrandPrizeUpdater
	{
		bool isNeed { get; }

		void Update();
	}

	public class NormalProgressInfo : IProgressInfo
	{
		private uint _003Cstage_id_003Ek__BackingField;

		private uint _003Cunlock_progress_003Ek__BackingField;

		private uint _003Cprogress_003Ek__BackingField;

		private uint _003Cvalue_003Ek__BackingField;

		private ProgressStatus _003Cstatus_003Ek__BackingField;

		public uint stage_id
		{
			get
			{
				return _003Cstage_id_003Ek__BackingField;
			}
			private set
			{
				_003Cstage_id_003Ek__BackingField = value;
			}
		}

		public uint unlock_progress
		{
			get
			{
				return _003Cunlock_progress_003Ek__BackingField;
			}
			private set
			{
				_003Cunlock_progress_003Ek__BackingField = value;
			}
		}

		public uint progress
		{
			get
			{
				return _003Cprogress_003Ek__BackingField;
			}
			private set
			{
				_003Cprogress_003Ek__BackingField = value;
			}
		}

		public uint value
		{
			get
			{
				return _003Cvalue_003Ek__BackingField;
			}
			private set
			{
				_003Cvalue_003Ek__BackingField = value;
			}
		}

		public uint type => 0u;

		public ProgressStatus status
		{
			get
			{
				return _003Cstatus_003Ek__BackingField;
			}
			private set
			{
				_003Cstatus_003Ek__BackingField = value;
			}
		}

		public NormalProgressInfo(uint id, uint unlock_progress, uint progress)
		{
		}

		public float GetFillAmount(uint cur_progress)
		{
			return 0f;
		}

		public uint GetNextValue(uint cur_progress)
		{
			return 0u;
		}

		public uint GetValue(uint cur_progress)
		{
			return 0u;
		}

		public int Init(uint cur_progress, uint[] claimed_stages, uint claimed_circle_progress)
		{
			return 0;
		}

		public int SetProgress(uint cur_progress)
		{
			return 0;
		}

		public bool SetStatus(uint[] claimed_stages, uint claimed_circle_progress)
		{
			return false;
		}
	}

	public class CycleProgressInfo : IProgressInfo
	{
		private uint _003Cstage_id_003Ek__BackingField;

		private uint _003Cunlock_progress_003Ek__BackingField;

		private uint _003Cprogress_003Ek__BackingField;

		private uint total_progress;

		private uint claimed_count;

		private uint total_claimed_count;

		private ProgressStatus mStatues;

		public uint stage_id
		{
			get
			{
				return _003Cstage_id_003Ek__BackingField;
			}
			private set
			{
				_003Cstage_id_003Ek__BackingField = value;
			}
		}

		public uint unlock_progress
		{
			get
			{
				return _003Cunlock_progress_003Ek__BackingField;
			}
			private set
			{
				_003Cunlock_progress_003Ek__BackingField = value;
			}
		}

		public uint progress
		{
			get
			{
				return _003Cprogress_003Ek__BackingField;
			}
			private set
			{
				_003Cprogress_003Ek__BackingField = value;
			}
		}

		public uint value => 0u;

		public uint award_count => 0u;

		public uint type => 0u;

		public ProgressStatus status => ProgressStatus.Lock;

		public CycleProgressInfo(uint id, uint unlock_progress, uint progress)
		{
		}

		public float GetFillAmount(uint cur_progress)
		{
			return 0f;
		}

		public uint GetNextValue(uint cur_progress)
		{
			return 0u;
		}

		public uint GetValue(uint cur_progress)
		{
			return 0u;
		}

		public int Init(uint cur_progress, uint[] claimed_stages, uint claimed_circle_progress)
		{
			return 0;
		}

		public int SetProgress(uint cur_progress)
		{
			return 0;
		}

		public bool SetStatus(uint[] claimed_stages, uint claimed_circle_progress)
		{
			return false;
		}
	}

	public class GrandPrizeProgressInfo : IProgressInfo, IGrandPrizeUpdater
	{
		public enum LockType
		{
			ALL,
			TIME,
			PROGRESS
		}

		private uint _003Cstage_id_003Ek__BackingField;

		private uint _003Cunlock_progress_003Ek__BackingField;

		private ulong _003Cunlock_time_003Ek__BackingField;

		private uint _003Cprogress_003Ek__BackingField;

		private uint total_progress;

		private ProgressStatus _003Cstatus_003Ek__BackingField;

		private LockType _003ClockType_003Ek__BackingField;

		private bool _003CisNeed_003Ek__BackingField;

		public uint stage_id
		{
			get
			{
				return _003Cstage_id_003Ek__BackingField;
			}
			private set
			{
				_003Cstage_id_003Ek__BackingField = value;
			}
		}

		public uint unlock_progress
		{
			get
			{
				return _003Cunlock_progress_003Ek__BackingField;
			}
			private set
			{
				_003Cunlock_progress_003Ek__BackingField = value;
			}
		}

		public ulong unlock_time
		{
			get
			{
				return _003Cunlock_time_003Ek__BackingField;
			}
			private set
			{
				_003Cunlock_time_003Ek__BackingField = value;
			}
		}

		public uint progress
		{
			get
			{
				return _003Cprogress_003Ek__BackingField;
			}
			private set
			{
				_003Cprogress_003Ek__BackingField = value;
			}
		}

		public uint value => 0u;

		public uint type => 0u;

		public ProgressStatus status
		{
			get
			{
				return _003Cstatus_003Ek__BackingField;
			}
			private set
			{
				_003Cstatus_003Ek__BackingField = value;
			}
		}

		public LockType lockType
		{
			get
			{
				return _003ClockType_003Ek__BackingField;
			}
			private set
			{
				_003ClockType_003Ek__BackingField = value;
			}
		}

		public bool isNeed
		{
			get
			{
				return _003CisNeed_003Ek__BackingField;
			}
			private set
			{
				_003CisNeed_003Ek__BackingField = value;
			}
		}

		public GrandPrizeProgressInfo(uint id, uint unlock_progress, uint unlock_timestamp)
		{
		}

		public float GetFillAmount(uint cur_progress)
		{
			return 0f;
		}

		public uint GetNextValue(uint cur_progress)
		{
			return 0u;
		}

		public uint GetValue(uint cur_progress)
		{
			return 0u;
		}

		public int Init(uint cur_progress, uint[] claimed_stages, uint claimed_circle_progress)
		{
			return 0;
		}

		public int SetProgress(uint cur_progress)
		{
			return 0;
		}

		public bool SetStatus(uint[] claimed_stages, uint claimed_circle_progress)
		{
			return false;
		}

		public void Update()
		{
		}
	}

	public enum ERamadanType : uint
	{
		Ramadan_Animation,
		Ramadan,
		Milestone
	}

	private IProgressAnimation m_Animation;

	public const uint PropID_GetMilestoneSetting = 2u;

	public const uint PropID_GetMilestoneInfo = 4u;

	public const uint PropID_ProgressRefersh = 8u;

	public const uint PropID_ProgressState = 16u;

	public const string FirstInEvt = "Ramadan24B_FirstInAnim_Evt";

	public const string Main_Enter = "UIFX_Milestone24B_MainPage_Ani";

	private UIModelBigEventTemplate m_UIModelBigEventTemplate;

	private uint _003CCustomEventId_003Ek__BackingField;

	private uint _003CCustomTokenId_003Ek__BackingField;

	private uint _003CExplore_StageID_003Ek__BackingField;

	private uint _003CCurProgress_003Ek__BackingField;

	private uint _003CAddMileage_003Ek__BackingField;

	private ERamadanType m_RamadanType;

	private string _003CCommonSpineVFX_003Ek__BackingField;

	private Vector2 _003CBubblePosition_003Ek__BackingField;

	private Vector2 _003CButtonPosition_003Ek__BackingField;

	private int _003CMissionStatus_003Ek__BackingField;

	private bool m_MilestoneSettingFetched;

	private Dictionary<uint, CustomMilestoneProgressDesc> m_DicProgressSettings;

	private Dictionary<uint, CustomMilestoneShareDesc> m_DicShareSettings;

	private List<IProgressInfo> m_ListProgressInfos;

	private bool m_IsConsumeTokenMsg;

	private ulong m_ConsumeTokenMsgTimeStamp;

	public uint CustomEventId
	{
		get
		{
			return _003CCustomEventId_003Ek__BackingField;
		}
		private set
		{
			_003CCustomEventId_003Ek__BackingField = value;
		}
	}

	public uint CustomTokenId
	{
		get
		{
			return _003CCustomTokenId_003Ek__BackingField;
		}
		private set
		{
			_003CCustomTokenId_003Ek__BackingField = value;
		}
	}

	public uint Explore_StageID
	{
		get
		{
			return _003CExplore_StageID_003Ek__BackingField;
		}
		private set
		{
			_003CExplore_StageID_003Ek__BackingField = value;
		}
	}

	public uint CurProgress
	{
		get
		{
			return _003CCurProgress_003Ek__BackingField;
		}
		private set
		{
			_003CCurProgress_003Ek__BackingField = value;
		}
	}

	public uint AddMileage
	{
		get
		{
			return _003CAddMileage_003Ek__BackingField;
		}
		private set
		{
			_003CAddMileage_003Ek__BackingField = value;
		}
	}

	public bool isRamadan => false;

	public bool isRamadanAnimation => false;

	public string CommonSpineVFX
	{
		get
		{
			return _003CCommonSpineVFX_003Ek__BackingField;
		}
		private set
		{
			_003CCommonSpineVFX_003Ek__BackingField = value;
		}
	}

	public Vector2 BubblePosition
	{
		get
		{
			return _003CBubblePosition_003Ek__BackingField;
		}
		private set
		{
			_003CBubblePosition_003Ek__BackingField = value;
		}
	}

	public Vector2 ButtonPosition
	{
		get
		{
			return _003CButtonPosition_003Ek__BackingField;
		}
		private set
		{
			_003CButtonPosition_003Ek__BackingField = value;
		}
	}

	public int MissionStatus
	{
		get
		{
			return _003CMissionStatus_003Ek__BackingField;
		}
		private set
		{
			_003CMissionStatus_003Ek__BackingField = value;
		}
	}

	public string GetFirstInAnimKey => null;

	public void OpenAnimationController(IProgressAnimation animation)
	{
	}

	public void CloseAnimationController()
	{
	}

	public override uint GetModelType()
	{
		return 0u;
	}

	public override void Login(object[] data)
	{
	}

	public override void Logout(object[] data)
	{
	}

	public override void Init()
	{
	}

	private void ClearCachedData()
	{
	}

	public void RequestCustomSetting(uint useType)
	{
	}

	public void RequestCustomMainInfo()
	{
	}

	public void RequsetConsumeToken()
	{
	}

	public void RequsetMilestoneReward(uint stage_id)
	{
	}

	private int CompareProgressSort(IProgressInfo left, IProgressInfo right)
	{
		return 0;
	}

	public IProgressInfo GetProgressInfo(uint stage_id)
	{
		return null;
	}

	public IProgressInfo GetProgressInfoByIndex(int index)
	{
		return null;
	}

	public uint GetGrandPrizeStageId()
	{
		return 0u;
	}

	public CustomMilestoneProgressDesc GetProgressDesc(uint stage_id)
	{
		return null;
	}

	public CustomMilestoneShareDesc GetShareDesc(uint share_id)
	{
		return null;
	}

	public string GetNoTokenWndBgCDNUrl(uint useType)
	{
		return null;
	}

	public string GetSpecialMissionItemBGUrl(uint useType)
	{
		return null;
	}

	public string GetSpecialMissionSubItemBGUrl1(uint useType)
	{
		return null;
	}

	public string GetSpecialMissionSubItemBGUrl2(uint useType)
	{
		return null;
	}

	public string GetCycleProgressRedDotUrl(uint useType)
	{
		return null;
	}

	public string GetGrandPrizeConditionBgUrl(uint useType)
	{
		return null;
	}

	public string GetGrandPrizeProgressLockBgUrl(uint useType)
	{
		return null;
	}

	public string GetProgressValueBgUrl(uint useType)
	{
		return null;
	}

	public string GetProgressShareIconUrl(uint useType)
	{
		return null;
	}

	public string GetProgressHighLightUrl(uint useType)
	{
		return null;
	}

	public string GetProgressMaskBgUrl(uint useType)
	{
		return null;
	}

	public string GetAccBtnUrl(uint useType)
	{
		return null;
	}

	public string GetAccTokenBgUrl(uint useType)
	{
		return null;
	}

	public string GetMileagePromptUrl(uint useType)
	{
		return null;
	}

	public string GetProgressGoCdnUrl(uint useType)
	{
		return null;
	}

	public string GetProgressNumLockCdnUrl(uint useType)
	{
		return null;
	}

	public string GetProgressNumUnLockCdnUrl(uint useType)
	{
		return null;
	}

	public string GetShareNormalTabCdnUrl(uint useType)
	{
		return null;
	}

	public string GetShareSelectedTabCdnUrl(uint useType)
	{
		return null;
	}

	public string GetShareSelectedKuangCdnUrl(uint useType)
	{
		return null;
	}

	public string GetShareBtnCdnUrl(uint useType)
	{
		return null;
	}

	public string GetShareGiftIconCdnUrl(uint useType)
	{
		return null;
	}

	public string GetShareGiftBgCdnUrl(uint useType)
	{
		return null;
	}

	public string GetShareGiftArrowCdnUrl(uint useType)
	{
		return null;
	}

	public string GetShareItemDragBgCdnUrl(uint useType)
	{
		return null;
	}

	public string GetShareItemDragFlagCdnUrl(uint useType)
	{
		return null;
	}

	public string GetCorePlayProgressBackgroundCdnUrl(uint useType)
	{
		return null;
	}

	public string GetCorePlayProgressForegroundCdnUrl(uint useType)
	{
		return null;
	}

	public string GetCorePlayProgressHighlightCdnUrl(uint useType)
	{
		return null;
	}

	public string GetCorePlayKellyRunBackgroundCdnUrl(uint useType)
	{
		return null;
	}

	public string GetLeftMaskCdnUrl(uint useType)
	{
		return null;
	}

	public string GetMissionSpecRedDotCdn(uint useType)
	{
		return null;
	}

	public string GetMSMileageFirstStageCdn(uint useType)
	{
		return null;
	}

	public string GetMSMileageSecondStageCdn(uint useType)
	{
		return null;
	}

	public string GetMSMileageThirdStageCdn(uint useType)
	{
		return null;
	}

	public string GetMSMileageForthStageCdn(uint useType)
	{
		return null;
	}

	public string GetMSMileageFifthStageCdn(uint useType)
	{
		return null;
	}

	private string GetMSMileageStageCdnByConfigKey(uint useType, EBigEventTemplateConfigKey configKey)
	{
		return null;
	}

	public float GetMSMileageFirstStageCndTime(uint useType)
	{
		return 0f;
	}

	public float GetMSMileageSecondStageCndTime(uint useType)
	{
		return 0f;
	}

	public float GetMSMileageThirdStageCndTime(uint useType)
	{
		return 0f;
	}

	public float GetMSMileageForthStageCndTime(uint useType)
	{
		return 0f;
	}

	public float GetMSMileageFifthStageCndTime(uint useType)
	{
		return 0f;
	}

	private float GetMSMileageStageCndTimeByConfigKey(uint useType, EBigEventTemplateConfigKey configKey)
	{
		return 0f;
	}

	public UIModelBigEventTemplate.LocStrWithColor GetNoTokenWndTitleDescLoc(uint useType)
	{
		return null;
	}

	public UIModelBigEventTemplate.LocStrWithColor GetSpecialMissionTitleDescLoc(uint useType)
	{
		return null;
	}

	public UIModelBigEventTemplate.LocStrWithColor GetProgressGoLoc(uint useType)
	{
		return null;
	}

	public UIModelBigEventTemplate.LocStrWithColor GetProgressStageLoc(uint useType, uint mileage)
	{
		return null;
	}

	public UIModelBigEventTemplate.LocStrWithColor GetCycleProgressStageLoc(uint useType, uint mileage, uint progress)
	{
		return null;
	}

	public UIModelBigEventTemplate.LocStrWithColor GetGrandPrizeTitleLoc(uint useType)
	{
		return null;
	}

	public UIModelBigEventTemplate.LabelEffect GetGrandPrizeTitleLabelEffect(uint useType)
	{
		return default(UIModelBigEventTemplate.LabelEffect);
	}

	public UIModelBigEventTemplate.LocStrWithColor GetGrandPrizeTimeConditionLoc(uint useType, string time)
	{
		return null;
	}

	public UIModelBigEventTemplate.LocStrWithColor GetGrandPrizeStageConditionLoc(uint useType)
	{
		return null;
	}

	public UIModelBigEventTemplate.LocStrWithColor GetProgressValueLoc(uint useType, uint mileage)
	{
		return null;
	}

	public UIModelBigEventTemplate.LocStrWithColor GetMileageAddLoc(uint useType, uint mileage)
	{
		return null;
	}

	public UIModelBigEventTemplate.LabelEffect GetMileageAddLabelEffect(uint useType)
	{
		return default(UIModelBigEventTemplate.LabelEffect);
	}

	public UIModelBigEventTemplate.LabelGradient GetMileageAddLabelGradient(uint useType)
	{
		return default(UIModelBigEventTemplate.LabelGradient);
	}

	public UIModelBigEventTemplate.LocStrWithColor GetAccBtnLoc(uint useType)
	{
		return null;
	}

	public UIModelBigEventTemplate.LocStrWithColor GetMileageStartPromptLoc(uint useType)
	{
		return null;
	}

	public UIModelBigEventTemplate.LocStrWithColor GetMileagePromptLoc(uint useType, uint mileage)
	{
		return null;
	}

	public UIModelBigEventTemplate.LocStrWithColor GetMileageCyclePromptLoc(uint useType, uint mileage)
	{
		return null;
	}

	public UIModelBigEventTemplate.LocStrWithColor GetStageRewardPreviewTitleLoc(uint useType)
	{
		return null;
	}

	public UIModelBigEventTemplate.LocStrWithColor GetStageRewardPreviewContentLoc(uint useType)
	{
		return null;
	}

	public UIModelBigEventTemplate.LocStrWithColor GetCycleStageRewardPreviewContentLoc(uint useType)
	{
		return null;
	}

	public UIModelBigEventTemplate.LocStrWithColor GetShareGiftLoc(uint useType)
	{
		return null;
	}

	public UIModelBigEventTemplate.LocStrWithColor GetShareBtnLoc(uint useType)
	{
		return null;
	}

	public Color GetMSMissionSpecSubItemDescColor1(uint useType)
	{
		return default(Color);
	}

	public Color GetMSMissionSpecSubItemDescColor2(uint useType)
	{
		return default(Color);
	}

	public UIModelBigEventTemplate.LocStrWithColor GetShareTitlePromptLoc(uint useType)
	{
		return null;
	}

	public UIModelBigEventTemplate.LabelEffect GetShareTitlePromptEffect(uint useType)
	{
		return default(UIModelBigEventTemplate.LabelEffect);
	}

	public UIModelBigEventTemplate.LocStrWithColor GetMSMileageFirstStageLoc(uint useType)
	{
		return null;
	}

	public UIModelBigEventTemplate.LocStrWithColor GetMSMileageSecondStageLoc(uint useType)
	{
		return null;
	}

	public UIModelBigEventTemplate.LocStrWithColor GetMSMileageThirdStageLoc(uint useType)
	{
		return null;
	}

	public UIModelBigEventTemplate.LocStrWithColor GetMSMileageForthStageLoc(uint useType)
	{
		return null;
	}

	public UIModelBigEventTemplate.LocStrWithColor GetMSMileageFifthStageLoc(uint useType)
	{
		return null;
	}

	public UIModelBigEventTemplate.LocStrWithColor GetMSMileageClamRemindStageLoc(uint useType)
	{
		return null;
	}

	public UIModelBigEventTemplate.LocStrWithColor GetSpeaMileagePromptLoc(uint useType, uint stageIndex, uint mileage)
	{
		return null;
	}

	private bool GetResult(string str)
	{
		return false;
	}

	public ResourceID GetSpecMissionClaimableVFX1(uint useType)
	{
		return default(ResourceID);
	}

	public ResourceID GetSpecMissionClaimableVFX2(uint useType)
	{
		return default(ResourceID);
	}

	public ResourceID GetProgressHighLightVFX(uint useType)
	{
		return default(ResourceID);
	}

	public ResourceID GetGrandPrizeStageLockVFX(uint useType)
	{
		return default(ResourceID);
	}

	public ResourceID GetFlyEffectVFX(uint useType)
	{
		return default(ResourceID);
	}

	public ResourceID GetCycleStageUnlockVFX(uint useType)
	{
		return default(ResourceID);
	}

	public ResourceID GetGrandPrizeStageUnlockVFX(uint useType)
	{
		return default(ResourceID);
	}

	public ResourceID GetMainPageTitleEnterVFX(uint useType)
	{
		return default(ResourceID);
	}

	public ResourceID GetAddMileageVFX(uint useType)
	{
		return default(ResourceID);
	}

	public ResourceID GetAccBtnEnterVFX(uint useType)
	{
		return default(ResourceID);
	}

	public ResourceID GetAccBtnClaimableVFX(uint useType)
	{
		return default(ResourceID);
	}

	public ResourceID GetProgressMaskEnterVFX(uint useType)
	{
		return default(ResourceID);
	}

	public ResourceID GetFlySound(uint useType)
	{
		return default(ResourceID);
	}

	public ResourceID GetCycleStageUnlockSound(uint useType)
	{
		return default(ResourceID);
	}

	public ResourceID GetGrandPrizeStageUnlockSound(uint useType)
	{
		return default(ResourceID);
	}

	public ResourceID GetKellyRunSound(uint useType)
	{
		return default(ResourceID);
	}

	public ResourceID GetNormalStageAchievedSound(uint useType)
	{
		return default(ResourceID);
	}

	public ResourceID GetNormalStageProgressSound(uint useType)
	{
		return default(ResourceID);
	}

	public ResourceID GetAddMileageSound(uint useType)
	{
		return default(ResourceID);
	}

	public ResourceID GetShareRewardSwitchSound(uint useType)
	{
		return default(ResourceID);
	}

	public void ShowGoposPopupWindow(Type type)
	{
	}

	public bool IsLobbyEntranceTipsNeedShow(uint useType, out bool showRewardTips)
	{
		showRewardTips = default(bool);
		return false;
	}

	public void ComputeMissionStatus(uint useType)
	{
	}

	private bool LoginOnSpecialTimeConditionCalculate(EActivity.PreConditionType condition_type, uint condition_value, ulong value)
	{
		return false;
	}

	public bool IsInLoginOnSpecialTime(ClientActivityDesc activityDesc)
	{
		return false;
	}

	private void _003CRequestCustomSetting_003Eb__73_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestCustomMainInfo_003Eb__74_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequsetConsumeToken_003Eb__75_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequsetMilestoneReward_003Eb__76_0(HttpErrorCode errorCode, object res)
	{
	}

	public void _003C_003EiFixBaseProxy_Login(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}
}
