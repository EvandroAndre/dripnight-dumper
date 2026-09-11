using System.Collections.Generic;

namespace proto;

public class CSGetSupercarSettingRes
{
	public SupercarSettingDesc supercar_setting;

	public List<SupercarSpeedDesc> cars;

	public List<SupercarRoundAward> awards;
}
