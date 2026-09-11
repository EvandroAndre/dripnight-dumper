using GCommon;
using UnityEngine;

namespace COW;

internal class UIHUDUGC_ZombieVFXController : UIHUDUGC_InternalHudController
{
	private UIHUDUGC_ZombieVFXView m_View;

	private UGCZombieVFXHudRepItem m_ViewData;

	private CommonParticleEffect m_Effect;

	private Object m_EffectObj;

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

	public override void DestroyEntity()
	{
	}

	private void OnOpenStateChanged(bool cur)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_SetEntityID(string P0)
	{
	}

	public void _003C_003EiFixBaseProxy_DestroyEntity()
	{
	}
}
