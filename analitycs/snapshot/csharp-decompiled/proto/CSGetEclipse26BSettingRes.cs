using System.Collections.Generic;

namespace proto;

public class CSGetEclipse26BSettingRes
{
	public List<BigEventProgressAwardDesc> progress_awards;

	public BigEventProgressCycleAwardDesc cycle_award;

	public List<EclipseSettingDesc> settings;

	public List<EclipseLocalizationDesc> localizations;

	public List<EclipseShareSettingDesc> share_settings;
}
