using GCommon;

namespace COW;

public class UGCPropertyConfigData : CSVBaseData, IGetId
{
	public string TypeName;

	public string PropertyValue;

	private EBEPropertyHideRule PropertyHideRule;

	private EBEDevOnlyRule DevOnlyRule;

	private uint ID;

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

	public bool IsHide()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}
}
