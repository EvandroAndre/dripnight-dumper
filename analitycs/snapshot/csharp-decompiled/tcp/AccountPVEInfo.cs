using System.Collections.Generic;
using ProtoBuf;

namespace tcp;

public class AccountPVEInfo : IMessage
{
	public HuntingGroundDetailedInfo hunting_ground_info;

	public List<HuntingGroundLikePVEInfo> hgl_pve_info;

	public PVETalentInfo talent;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
