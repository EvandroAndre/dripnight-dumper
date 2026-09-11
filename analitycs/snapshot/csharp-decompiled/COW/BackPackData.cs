using GCommon;

namespace COW;

public class BackPackData : CSVBaseData, IGetId
{
	public uint iID;

	public uint sortId;

	public ESourceType sourceTypeKey;

	public bool IsShow;

	public ResourceID FeMaleIngameEffectLV3;

	public ResourceID MaleIngameEffectLV3;

	public bool IsEffectsTrigger;

	public ResourceID ModleIDM;

	public ResourceID ModleIDF;

	public ResourceID LowModleIDM;

	public ResourceID LowModleIDF;

	public ResourceID MaleIdleEffectLV3;

	public ResourceID FemaleIdleEffectLV3;

	public ResourceID MaleTriggerEffectLV3;

	public ResourceID FemaleTriggerEffectLV3;

	public ResourceID previewResLV1;

	public ResourceID previewResLV2;

	public ResourceID previewResLV3;

	public uint LobbyNumber;

	public uint IdleNumber;

	public ResourceID MaleEffectLV1;

	public ResourceID FemaleEffectLV1;

	public ResourceID MaleEffectLV2;

	public ResourceID FemaleEffectLV2;

	public uint NewMatType;

	public bool IfOnlyLv3;

	public int[] maleRecipes;

	public int[] maleRecipes_N;

	public int[] femaleRecipes;

	public int[] femaleRecipes_N;

	public override void DeserializeData(MutableStringBinaryReader bR)
	{
	}

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

	public int GetCollectionRecipe(bool female, bool useHQ, uint level)
	{
		return 0;
	}

	public ResourceID GetPreviewResourceIDByLevel(ECollectionLevel level)
	{
		return default(ResourceID);
	}

	public bool IsNewMatType()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_DeserializeData(MutableStringBinaryReader P0)
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
