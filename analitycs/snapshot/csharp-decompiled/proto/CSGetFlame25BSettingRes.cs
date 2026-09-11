using System.Collections.Generic;

namespace proto;

public class CSGetFlame25BSettingRes
{
	public List<BigEventProgressAwardDesc> progress_awards;

	public Flame25BSettingDesc settings;

	public List<Flame25BLevelDesc> levels;

	public List<Flame25BPoseDesc> poses;

	public List<Flame25BClanDesc> clans;

	public List<Flame25BPropDesc> props;

	public List<Flame25BBadgeDesc> badges;

	public List<Flame25BPlayerEventDesc> player_events;

	public List<Flame25BGlobalEventDesc> global_events;
}
