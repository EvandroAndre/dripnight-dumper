using GCommon;

public class ClientSquareDancingTrigger : Entity
{
	public uint ServerConfigUID;

	public bool isCabinDanceTrigger;

	private uint m_CollectEmoteID;

	public uint CollectEmoteID => 0u;

	protected override void OnAwake()
	{
	}

	public void OnServerSyncSwitchData(uint collectEmoteID)
	{
	}

	public void OnServerCreate(uint collectEmoteID)
	{
	}
}
