using ProtoBuf;

namespace proto;

public class AntiAddictionSwitchDesc : IMessage
{
	public string country;

	public bool function_switch;

	public string limit_age;

	public bool children_group;

	public bool skip;

	public string remind_cdn;

	public string ban_mode_cdn;

	public bool age_certification_switch;

	public uint[] phone_num_control_list;

	public uint cd_time;

	public uint daily_reset_hour;

	public bool lobby_time_switch;

	public bool message_send_switch;

	public string region;

	public bool ugc_offline_time_switch;

	public EAntiAddiction.AntiAddictionType anti_addiction_type;

	public EAntiAddiction.PlayTimeResetType play_time_reset_type;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
