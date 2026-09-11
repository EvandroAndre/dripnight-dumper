namespace proto;

public class CSGetPlatformFriendListReq
{
	public string token;

	public uint platform_sdk_id;

	public uint platform_type;

	public bool need_presence;

	public bool need_stats;

	public bool need_ranking_stats;

	public bool need_casual_stats;

	public bool need_cs_ranking_stats;

	public bool need_pve_stats;

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
