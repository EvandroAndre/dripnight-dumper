using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudVerticleViewJoystickController : UIBaseController
{
	private UIHudVerticleMoveView m_View;

	private float m_BGRangeRadius;

	private float m_MaxJoyLength;

	private Vector3 m_Position;

	private Vector3 m_Rotation;

	private float m_BtnScale;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	private void Update()
	{
	}

	private void ActiveJoyStick(bool v)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}
}
