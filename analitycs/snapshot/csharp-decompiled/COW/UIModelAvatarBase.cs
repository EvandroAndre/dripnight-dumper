using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIModelAvatarBase : UIBaseModel
{
	public enum EWardrobeType
	{
		CLOTHESTYPENONE = 0,
		Head = 1,
		Hands = 2,
		Chest = 3,
		Legs = 4,
		Feet = 5,
		Waist = 6,
		Eye = 7,
		Face = 8,
		Parachute = 9,
		ParachuteBag = 10,
		Hair = 11,
		Set = 12,
		BagPack = 13,
		HeadAdditive = 14,
		EventTrigger = 20,
		All = 21
	}

	public enum EGenderType
	{
		GENDERTYPENONE,
		Woman,
		Man
	}

	public enum EHairType
	{
		HAIRTYPENONE,
		SINGLEHAIR,
		DOUBLEHAIR
	}

	public enum EClothGenderType
	{
		GENDERTYPENONE,
		Woman,
		Man,
		Common
	}

	public enum EAvatarType
	{
		AVATARTYPENONE,
		DefaultCharacter,
		CharacterWithSkill,
		OnlyCharacter,
		OnlySkill
	}

	[Serializable]
	public class AvatarSkin
	{
		public Color color;

		public float colorNormalized;

		public uint avatar_id;

		public uint skin_color;
	}

	[Serializable]
	public class AvatarCloth
	{
		public Dictionary<int, uint> ClothDict;
	}

	public class AvatarData
	{
		public bool dirty;

		public uint avatarID;

		public bool isFemale;

		public uint skin_color;

		public EHairType hairType;

		public Dictionary<int, uint> ClothDict;

		public static AvatarData Clone(AvatarData sr)
		{
			return null;
		}
	}

	public const uint PropID_AvatarClothRetOK = 2u;

	public const uint PropID_AvatarSkinRetOK = 4u;

	public const uint PropID_AvatarBagpack = 8u;

	private static Color _FemaleStartColor;

	private static Color _AvatarStartColor;

	private static Color _AvatarEndColor;

	public static readonly Dictionary<byte, int> SpotlightSortOrderWithWardrobeType;

	public const string DefaultInGameRaceFemale = "BaseFemale";

	public const string DefaultInGameRaceMale = "BaseMale";

	public const string HQInGameRaceFemale = "BaseFemale_N";

	public const string HQInGameRaceMale = "BaseMale_N";

	public const string ClothesFaceSlotName = "Face";

	public const string ClothesHairSlotName = "Hair";

	public const string ClothesSetSlotName = "Set";

	public const string ClothesBagPackSlotName = "BagPack";

	public const string ClothesHeadAdditiveSlotName = "HeadAdditive";

	public const string ClothesChestSlotName = "Chest";

	public const string ClothesLegsSlotName = "Legs";

	public const string ClothesFeetSlotName = "Feet";

	public const int ClothesSetTypeValue = 12;

	public const int ClothesHairSlotValue = 11;

	public const int ClothesFaceSlotValue = 8;

	public const uint InitialEnterTeamAnim = 900000015u;

	private static Dictionary<int, string> m_AvatarSlotDic;

	private static Dictionary<int, string> m_AvatarCanEquipSlotDict;

	protected static Dictionary<int, string> m_RaceDic;

	protected static Dictionary<int, string> m_RaceDicLow;

	public const uint DEFAULT_HAIR_ID = 211000000u;

	public const uint DEFAULT_FACE_ID = 208000000u;

	public const uint DEFAULT_HEAD_ADDITIVE_ID = 214000000u;

	public static Color FemaleStartColor => default(Color);

	public static Color AvatarStartColor => default(Color);

	public static Color AvatarEndColor => default(Color);

	public static Color GetSkinColor(float v)
	{
		return default(Color);
	}

	public static Color GetFemaleSkinColor(float v)
	{
		return default(Color);
	}

	public static Dictionary<int, string> AvatarSlotDict()
	{
		return null;
	}

	public static Dictionary<int, string> AvatarCanEquipSlotDict()
	{
		return null;
	}

	public static bool IsFemale(uint avatar_id)
	{
		return false;
	}

	public static EHairType GetHairType(uint avatar_id)
	{
		return EHairType.HAIRTYPENONE;
	}

	public static bool IsDefaultClothesID(uint id)
	{
		return false;
	}

	public static bool IsDefaultClothesWithNoDefaultRecipe(uint id)
	{
		return false;
	}

	public static uint GetDefaultClothesID(EWardrobeType slot)
	{
		return 0u;
	}

	public override uint GetModelType()
	{
		return 0u;
	}
}
