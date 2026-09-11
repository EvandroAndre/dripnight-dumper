using System.Collections.Generic;

namespace tcp;

public class GroupAcceptReq
{
	public ulong group_id;

	public ulong inviter_account_id;

	public uint[] available_maps;

	public string group_code;

	public EGroup.InviteChannelType invite_channel_type;

	public uint system_platform;

	public MatchClientInfo client_info;

	public string secret_code;

	public List<AccountIDCPingInfo> ping_list;

	public bool auto_accept;

	public string language;

	public ulong original_group_id;

	public string recruit_code;

	public uint[] unavailable_game_modes;

	public ulong original_room_id;

	public List<AccountIDCPingInfo> proxy_ping_list;

	public string group_qr_code;

	public List<MapVersionInfo> map_versions;

	public List<AccountIDCPingInfo> voice_ping_list;

	public TransformEmoteInfo transform_emote_info;

	public string gp_player_id;

	public string ugc_social_url;

	public bool set_unready;

	public EGroup.PlayerDisplayState display_state;

	public RecruitPlayerBasicInfo recruit_player_basic_info;
}
