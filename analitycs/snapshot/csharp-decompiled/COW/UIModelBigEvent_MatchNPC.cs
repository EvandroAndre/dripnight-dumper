using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIModelBigEvent_MatchNPC : UIBaseModel
{
	private sealed class _003C_003Ec__DisplayClass36_0
	{
		public UIModelBigEvent_MatchNPC _003C_003E4__this;

		public uint useType;

		internal void _003CRequestMatchNpcCustomEvent_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass40_0
	{
		public UIModelBigEvent_MatchNPC _003C_003E4__this;

		public CustomEventMatchNPCProcessDesc desc;

		public bool isClaimrepeatReward;

		public uint process_amount;

		internal void _003CRequestClaimProcessReward_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass41_0
	{
		public CustomEventMatchNPCStoryDesc story_desc;

		public Predicate<CustomEventMatchNPCStoryDesc> _003C_003E9__1;

		internal bool _003CProcessStory_003Eb__0(CustomEventMatchNPCStoryDesc x)
		{
			return false;
		}

		internal bool _003CProcessStory_003Eb__1(CustomEventMatchNPCStoryDesc x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass51_0
	{
		public uint story_id;

		internal bool _003CGetStoryClassByStoryId_003Eb__0(CustomEventMatchNPCStoryDesc x)
		{
			return false;
		}
	}

	private List<CustomEventMatchNPCStoryDesc> m_StoryClass;

	private UIModelBigEventTemplate m_ModelBigEventTemplate;

	private Dictionary<uint, List<CustomEventMatchNPCStoryDesc>> m_BigEventMatchNpcStoryDict;

	private Dictionary<uint, CustomEventMatchNPCProcessDesc> m_BigEventMatchNpcProcessDict;

	private Dictionary<uint, BigEventTemplateVFXDesc> m_BigEventMatchNpcProcessVFXDict;

	private Dictionary<uint, AutoOpenIntegrationData> m_ProcessIdRewardBaseDict;

	private AutoOpenIntegrationData m_ProcessRepeatRewards;

	private CustomEventMatchNPCSettingDesc m_BigEventMatchNpcSettingDesc;

	private CSCustomEventMatchNPCAccountInfoRes m_PlayerAccountInfo;

	private bool m_HaveInitData;

	private uint m_PlayerProcess;

	private uint m_NpcProcess;

	private uint m_LastPlayerProcess;

	private uint m_LastNpcProcess;

	private uint m_PlayerProcessAll;

	private uint m_PlayerDetalProcessAll;

	private uint m_OneAddTokenMaxCount;

	private ulong m_NpcCountDownBeginTimeStamp;

	private uint m_Custom_Event_Id;

	private uint m_TotalProcessMaxAmount;

	private const uint STATEOFFSET = 6u;

	public const int PropID_MatchNPCSettingInfoRefresh = 2;

	public const int PropID_MatchNPCProcessRefresh = 4;

	public const int PropID_MatchNPCProcessClaimReward = 8;

	public const int PropID_MatchNPCPlayerAccountInfoRefresh = 16;

	public const int PropID_MatchNPCPlayerTotalProcessRefresh = 32;

	public const int PropID_MatchNPCPlayerAddTokenRefresh = 64;

	public const int PropID_MatchNPCPlayerTurnFinishedRefresh = 128;

	private List<int> m_VFXProcessIdList;

	public uint CustomEventId => 0u;

	public override uint GetModelType()
	{
		return 0u;
	}

	public override void Init()
	{
	}

	protected override void OnCleanup()
	{
	}

	public override void Logout(object[] data)
	{
	}

	private void ClearCacheDataForMatchNpcCustomEvent()
	{
	}

	public void RequestMatchNpcCustomEvent(uint useType, uint custom_event_id)
	{
	}

	public void RequestMatchNpcRoundFinishedPlayerTotalProcess()
	{
	}

	public void RequestPlayerAccountInfo()
	{
	}

	public void RequestAddMatchNpcToken(uint add_token_num)
	{
	}

	public void RequestClaimProcessReward(uint process_amount, bool isClaimrepeatReward = false)
	{
	}

	private void ProcessStory(List<CustomEventMatchNPCStoryDesc> story_desc_List)
	{
	}

	private void ProcessProcessDesc(List<CustomEventMatchNPCProcessDesc> process_desc_list)
	{
	}

	private void RefreshPlayerAndNpcProcess(uint player_process, uint npc_process)
	{
	}

	public void RefreshNpcProcess()
	{
	}

	public void RefreshNpcProcess(uint process)
	{
	}

	private void RefreshPlayerOnceAddMaxToken()
	{
	}

	private void RefreshPlayerTotalProcess(uint player_process_all)
	{
	}

	private void refreshCircleClaimTimes()
	{
	}

	private uint GetCurrentRewardProcessIDInternal()
	{
		return 0u;
	}

	public CustomEventMatchNPCStoryDesc GetStoryClassByStoryCdt(BigEventMatchNpcTriggerDialogState state)
	{
		return null;
	}

	public CustomEventMatchNPCStoryDesc GetStoryClassByStoryId(uint story_id)
	{
		return null;
	}

	public string GetStoryLocKey(uint loc_id)
	{
		return null;
	}

	public AutoOpenIntegrationData GetStoryEndRewardItemInfoListByProcessAmount(uint process_amount)
	{
		return null;
	}

	public AutoOpenIntegrationData GetRepeatReward()
	{
		return null;
	}

	public bool IsStageRewardTipsNeedShow(uint processID, uint stageProcess)
	{
		return false;
	}

	public bool IsRepeatRewardTipsNeedShow()
	{
		return false;
	}

	public bool IsTurnFinishedTipsNeedShow()
	{
		return false;
	}

	public bool IsLobbyEntranceTipsNeedShow()
	{
		return false;
	}

	public BaseItemInfo GetRepeatRewardBaseItemInfo()
	{
		return null;
	}

	public CustomEventMatchNPCProcessDesc GetProcessRewardItemInfo(uint process_amount)
	{
		return null;
	}

	public bool IsPlayerGetThisProcessReward(uint process_amount)
	{
		return false;
	}

	public CustomEventMatchNPCStoryDesc GetStoryClassByProcessAmount(uint process_amount)
	{
		return null;
	}

	public List<uint> GetProcessAmountKeyList()
	{
		return null;
	}

	public CustomEventMatchNPCSettingDesc GetMatchNpcSettingDesc()
	{
		return null;
	}

	public uint GetPlayerProcess()
	{
		return 0u;
	}

	public uint GetPlayerLastTurnProcess()
	{
		return 0u;
	}

	public uint GetNpcProcess()
	{
		return 0u;
	}

	public uint GetNpcLastTurnProcess()
	{
		return 0u;
	}

	public void NpcProcessUpgrade()
	{
	}

	public uint GetPlayerMaxProcess()
	{
		return 0u;
	}

	public uint GetTotalProcessMaxAmount()
	{
		return 0u;
	}

	public uint GetNpcMaxProcess()
	{
		return 0u;
	}

	public uint GetNpcProcessPreHour()
	{
		return 0u;
	}

	public uint GetRepeatAwardProcess()
	{
		return 0u;
	}

	public uint GetNowRepeatRewardTimes()
	{
		return 0u;
	}

	public uint GetNowToNextRepeatRewardProcess()
	{
		return 0u;
	}

	public uint GetPlayerProcessAll()
	{
		return 0u;
	}

	public uint GetPlayerGainProcessAll()
	{
		return 0u;
	}

	public uint GetTokenId()
	{
		return 0u;
	}

	public uint GetPlayerPorceePerToken()
	{
		return 0u;
	}

	public ulong GetNpcCountDownBeginTimeStamp()
	{
		return 0uL;
	}

	public uint GetPlayerWinExtraProcess()
	{
		return 0u;
	}

	public uint GetSettingPlayerRepeatProcess()
	{
		return 0u;
	}

	public uint GetMatchNpcPlayerLeftOrRight(uint useType)
	{
		return 0u;
	}

	public string GetPlayerIconCDNUrl(uint useType)
	{
		return null;
	}

	public string GetLeftCharBgCDNUrl(uint useType)
	{
		return null;
	}

	public string GetLeftCharNameBgCDNUrl(uint useType)
	{
		return null;
	}

	public string GetLeftCharDiaolgueBgCDNUrl(uint useType)
	{
		return null;
	}

	public string GetRightCharBgCDNUrl(uint useType)
	{
		return null;
	}

	public string GetRightCharNameBgCDNUrl(uint useType)
	{
		return null;
	}

	public string GetRightCharDiaolgueBgCDNUrl(uint useType)
	{
		return null;
	}

	public string GetSpecialDiaolgueBgCDNUrl(uint useType)
	{
		return null;
	}

	public string GetSpecialDialogueLeftCharNameBgCDNUrl(uint useType)
	{
		return null;
	}

	public string GetSpecialDiaolgueRightCharNameBgCDNUrl(uint useType)
	{
		return null;
	}

	public string GetSpecialDiaolgueClickIconCDNUrl(uint useType)
	{
		return null;
	}

	public string GetRoundWinIconCDNUrl(uint useType)
	{
		return null;
	}

	public string GetRoundEndNoticeBgCDNUrl(uint useType)
	{
		return null;
	}

	public string GetAddTokenButtonRectangleCDNUrl(uint useType)
	{
		return null;
	}

	public string GetAddTokenButtonBgCDNUrl(uint useType)
	{
		return null;
	}

	public string GetAddNoTokenButtonRectangleCDNUrl(uint useType)
	{
		return null;
	}

	public string GetAddNoTokenButtonBgCDNUrl(uint useType)
	{
		return null;
	}

	public string GetShowResultButtonRectangleCDNUrl(uint useType)
	{
		return null;
	}

	public string GetShowResultButtonBgCDNUrl(uint useType)
	{
		return null;
	}

	public string GetTotalProcessRepeatBoxBgCDNUrl(uint useType)
	{
		return null;
	}

	public string GetNoTokenWndBgCDNUrl(uint useType)
	{
		return null;
	}

	public string GetTotalProcessAwardMarkBgCDNUrl(uint useType)
	{
		return null;
	}

	public string GetTotalProcessAwardWndBgCDNUrl(uint useType)
	{
		return null;
	}

	public string GetDivideProcessIconCDNUrl(uint useType)
	{
		return null;
	}

	public string GetRewardPopBgCDNUrl(uint useType)
	{
		return null;
	}

	public string GetRewardPopButtonBgCDNUrl(uint useType)
	{
		return null;
	}

	public string GetRepeatAwardPopoverBgCDNUrl(uint useType)
	{
		return null;
	}

	public string GetTotalProcessDescBgCDNUrl(uint useType)
	{
		return null;
	}

	public string GetTotalProcessFrontCDNUrl(uint useType)
	{
		return null;
	}

	public string GetTotalProcessBgCDNUrl(uint useType)
	{
		return null;
	}

	public string GetResultWinWndTitleCDNUrl(uint useType)
	{
		return null;
	}

	public string GetResultLoseWndTitleCDNUrl(uint useType)
	{
		return null;
	}

	public string GetResultWndPlayerBgUrl(uint useType)
	{
		return null;
	}

	public string GetResultWndNPCBgUrl(uint useType)
	{
		return null;
	}

	public Color GetLeftDialogueTextColor(uint useType)
	{
		return default(Color);
	}

	public Color GetLeftCharProcessFilledColor(uint useType)
	{
		return default(Color);
	}

	public Color GetLeftCharProcessUnfilledColor(uint useType)
	{
		return default(Color);
	}

	public Color GetRightCharDiaolgueTextColor(uint useType)
	{
		return default(Color);
	}

	public Color GetRightCharProcessFilledColor(uint useType)
	{
		return default(Color);
	}

	public Color GetRightCharProcessUnfilledColor(uint useType)
	{
		return default(Color);
	}

	public Color GetSpecialDiaolgueTextColor(uint useType)
	{
		return default(Color);
	}

	public Color GetTotalProcessAwardWndCloseColor(uint useType)
	{
		return default(Color);
	}

	public Color GetTotalProcessDescTextColor(uint useType)
	{
		return default(Color);
	}

	public Color GetTotalProcessAwardMarkTextColor(uint useType)
	{
		return default(Color);
	}

	public Color GetTotalProcessFilledColor(uint useType)
	{
		return default(Color);
	}

	public Color GetTotalProcessUnFilledColor(uint useType)
	{
		return default(Color);
	}

	public Color GetNPCDescIconColor(uint useType)
	{
		return default(Color);
	}

	public Color GetCountdownTextColor(uint useType)
	{
		return default(Color);
	}

	public UIModelBigEventTemplate.LocStrWithColor GetNpcDescLoc(uint useType)
	{
		return null;
	}

	public string GetNoTokenWndTitleDescLoc(uint useType)
	{
		return null;
	}

	public UIModelBigEventTemplate.LocStrWithColor GetAddTokenButtonDescLocWithColor(uint useType)
	{
		return null;
	}

	public UIModelBigEventTemplate.LocStrWithColor GetShowResultButtonDescLocWithColor(uint useType)
	{
		return null;
	}

	public UIModelBigEventTemplate.LocStrWithColor GetRewardTitleDescLocWithColor(uint useType)
	{
		return null;
	}

	public UIModelBigEventTemplate.LocStrWithColor GetResultWndNpcNameLocWithColor(uint useType)
	{
		return null;
	}

	public UIModelBigEventTemplate.LocStrWithColor GetResultWndPlayerNameLocWithColor(uint useType)
	{
		return null;
	}

	private void ProcessMatchNpcVFX(uint useType)
	{
	}

	public BigEventTemplateVFXDesc GetBigEventVFXDesc(uint configKey)
	{
		return null;
	}

	private void _003CRequestMatchNpcRoundFinishedPlayerTotalProcess_003Eb__37_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestPlayerAccountInfo_003Eb__38_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestAddMatchNpcToken_003Eb__39_0(HttpErrorCode errorCode, object res)
	{
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	public void _003C_003EiFixBaseProxy_OnCleanup()
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
