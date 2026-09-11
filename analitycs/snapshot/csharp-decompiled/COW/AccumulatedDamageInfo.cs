using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class AccumulatedDamageInfo
{
	public static AccumulateDamageEvent AccumulateDmgEvent;

	public int TotalDamage;

	public int TotalShieldDamage;

	public float FirstHitTime;

	public float LastHitTIme;

	public int WeaponID;

	public LLEDPGIGCMO ColliderType;

	public CECJMLEEPLG SpecialDamageType;

	public bool IsHealing;

	public bool IsDecreaseByPetSkill;

	public bool IsGSDamage;

	public string DamageIconName;

	public Color DamageIconColor;

	public bool isShowMissingDamage;

	public int PelletCount;

	public int headShotCount;

	public uint UniqueID;

	public bool Finished;

	public GEvent GetEvent(bool show, float fireInterval)
	{
		return null;
	}

	public void Reset()
	{
	}
}
