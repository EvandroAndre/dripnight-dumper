using System.Collections.Generic;

namespace proto;

public class CSGetFreshDescRes
{
	public List<NewPlayerLimitedTaskMainDesc> limit_task_main;

	public List<NewPlayerLimitedTaskDesc> limit_task;

	public NewPlayerLevelUpLimitTimeDesc limit_time;
}
