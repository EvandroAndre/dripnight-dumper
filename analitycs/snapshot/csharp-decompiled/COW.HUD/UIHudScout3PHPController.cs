using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW.HUD;

internal class UIHudScout3PHPController : UIHudNameBaseController
{
	private UIHudScout3PHPView m_View;

	private uint m_BindScoutID;

	private LevelScout m_BindScout;

	private float m_RaycastTime;

	private float m_RaycastShowCheckInterval;

	private float m_NextRaycastShowCheckTime;

	private bool m_IsRaycastShow;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void BindScout(uint scoutUID)
	{
	}

	public void UnBindScout()
	{
	}

	protected override bool NeedAutoScaleByDistance()
	{
		return false;
	}

	private bool NeedShow()
	{
		return false;
	}

	protected override void UpdateNamePosition()
	{
	}

	protected override Vector3 TargetPosition()
	{
		return default(Vector3);
	}

	private void UpdateHP()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public bool _003C_003EiFixBaseProxy_NeedAutoScaleByDistance()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_UpdateNamePosition()
	{
	}

	public Vector3 _003C_003EiFixBaseProxy_TargetPosition()
	{
		return default(Vector3);
	}
}
