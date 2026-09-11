using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIModelFriendObserve : UIBaseModel
{
	private sealed class _003C_003Ec__DisplayClass36_0
	{
		public UIModelFriendObserve _003C_003E4__this;

		public string cmd;

		public bool isHide;

		internal void _003CRequestSetSetDisableFriendSpectateInfo_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private uint m_CurWaitingTag;

	private ulong m_CurWaitingAccountID;

	private uint m_CurMatchMode;

	private uint m_CurGameMode;

	private ulong m_CurRoomId;

	private string m_CurWorkshopCode;

	private WaitingResponseHandler m_WaitingHandlerResponse;

	public const string FRIENDSPECTATEREDTIPKEY = "FriendSpectateRedTip_Key";

	private Dictionary<uint, SpectateRankLimitDesc> m_SpectateRankLimitDescDic;

	private uint m_ObserverRewardLimitPerPlayer;

	private uint m_ObserverRewardLimitPerDay;

	private uint m_RecvRewardLimitPerDay;

	private Dictionary<uint, SpectateCurrencyRewardDesc> m_ObserverRewardDescDic;

	public bool NeedUpdateWalletAfterReward;

	public bool NeedUpdateWalletAfterGetReward;

	public uint ObserverRewardLimitPerPlayer => 0u;

	public uint ObserverRewardLimitPerDay => 0u;

	public uint RecvRewardLimitPerDay => 0u;

	public uint CurWaitingTag => 0u;

	public string CurWorkshopCode => null;

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

	public void UpdateCurWaitingTagAndAccountId(uint tag, ulong accoutID, uint matchMode, uint gameMode, ulong roomId = 0uL, string workshopCode = null)
	{
	}

	public void ProcessTagOptioanlPatchDownloadFinished(ResErrorCode errorCode, uint tag)
	{
	}

	public void ProcessOptionalDownloadPause(uint tag)
	{
	}

	public void ProcessAfterObservsMapDownLoad(bool isAfterMapDownLoad)
	{
	}

	public bool CanCurPlayerStateObserveExceptInGroup()
	{
		return false;
	}

	private bool IsMatchMaking()
	{
		return false;
	}

	public void ClearWaitingData()
	{
	}

	public void RequestSetSetDisableFriendSpectateInfo(bool isHide)
	{
	}

	public void ProcessObserverRewardLimitDesc(SpectateCurrencySettingDesc observerRewardLimitDesc)
	{
	}

	public void ProcessObserverRewardDesc(List<SpectateCurrencyRewardDesc> observerRewardDesc)
	{
	}

	public void ProcessSpectateRankLimitDescs(List<SpectateRankLimitDesc> spectateRankLimitDescs)
	{
	}

	public uint GetSpectateRankLimitKey(uint matchMode, uint rank)
	{
		return 0u;
	}

	public SpectateCurrencyRewardDesc GetObserverRewardDescById(uint rewardID)
	{
		return null;
	}

	public SpectateCurrencyRewardDesc GetObserverRewardCoinDesc()
	{
		return null;
	}

	public bool CheckMeetSpectateRankLimit(uint matchMode, uint rank, ref uint levelLimit, ref string limitRankName)
	{
		return false;
	}

	public void OnLocalPlayerLeaveTeamTrySpectate(uint leaveType)
	{
	}

	public void EventLogUGCShowMapDownload(uint tag)
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
