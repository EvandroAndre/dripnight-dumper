using ProtoBuf;

namespace proto;

public class CSPeakTournamentPointCalParamDesc : IMessage
{
	public uint default_point;

	public double MinEaRatio;

	public double MaxEaRatio;

	public uint min_point;

	public uint max_point;

	public bool is_new_algorithm;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
