namespace COW;

public class QuickChatShowItem
{
	public float m_ShowTimstamp;

	public uint QuickChatID;

	public QuickChatView m_ShowChatView;

	public bool HasHelped;

	public uint SenderPlayerId;

	public bool IsShow()
	{
		return false;
	}

	public void OnDeque()
	{
	}
}
