namespace tcp;

public class AntiAddictionInitReq
{
	public uint age_state;

	public long history_update_ts;

	public uint history_seconds;

	public bool is_reconnect;

	public AntiAddictionGuardianSetting guardian_setting;

	public AntiAddictionAgeAuthInfo auth_info;
}
