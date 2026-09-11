using System;
using System.Collections.Generic;
using COW.OpSysExt;
using GCommon;
using SimpleJSON;
using proto;

namespace COW;

public class UIModelAgeCtrlByStore : UIBaseModel
{
	[Serializable]
	private class PlayerLocalInfo
	{
		public string InstallID;

		public ulong LastBanCheckTimeStamp;
	}

	private class StrategyPerAgeRange
	{
		public enum Feature
		{
			Login,
			Social
		}

		public enum Policy
		{
			Allow,
			Verify,
			Ban
		}

		public UserAgeMgr.AgeRange Range;

		public Dictionary<int, int> Details;

		public string[] Policies;

		public static readonly Dictionary<string, StrategyPerAgeRange> PREDEFINED_STRATEGIES;

		public static readonly Dictionary<string, UserAgeMgr.AgeRange> PREDEFINED_AGE_RANGES;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<StrategyPerAgeRange, int> _003C_003E9__25_0;

		public static Converter<int, string> _003C_003E9__25_1;

		public static Action _003C_003E9__44_0;

		internal int _003CCalculateAgeGates_003Eb__25_0(StrategyPerAgeRange s)
		{
			return 0;
		}

		internal string _003CCalculateAgeGates_003Eb__25_1(int g)
		{
			return null;
		}

		internal void _003CPromptToQuit_003Eb__44_0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass27_0
	{
		public string user;

		internal bool _003CContainedIn_003Eb__0(string cfgElement)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass32_0
	{
		public UIModelAgeCtrlByStore _003C_003E4__this;

		public string minor_policy;

		public Action _003C_003E9__1;

		internal void _003CPrecheckWithServer_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}

		internal void _003CPrecheckWithServer_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass33_0
	{
		public UIModelAgeCtrlByStore _003C_003E4__this;

		public string minor_policy;

		internal void _003CHandlePrecheckResult_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass35_0
	{
		public UIModelAgeCtrlByStore _003C_003E4__this;

		public string installID;

		public Action _003C_003E9__1;

		internal void _003CBanCheckWithServer_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}

		internal void _003CBanCheckWithServer_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass41_0
	{
		public UserAgeMgr.AgeResult ageResult;

		public UIModelAgeCtrlByStore _003C_003E4__this;

		public EAntiAddiction.AgeCtrlResult result;

		internal void _003CNotifyServerWithAgeCtrlAPIResult_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	public const uint PropID_ProceedToLobby = 2u;

	private const string PLAYER_PREFS_KEY_AGE_INFO_FOR_PLAYER = "AgeCtrlByStore_PlayerLocalInfo_{0}";

	private const string PLAYER_PREFS_KEY_AGE_API_RETRY_INTV = "AgeCtrlByStore_APIRetryIntv_S";

	private const string PLAYER_PREFS_KEY_AGE_API_LAST_RETRYABLE_FAILURE_TIMESTAMP = "AgeCtrlByStore_APIRetryableFailureTimestamp";

	private const string PLAYER_PREFS_KEY_AGE_API_FAIL_CNT = "AgeCtrlByStore_APIFailCnt";

	private StrategyPerAgeRange[] _AgeCtrlStrategies;

	private List<AgePolicyPreCheckDesc> _PrecheckCfg;

	private List<AgePolicyConfigDesc> _PolicyCfg;

	private static PlayerLocalInfo CurrentPlayerLocalInfo
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private ulong UserAgeAPINextRetryTimeStamp => 0uL;

	public override uint GetModelType()
	{
		return 0u;
	}

	private void ClearAgeAPIFailureRecords()
	{
	}

	private bool RecordAgeAPIFailure(bool expBackoff)
	{
		return false;
	}

	public override void Logout(object[] data)
	{
	}

	public void SetPrecheckCfg(List<AgePolicyPreCheckDesc> agePolicyPreCheckDescs)
	{
	}

	public void SetAgePolicyCfg(List<AgePolicyConfigDesc> agePolicyConfigDescs)
	{
	}

	private static StrategyPerAgeRange[] ParseAgeCtrlStrategies(string strategies)
	{
		return null;
	}

	private static UserAgeMgr.AgeRange ParseAgeRange(JSONNode obj)
	{
		return null;
	}

	private static StrategyPerAgeRange.Feature? ParseFeature(string featureStr)
	{
		return null;
	}

	private static StrategyPerAgeRange.Policy? ParsePolicy(string policyStr)
	{
		return null;
	}

	private static int[] CalculateAgeGates(StrategyPerAgeRange[] strategies)
	{
		return null;
	}

	public void CheckAgeCtrl()
	{
	}

	private static bool ContainedIn(string user, string cfg)
	{
		return false;
	}

	private string GetMinorPolicyFromPrecheckCfg()
	{
		return null;
	}

	private bool GetPolicyFromCfg(string policy_name, out AgePolicyConfigDesc cfgByPolicyName, out AgePolicyConfigDesc cfgByRegionAndCountry)
	{
		cfgByPolicyName = null;
		cfgByRegionAndCountry = null;
		return false;
	}

	private bool ProcessPolicyCfg(AgePolicyConfigDesc policyDesc)
	{
		return false;
	}

	private bool CanMinorUseFeature(UserAgeMgr.AgeRange ageRange, StrategyPerAgeRange.Feature feature)
	{
		return false;
	}

	private void PrecheckWithServer(string minor_policy)
	{
	}

	private void HandlePrecheckResult(string minor_policy, CSAccountAgeCtrlByStoreInfoRes ageCtrlByStoreInfo)
	{
	}

	private void HandlePrecheckMinor_Android(CSAccountAgeCtrlByStoreInfoRes info, AgePolicyConfigDesc desc)
	{
	}

	private void BanCheckWithServer(string installID)
	{
	}

	private void BanAckToServer(string installID)
	{
	}

	private void CallAgeCtrlAPI()
	{
	}

	private void _CallAgeCtrlAPI()
	{
	}

	private void HandleAgeCtrlAPIResult_Android(UserAgeMgr.AgeResult ageResult)
	{
	}

	private void HandleAgeCtrlAPIResult(UserAgeMgr.AgeResult ageResult)
	{
	}

	private void NotifyServerWithAgeCtrlAPIResult(UserAgeMgr.AgeResult ageResult, string installID = null)
	{
	}

	private bool MaybePromptWhenBannedByStrategy(int minAgeToPlay)
	{
		return false;
	}

	private void PromptToRetryAgeCtrlAPI(string content)
	{
	}

	private void PromptToQuit(string content)
	{
	}

	private void PromptUserBlockedByAgeCtrl(string content, string buttonText = null, ulong countdownSecs = 0uL, Action onClick = null)
	{
	}

	private void _003CBanAckToServer_003Eb__36_0(HttpErrorCode errorCode, object res)
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
