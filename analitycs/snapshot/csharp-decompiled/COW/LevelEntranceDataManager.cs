using System;
using System.Collections.Generic;
using GCommon;

namespace COW;

public class LevelEntranceDataManager : SingletonModule<LevelEntranceDataManager>
{
	public enum EntranceIdType
	{
		NewPlayerSignin = 1,
		Avatar = 2,
		LowLoadOut = 3,
		EPContainer = 4,
		Manual = 5,
		Collection = 6,
		HighLoadOut = 7,
		Gacha = 8,
		Pet = 9,
		Championship = 10,
		LobbyClan = 11,
		RankMatch = 12,
		NormalSignIn = 13,
		BindAccount = 14,
		RankLadder = 15,
		Mission = 16,
		Store = 17,
		BuildSystem = 19,
		Event = 20,
		Lab = 21,
		Weapon = 22,
		BigEvent = 23,
		HideOutAndIAP = 24,
		SubSystem = 25,
		Achievement = 26,
		ESports = 27,
		EVOGun = 28,
		WeaponProficiency = 29,
		CustomSkin = 30,
		MySteryShop = 31,
		KeyGacha = 32,
		FlashStore = 33,
		LuckyWheel = 34,
		AntiHack = 35,
		Ladder = 36,
		LocalActivity = 37,
		SpecialEntrance = 38,
		LobbyCraftlandEntrance = 39,
		ModeSelectionPageCraftLandTab = 40,
		CustomRoomUGCEntrance = 42,
		RelayMart = 43,
		DrawShop = 44
	}

	public enum EntranceUnlockType
	{
		Level = 1,
		Day
	}

	public enum LockStatusType
	{
		NoLock,
		Locked,
		Hided
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<LevelEntranceData> _003C_003E9__12_0;

		public static Comparison<LevelEntranceData> _003C_003E9__13_0;

		public static Comparison<LevelEntranceData> _003C_003E9__14_0;

		internal int _003CGetEntranceDataByUnlockLevel_003Eb__12_0(LevelEntranceData x, LevelEntranceData y)
		{
			return 0;
		}

		internal int _003CGetEntranceDataByAnnounceLevel_003Eb__13_0(LevelEntranceData x, LevelEntranceData y)
		{
			return 0;
		}

		internal int _003CGetLevelEntranceListSortByUnLockNum_003Eb__14_0(LevelEntranceData x, LevelEntranceData y)
		{
			return 0;
		}
	}

	private sealed class _003C_003Ec__DisplayClass10_0
	{
		public uint entranceId;

		internal bool _003CGetEntranceDataByEntranceId_003Eb__0(LevelEntranceData x)
		{
			return false;
		}
	}

	public List<LevelEntranceData> m_EntranceDataList;

	public Dictionary<uint, List<LevelEntranceData>> m_GoPosV1EntranceDataDict;

	public Dictionary<uint, List<LevelEntranceData>> m_GoPosV2EntranceDataDict;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public void LoadWithRegion()
	{
	}

	public uint GetLockStatusByEntranceId(uint entranceId, uint curLevel)
	{
		return 0u;
	}

	public LevelEntranceData GetEntranceDataByEntranceId(uint entranceId)
	{
		return null;
	}

	public uint GetEntranceDataUnLockLevelByEntranceId(uint entranceId)
	{
		return 0u;
	}

	public List<LevelEntranceData> GetEntranceDataByUnlockLevel(uint unlockLevel)
	{
		return null;
	}

	public List<LevelEntranceData> GetEntranceDataByAnnounceLevel(uint announceLevel)
	{
		return null;
	}

	public List<LevelEntranceData> GetLevelEntranceListSortByUnLockNum()
	{
		return null;
	}

	public List<LevelEntranceData> GetLobbyShowLevelEntranceListByUnlockLevel(uint unlockLevel, bool isfps)
	{
		return null;
	}

	public bool IsGuest()
	{
		return false;
	}

	private void CreateGoposDict()
	{
	}

	public List<LevelEntranceData> GetLevelEntranceListByGoPos(uint gopos, bool IsV2 = true)
	{
		return null;
	}
}
