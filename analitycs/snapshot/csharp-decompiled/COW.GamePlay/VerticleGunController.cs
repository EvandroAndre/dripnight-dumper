using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW.GamePlay;

public class VerticleGunController : MonoBehaviour
{
	public uint GunId;

	public Transform[] BulletSpawn;

	public bool[] IsHideBulletSpawn;

	public float MillisecondBetweenShot;

	public float MuzzleVelocity;

	public int BulletsPerMag;

	public float ReloadTime;

	public float BulletLifeTime;

	public float BulletDamage;

	public float SkillRechargeRate;

	public string BulletResId;

	public string BulletDesctroyEffectId;

	public string FireSoundId;

	public string BulletDestroySoundId;

	public Color LineColor;

	public ResourceID RealFireResId;

	public bool IsSector;

	public float Angle;

	public float Width;

	public bool IsGrenade;

	public float ExplosionRange;

	public bool NeedPlayerFollow;

	public Transform PlayerFollowMuzzle;

	public bool IsPassPlayer;

	public float FireKeepTime;

	public bool UseGroup;

	private float HNMGGIJLKKA;

	public int BulletsRemainingInMag;

	private uint KOHOAGNJKAB;

	private float ENAHFFLFDLP;

	private float FGKJNHODCCN;

	public List<Transform> VisibleMuzzleList;

	private GIFGAGAGFLA HGEGDIMKMFM;

	public float GunRange;

	private bool KJIPDCBLBCE;

	private bool MKNOIIEJCFJ;

	public CBLMFOAKHFH GunType;

	private float BCFOBDFEABB;

	private void Awake()
	{
	}

	public void FillAllAmount()
	{
	}

	public void SetData(uint KJLFMPOFELA, bool DMOPHIIADON)
	{
	}

	public bool CanFire()
	{
		return false;
	}

	public bool IsShowReloadingTips()
	{
		return false;
	}

	private bool JMEHPECAMPE()
	{
		return false;
	}

	public bool OnTriggerHold(float NJHPODHGNOM = 0f)
	{
		return false;
	}

	public void GetGrenadeLifeTime(float NJHPODHGNOM = 0f)
	{
	}

	public void OnSyncShoot(float KBMGFBJJHAK, float INNIDEIFIFN)
	{
	}

	public float GetGunSqrDist()
	{
		return 0f;
	}
}
