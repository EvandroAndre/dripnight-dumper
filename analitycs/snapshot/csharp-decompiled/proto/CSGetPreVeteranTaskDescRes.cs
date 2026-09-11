using System.Collections.Generic;

namespace proto;

public class CSGetPreVeteranTaskDescRes
{
	public List<ClientVeteranTaskDesc> task_descs;

	public ulong start_time;

	public ulong end_time;
}
