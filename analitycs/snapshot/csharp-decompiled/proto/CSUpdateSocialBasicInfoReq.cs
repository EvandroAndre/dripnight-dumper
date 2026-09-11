using System.Collections.Generic;

namespace proto;

public class CSUpdateSocialBasicInfoReq
{
	public ESocial.Gender gender;

	public ESocial.Language language;

	public ESocial.TimeOnline time_online;

	public ESocial.TimeActive time_active;

	public List<ESocial.PlayerBattleTagID> battle_tag;

	public List<ESocial.SocialTag> social_tag;

	public ESocial.ModePrefer mode_prefer;

	public string signature;

	public ESocial.RankShow rank_show;

	public uint[] weapon_power_select_titles;

	public uint[] guild_war_select_titles;

	public ulong group_id;

	public ulong room_id;

	public List<AreaLeaderboardSelectTitle> area_leaderboard_select_titles;

	public uint[] cs_peak_select_titles;
}
