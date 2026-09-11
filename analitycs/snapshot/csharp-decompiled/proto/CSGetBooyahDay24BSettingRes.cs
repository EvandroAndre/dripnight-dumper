using System.Collections.Generic;

namespace proto;

public class CSGetBooyahDay24BSettingRes
{
	public List<BigEventProgressAwardDesc> progress_awards;

	public BigEventProgressCycleAwardDesc cycle_award;

	public BooyahDay24BSettingDesc settings;

	public List<BooyahDay24BDimensionScoreDesc> dimension_scores;

	public List<BooyahDay24BDimensionBaseDesc> dimension_bases;

	public List<BooyahDay24BDimensionTitleDesc> dimension_titles;

	public List<BooyahDay24BGlobalProgressDesc> global_progresses;

	public List<BooyahDay24BStarDesc> star_descs;
}
