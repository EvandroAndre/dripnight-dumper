using System.Collections.Generic;

namespace proto;

public class CSGetFFWSSettingRes
{
	public FFWSSettingDesc setting;

	public List<FFWSTeamInfoDesc> team_infos;

	public List<FFWSGuessingAwardDesc> awards;

	public List<FFWSDailyTaskTextDesc> daily_task;

	public List<FFWSSpecialTaskTextDesc> special_task;
}
