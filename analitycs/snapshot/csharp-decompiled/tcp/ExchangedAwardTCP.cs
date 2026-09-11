using ProtoBuf;

namespace tcp;

public class ExchangedAwardTCP : IMessage
{
	public int origin_award_type;

	public uint origin_award_id;

	public uint origin_award_num;

	public int dest_award_type;

	public uint dest_award_id;

	public uint dest_award_num;

	public uint origin_award_time;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
