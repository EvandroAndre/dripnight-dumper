using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudNameRedEnvelopeController : UIHudNameBaseController
{
	private LevelRedEnvelope bindedLevelObject;

	private UIHudNameRedEnvelopeView m_View;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void BindLevelObject(LevelRedEnvelope red)
	{
	}

	protected override Vector3 TargetPosition()
	{
		return default(Vector3);
	}

	public void OnRedEnvelopeStatusChanged(bool isAlive)
	{
	}

	protected override bool NeedAutoScaleByDistance()
	{
		return false;
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
