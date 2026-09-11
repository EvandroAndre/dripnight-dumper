using ProtoBuf;

namespace tcp;

public class PresenceInfo : IMessage
{
	public ulong i;

	public string r;

	public uint p;

	public long update_time;

	public uint m;

	public uint g;

	public uint a;

	public ulong gi;

	public uint gmc;

	public uint grm;

	public uint ss;

	public string wsc;

	public string wsn;

	public uint sp;

	public ulong ri;

	public uint rt;

	public uint rmc;

	public uint rmmc;

	public uint es;

	public bool hj;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
