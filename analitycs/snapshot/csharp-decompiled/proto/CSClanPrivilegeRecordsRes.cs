using System.Collections.Generic;

namespace proto;

public class CSClanPrivilegeRecordsRes
{
	public ClanPrivilegeRecord current_privilege;

	public List<ClanPrivilegeRecord> upcoming_privileges;

	public List<ClanPrivilegeHistoryRecord> history_privileges;
}
