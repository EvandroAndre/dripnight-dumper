using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW.HUD;

internal class UIHudCommonDistanceController : UIHudNameBaseController
{
	private UIHudCommonDistanceView m_View;

	private BHAEKJPDDPE m_BindLevelObject;

	private float m_ScaleFactorDefault;

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

	protected override float GetScaleFactorDefault()
	{
		return 0f;
	}

	public void SetScale(float scale)
	{
	}

	public void BindLevelObject(OPICPDCLKAG levelObjectType, uint levelObjectID)
	{
	}

	public void UnBindLevelObject()
	{
	}

	private bool NeedShow()
	{
		return false;
	}

	protected override void UpdateNamePosition()
	{
	}

	private void UpdateDistanceLabel()
	{
	}

	protected override Vector3 TargetPosition()
	{
		return default(Vector3);
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public bool _003C_003EiFixBaseProxy_NeedAutoScaleByDistance()
	{
		return false;
	}

	public float _003C_003EiFixBaseProxy_GetScaleFactorDefault()
	{
		return 0f;
	}

	public void _003C_003EiFixBaseProxy_UpdateNamePosition()
	{
	}

	public Vector3 _003C_003EiFixBaseProxy_TargetPosition()
	{
		return default(Vector3);
	}
}
