using System.Collections.Generic;

namespace proto;

public class CSGetSF50BSettingRes
{
	public List<BigEventProgressAwardDesc> progress_awards;

	public BigEventProgressCycleAwardDesc cycle_award;

	public SF50BSettingDesc settings;

	public List<SF50BCareerBaseDesc> career_bases;

	public List<SF50BCareerProficiencyDesc> career_proficiencies;
}
