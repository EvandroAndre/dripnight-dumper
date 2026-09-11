using System.Collections.Generic;
using ProtoBuf;

namespace tcp;

public class HippoInventoryItem : IMessage
{
	public class AttachmentInfo : IMessage
	{
		public uint slot_id;

		public uint item_id;

		public ulong inst_id;

		public void ParseFrom(ProtoReader reader)
		{
		}
	}

	public class AttrInfo : IMessage
	{
		public uint durability;

		public void ParseFrom(ProtoReader reader)
		{
		}
	}

	public ulong inst_id;

	public uint item_id;

	public uint amount;

	public List<AttachmentInfo> attachments;

	public AttrInfo attr;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
