using System.Collections.Generic;

namespace tcp;

public class CallbackPointUpdateNtf
{
	public uint delta_points;

	public uint total_points;

	public List<ReturnerGamePlayedInfo> returner_infos;
}
