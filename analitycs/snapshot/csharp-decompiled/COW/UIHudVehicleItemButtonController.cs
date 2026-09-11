using COW.GamePlay;
using UnityEngine;

namespace COW;

internal abstract class UIHudVehicleItemButtonController : UIHudButtonBaseController
{
	protected UISprite m_CDProgress;

	protected GameObject m_CDMask;

	protected UISprite m_EffectingProgress;

	protected DKCOBGILPCO m_TargetSlot;

	protected float m_CdEndTime;

	private float m_CdTime;

	private float m_LeftTime;

	protected Vehicle m_Vehicle;

	protected BDBKGOMDIME m_Inv;

	protected bool IsInCd => false;

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected virtual void OnPlayerGetOnVehicle(object[] ps)
	{
	}

	protected virtual void OnPlayerGetOffVehicle(object[] ps)
	{
	}

	protected void OnLocalVehicleEquipChange(object[] ps)
	{
	}

	protected void OnLocalVehicleUseItem(object[] ps)
	{
	}

	protected void CheckAndUpdateVisibility()
	{
	}

	protected void CheckAndUpdateVisibility(LevelVehicle veh)
	{
	}

	protected virtual bool ShouldHide()
	{
		return false;
	}

	protected virtual void Update()
	{
	}

	protected virtual void UpdateCd(BDBKGOMDIME item)
	{
	}

	protected virtual float GetEffectingTime()
	{
		return 0f;
	}

	protected virtual float GetEffectingTimeLeft()
	{
		return 0f;
	}

	protected BDBKGOMDIME GetInv()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
