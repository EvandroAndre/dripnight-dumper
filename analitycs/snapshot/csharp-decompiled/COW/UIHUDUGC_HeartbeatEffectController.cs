using GCommon;
using UnityEngine;

namespace COW;

public class UIHUDUGC_HeartbeatEffectController : UIHUDUGC_InternalHudController
{
	private UIHUDUGC_HeartbeatEffectView m_View;

	private UGCHeartbeatEffectHudRepItem m_Component;

	private const string EFFECT_SLOW = "UGC_EFFECT_HEARTBEAT_SLOW";

	private const string EFFECT_NORMAL = "UGC_EFFECT_HEARTBEAT_NORMAL";

	private const string EFFECT_QUICK = "UGC_EFFECT_HEARTBEAT_QUICK";

	private string CurRes;

	private GameObject ParticleObj;

	private Renderer[] CacheRenders;

	private Color CurColor;

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

	private void OnOpenStateChanged(bool b)
	{
	}

	private void OnPlaySpeedChanged(float v)
	{
	}

	private void OnColorChanged(int v)
	{
	}

	private void ApplyColor()
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
