using System.Collections.Generic;

namespace proto;

public class Create25BSettingDesc
{
	public uint token_id;

	public uint vote_all_in;

	public uint go_pos;

	public string br_sub_go_pos;

	public string br_backup_sub_go_pos;

	public string cs_sub_go_pos;

	public string cs_backup_sub_go_pos;

	public uint claimed_build_count;

	public List<AwardDesc> award;

	public uint mail_receive_day;
}
