using COW.GamePlay;

namespace COW;

public static class WeaponPropertyUtil
{
	public static void GetWeaponProperty(uint wpid, uint skinId, EWeaponScoreID scoreId, int score, out float defaultProperty, out float skinProperty)
	{
		defaultProperty = default(float);
		skinProperty = default(float);
	}

	public static void GetWeaponPveProperty(uint wpid, uint skinId, EWeaponScoreID scoreId, int score, out float defaultProperty, out float skinProperty)
	{
		defaultProperty = default(float);
		skinProperty = default(float);
	}

	private static void GetWeaponDamageNew(AGACNOCEEFP weaponData, LFAAGMJOKHG propertyData, bool sameProperty, out float defaultProperty, out float skinProperty)
	{
		defaultProperty = default(float);
		skinProperty = default(float);
	}

	private static void GetWeaponRateOfFire(AGACNOCEEFP weaponData, LFAAGMJOKHG propertyData, bool sameProperty, out float defaultProperty, out float skinProperty)
	{
		defaultProperty = default(float);
		skinProperty = default(float);
	}

	private static void GetWeaponRange(AGACNOCEEFP weaponData, LFAAGMJOKHG propertyData, bool sameProperty, out float defaultProperty, out float skinProperty)
	{
		defaultProperty = default(float);
		skinProperty = default(float);
	}

	private static void GetWeaponReloadSpeed(AGACNOCEEFP weaponData, LFAAGMJOKHG propertyData, bool sameProperty, out float defaultProperty, out float skinProperty)
	{
		defaultProperty = default(float);
		skinProperty = default(float);
	}

	private static void GetWeaponAmmoClipSize(AGACNOCEEFP weaponData, LFAAGMJOKHG propertyData, bool sameProperty, out float defaultProperty, out float skinProperty)
	{
		defaultProperty = default(float);
		skinProperty = default(float);
	}

	private static void GetWeaponAccuracy(AGACNOCEEFP weaponData, LFAAGMJOKHG propertyData, bool sameProperty, out float defaultProperty, out float skinProperty)
	{
		defaultProperty = default(float);
		skinProperty = default(float);
	}

	private static void GetAttachmentsProperty(AGACNOCEEFP weaponData, out int attachmentSightAmplifyRatio, out float attachmentShrinkSpeed)
	{
		attachmentSightAmplifyRatio = default(int);
		attachmentShrinkSpeed = default(float);
	}

	private static void GetWeaponBiteAmmor(AGACNOCEEFP weaponData, LFAAGMJOKHG propertyData, bool sameProperty, out float defaultProperty, out float skinProperty)
	{
		defaultProperty = default(float);
		skinProperty = default(float);
	}

	private static void GetWeaponMovementSpeed(AGACNOCEEFP weaponData, LFAAGMJOKHG propertyData, bool sameProperty, out float defaultProperty, out float skinProperty)
	{
		defaultProperty = default(float);
		skinProperty = default(float);
	}

	private static void GetWeaponExplodeRange(AGACNOCEEFP weaponData, out float defaultProperty, out float skinProperty)
	{
		defaultProperty = default(float);
		skinProperty = default(float);
	}

	private static void GetHealing(AGACNOCEEFP weaponData, out float defaultProperty, out float skinProperty)
	{
		defaultProperty = default(float);
		skinProperty = default(float);
	}

	private static void GetGlooRange(int score, out float defaultProperty, out float skinProperty)
	{
		defaultProperty = default(float);
		skinProperty = default(float);
	}

	private static void GetGlooHeight(int score, out float defaultProperty, out float skinProperty)
	{
		defaultProperty = default(float);
		skinProperty = default(float);
	}

	private static void GetGlooClimb(int score, out float defaultProperty, out float skinProperty)
	{
		defaultProperty = default(float);
		skinProperty = default(float);
	}

	public static float DamageFormulaNew(int damage, int oneAmmo)
	{
		return 0f;
	}

	public static float SkinDamageFormulaNew(int weaponDamage, int skinDamageDelta, int oneAmmo, float weaponDamageScore)
	{
		return 0f;
	}

	public static float RateOfFireFormula(uint fireType, float fireInterval, float repeatFireInterval)
	{
		return 0f;
	}

	public static float RangeFormula(float fullDamageDistance, float minDamageDistance, float range)
	{
		return 0f;
	}

	public static float ReloadSpeedFormula(float reloadSpeed)
	{
		return 0f;
	}

	public static float AmmoClipSizeFormula(int ammoClipSize)
	{
		return 0f;
	}

	public static float MovementSpeedFormula(float playerSpeedFactor)
	{
		return 0f;
	}

	public static float BiteArmorFormula(float biteArmor)
	{
		return 0f;
	}

	public static float AccuracyFormula(float scatterNum, float scatterSpeed, float scatterMax, float aimAssistLockDecreaseTime, float aimAssistLockDecreaseTimeSight, float sightAmplifyRatio, float shrinkSpeed)
	{
		return 0f;
	}

	private static float Median(float a, float b, float c)
	{
		return 0f;
	}

	private static float ExplodeRangeFormula(float range)
	{
		return 0f;
	}

	private static float HealingFormula(int healing)
	{
		return 0f;
	}
}
