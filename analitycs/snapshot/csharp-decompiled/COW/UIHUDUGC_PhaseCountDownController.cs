using GCommon;
using UnityEngine;

namespace COW;

public class UIHUDUGC_PhaseCountDownController : UIHUDUGC_InternalHudController
{
	private UIHUDUGC_PhaseCountDownView m_View;

	private UGCPhaseCountDownHudRepItem m_ViewData;

	private UITimeLabelHelper m_TimeHelper;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void Update()
	{
	}

	public override void SetEntityID(string entityID)
	{
	}

	public override void DestroyEntity()
	{
	}

	private void InitTimer()
	{
	}

	private void OnOpenStateChanged(bool cur)
	{
	}

	private void OnBaseTimeChanged(int cur)
	{
	}

	private void OnDurationTimeChanged(int cur)
	{
	}

	private void OnOffsetChange(Vector3 offset)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_SetEntityID(string P0)
	{
	}

	public void _003C_003EiFixBaseProxy_DestroyEntity()
	{
	}
}
