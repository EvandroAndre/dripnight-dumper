using GCommon;

namespace COW;

public class PetSkinData : CSVBaseData
{
	public uint SkinID;

	public int PetID;

	public int PetLevel;

	public ResourceID UISkinPrefab;

	public ResourceID IngameSkinPrefab;

	public ResourceID IngameSkinPrefab3P;

	public ResourceID IngameSkinPrefabMode;

	public ResourceID IngameSkinPrefab3PMode;

	public bool OverrideShowHideEffect;

	public ResourceID ShowHideEffect;

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
