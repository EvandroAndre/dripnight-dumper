using System.Collections.Generic;

namespace proto;

public class CSGetWinterLand25BSettingRes
{
	public List<BigEventProgressAwardDesc> progress_awards;

	public BigEventProgressCycleAwardDesc cycle_award;

	public List<BigEventProgressAwardDesc> mini_game_progress_awards;

	public WinterLand25BSettingDesc setting;

	public List<WinterLand25BMiniGameCandyDesc> mini_game_candies;

	public List<WinterLand25BDreamWordDesc> dream_words;
}
