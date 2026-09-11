using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class SocialBasicInfo : IMessage
{
	public ulong account_id;

	public ESocial.Gender gender;

	public ESocial.Language language;

	public ESocial.TimeOnline time_online;

	public ESocial.TimeActive time_active;

	public List<ESocial.PlayerBattleTagID> battle_tag;

	public List<ESocial.SocialTag> social_tag;

	public ESocial.ModePrefer mode_prefer;

	public string signature;

	public ESocial.RankShow rank_show;

	public uint[] battle_tag_count;

	public long signature_ban_expire_time;

	public LeaderboardTitleInfo leaderboard_titles;

	public string photo_wall_url;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
