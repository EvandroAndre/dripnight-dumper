using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudUGC_ProgressCircleController : UIHUDUGC_InternalHudController
{
	private UIHudUGC_ProgressCircleView m_View;

	private UGCProgressCircleHudRepItem m_RepViewData;

	private UITimeLabelHelper m_TimeHelper;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void DestroyEntity()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public override void SetEntityID(string entityID)
	{
	}

	private void OnOpenStateChanged(bool value)
	{
	}

	private void OnOffsetChanged(Vector3 pos)
	{
	}

	private void OnIconChanged(string value)
	{
	}

	private void OnEndTimeSChanged(int time)
	{
	}

	private void InitTimer()
	{
	}

	private void Update()
	{
	}

	private void OnBtnActionClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_DestroyEntity()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_SetEntityID(string P0)
	{
	}
}
