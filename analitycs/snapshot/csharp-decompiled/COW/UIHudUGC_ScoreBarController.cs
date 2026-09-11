using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudUGC_ScoreBarController : UIHUDUGC_InternalHudController
{
	private UGCScoreBarHudRepItem m_RepItem;

	private UIHUDUGC_ScoreBarView m_View;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public override void DestroyEntity()
	{
	}

	public override void SetEntityID(string entityID)
	{
	}

	public void Update()
	{
	}

	private void OnCentralLinePosChange(float val)
	{
	}

	private void OnCentralLineChange(bool obj)
	{
	}

	private void OnPosChange(Vector3 pos)
	{
	}

	private void OnSpeedChange(float v)
	{
	}

	private void OnValueChange(float obj)
	{
	}

	private void OnLeftColorChange(int obj)
	{
	}

	private void OnLeftEffectChange(bool active)
	{
	}

	private void OnRightColorChange(int obj)
	{
	}

	private void OnRightEffectChange(bool obj)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_DestroyEntity()
	{
	}

	public void _003C_003EiFixBaseProxy_SetEntityID(string P0)
	{
	}
}
