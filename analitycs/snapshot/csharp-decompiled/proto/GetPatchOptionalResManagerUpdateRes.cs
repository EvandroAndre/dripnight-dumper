using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class GetPatchOptionalResManagerUpdateRes : IMessage
{
	public List<PatchOptionalResManagerUpdateDesc> patch_optional_res_manager_updates;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
