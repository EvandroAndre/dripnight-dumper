using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIModelBigEvent_PersonalProgress : UIBaseModel
{
	private sealed class _003C_003Ec__DisplayClass30_0
	{
		public UIModelBigEvent_PersonalProgress _003C_003E4__this;

		public uint processId;

		internal void _003CRequestClaimProgressRewards_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	public Dictionary<uint, CustomEventPersonalProgressDesc> DictProgressAwardsSettings;

	public List<uint> ListHaveClaimedRewardProgressId;

	private int m_TodayCurrentAssistCnt;

	private uint m_MaxProgressTokenAmount;

	private CustomEventShareConfigDesc m_CustomEventShareConfigDesc;

	private List<AssistanceInfo> m_AssistanceInfos;

	private List<ulong> m_AssistantIdsBetweenTimeList;

	private AssistanceInfoCompare m_assistanceInfoComparer;

	private bool m_needShowAssistanceInfo;

	public const int PropID_GetProgressSettingAndShareConfigDesc = 2;

	public const int PropID_GetPlayerShareInfo = 4;

	public const int PropID_ClaimProcessRewards = 8;

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

	private void ClearCachedData()
	{
	}

	public bool CanGetProgressSetting()
	{
		return false;
	}

	private CustomEventPersonalProgressDesc GetProgressSettingByProgressId(uint progressId)
	{
		return null;
	}

	public uint GetMaxProgressTokenAmount()
	{
		return 0u;
	}

	public uint GetPersonalProgressTokenAmountByProgressId(uint progressId)
	{
		return 0u;
	}

	public float GetPersonalProgressPercentageByProgressId(uint progressId)
	{
		return 0f;
	}

	public List<ulong> GetAssistantIdList()
	{
		return null;
	}

	public CustomEventShareConfigDesc GetCustomEventShareConfigDesc()
	{
		return null;
	}

	public uint GetTokenId()
	{
		return 0u;
	}

	public bool IsReachMaxAssistNum()
	{
		return false;
	}

	public bool IsClaimedFinalAward()
	{
		return false;
	}

	private List<ulong> GetAssistantIdsBetweenTimeList()
	{
		return null;
	}

	public bool NeedShowAssistanceInfo()
	{
		return false;
	}

	public void RequestPersonalProgressSettingAndShareConfig(uint useType, bool forceReq = false)
	{
	}

	public void RequestGetGetCustomEventPlayerShareInfo(uint useType)
	{
	}

	public void RequestClaimProgressRewards(uint useType, uint processId)
	{
	}

	private void _003CRequestPersonalProgressSettingAndShareConfig_003Eb__28_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestGetGetCustomEventPlayerShareInfo_003Eb__29_0(HttpErrorCode errorCode, object res)
	{
	}

	public void _003C_003EiFixBaseProxy_Login(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
