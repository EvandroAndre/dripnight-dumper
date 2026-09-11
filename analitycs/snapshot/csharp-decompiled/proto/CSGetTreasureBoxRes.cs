using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class CSGetTreasureBoxRes : IMessage
{
	public List<TreasureBoxShow> boxes;

	public List<CrateDescs> crates;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
