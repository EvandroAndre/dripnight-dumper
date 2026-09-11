using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;
using tcp;

namespace COW;

public class UIModelWeaponProficiency : UIBaseModel
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<WeaponExpSwitch, uint> _003C_003E9__28_0;

		public static Converter<string, int> _003C_003E9__44_0;

		public static Comparison<WeaponExpLevelDesc> _003C_003E9__62_0;

		public static Comparison<WeaponExpInfo> _003C_003E9__64_0;

		public static Comparison<WeaponExpSwitch> _003C_003E9__80_0;

		public static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003E9__84_2;

		public static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003E9__84_3;

		public static Comparison<WeaponExpUpdateInfo> _003C_003E9__86_0;

		internal uint _003CGetWeaponIdsByPopMenuType_003Eb__28_0(WeaponExpSwitch x)
		{
			return 0u;
		}

		internal int _003CGetWeaponShow_003Eb__44_0(string x)
		{
			return 0;
		}

		internal int _003CCacheLevelDesc_003Eb__62_0(WeaponExpLevelDesc x, WeaponExpLevelDesc y)
		{
			return 0;
		}

		internal int _003CGetWeaponProficiencyMaxItemID_003Eb__64_0(WeaponExpInfo x, WeaponExpInfo y)
		{
			return 0;
		}

		internal int _003CCacheDictWeaponSwitch_003Eb__80_0(WeaponExpSwitch x, WeaponExpSwitch y)
		{
			return 0;
		}

		internal CommonRewardItemInfo _003CRequestClaimWeaponExpAward_003Eb__84_2(BaseItemInfo item)
		{
			return null;
		}

		internal CommonRewardItemInfo _003CRequestClaimWeaponExpAward_003Eb__84_3(BaseItemInfo item)
		{
			return null;
		}

		internal int _003COnWeaponExpUpdateNotification_003Eb__86_0(WeaponExpUpdateInfo x, WeaponExpUpdateInfo y)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass39_0
	{
		public uint level;

		internal bool _003CGetAward_003Eb__0(WeaponExpAwardDesc x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass50_0
	{
		public uint level;

		internal bool _003CGetLevelDesc_003Eb__0(WeaponExpLevelDesc x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass77_0
	{
		public uint weaponId;

		internal bool _003CGetWeaponSwitchById_003Eb__0(WeaponExpSwitch x)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass84_0
	{
		public UIModelWeaponProficiency _003C_003E4__this;

		public uint weaponId;

		public List<uint> level;

		public bool IsLevelUp;

		public Action _003C_003E9__1;

		internal void _003CRequestClaimWeaponExpAward_003Eb__0(HttpErrorCode errorCode, object res)
		{
		}

		internal void _003CRequestClaimWeaponExpAward_003Eb__1()
		{
		}
	}

	private Dictionary<Vector3, List<WeaponExpSwitch>> m_DictWeaponSwitch;

	private Dictionary<uint, List<WeaponExpAwardDesc>> m_DictWeaponAward;

	private Dictionary<uint, WeaponExpInfo> m_DictWeaponExpInfo;

	private Dictionary<uint, List<uint>> m_DictWeaponAwardInfo;

	private List<uint> m_PinnedWeapons;

	private List<uint> m_ListWeaponUpgraded;

	private Dictionary<uint, uint> m_DictWeaponExpRank;

	private List<WeaponExpRankConfig> m_DictWeaponExpRankConfig;

	private uint m_V1MaxLevelExpUpperBound;

	private Dictionary<uint, ResourceID> m_DictResIdLevelIcon;

	private ResourceID m_WeaponV2ResId;

	public const int PropID_ProcessedSettingDesc = 2;

	public const int PropID_ProcessedInfo = 4;

	public const int PropID_ClaimedAward = 8;

	public const int PropID_PinChanged = 16;

	public const uint POPMENU_TYPE_ALL = 0u;

	private bool m_SettingDescFetched;

	private bool m_InfoFetched;

	private bool m_RewardRequesting;

	private bool m_PinDirty;

	private List<WeaponExpLevelDesc> m_SortedLevelDesc;

	private List<WeaponExpUpdateInfo> m_UpdateInfo;

	public ResourceID WeaponV2ResId => default(ResourceID);

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

	public List<uint> GetAllWeaponIds()
	{
		return null;
	}

	public List<uint> GetWeaponIdsByPopMenuType(uint popMenuType)
	{
		return null;
	}

	public List<uint> GetPopMenuTypes()
	{
		return null;
	}

	public string GetWeaponTypeNameByPopType(uint popType)
	{
		return null;
	}

	public uint GetPopMenuTypeByWeaponType(uint weaponType, uint subtype, uint subsubtype)
	{
		return 0u;
	}

	public uint GetLevelByWeapon(uint weaponId)
	{
		return 0u;
	}

	public uint GetLevelByWeapon(uint weaponId, out float progress)
	{
		progress = default(float);
		return 0u;
	}

	public float GetProgressOfLevel(uint level, uint exp)
	{
		return 0f;
	}

	public ResourceID GetResIdLevelIcon(uint level)
	{
		return default(ResourceID);
	}

	public bool IsWeaponFullProgress(uint weaponId)
	{
		return false;
	}

	public int GetFullProgressWeaponCount()
	{
		return 0;
	}

	public ResourceID GetResIdLevelIconByWeaponId(uint weaponId)
	{
		return default(ResourceID);
	}

	public WeaponExpAwardDesc GetAward(uint weaponId, uint level)
	{
		return null;
	}

	public uint GetWeaponKill(uint weaponId)
	{
		return 0u;
	}

	public uint GetWeaponDamage(uint weaponId)
	{
		return 0u;
	}

	public uint GetWeaponHeadShot(uint weaponId)
	{
		return 0u;
	}

	public uint GetWeaponCure(uint weaponId)
	{
		return 0u;
	}

	public List<int> GetWeaponShow(uint weaponId)
	{
		return null;
	}

	public void ChangeWeaponPinState(uint weaponId)
	{
	}

	public bool IsPinnedWeapon(uint weaponId)
	{
		return false;
	}

	public int GetLevelCount()
	{
		return 0;
	}

	public uint GetMaxLevel()
	{
		return 0u;
	}

	public uint GetWeaponExp(uint weaponId)
	{
		return 0u;
	}

	public WeaponExpLevelDesc GetLevelDesc(uint level)
	{
		return null;
	}

	public List<uint> GetAwardInfo(uint weaponId)
	{
		return null;
	}

	public bool HaveClaimAward(uint weaponId, uint level)
	{
		return false;
	}

	public void SetInfoDirty()
	{
	}

	public bool HaveCanClaimAward()
	{
		return false;
	}

	public int GetCanClaimAwardCount()
	{
		return 0;
	}

	public bool HaveCanClaimAward(uint weaponId)
	{
		return false;
	}

	public bool IsWeaponProficiencyEnable(uint weaponId)
	{
		return false;
	}

	public void AddUpgradedWeapon(uint weaponId)
	{
	}

	public bool IsUpgradedWeapon(uint weaponId)
	{
		return false;
	}

	public void RemoveUpgradedWeapon(uint weaponId)
	{
	}

	public uint GetOwnedWeaponMaxLevel()
	{
		return 0u;
	}

	public void CacheLevelDesc(List<WeaponExpLevelDesc> levelDesc)
	{
	}

	public void UpdateWeaponProficiencyEntranceTipsNums()
	{
	}

	public uint GetWeaponProficiencyMaxItemID()
	{
		return 0u;
	}

	public bool IsWeaponV2(uint weaponId)
	{
		return false;
	}

	public bool IsNeedShowLevelUpButton(uint weaponId)
	{
		return false;
	}

	public uint GetWeaponLevelV2(uint weaponId)
	{
		return 0u;
	}

	public uint GetWeaponLevelV2ByExp(uint exp)
	{
		return 0u;
	}

	public float GetWeaponLevelV2Process(uint weaponId)
	{
		return 0f;
	}

	public float GetWeaponLevelV2ProcessByExp(uint exp)
	{
		return 0f;
	}

	public uint GetWeaponV1MaxLevelExpUpperBound()
	{
		return 0u;
	}

	public uint GetCycleExpSetting()
	{
		return 0u;
	}

	public uint GetWeaponRank(uint weaponId)
	{
		return 0u;
	}

	public List<uint> GetAllUnClaimedRewards(uint weaponId)
	{
		return null;
	}

	public uint GetMaxLevelAwardItemID(uint weaponId)
	{
		return 0u;
	}

	private void SetAwardClaimed(uint weaponId, List<uint> levelList)
	{
	}

	private WeaponExpSwitch GetWeaponSwitchById(uint weaponId)
	{
		return null;
	}

	public uint GetLevelByExp(uint exp)
	{
		return 0u;
	}

	private WeaponExpInfo GetWeaponExpInfo(uint weaponId)
	{
		return null;
	}

	private void CacheDictWeaponSwitch(List<WeaponExpSwitch> listWeaponSwitch)
	{
	}

	private void CacheUpgradedWeapon()
	{
	}

	public void RequestWeaponExpSetting(bool forceReq = false)
	{
	}

	public void RequestWeaponExpInfo(bool forceReq = false, HttpManager.EHttpChannel channel = HttpManager.EHttpChannel.Main)
	{
	}

	public void RequestClaimWeaponExpAward(uint weaponId, List<uint> level, bool IsLevelUp = false)
	{
	}

	public void RequestUpdatePinnedWeapons()
	{
	}

	public void OnWeaponExpUpdateNotification(WeaponExpUpdateNtf weaponExpUpdate)
	{
	}

	public List<WeaponExpUpdateInfo> GetWeaponExpUpdateList()
	{
		return null;
	}

	public WeaponExpLevelDesc GetWeaponExpLevelDesc(uint exp)
	{
		return null;
	}

	public bool IsShowMatchResultWnd()
	{
		return false;
	}

	public void OnStartMatch()
	{
	}

	private void _003CRequestWeaponExpSetting_003Eb__82_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestWeaponExpInfo_003Eb__83_0(HttpErrorCode errorCode, object res)
	{
	}

	private void _003CRequestUpdatePinnedWeapons_003Eb__85_0(HttpErrorCode errorCode, object res)
	{
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
