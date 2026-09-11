using GCommon;

namespace COW;

public class RoomCrateSettingData : CSVBaseData
{
	public uint ID;

	public uint GameMode;

	public uint Environment;

	public uint UnlimitedAmmoSwitch;

	public uint UnlimitedThrowablesSwitch;

	public uint FallDamage;

	public uint LoadoutSwitch;

	public uint AirDropSwitch;

	public uint CharacterSkill;

	public uint CarDropSwitch;

	public uint BanGunSkinAttr;

	public uint UAV;

	public uint Airstrike;

	public uint AirShipSwitch;

	public uint HideEnemyFashion;

	public uint HideHud;

	public uint FriendlyFire;

	public uint PreciseAim;

	public uint SaveZoneSpeed;

	public uint SaveZoneDamage;

	public uint AutoRevival;

	public uint GlobalMission;

	public uint HotZoneSwitch;

	public uint GameMission;

	public uint MovingSafeZone;

	public uint AFKPunish;

	public uint HeadShotOnly;

	public uint SoloActiveSkill;

	public uint DoubleKillScore;

	public uint BRWeaponBox;

	public uint ItemGenerator;

	public uint GameAffix;

	public uint BanPick;

	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	public override string GetPrimaryKey()
	{
		return null;
	}

	public static bool IsHide(uint value)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_ParseData(long P0, int P1, string[] P2, string[] P3)
	{
	}

	public string _003C_003EiFixBaseProxy_GetPrimaryKey()
	{
		return null;
	}
}
