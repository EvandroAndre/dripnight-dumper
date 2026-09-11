using System;
using GCommon;
using proto;

namespace COW;

public class UIModelNB1RESYS : UIBaseModel, IBigEventModel
{
	private sealed class _003C_003Ec__DisplayClass49_0
	{
		public UIModelNB1RESYS _003C_003E4__this;

		public string cmd;

		internal void _003CRequestWarmUpInfo_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	public const uint PropID_WarmUpInfo = 2u;

	private const string SelectBundlePrefsKey = "NB1RESYS_LobbyWarmUp_SelectedBundle_{0}_{1}";

	private readonly WaitingResponseHandler m_WaitingResponse;

	private NB1ReSysWarmUpSettingDesc _003CWarmUpSetting_003Ek__BackingField;

	private bool _003CHasNB1Token_003Ek__BackingField;

	private bool _003CHasNB1FinalReward_003Ek__BackingField;

	private bool _003CHasWarmUpInfo_003Ek__BackingField;

	private uint _003CMaxNB1Progress_003Ek__BackingField;

	private string _003CNB1FinalRewardClaimedDate_003Ek__BackingField;

	public NB1ReSysWarmUpSettingDesc WarmUpSetting
	{
		get
		{
			return _003CWarmUpSetting_003Ek__BackingField;
		}
		private set
		{
			_003CWarmUpSetting_003Ek__BackingField = value;
		}
	}

	public bool HasNB1Token
	{
		get
		{
			return _003CHasNB1Token_003Ek__BackingField;
		}
		private set
		{
			_003CHasNB1Token_003Ek__BackingField = value;
		}
	}

	public bool HasNB1FinalReward
	{
		get
		{
			return _003CHasNB1FinalReward_003Ek__BackingField;
		}
		private set
		{
			_003CHasNB1FinalReward_003Ek__BackingField = value;
		}
	}

	public bool HasWarmUpInfo
	{
		get
		{
			return _003CHasWarmUpInfo_003Ek__BackingField;
		}
		private set
		{
			_003CHasWarmUpInfo_003Ek__BackingField = value;
		}
	}

	public uint MaxNB1Progress
	{
		get
		{
			return _003CMaxNB1Progress_003Ek__BackingField;
		}
		private set
		{
			_003CMaxNB1Progress_003Ek__BackingField = value;
		}
	}

	public string NB1FinalRewardClaimedDate
	{
		get
		{
			return _003CNB1FinalRewardClaimedDate_003Ek__BackingField;
		}
		private set
		{
			_003CNB1FinalRewardClaimedDate_003Ek__BackingField = value;
		}
	}

	public uint AdditionalPrice => 0u;

	public uint AdditionalOriginalPrice => 0u;

	public uint LastGrandPrizePartId => 0u;

	public override uint GetModelType()
	{
		return 0u;
	}

	public UIABigEventLobbyEnterWndControler GetBigEventLobbyEnterWnd()
	{
		return null;
	}

	public UIBigEventLobbyIconWndController GetBigEventLobbyIconWnd()
	{
		return null;
	}

	public Type GetLobbyEntranceType()
	{
		return null;
	}

	public bool IgnoreCheckOptionalDownload()
	{
		return false;
	}

	public bool OptionalResNeedDownload()
	{
		return false;
	}

	public bool CheckOpenedActivityView()
	{
		return false;
	}

	public void GotoBigEvent(string from, UIModelBigEvent.EBigEventEntranceID entranceId, ELimitedEvent.EventState activityState, string param, ulong subType3, object extra)
	{
	}

	public bool CanGotoWhenBigEventClosed()
	{
		return false;
	}

	public bool CanIngoreDownloadRes(UIModelBigEvent.EBigEventEntranceID entranceId)
	{
		return false;
	}

	public void OnProcessEventOpenInfo()
	{
	}

	public override void ClearCache()
	{
	}

	public override void Logout(object[] data)
	{
	}

	public int GetWarmUpSelectedBundle(int defaultBundle)
	{
		return 0;
	}

	public void SaveWarmUpSelectedBundle(int selectedBundle)
	{
	}

	private string GetWarmUpSelectionPrefsKey()
	{
		return null;
	}

	public void RequestWarmUpInfo()
	{
	}

	private void SetWarmUpInfo(CSGetNB1ReSysWarmUpInfoRes res)
	{
	}

	private uint GetMaxProgress(CSGetNB1ReSysWarmUpInfoRes res)
	{
		return 0u;
	}

	private void ClearWarmUpInfo()
	{
	}

	public void _003C_003EiFixBaseProxy_ClearCache()
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
