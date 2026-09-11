using GCommon;

namespace COW;

public class EventClothEffectsData : CSVBaseData
{
	public enum TriggerEffectType
	{
		NormalEffect,
		VFXMaterialEffect,
		VFXMaterialHasReverse
	}

	public TriggerEffectType EffectType;

	public uint UMAPlayOnceInPrivilege;

	public ResourceID FemaleCountEffectPriview;

	public ResourceID MaleCountEffectPriview;

	public uint MultipleTriggerType;

	public uint SoloEffectTrigger;

	public ResourceID PrivilegeEffectWithoutAvatar;

	public ResourceID PrivilegeEffectIDMF;

	public ResourceID PrivilegeEffectIDM;

	public ResourceID PrivilegeNormalEffect;

	public ResourceID EffectReverseIDF3P;

	public ResourceID EffectReverseIDM3P;

	public ResourceID EffectReverseIDF;

	public ResourceID EffectReverseIDM;

	public ResourceID EffectFinishIDF;

	public ResourceID EffectFinishIDM;

	public uint TriggerEffectItemID;

	public uint StateID;

	public ResourceID FEMaleRefID;

	public ResourceID MaleRefID;

	public ResourceID EffectIDF3P;

	public ResourceID EffectIDM3P;

	public ResourceID LobbyEffectIDF;

	public ResourceID LobbyEffectIDM;

	public ResourceID EffectIDF;

	public ResourceID EffectIDM;

	public uint TIME;

	public uint IsHide;

	public uint IsStepEffect;

	public uint EffectsTriggerID;

	public uint ClothID;

	public override void PostDeserializeData()
	{
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	public bool HasPrivilegeSpecializedEffect(bool isFemale)
	{
		return false;
	}

	public ResourceID GetPrivilegePreviewEffect(bool isFemale)
	{
		return default(ResourceID);
	}

	public bool HasLobbySpecializedEffect(bool isFemale)
	{
		return false;
	}

	public ResourceID GetLobbyEffect(bool isFemale)
	{
		return default(ResourceID);
	}

	public static EventClothEffectsData PartialClone(EventClothEffectsData d)
	{
		return null;
	}

	public bool ContainEventTriggerType(uint type)
	{
		return false;
	}

	public override string GetPrimaryKey()
	{
		return null;
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
