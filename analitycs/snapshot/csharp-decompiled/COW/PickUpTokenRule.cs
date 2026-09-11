using GCommon;

namespace COW;

public class PickUpTokenRule : CSVBaseData, IGetId
{
	private long m_StartTime;

	private long m_StopTime;

	public uint ID;

	public uint DropID;

	public uint TokenID;

	public string NoShowRegion;

	public string StringStartTime;

	public string StringStopTime;

	public long StartTime
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public long StopTime
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public override string GetPrimaryKey()
	{
		return null;
	}

	public uint GetId()
	{
		return 0u;
	}

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}
}
