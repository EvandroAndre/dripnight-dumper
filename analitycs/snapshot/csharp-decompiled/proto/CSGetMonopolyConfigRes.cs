using System.Collections.Generic;

namespace proto;

public class CSGetMonopolyConfigRes
{
	public List<MonopolyNodeDesc> nodes;

	public MonopolySettingDesc setting;

	public List<MonopolyEventDesc> events;
}
