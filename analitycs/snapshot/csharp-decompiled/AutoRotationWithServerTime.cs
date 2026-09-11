using COW;
using GCommon;
using UnityEngine;

public class AutoRotationWithServerTime : Entity
{
	private class ShadowState : ShadowStateBase
	{
		public float CurAngle;

		public float NextAngle;
	}

	public bool Clockwise;

	public GameObject Target;

	public float RotateSpeed;

	public int TickInterval;

	private bool m_NeedUpdate;

	private uint m_LastValidTickCount;

	private ShadowState m_ShadowState;

	protected override void OnAwake()
	{
	}

	public override void OnFixedUpdate(float gameTime, float deltaTime)
	{
	}
}
