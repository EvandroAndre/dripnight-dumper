using System.Collections.Generic;
using ProtoBuf;

namespace tcp;

public class GroupMemberInfo : IMessage
{
	public ulong account_id;

	public string nickname;

	public string region;

	public ulong join_time;

	public uint level;

	public uint avatar_id;

	public uint skin_color;

	public uint[] clothes;

	public bool ready;

	public uint rank;

	public uint ranking_points;

	public uint banner_id;

	public uint head_pic;

	public uint role;

	public uint[] shows;

	public GroupMemberPetInfo pet_info;

	public uint pve_weapon_id;

	public uint[] available_maps;

	public uint cs_rank;

	public uint cs_ranking_points;

	public uint pin_id;

	public bool is_cs_ranking_ban;

	public List<IntimacyRelation> intimacy_relations;

	public uint using_version;

	public bool is_emulator;

	public uint game_bag_show;

	public uint peak_rank_pos;

	public uint cs_peak_rank_pos;

	public uint periodic_rank;

	public uint periodic_ranking_points;

	public List<CreditPunishInfo> credit_punish_info;

	public EGroup.PlayerPatchOptionalResStatus patch_optional_res_status;

	public uint platform_type;

	public uint[] skills;

	public List<MMRInfo> mmr_info;

	public uint cs_ranking_streak_wins;

	public uint[] clothes_tailor_effects;

	public AccountPVEInfo pve_info;

	public uint ranking_streak_wins;

	public uint title;

	public bool is_sixthb_distributor;

	public ExternalIconInfo external_icon_info;

	public List<LoadoutInfo> loadouts;

	public bool auto_start;

	public List<WeaponSkinStat> weapon_skin_stat;

	public AccountMatchVeteranData veteran_data;

	public LeaderboardTitleInfo leaderboard_titles;

	public ulong clan_id;

	public string clan_name;

	public uint load_out_v2;

	public uint monster_invasion_boss_progress;

	public uint monster_invasion_slay_dragon_cnt;

	public List<AccountOccupationData> select_occupations;

	public List<SocialHighLight> social_high_lights;

	public bool is_seventhb_distributor;

	public EGroup.PlayerState player_state;

	public uint[] unavailable_game_modes;

	public PresenceInfo presence_info;

	public WorkshopVipInfo workshop_vip_info;

	public List<ItemTagInfo> item_tag_info;

	public uint credit_score;

	public bool workshop_vip_switch;

	public uint periodic_summary_level;

	public HippoInventoryGSEnterInfo hippo_equip_info;

	public uint hippo_rank;

	public List<RankingStatsSummary> ranking_stats_summary;

	public ModeStatsInfo mode_stats_info;

	public EighthBApplyDecorationInfo eighthb_apply_decoration_info;

	public bool is_eighthb_distributor;

	public BadgeInfo badge_info;

	public PrimePrivilegeDetail prime_privilege_detail;

	public bool is_wearing_shared_set;

	public SharedSetInfo shared_set;

	public uint prime_sharee_remain_times;

	public List<MapVersionInfo> map_versions;

	public uint clan_badge;

	public List<CreditPunishOtherInfo> credit_punish_other_info;

	public uint clan_frame_id;

	public TransformEmoteInfo transform_emote_info;

	public uint cs_peak_points;

	public bool display_cs_peak_point;

	public uint avatar_frame;

	public Flame25BLoadingCardInfo loading_card_info;

	public string gp_player_id;

	public AntiAddictionAgeAuthInfo br_auth_info;

	public GuardianTextChatSetting text_chat_setting;

	public GuardianVoiceChatSetting voice_chat_setting;

	public List<AccountCollectionCustomItemInfo> collection_custom_list;

	public EGroup.PlayerDisplayState display_state;

	public long game_start_ts;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
