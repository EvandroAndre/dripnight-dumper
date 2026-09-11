using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudNameRedEnvelopeOwnerController : UIHudNameBaseController
{
	private UIHudNameRedEnvelopeOwnerView m_View;

	private Transform m_CachedTransform;

	private Player m_Owner;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void BindPlayer(Player owner)
	{
	}

	protected override Vector3 TargetPosition()
	{
		return default(Vector3);
	}

	protected override bool NeedAutoScaleByDistance()
	{
		return false;
	}

	public float GetUIHeight()
	{
		return 0f;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public Vector3 _003C_003EiFixBaseProxy_TargetPosition()
	{
		return default(Vector3);
	}

	public bool _003C_003EiFixBaseProxy_NeedAutoScaleByDistance()
	{
		return false;
	}
}
