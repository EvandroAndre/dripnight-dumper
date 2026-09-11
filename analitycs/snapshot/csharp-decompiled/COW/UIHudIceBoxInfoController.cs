using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudIceBoxInfoController : UIHudNameBaseController
{
	private LevelObjectIceBox m_Target;

	private UIHudIceBoxInfoView m_View;

	private Vector3 m_TrackPosition;

	public void Bind(LevelObjectIceBox target)
	{
	}

	protected override Vector3 TargetPosition()
	{
		return default(Vector3);
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void UpdateProgress(float gameTime, float beginTime, float endTime)
	{
	}

	protected override bool NeedAutoScaleByDistance()
	{
		return false;
	}

	public Vector3 _003C_003EiFixBaseProxy_TargetPosition()
	{
		return default(Vector3);
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public bool _003C_003EiFixBaseProxy_NeedAutoScaleByDistance()
	{
		return false;
	}
}
