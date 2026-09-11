using COW.GamePlay;
using GCommon;

namespace COW;

internal class UIHudHumanlikeTargetDamageResultController : UIBaseController
{
	private UIHudHumanlikeTargetDamageResultView m_View;

	private float m_BeginDamageTime;

	private float m_LastDamageTime;

	private float m_DamageResetTime;

	private bool m_IsFirstHit;

	private uint m_TotalEffectDamage;

	private uint m_RealDamageVal;

	private uint m_ShieldVal;

	private uint m_HeadShotVal;

	private uint m_BodyShotVal;

	private uint m_LimbShotVal;

	private float m_FirstDamageTime;

	private bool m_CanBeKilled;

	private uint m_beDamagerPlayerId;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnCloseDamageResult()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void OnCloseBtnClick()
	{
	}

	private void OnHumanTargetHumanBecameInVisible(uint playerId)
	{
	}

	private void OnLocalPlayerZoneChanged(object[] data)
	{
	}

	public void UpdateData(Player_TrainingHumanTarget player, LLEDPGIGCMO t, uint realDamage, uint shieldDamage)
	{
	}

	private void UpdateVal(float dura)
	{
	}

	private void ClearAllData()
	{
	}

	private void OnTrainTargetDead(object[] data)
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
