using System.Collections.Generic;

namespace proto;

public class CSGetNColor25BSettingRes
{
	public List<BigEventProgressAwardDesc> progress_awards;

	public BigEventProgressCycleAwardDesc cycle_award;

	public NColor25BSettingDesc settings;

	public List<NColor25BMentorSettingDesc> mentor_settings;

	public List<NColor25BChallengeSettingDesc> challenge_settings;

	public List<NColor25BGameplayDesc> gameplay_settings;

	public List<NColor25BNinjutsuDesc> ninjutsu_settings;

	public List<NColor25BKeepsakeDesc> keepsake_settings;
}
