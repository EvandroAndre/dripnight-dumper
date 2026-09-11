namespace tcp;

public class MatchStatsRes
{
	public ulong account_id;

	public ulong match_id;

	public uint level_before;

	public uint level_after;

	public byte[] income;

	public byte[] match_stats;

	public uint group_mode;

	public HuntingGroundRecords hg_record_before;

	public HuntingGroundLikePVERecords hgl_pve_record_before;

	public byte[] match_stats_brief;

	public byte[] cs_match_stats_brief;

	public HippoMatchStatsBrief hippo_match_stats_brief;
}
