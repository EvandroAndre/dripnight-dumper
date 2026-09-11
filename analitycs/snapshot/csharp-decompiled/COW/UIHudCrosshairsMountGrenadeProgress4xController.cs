using GCommon;
using UnityEngine;

namespace COW;

public class UIHudCrosshairsMountGrenadeProgress4xController : UIHudCrosshairsMountGrenadeProgressControllerBase
{
	private UIHudCrosshairsMountGrenadeProgress4xView m_View;

	protected Vector3 m_ProgressItemOffset4x;

	protected Vector3 m_ProgressItemOffset8x;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetProgressItemOffsetByRatio(int ratio)
	{
	}

	protected override void OnUIDestory()
	{
	}

	public override GameObject GetTemplate()
	{
		return null;
	}

	public override Transform GetRootNode()
	{
		return null;
	}

	public override int GetAmplifyRatio()
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public GameObject _003C_003EiFixBaseProxy_GetTemplate()
	{
		return null;
	}

	public Transform _003C_003EiFixBaseProxy_GetRootNode()
	{
		return null;
	}

	public int _003C_003EiFixBaseProxy_GetAmplifyRatio()
	{
		return 0;
	}
}
