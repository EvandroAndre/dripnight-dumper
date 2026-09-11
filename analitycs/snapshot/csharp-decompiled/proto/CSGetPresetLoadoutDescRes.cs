using System.Collections.Generic;

namespace proto;

public class CSGetPresetLoadoutDescRes
{
	public List<LoadoutRecommendTabDesc> tab_desc_list;

	public List<LoadoutRecommendEntryDesc> entry_desc_list;

	public LoadoutBuildSettingDesc settings;
}
