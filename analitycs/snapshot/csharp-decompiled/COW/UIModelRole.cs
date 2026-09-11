using System;
using System.Collections.Generic;
using GCommon;
using proto;
using tcp;

namespace COW;

public class UIModelRole : UIBaseModel
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<PrivilegeIconConfig, uint> _003C_003E9__9_0;

		public static Func<PrivilegeIconTypeConfig, uint> _003C_003E9__9_1;

		internal uint _003CInit_003Eb__9_0(PrivilegeIconConfig value)
		{
			return 0u;
		}

		internal uint _003CInit_003Eb__9_1(PrivilegeIconTypeConfig value)
		{
			return 0u;
		}
	}

	private sealed class _003C_003Ec__DisplayClass12_0
	{
		public CSSetAccountBadgeReq req;

		public UIModelRole _003C_003E4__this;

		internal void _003CRequestSetBadgeInfo_003Eb__0(HttpErrorCode errorCode, object obj)
		{
		}
	}

	private CSVAsyncDataMap<uint, PrivilegeIconConfig> m_PrivilegeConfigData;

	private CSVAsyncDataMap<uint, PrivilegeIconTypeConfig> m_PrivilegeIconTypeConfigData;

	private Dictionary<uint, PrivilegeIconConfig> m_CombinePairingToData;

	public const uint PropID_SetBadgeInfo = 2u;

	private static bool m_AutoSetBadge;

	public Dictionary<uint, PrivilegeIconConfig> CombinePairingToData => null;

	private Dictionary<uint, PrivilegeIconConfig> CombinePairingToDataInner => null;

	public override void Init()
	{
	}

	public override void Logout(object[] data)
	{
	}

	public override uint GetModelType()
	{
		return 0u;
	}

	public void RequestSetBadgeInfo(CSSetAccountBadgeReq req)
	{
	}

	public void UpdateBadgeInfo(tcp.BadgeInfo badgeInfo)
	{
	}

	public void CheckAndSetBadge()
	{
	}

	private void SetBadge(BadgeType type, uint subType)
	{
	}

	public bool ShowPrivilegeIconInGame(uint type, uint level = 0u)
	{
		return false;
	}

	public PrivilegeIconConfig GetPrivilegeIconData(uint type, uint level = 0u)
	{
		return null;
	}

	public ResourceID GetPrivilegeIconRes(uint type, uint level)
	{
		return default(ResourceID);
	}

	public ResourceID GetPrivilegeIconResInGame(uint type, uint level)
	{
		return default(ResourceID);
	}

	public ResourceID GetPrivilegeVFXRes(uint type, uint level)
	{
		return default(ResourceID);
	}

	public void SetCelebrityPrivilegeForDebug(ref uint mainType, ref uint subType)
	{
	}

	public bool CheckIsBadge(tcp.BadgeInfo badgeInfo, uint role, uint primeLevel, bool BadgePrivilegeOpen = true)
	{
		return false;
	}

	public bool CheckIsBadge(proto.BadgeInfo badgeInfo, uint role, uint primeLevel, bool BadgePrivilegeOpen = true)
	{
		return false;
	}

	public bool CheckIsBadge(BadgeInfoLobby badgeInfo, uint role, uint primeLevel, bool BadgePrivilegeOpen = true)
	{
		return false;
	}

	private bool CheckIsBadge(BadgeType mainType, uint subType, uint role, uint primeLevel, bool BadgePrivilegeOpen = true)
	{
		return false;
	}

	public bool CheckIsBadge(BadgeInfoInGame badgeInfoInGame)
	{
		return false;
	}

	public BadgeInfoLobby GetBadgeInfoForDisplay(proto.BadgeInfo badgeInfo, uint role, uint primeLevel)
	{
		return null;
	}

	public BadgeInfoLobby GetBadgeInfoForDisplay(tcp.BadgeInfo badgeInfo, uint role, uint primeLevel)
	{
		return null;
	}

	public BadgeInfoLobby GetBadgeInfoForDisplay(BadgeInfoLobby badgeInfo, uint role, uint primeLevel)
	{
		return null;
	}

	private BadgeInfoLobby GetBadgeInfoForDisplay(BadgeType badgeType, uint subType, uint role, uint primeLevel, bool isBadgeInfoNull)
	{
		return null;
	}

	public uint GetPrivilegeIconTypeByPriority(uint[] typeArray)
	{
		return 0u;
	}

	public uint GetSubTypeByCelebrityRole(uint role)
	{
		return 0u;
	}

	public bool HasBadgePrivilege(uint level)
	{
		return false;
	}

	public bool IsCelebrity(uint role)
	{
		return false;
	}

	public bool IsCelebrity(proto.EAccount.Role role)
	{
		return false;
	}

	public string GetNameAfterCelebrityCheck(uint role, string name)
	{
		return null;
	}

	public string GetNameAfterCelebrityCheck(proto.EAccount.Role role, string name)
	{
		return null;
	}

	public static void SetAutoSetBadgeAfterVerUpdate(bool update)
	{
	}

	private uint GetCombinedPairing(uint type, uint level)
	{
		return 0u;
	}

	private void ProcessCombineDic()
	{
	}

	private bool IsCelebrityByConfig(uint role)
	{
		return false;
	}

	private bool CheckHasBadgeWithPrimeClose(uint role)
	{
		return false;
	}

	private uint _003CGetPrivilegeIconTypeByPriority_003Eb__31_0(uint x)
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
