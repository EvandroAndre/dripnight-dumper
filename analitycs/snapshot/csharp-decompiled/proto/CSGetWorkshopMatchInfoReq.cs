namespace proto;

public class CSGetWorkshopMatchInfoReq
{
	public uint player_cnt;

	public EWorkshop.MatchPoolType match_pool_type;

	public bool is_in_group;

	public ulong[] member_ids;
}
