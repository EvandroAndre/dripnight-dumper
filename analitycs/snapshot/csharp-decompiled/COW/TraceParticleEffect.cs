using GCommon;
using UnityEngine;

namespace COW;

internal class TraceParticleEffect : ReusableObject
{
	public delegate void Callback();

	public float Speed;

	public float AddSpeed;

	public float Gravity;

	public float DestroyTime;

	public float OffY;

	public Transform Target;

	public Vector3 TargetPos;

	public bool NeedReachTarget;

	protected ParticleSystem[] m_Particles;

	private float m_StartTime;

	private Callback m_Complete;

	private float m_Speed;

	private float m_AddSpeed;

	private float m_Distance;

	private bool m_IsReachedTarget;

	private bool m_IsPlaying;

	private void Start()
	{
	}

	protected virtual void Update()
	{
	}

	public void Play()
	{
	}

	public void Stop()
	{
	}

	protected override void DoRecycle()
	{
	}

	public void AddComplete(Callback fun)
	{
	}

	public void _003C_003EiFixBaseProxy_DoRecycle()
	{
	}
}
