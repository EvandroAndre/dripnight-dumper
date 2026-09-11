using GCommon;

namespace COW;

public class UGCBlockConfigData : CSVBaseData, IGetId
{
	public string TypeName;

	public string BlockCategory;

	public string weblink;

	public string SearchKey;

	public string Tips;

	public EBEDevOnlyRule devOnlyRule;

	public string CustomRule;

	public string apiRef;

	public string name;

	public string BlockSubType;

	public float UtilizationFactor;

	public int ID;

	public int Order;

	public override void PostDeserializeData()
	{
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	public override string GetPrimaryKey()
	{
		return null;
	}

	public uint GetId()
	{
		return 0u;
	}

	public bool IsDevOnly()
	{
		return false;
	}

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public void _003C_003EiFixBaseProxy_PostDeserializeData()
	{
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
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
