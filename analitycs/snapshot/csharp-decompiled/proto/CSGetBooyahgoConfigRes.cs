using System.Collections.Generic;

namespace proto;

public class CSGetBooyahgoConfigRes
{
	public List<BooyahgoNodeDesc> nodes;

	public BooyahgoMiniGameSettingDesc setting;

	public List<BooyahgoEventDesc> events;

	public List<BooyahgoSkullKingActivityDesc> skull_kings;
}
