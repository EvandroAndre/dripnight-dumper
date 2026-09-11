using System.Collections.Generic;
using ProtoBuf;

namespace tcp;

public class SharedSetInfo : IMessage
{
	public ulong sharer_id;

	public uint[] shared_clothes;

	public uint shared_avatar_id;

	public List<AccountCollectionCustomItemInfo> shared_collection_customs;

	public string shared_nick_name;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
