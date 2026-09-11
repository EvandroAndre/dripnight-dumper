namespace proto;

public class CSGetFriendListReq
{
	public bool need_presence;

	public bool need_stats;

	public bool need_ranking_stats;

	public bool need_casual_stats;

	public bool need_cs_ranking_stats;

	public uint need_periodic_ranking_game_mode;

	public bool need_veteran_info;

	public bool need_pve_stats;

	public bool online_notify;

	public bool need_hippo_ranking_stats;

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}
}
