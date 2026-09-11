using System.Collections.Generic;
using ProtoBuf;

namespace proto;

public class SocialHighLightsWithSocialBasicInfo : IMessage
{
	public List<SocialHighLight> social_high_lights;

	public SocialBasicInfo social_basic_info;

	public void ParseFrom(ProtoReader reader)
	{
	}
}
