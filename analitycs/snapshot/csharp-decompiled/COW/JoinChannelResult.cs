using System;

namespace COW;

[Serializable]
public class JoinChannelResult : BaseResult
{
	public ChannelInfo channelInfo;

	public VodkaMemberInfo[] members;
}
