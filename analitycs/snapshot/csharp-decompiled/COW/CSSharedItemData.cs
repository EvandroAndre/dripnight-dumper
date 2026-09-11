using GCommon;

namespace COW;

public class CSSharedItemData : CSVBaseData, IGetId
{
	public static bool LocIdxSerialized;

	public uint iID;

	public uint nameId;

	public uint descriptionId;

	private ResourceID m_iconRes;

	public byte Rare;

	public bool isUnique;

	public byte IconInAB;

	public byte itemType;

	public byte collectionType;

	public ResourceID iconRes
	{
		get
		{
			return default(ResourceID);
		}
		set
		{
		}
	}

	public string name => null;

	public string description => null;

	public virtual ResourceID BigIcon => default(ResourceID);

	public byte subType => 0;

	public string endTime => null;

	public uint GetId()
	{
		return 0u;
	}

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	public override void PostDeserializeData()
	{
	}

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_PostDeserializeData()
	{
	}

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}
}
