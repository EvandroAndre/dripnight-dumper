using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class CSChampionshipBasicInfoRes : IMessage
{
	public List<ChampionshipOpenInfoDesc> open_infos;

	public uint limited_level;

	public uint limited_rank;

	public List<ChampionshipScoreRewardDesc> reward_infos;

	public List<ChampionshipSettingDesc> setting_infos;

	public List<ChampionshipScoreBaseDesc> score_bases;

	public List<ChampionshipNameOverwriteDesc> name_overwrite_infos;

	public List<ChampionshipTeamDesc> team_settings;

	public bool isInBlacklist;

	public uint upper_limited_level;

	public uint upper_limited_rank;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
