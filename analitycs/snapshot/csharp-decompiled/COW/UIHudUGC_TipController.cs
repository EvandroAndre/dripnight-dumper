using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudUGC_TipController : UIHUDUGC_InternalHudController
{
	private UIHUDUGC_TipView m_View;

	private UGCTipHudRepItem m_RepItem;

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

	private void OnTextColorChange(int obj)
	{
	}

	private void OnLocChange(bool obj)
	{
	}

	private string GetText(string obj)
	{
		return null;
	}

	private void OnPosChange(Vector3 pos)
	{
	}

	private void OnTextChange(string obj)
	{
	}

	private void OnBackgroundChange(string obj)
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
