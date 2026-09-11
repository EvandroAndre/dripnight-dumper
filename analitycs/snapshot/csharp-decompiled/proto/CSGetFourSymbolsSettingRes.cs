using System.Collections.Generic;

namespace proto;

public class CSGetFourSymbolsSettingRes
{
	public FourSymbolsSettingDesc setting;

	public List<FourSymbolsChatDesc> chat_descs;

	public FourSymbolsTreasureMapDesc treasure_map_desc;

	public FourSymbolsSignInDesc sign_in_desc;

	public List<FourSymbolsRoadDesc> road_desc;
}
