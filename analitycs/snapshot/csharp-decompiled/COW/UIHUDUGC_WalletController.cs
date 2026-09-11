using GCommon;
using UnityEngine;

namespace COW;

internal class UIHUDUGC_WalletController : UIHUDUGC_InternalHudController
{
	private UIHUDUGC_WalletView m_View;

	private UGCWalletHudRepItem m_ViewData;

	private UGCMoneyRepItem m_BindMoneyComponent;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void SetEntityID(string entityID)
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public override void DestroyEntity()
	{
	}

	private void OnBindMoneyEntityChangeEvent(string cur)
	{
	}

	private void OnOffsetChangeEvent(Vector3 cur)
	{
	}

	private void RefreshPosition(Vector3 pos)
	{
	}

	private void BindMoneyEntity(string moneyEntityID)
	{
	}

	private void OnCountChangeEvent(float cur)
	{
	}

	private void OnIconChangeEvent(string cur)
	{
	}

	private void OnColorChangeEvent(int cur)
	{
	}

	private void OnScaleChangeEvent(Vector3 cur)
	{
	}

	private void _003COnIconChangeEvent_003Eb__13_0(UIAtlas atlas, string spriteName)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_SetEntityID(string P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_DestroyEntity()
	{
	}
}
