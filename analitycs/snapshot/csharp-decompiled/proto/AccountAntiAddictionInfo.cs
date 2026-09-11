using ProtoBuf;

namespace proto;

public class AccountAntiAddictionInfo : IMessage
{
	public EAntiAddiction.TotalTimeBanMode ban_mode;

	public uint unban_time;

	public long history_update_ts;

	public uint history_seconds;

	public string hint_string;

	public uint play_time;

	public AccountGuardianSettingInfo guardian_setting;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
