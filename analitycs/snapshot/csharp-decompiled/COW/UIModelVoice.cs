using System;
using System.Collections.Generic;
using GCommon;
using proto.Login;
using tcp;

namespace COW;

internal class UIModelVoice : UIBaseModel
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<VoiceChangerSettingData> _003C_003E9__35_0;

		internal int _003CGetAllVaildVoiceChangerSetting_003Eb__35_0(VoiceChangerSettingData a, VoiceChangerSettingData b)
		{
			return 0;
		}
	}

	public const uint PropID_VoiceChangerSettingChanged = 1u;

	private HashSet<ulong> m_MuteQuickChatVoicePlayerList;

	private float m_MutedTimeStamp;

	private uint m_MutedRemainMatch;

	private bool m_HasStartUploadContinuousAudio;

	private Dictionary<ulong, ulong> m_ReportedPlayerTimeDict;

	public const uint PropID_LocalUserBeVoiceMuted = 2u;

	private HashSet<ulong> m_ReportSucPlayers;

	private Dictionary<int, VoiceChangerSettingData> m_VoiceChangerSettingDataDic;

	private Dictionary<int, VoiceChangerSettingData> VoiceChangerSettingDataDic => null;

	public Dictionary<ulong, ulong> ReportedPlayerTimeDict => null;

	public override uint GetModelType()
	{
		return 0u;
	}

	public bool IsMuted()
	{
		return false;
	}

	public void InitAfterLogin(EGLJDBDMENB loginRes)
	{
	}

	public override void Login(object[] data)
	{
	}

	public void SetMutedTime(long timeToLive)
	{
	}

	public string CalMutedTime()
	{
		return null;
	}

	public bool TryReportVoice(ulong userID)
	{
		return false;
	}

	public void TryStartUploadContinuousAudio()
	{
	}

	public void TryStopUploadContinuousAudio()
	{
	}

	private void PopReportWnd()
	{
	}

	public void BeMutedTweenTips()
	{
	}

	public string GetBeMutedTipStr()
	{
		return null;
	}

	public void OnBeReportedPunish(AccountMicMuteTCP info)
	{
	}

	public void AddMuteQuickChatVoicePlayer(ulong aid)
	{
	}

	public void RemoveMuteQuickChatVoicePlayer(ulong aid)
	{
	}

	public bool IsMuteQuickChatVoicePlayer(ulong aid)
	{
		return false;
	}

	public override void Logout(object[] data)
	{
	}

	public void SetReportSuccessPlayer(ulong playerID)
	{
	}

	public bool HasReportPlayer(ulong playerID)
	{
		return false;
	}

	public void ClearReportSuccessPlayer()
	{
	}

	public bool IsVoiceChangerSwitchOpen()
	{
		return false;
	}

	public VoiceChangerSettingData GetVoiceChangerSetting(int id)
	{
		return null;
	}

	public List<VoiceChangerSettingData> GetAllVaildVoiceChangerSetting()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_Login(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
