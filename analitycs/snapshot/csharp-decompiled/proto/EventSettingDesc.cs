using ProtoBuf;

namespace proto;

public class EventSettingDesc : IMessage
{
	public uint ep_event_id;

	public string start_time;

	public string end_time;

	public string ep_event_name;

	public uint ep_badge;

	public uint gold_limit_improved;

	public uint fp_challenge;

	public long start_timestamp;

	public long end_timestamp;

	public uint completion_per_round;

	public uint completion_per_day;

	public string lobby_icon;

	public string hdep_lobby_vfx;

	public uint interval2;

	public uint interact_exp;

	public uint interact_receive;

	public uint interact_give;

	public string bp_icon;

	public string bp_cdn1;

	public string bp_cdn2;

	public uint max_shared_player_num;

	public uint task_refresh_num;

	public string fp_popover_lv;

	public string fp_popover_day;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
