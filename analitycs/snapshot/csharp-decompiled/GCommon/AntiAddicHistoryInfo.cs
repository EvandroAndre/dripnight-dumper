using proto;

namespace GCommon;

public class AntiAddicHistoryInfo
{
	public bool IsAntiAddicActivated;

	public bool LobbyTimeSwitch;

	public bool IsReconnect;

	public uint AgeState;

	public string AgeType;

	public uint AuthStateIndex;

	public long HistoryUpdateTs;

	public uint HistorySeconds;

	public AccountGuardianSettingInfo GuardianSetting;

	public AntiAddictionAgeAuthInfo AuthInfo;

	public EAntiAddiction.TotalTimeBanMode BanMode;
}
