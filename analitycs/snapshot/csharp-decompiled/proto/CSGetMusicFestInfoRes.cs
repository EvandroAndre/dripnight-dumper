using System.Collections.Generic;

namespace proto;

public class CSGetMusicFestInfoRes
{
	public List<MusicFestPuzzleDetail> puzzles;

	public List<MusicFestTradeRecord> unreceived_tokens;

	public MusicFestRewardsInfo rewards_info;

	public uint send_cnt;
}
