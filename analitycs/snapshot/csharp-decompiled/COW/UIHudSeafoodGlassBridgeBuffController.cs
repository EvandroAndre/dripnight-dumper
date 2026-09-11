using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudSeafoodGlassBridgeBuffController : UIHudNameBaseController
{
	private UIHudSeafoodGlassBridgeBuffView m_View;

	private BHGGAEEHJCO m_PlayerID;

	private uint m_DelayCallId;

	private float m_DelayTime;

	private Vector3 m_BuffIconOffset;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override Vector3 TargetPosition()
	{
		return default(Vector3);
	}

	public void BindPlayer(BHGGAEEHJCO player_id)
	{
	}

	private void TryHideSeafoodGlassBridgeBuff()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public Vector3 _003C_003EiFixBaseProxy_TargetPosition()
	{
		return default(Vector3);
	}
}
