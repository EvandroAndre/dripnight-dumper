using GCommon;

namespace COW;

public class DiscolorationCollectionData : CSVBaseData, IGetId
{
	public ResourceID ResourceLow;

	public ResourceID ResourceHighRed;

	public ResourceID ResourceHighBlue;

	public ResourceID ResourceHighRedTex;

	public uint resourcesizex;

	public uint resourcesizey;

	public uint IID;

	public string ResourceLowName;

	public string ResourceHighRedName;

	public string ResourceHighRedTexture;

	public string ResourceHighBlueName;

	public override bool AfterParseData()
	{
		return false;
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

	public override uint GetUIntKey()
	{
		return 0u;
	}

	public override int GetIntKey()
	{
		return 0;
	}

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

	public bool _003C_003EiFixBaseProxy_AfterParseData()
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

	public uint _003C_003EiFixBaseProxy_GetUIntKey()
	{
		return 0u;
	}

	public int _003C_003EiFixBaseProxy_GetIntKey()
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
	{
	}
}
