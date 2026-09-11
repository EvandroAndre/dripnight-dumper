using System;
using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIModelWeaponSkinPokedex : UIBaseModel
{
	public enum OwnerState
	{
		All,
		Permanent,
		Limit,
		PastDue
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<WeaponSkinPermanentDesc> _003C_003E9__32_1;

		internal bool _003CFindWeaponPermanentDescByID_003Eb__32_1(WeaponSkinPermanentDesc x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass32_0
	{
		public uint id;

		internal bool _003CFindWeaponPermanentDescByID_003Eb__0(WeaponSkinPermanentDesc x)
		{
			return false;
		}
	}

	public Dictionary<uint, string> m_DictWeaponType2Text;

	private readonly bool[] m_UsedQualities;

	private readonly Dictionary<int, List<WeaponPokedexDesc>> m_DictWeaponSkinPokedexByQuality;

	private readonly Dictionary<uint, WeaponPokedexDesc> m_WeaponSkinPokedexDescDict;

	private readonly Dictionary<uint, WeaponSkinPermanentGoPosDesc> m_WeaponSkinPermanentGoPosDescDict;

	public const uint WEAPON_MODEL_FILTER_ALL = 0u;

	private List<WeaponSkinPermanentDesc> m_WeaponSkinPermanentDesc;

	private Dictionary<uint, uint> m_OldWeaponSkinPermanent;

	private RewardWndCfg m_GachaRewardCfg;

	private List<WeaponPokedexDesc> m_WeaponPermanentServerData;

	private bool m_HasProcessWeaponPermanentData;

	public override uint GetModelType()
	{
		return 0u;
	}

	public override void Init()
	{
	}

	public override void Logout(object[] data)
	{
	}

	private void InitUsedQualities()
	{
	}

	public void RecordGachaRewardInfo(List<CommonRewardItemInfo> rewardItemInfos)
	{
	}

	public void CheckAndShowWeaponPermanentView()
	{
	}

	public void ShowGachaWeaponPermanentView(bool showFull = false)
	{
	}

	public void ProcessWeaponSkinPermanent(CSGetWeaponPermanentRes res)
	{
	}

	public void EnsureWeaponSkinPokedexData()
	{
	}

	private void ProcessWeaponSkinPokedex(List<WeaponPokedexDesc> pokedexDescList)
	{
	}

	private void InitPokedexByQuality(WeaponPokedexDesc descItem)
	{
	}

	public List<WeaponPokedexDesc> GetWeaponSkinPokedexByRareOwnerState(CSSharedItemDataManager.StoreQuality quality, OwnerState ownerState)
	{
		return null;
	}

	public Dictionary<uint, List<WeaponPokedexDesc>> GetWeaponSkinOwnerStateDictByQuality(CSSharedItemDataManager.StoreQuality quality)
	{
		return null;
	}

	private List<WeaponPokedexDesc> GetWeaponSkinPokedexByRare(CSSharedItemDataManager.StoreQuality quality)
	{
		return null;
	}

	private Dictionary<uint, List<WeaponPokedexDesc>> PokedexDescListSortByOwnerState(List<WeaponPokedexDesc> list)
	{
		return null;
	}

	public List<WeaponPokedexDesc> SortPokedexDesc(List<WeaponPokedexDesc> list)
	{
		return null;
	}

	private int CompareToQuality(WeaponPokedexDesc x, WeaponPokedexDesc y)
	{
		return 0;
	}

	public Dictionary<uint, Dictionary<uint, List<WeaponPokedexDesc>>> GetPokedexDescByCurrentFilters(CSSharedItemDataManager.StoreQuality curQuality, OwnerState curOwnerState)
	{
		return null;
	}

	public int QualitySortID(int rare)
	{
		return 0;
	}

	public int WeaponTypeSortID(uint type)
	{
		return 0;
	}

	public WeaponSkinPermanentDesc FindWeaponPermanentDescByID(uint id)
	{
		return null;
	}

	public WeaponSkinPermanentGoPosDesc FindWeaponPermanentGoPosDescByID(uint id)
	{
		return null;
	}

	public void OnBackPackInfoUpdate(Item it, Item origItem)
	{
	}

	public int GetOldPermanentByID(uint id)
	{
		return 0;
	}

	public void ClearOldPermanent()
	{
	}

	public uint GetWeaponPermanentValue(uint itemID)
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
