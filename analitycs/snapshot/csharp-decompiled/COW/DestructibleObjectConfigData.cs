using GCommon;

namespace COW;

public class DestructibleObjectConfigData : CSVBaseData, IGetId
{
	public uint ID;

	public uint HP;

	public uint HalfDestroyHP;

	public uint AlmostDestroyHP;

	public ResourceID HalfDestroyVFX;

	public ResourceID AlmostDestroyVFX;

	public ResourceID DestroyVFX;

	public ResourceID HalfDestroyPrefabResID;

	public ResourceID AlmostDestroyPrefabResID;

	public ResourceID NormalPrefabResID;

	public ResourceID HalfDestroySound;

	public ResourceID AlmostDestroySound;

	public ResourceID DestroySound;

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

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}
}
