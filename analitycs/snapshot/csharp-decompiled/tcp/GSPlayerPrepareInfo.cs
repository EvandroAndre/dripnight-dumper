using System.Collections.Generic;

namespace tcp;

public class GSPlayerPrepareInfo
{
	public ulong account_id;

	public string nickname;

	public uint level;

	public uint avatar_id;

	public uint skin_color;

	public uint[] clothes;

	public uint[] slots;

	public ulong group_id;

	public EMatch.GroupMode group_mode;

	public uint room_role;

	public int ranking_points;

	public uint[] skills;

	public string lock_region;

	public string noti_region;

	public uint banner_id;

	public uint head_pic;

	public string clan_name;

	public uint season_rank;

	public List<LoadoutInfo> loadouts;

	public bool has_elite_pass;

	public uint badge_cnt;

	public uint badge_id;

	public bool use_cache;

	public uint ep_goldlimit_bonus;

	public bool show_rank;

	public List<EmoteInfo> emotes;

	public string group_name;

	public List<RedEnvelopeInfo> red_envelopes;

	public uint[] shows;

	public PetInfo pet_info;

	public uint pve_primary_weapon_skin;

	public WalletInfo wallet;

	public uint pin_id;

	public string group_abbr_name;

	public uint game_bag_show;

	public ulong voice_id;

	public ulong pre_group_id;

	public uint clan_badge;

	public ulong clan_id;

	public uint workshop_team_index;

	public uint peak_rank_pos;

	public TrainingTokenInfo training_token_info;

	public List<IngameItem> ingame_items;

	public List<ReviveTokenInfo> revive_tokens;

	public uint wta_currency_type;

	public WarmGameInfo warmGame;

	public ChampionshipInfo championship_info;

	public TokenCupMatchInfo cup_info;

	public LinkageInfo linkage_activity_info;

	public uint[] clothes_tailor_effects;

	public uint season_rank_sort;

	public uint cs_rank;

	public uint cs_peak_rank_pos;

	public uint[] collection_actions;

	public QuickMsgSettings quick_msg_settings;

	public uint[] collection_skill_skins;

	public uint load_out_v2;

	public PVETalentInfo pve_talent;

	public PVEReviveTokenInfo pve_revive_token_info;

	public List<PVEBuffTokenInfo> pve_buff_token_info;

	public uint[] selected_final_shots;

	public List<WeaponSkinCustom> weapon_skin_customs;

	public WorkshopVipInfo workshop_vip_info;

	public uint selected_super_emote;

	public bool disable_friend_spectate;

	public ulong spectate_account_id;

	public ulong[] friends_in_game;

	public uint cur_day_spec_reward_cnt;

	public long cur_day_spec_reward_cnt_time;

	public bool workshop_vip_switch;

	public BadgeInfo badge_info;

	public uint role;

	public PrimePrivilegeDetail prime_privilege_detail;

	public uint title_id;

	public uint cs_peak_points;

	public uint avatar_frame;

	public string gp_player_id;

	public List<WorkshopTokenInfo> workshop_token_infos;

	public uint selected_finish_move;

	public AntiAddictionAgeAuthInfo br_auth_info;

	public GuardianTextChatSetting text_chat_setting;

	public GuardianVoiceChatSetting voice_chat_setting;

	public bool is_friend_half_join;

	public List<AccountCollectionCustomItemInfo> collection_custom_list;

	public string shared_nick_name;
}
