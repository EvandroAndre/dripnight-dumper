using GCommon;
using UnityEngine;

namespace COW;

public class CSSharedAvatarData : CSVBaseData, IGetId
{
	public int[] recipeStrInGame;

	public int[] recipeStrInLobby;

	public int[] recipeFacialStrInGame;

	public int[] recipeFacialStrInLobby;

	public bool isSpecialCharacter;

	public string VideoUrl;

	public string SkillVideoUrl;

	public ResourceID portrait;

	public ResourceID sharePortrait;

	public uint[] wardrobeType;

	public string sharePortraitName;

	public string TagDescKey;

	public string KeyartUrl;

	public UIModelAvatarBase.EAvatarType AvatarType;

	public string name;

	public string introduction;

	public string portraitName;

	public Color defaultSkinColor;

	public uint iID;

	public uint TagPower;

	public ResourceID showPoseAnimation;

	public int sortID;

	public ResourceID resIcon;

	public ResourceID inGameSpecialAnim;

	public int hairType;

	public ResourceID DecorPropIDRoot;

	public ResourceID DecorPropIDRight;

	public ResourceID DecorPropIDLeft;

	public uint avatarSkillSlotID;

	public ResourceID resWalkAnimation;

	public int animationInterval;

	public ResourceID resAvatar;

	public uint Tag;

	public uint pvePrimaryWeapon;

	public ResourceID AlignmentIcon;

	public ResourceID VFXShowPose;

	public int gender;

	public ResourceID standIdleAnimation;

	public uint luxuryBundleID;

	public uint bundleID;

	public bool isDefault;

	public bool isSelected;

	public bool EnableEyesLookAt;

	public bool NotInCDN;

	public bool IsStoryShow;

	public bool IsSkillDetail;

	public bool IsActiveSkill;

	public bool HeadAdditiveSwitch;

	public bool canChangeSkinColor;

	public bool IsFemale()
	{
		return false;
	}

	public override bool AfterParseData()
	{
		return false;
	}

	public override void PostDeserializeData()
	{
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	private Color GetColor(uint[] skinColor)
	{
		return default(Color);
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
