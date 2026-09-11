using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW.HUD;

internal class UIHudUAVHPController : UIHudNameBaseController
{
	private UIHudUAVHPView m_View;

	private uint m_BindUAVId;

	private float m_RaycastTime;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override bool NeedAutoScaleByDistance()
	{
		return false;
	}

	protected override bool NeedUpdatePosition()
	{
		return false;
	}

	private LevelUAV GetBoundUAV()
	{
		return null;
	}

	private bool TryGetValidUAV(out LevelUAV uav)
	{
		uav = null;
		return false;
	}

	protected override Vector3 TargetPosition()
	{
		return default(Vector3);
	}

	public void BindUAV(uint uavId)
	{
	}

	public void UnBindUAV()
	{
	}

	protected override void UpdateNamePosition()
	{
	}

	private void UpdateUAVHP(LevelUAV uav)
	{
	}

	private void RecycleHudUAVHP()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public bool _003C_003EiFixBaseProxy_NeedAutoScaleByDistance()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_NeedUpdatePosition()
	{
		return false;
	}

	public Vector3 _003C_003EiFixBaseProxy_TargetPosition()
	{
		return default(Vector3);
	}

	public void _003C_003EiFixBaseProxy_UpdateNamePosition()
	{
	}
}
