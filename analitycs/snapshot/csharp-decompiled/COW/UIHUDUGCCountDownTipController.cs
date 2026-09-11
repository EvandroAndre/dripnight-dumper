using GCommon;
using UnityEngine;

namespace COW;

internal class UIHUDUGCCountDownTipController : UIHUDUGC_InternalHudController
{
	private UIHudSimpleCountdownView m_View;

	private UGCCountdownHudRepItem m_ViewData;

	private UITimeLabelHelper m_TimeHelper;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override void SetEntityID(string entityID)
	{
	}

	private void OnOffsetChange(Vector3 offset)
	{
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnDestroy()
	{
	}

	public override void DestroyEntity()
	{
	}

	private void Update()
	{
	}

	private void UpdateLeftTimeShow()
	{
	}

	private void OnOpenStateChangeEventHandle(bool nowValue)
	{
	}

	private void OnBaseTimeChangeHandle(int nowValue)
	{
	}

	private void OnDurationChangeHandle(int nowValue)
	{
	}

	private void OnUpdateTypeChangeHandle(int nowValue)
	{
	}

	private void RefreshViewData2View()
	{
	}

	public void _003C_003EiFixBaseProxy_SetEntityID(string P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_DestroyEntity()
	{
	}
}
