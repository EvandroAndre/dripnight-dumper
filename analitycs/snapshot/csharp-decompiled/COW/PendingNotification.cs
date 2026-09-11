using COW.GamePlay;
using GCommon;

namespace COW;

public class PendingNotification
{
	public BHGGAEEHJCO KillerId;

	public BHGGAEEHJCO BeKillerId;

	public string m_KillerName;

	public static string EllipsisName;

	public string m_BeKilledName;

	public string WeaponName;

	public string KillerNameColor;

	public string BeKilledNameColor;

	public bool ShowKillBonus;

	public string BattleInfo;

	public EPendingNotificationType InfoType;

	public uint SkinItemId;

	public uint WeaponID;

	public float DefaultVisibleTime;

	public uint KillerRole;

	public uint BeKilledRole;

	public bool KillerHasEP;

	public bool VictimHasEP;

	public byte KillerFFWSFlag;

	public byte BeKilledFFWSFlag;

	public uint KillStacks;

	public BadgeInfoInGame KillBadgeInfo;

	public BadgeInfoInGame BeKillBadgeInfo;

	public string KillBadgeSpriteName;

	public string BeKillBadgeSpriteName;

	public ResourceID KillBadgeVFX;

	public ResourceID BeKillBadgeVFX;

	public string KillerName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string BeKilledName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private string GetPlayerName(string mName, BHGGAEEHJCO playerID, BadgeInfoInGame badgeInfo, bool hasEP, bool iskiller, byte flagID)
	{
		return null;
	}

	public void Reset()
	{
	}

	public void RefreshPrimeIcon()
	{
	}

	public static string GetFFWSNotificationIcon(int flagID)
	{
		return null;
	}
}
