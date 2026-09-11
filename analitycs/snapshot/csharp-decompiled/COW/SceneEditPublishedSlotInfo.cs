namespace COW;

public class SceneEditPublishedSlotInfo
{
	private uint m_SlotId;

	private string m_LongShareCode;

	private uint m_SlotIdLocal;

	public SceneEditSlotInfo ServerSlotInfo;

	public int ReservedLocalSlotId;

	public int MapRank;

	public uint SlotId
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public string LongShareCode
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public uint SlotIdLocal
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	public void SetEmpty()
	{
	}

	public override string ToString()
	{
		return null;
	}

	public SceneEditSlotInfo GetLocalSlotInfo()
	{
		return null;
	}

	public SceneEditSlotInfo GetLocalOrServerSlotInfo()
	{
		return null;
	}

	public string _003C_003EiFixBaseProxy_ToString()
	{
		return null;
	}
}
