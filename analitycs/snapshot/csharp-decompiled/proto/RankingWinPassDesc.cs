using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class RankingWinPassDesc : IMessage
{
	public uint season_start;

	public uint season_end;

	public uint stage;

	public uint progress;

	public List<AwardDesc> awards;

	public ERanking.WinPassType type;

	public bool pre_show;

	public uint win_rank_rate;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
