using GCommon;

namespace COW;

public class IngameQuickChatData : CSVBaseData
{
	public enum ResponseForwardType
	{
		None,
		IsDead,
		IsKnockDown
	}

	public static readonly uint Normal_ID_Request_Help_Me;

	public static readonly uint Normal_ID_Request_Need_Medkit;

	public static readonly uint Normal_ID_Request_Need_Gun;

	public static readonly uint Special_ID_DeadBox;

	public static readonly uint Special_ID_LevelObject;

	public static readonly uint Special_ID_PickUp;

	public static readonly uint Special_ID_Location;

	public static readonly uint Special_ID_NoticeEnemy;

	public static readonly uint Special_ID_NoticeEnemyKnockDown;

	public static readonly uint Special_ID_NoticeEnemyDead;

	public static readonly uint Special_ID_House_Point;

	public static readonly uint Special_ID_House_Enemy;

	public static readonly uint Special_ID_SafeZoneLocation;

	public static readonly uint Special_ID_NoticeEnemyNear;

	public static readonly uint Special_ID_NoticeEnemyFar;

	public static readonly uint Special_ID_TeamRally;

	public static readonly uint Special_ID_Request_Help_Purchase;

	public static readonly uint Special_ID_Response_Help_Purchase;

	public static readonly uint Special_ID_Request_Friendly_Interaction;

	public static readonly uint Special_ID_Request_Enemy_Down;

	public static readonly uint Special_ID_Request_Another_Down;

	public static readonly uint Special_ID_Request_Enemy_Killed;

	public static readonly uint Special_ID_Request_Another_Killed;

	public static readonly uint Special_ID_Request_AirDrop;

	public static readonly uint Special_ID_Request_Have_Token;

	public static readonly uint Special_ID_Request_Weapon_Equiped;

	public static readonly uint Special_ID_Request_Need_ItemName;

	public static readonly uint Special_ID_Request_Has_Item;

	public static readonly uint Special_ID_Request_ActiveSkill_In_CD;

	public static readonly uint Special_ID_Request_ActiveSkill_OK;

	public static readonly uint Special_ID_Request_HP_Full;

	public static readonly uint Special_ID_Request_HP_Not_Full;

	public static readonly uint Special_ID_Request_Need_Token;

	public static readonly uint Special_ID_Request_Need_Ammo;

	public static readonly uint Special_ID_Request_Need_Equip;

	public static readonly uint Special_ID_Request_HasIceWallAndNeed;

	public static readonly uint Special_ID_Request_FillIceWall;

	public static readonly uint Special_ID_Request_FillIceWallFull;

	public static readonly uint Special_ID_Request_CreatePortal;

	public static readonly uint Special_ID_Request_FirstPickupWeapon;

	public static readonly uint Special_ID_Request_CoinNotEnough;

	public static readonly uint Special_ID_Request_TreasuryOccupyProgress;

	public static readonly uint Special_ID_Request_LockAirDropOccupyProgress;

	public static readonly uint Special_ID_Request_Haved_Token;

	public static readonly uint Special_ID_Waiting_Thumb_Up;

	public static readonly uint Special_ID_Request_ItemGenerator;

	public static readonly string Special_ID_GoodWork;

	public static readonly uint Special_ID_Request_TechDevice_In_CD;

	public static readonly uint Special_ID_Request_TechDevice_OK;

	public static readonly uint Special_ID_Response_HealRobot_Rescue;

	public static readonly uint Special_ID_Request_GotWishCoin;

	public static readonly uint Special_ID_Request_Observer_ReviveMe;

	public static readonly uint Special_ID_PickUp_AdvancedWeapon;

	public static readonly uint Special_ID_PickUp_AdvancedArmor;

	public static readonly uint Special_ID_PickUp_AdvancedHelmet;

	public static readonly uint Special_ID_Location_TreasureHuntMap;

	public static readonly uint Special_ID_Location_ParachutingPOI;

	public static readonly uint Special_ID_TreasureHunt_UnderTreasuryOpen;

	public uint m_ID;

	public EQuickChatBasicTab m_Tab;

	public EQuickChatCategory m_Category;

	public string m_MessageKey;

	public string m_SoundResourceName;

	public uint SamoOrder;

	public string ResponseIcon;

	public string ResponseKey;

	public uint ResponseMessageId;

	public int[] ResponseForwardArr;

	public int SoundDistance;

	public static bool IsMarkPickupItemQuickChat(uint chatId)
	{
		return false;
	}

	public override string GetPrimaryKey()
	{
		return null;
	}

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	public static EQuickChatCategory IntToCategory(uint categoryInt)
	{
		return EQuickChatCategory.None;
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}
}
