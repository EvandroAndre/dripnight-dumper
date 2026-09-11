using ProtoBuf;

namespace proto;

public class CSPeakTournamentEnergyParamDesc : IMessage
{
	public bool is_open;

	public uint win_extra_point_threshold;

	public uint no_extra_point_threshold;

	public uint hide_threshold;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
