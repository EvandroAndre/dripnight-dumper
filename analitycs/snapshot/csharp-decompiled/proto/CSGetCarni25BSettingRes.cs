using System.Collections.Generic;

namespace proto;

public class CSGetCarni25BSettingRes
{
	public List<BigEventProgressAwardDesc> progress_awards;

	public BigEventProgressCycleAwardDesc cycle_award;

	public Carni25BSettingDesc settings;

	public List<Carni25BPlayerEventDesc> events;

	public List<Carni25BProgressDesc> progresses;

	public List<Carni25BChatDesc> chats;
}
