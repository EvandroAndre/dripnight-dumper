using System.Collections.Generic;
using proto;

namespace COW;

public class DropListConfigInfo
{
	public uint ID;

	public HashSet<uint> GameModes;

	public string LocKey;

	public string DescribeKey;

	public string TagKey;

	public string Color;

	public string PresetImage;

	public ERoom.DropPresetState UnlimitedAmmo;

	public ERoom.DropPresetState UnlimitedThrowables;

	public ERoom.DropPresetState AirDrop;

	public ERoom.DropPresetState Loadout;

	public ERoom.DropPresetState Vehicle;

	public ERoom.DropPresetState Zeppelin;

	public ERoom.DropPresetState BanGunSkinAttr;

	public ERoom.DropPresetState HideEnemyFashion;

	public ERoom.DropPresetState FriendlyFire;

	public ERoom.DropPresetState HideHud;

	public uint Revival;

	public ERoom.DropPresetState AutoRevival;

	public ERoom.DropPresetState SaveZoneSpeed;

	public ERoom.DropPresetState SaveZoneDamage;

	public string CDNLink;

	public ERoom.DropPresetState HeadShotOnly;

	public ERoom.DropPresetState WeaponBox;

	public ERoom.DropPresetState ItemGenerator;

	public ERoom.DropPresetState GameAffix;

	public ERoom.DropPresetState MoveSafeZone;

	public ERoom.DropPresetState BanPick;

	public string DefaultCSRound;

	public string DefaultCSInitEco;

	public string DefaultAirdropType;
}
