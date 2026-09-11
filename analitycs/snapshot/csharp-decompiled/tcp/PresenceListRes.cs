using System.Collections.Generic;

namespace tcp;

public class PresenceListRes
{
	public List<PresenceInfo> presences;

	public uint account_list_type;

	public ulong[] offline_account_ids;
}
