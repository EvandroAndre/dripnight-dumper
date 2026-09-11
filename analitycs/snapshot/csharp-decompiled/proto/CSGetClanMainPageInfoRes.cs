using System.Collections.Generic;

namespace proto;

public class CSGetClanMainPageInfoRes
{
	public ClanInfo clan_info;

	public List<ClanMemberWithAccountInfo> member_list;

	public List<ClanActivenessRecord> activeness_records;

	public long activeness_refresh_time;

	public uint[] claimed_act_award_level;
}
