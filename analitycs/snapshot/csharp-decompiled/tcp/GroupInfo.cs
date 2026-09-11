using System.Collections.Generic;
using ProtoBuf;

namespace tcp;

public class GroupInfo : IMessage
{
	public ulong group_id;

	public string region;

	public bool auto_group;

	public uint group_mode;

	public List<GroupMemberInfo> members;

	public uint[] map_ids;

	public uint game_mode;

	public uint difficulty;

	public uint match_mode;

	public string group_code;

	public uint ranking_match_type;

	public bool is_public;

	public string secret_code;

	public uint required_rank;

	public string group_tag;

	public ulong voice_id;

	public string workshop_code;

	public string workshop_name;

	public MaxLobbyDisplayInfo max_lobby_display_info;

	public bool hide_captain_lobby;

	public uint max_required_rank;

	public EMatch.RoomMatchmakingType room_matchmaking_type;

	public uint[] workshop_tag_match_type_ids;

	public EGroup.State state;

	public bool is_hot_map;

	public bool need_resource_download;

	public uint special_mode_event_id;

	public string group_idc;

	public List<GroupReservationShowInfo> reservation_shows;

	public string reservation_code;

	public bool is_intra_team_battle;

	public string group_qr_code;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
