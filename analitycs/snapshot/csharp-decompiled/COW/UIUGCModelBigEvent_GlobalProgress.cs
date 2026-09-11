using System;
using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIUGCModelBigEvent_GlobalProgress : UIBaseModel
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003E9__24_1;

		internal CommonRewardItemInfo _003CRequestClaimProcessRewards_003Eb__24_1(BaseItemInfo item)
		{
			return null;
		}
	}

	private sealed class _003C_003Ec__DisplayClass22_0
	{
		public UIUGCModelBigEvent_GlobalProgress _003C_003E4__this;

		public uint useType;

		internal void _003CRequestGlobalProgressSetting_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass23_0
	{
		public UIUGCModelBigEvent_GlobalProgress _003C_003E4__this;

		public uint useType;

		internal void _003CRequestGetCurrentGlobalProgressValue_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass24_0
	{
		public UIUGCModelBigEvent_GlobalProgress _003C_003E4__this;

		public uint useType;

		public uint processId;

		internal void _003CRequestClaimProcessRewards_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass25_0
	{
		public UIUGCModelBigEvent_GlobalProgress _003C_003E4__this;

		public uint useType;

		internal void _003CRequestGetRewardState_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	private Dictionary<uint, ulong> m_DictUseTypeToCurrentGloabalProgressValue;

	public Dictionary<uint, Dictionary<uint, CustomEventProcessSettingDesc>> DictUseTypeToDictProcessSettings;

	private readonly Dictionary<uint, List<uint>> m_DictUseTypeToListProcessIdHaveClaimedReward;

	public const int PropID_GetProcessSettingDesc = 2;

	public const int PropID_GetRewardStateInfo = 4;

	public const int PropID_GetGlobalProgressValue = 8;

	public const int PropID_ClaimProcessRewards = 16;

	public override uint GetModelType()
	{
		return 0u;
	}

	public override void Init()
	{
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

	public bool HasGetProcessSetting(uint useType)
	{
		return false;
	}

	private CustomEventProcessSettingDesc GetProcessSettingByProcessId(uint useType, uint processId)
	{
		return null;
	}

	public float GetCurrentGlobalProgressPercentage(uint useType)
	{
		return 0f;
	}

	public ulong GetCurrentGlobalProgressValue(uint useType)
	{
		return 0uL;
	}

	private ulong GetMaxGloabalProgressValue(uint useType)
	{
		return 0uL;
	}

	public ulong GetGlobalProgressEndValueByProcessId(uint useType, uint process)
	{
		return 0uL;
	}

	public float GetGlobalProgressPercentageByProcessId(uint useType, uint process)
	{
		return 0f;
	}

	public int GetCanClaimRewardCount(uint useType)
	{
		return 0;
	}

	public bool GetRewardStateByIndex(uint useType, uint processId, out EActivity.State state)
	{
		state = default(EActivity.State);
		return false;
	}

	public bool IsLobbyEntranceTipsNeedShow(uint useType)
	{
		return false;
	}

	public void RequestGlobalProgressSetting(uint useType, bool forceReq = false)
	{
	}

	public void RequestGetCurrentGlobalProgressValue(uint useType)
	{
	}

	public void RequestClaimProcessRewards(uint useType, uint processId)
	{
	}

	public void RequestGetRewardState(uint useType)
	{
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	public void _003C_003EiFixBaseProxy_Login(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
