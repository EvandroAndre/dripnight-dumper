using System;
using System.Collections.Generic;
using GCommon;

namespace COW;

public class AvatarWardrobeData : CSVBaseData, IComparable<AvatarWardrobeData>, IGetId
{
	public int recipeHashInLobby;

	public int recipeHashInGame;

	public int recipeHashInLobby_F;

	public int recipeHashInGame_F;

	public ushort ClothesExt_EffectIndex;

	public ushort ClothesExtIndex;

	public const byte HeadAdditiveSlotId = 14;

	public bool HasSpecialData;

	public static Dictionary<uint, List<ClothesSpecialData>> avatarSpetialRecipes;

	public uint avatarID;

	public uint setID;

	public uint iID;

	public byte wardrobeType;

	public bool BackpackSwitch;

	public ResourceID EffectID_3P_M => default(ResourceID);

	public ResourceID EffectID_3P_F => default(ResourceID);

	public ResourceID EffectID_M => default(ResourceID);

	public ResourceID EffectID_F => default(ResourceID);

	public ResourceID idleAnimResID_M => default(ResourceID);

	public bool isSpecialIdle => false;

	public ResourceID showPoseEffectResID => default(ResourceID);

	public ResourceID DecorPropIDRight => default(ResourceID);

	public ResourceID FootHaloResId => default(ResourceID);

	public ResourceID DecorPropIDRoot => default(ResourceID);

	public ResourceID DecorPropIDLeft => default(ResourceID);

	public ResourceID idleAnimResID_F => default(ResourceID);

	public ResourceID showPoseAnimResID_M => default(ResourceID);

	public ResourceID showPoseAnimResID_F => default(ResourceID);

	public bool EffectForceShow => false;

	public byte NewMatType => 0;

	public byte TeamID => 0;

	public ResourceID VFXPoseAnimIDMale => default(ResourceID);

	public uint IfSpecialBackground => 0u;

	public int ConditionRecipeType => 0;

	public ResourceID VFXPoseAnimIDFemale => default(ResourceID);

	public bool isDefault => false;

	public bool InvalidRes => false;

	public bool Asynchronousloading => false;

	public bool FrameAnim => false;

	public bool VFXMandatoryDisplay => false;

	public bool IsHeadAdditiveSlot => false;

	public uint GetId()
	{
		return 0u;
	}

	public override string GetPrimaryKey()
	{
		return null;
	}

	public static void ClearAvatarSpecialData()
	{
	}

	public void AddAvatarSpecialData(ClothesSpecialData c)
	{
	}

	private ClothesSpecialData GetAvatarData(uint avatarID)
	{
		return null;
	}

	public bool HasLobbyRecipeForAvatar(uint avatarID, bool female)
	{
		return false;
	}

	public int GetLobbyRecipeForAvatar(uint avatarID, bool female)
	{
		return 0;
	}

	public int GetGameRecipeForAvatar(uint avatarID, bool female)
	{
		return 0;
	}

	public uint GetMappedItemID(uint avatarID)
	{
		return 0u;
	}

	private int GetRecipeForAvatar(bool lobby, uint avatarID, bool female)
	{
		return 0;
	}

	private int GetRecipeForAvatarRaw(bool lobby, uint avatarID, bool female)
	{
		return 0;
	}

	public int GetArbitraryLobbyRecipe()
	{
		return 0;
	}

	public int CompareTo(AvatarWardrobeData other)
	{
		return 0;
	}

	public ResourceID GetEffectResID(bool is1P, bool isFemale)
	{
		return default(ResourceID);
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
