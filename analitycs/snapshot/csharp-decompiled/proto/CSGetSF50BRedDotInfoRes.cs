using System.Collections.Generic;

namespace proto;

public class CSGetSF50BRedDotInfoRes
{
	public bool has_progress_claimable;

	public SF50BAccountInfo info;

	public SF50BSettingDesc settings;

	public List<SF50BCareerProficiencyDesc> career_proficiencies;
}
