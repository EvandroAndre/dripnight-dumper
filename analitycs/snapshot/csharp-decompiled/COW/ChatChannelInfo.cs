using tcp;

namespace COW;

public class ChatChannelInfo
{
	public EChannel.ChannelType m_ChannelType;

	public ulong m_ChannelID;

	public ChatChannelInfo(EChannel.ChannelType type, ulong id)
	{
	}

	public override bool Equals(object obj)
	{
		return false;
	}

	public override int GetHashCode()
	{
		return 0;
	}

	public bool _003C_003EiFixBaseProxy_Equals(object P0)
	{
		return false;
	}

	public int _003C_003EiFixBaseProxy_GetHashCode()
	{
		return 0;
	}
}
