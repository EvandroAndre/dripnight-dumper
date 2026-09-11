using ProtoBuf;

namespace proto;

public class LobbyGameEnterStyleDesc : IMessage
{
	public uint event_id;

	public string start_time;

	public string end_time;

	public string lobby_start_icon;

	public string lobby_start_vfx;

	public string lobby_start_fontcolor;

	public string match_fontcolor;

	public string lobby_mode_icon;

	public string lobby_mode_vfx;

	public string mode_fontcolor;

	public string mode_map_fontcolor;

	public string mode_ranked_fontcolor;

	public string mode_buff_fontcolor;

	public string mode_buff_vfx;

	public string lobby_mode_bg;

	public string match_queue_icon;

	public string preset_icon;

	public string preset_bg;

	public string info_preset_icon;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
