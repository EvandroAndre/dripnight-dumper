using System.Collections.Generic;

namespace proto;

public class CSGetNinthSysSettingRes
{
	public List<BigEventProgressAwardDesc> progress_awards;

	public NinthSysSettingDesc setting;

	public List<NinthSysAwardDesc> awards;

	public List<NinthSysActivityMultiRewardDesc> activity_multi_rewards;

	public List<NinthSysSkillDesc> skills;

	public List<NinthSysEventDesc> events;

	public List<NinthSysGamePlayDesc> game_plays;

	public List<NinthSysActivityTipsDesc> activity_tips;
}
