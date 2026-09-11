using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudFPPPlayerEffectController : UIBaseController
{
	private UIHudFPPPlayerEffectView m_View;

	private VisualInstanceHolder m_VfxBeHurtHolder;

	private VisualInstanceHolder m_VfxSpeedUpHolder;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void Update()
	{
	}

	private void PlayFPPPlayerBeHurtEffect(uint deltaHp)
	{
	}

	private void AttachBeHurtFinish(GameObject go)
	{
	}

	private void ShowSpeedUpEffect(bool show)
	{
	}

	protected override void OnDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}
}
