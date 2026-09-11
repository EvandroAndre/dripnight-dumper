using System.Collections.Generic;

namespace tcp;

public class RoomPlayerInfo
{
	public ulong group_id;

	public ulong account_id;

	public string nickname;

	public uint emulator_score;

	public uint head_pic;

	public bool ready;

	public uint banner_id;

	public uint role;

	public uint[] available_maps;

	public uint pin_id;

	public uint using_version;

	public uint rank;

	public uint ranking_points;

	public uint cs_rank;

	public uint cs_ranking_points;

	public ulong voice_id;

	public uint peak_rank_pos;

	public uint cs_peak_rank_pos;

	public ERoom.PlayerPatchOptionalResStatus patch_optional_res_status;

	public bool is_matchmaking;

	public bool is_offline;

	public ExternalIconInfo external_icon_info;

	public AccountMatchVeteranData veteran_data;

	public string lock_region;

	public uint[] skills;

	public uint[] pet_skills;

	public uint[] loadouts;

	public uint loadout_v2;

	public BadgeInfo badge_info;

	public PrimePrivilegeDetail prime_privilege_detail;

	public List<MapVersionInfo> map_versions;

	public uint cs_peak_points;

	public bool display_cs_peak_point;

	public uint avatar_frame;

	public AntiAddictionAgeAuthInfo br_auth_info;

	public GuardianTextChatSetting text_chat_setting;

	public GuardianVoiceChatSetting voice_chat_setting;

	public uint[] available_active_skills;

	public uint pet_id;

	public bool from_workshop_halfway_join;
}
