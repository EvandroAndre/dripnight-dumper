using System.Collections.Generic;

namespace proto;

public class CSGetVeteranTaskDescRes
{
	public List<ClientVeteranTaskDesc> task_descs;

	public ulong veteran_expire_time;

	public List<ClientVeteranTaskDesc> short_daily_task_desc;
}
