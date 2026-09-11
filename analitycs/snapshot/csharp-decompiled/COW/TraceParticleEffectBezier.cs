using GCommon;
using UnityEngine;

namespace COW;

internal class TraceParticleEffectBezier : ReusableObject
{
	public delegate void Callback();

	public float Speed;

	public float AddSpeed;

	public float Gravity;

	public float DestroyTime;

	public float OffY;

	public Transform Target;

	protected ParticleSystem[] m_Particles;

	private float m_StartTime;

	private Callback m_Complete;

	private Vector3 m_StartPos;

	private Vector3 m_EndPos;

	private Vector3 m_ControlPos;

	private float m_T;

	private float m_BezierLength;

	private float m_CurSpeed;

	private float m_CurAddSpeed;

	private bool isPosFlying;

	private void Start()
	{
	}

	protected virtual void Update()
	{
	}

	public void Play(Vector3 endPos)
	{
	}

	public void Play()
	{
	}

	public void Stop()
	{
	}

	private float CalcBezierLength(Vector3 p0, Vector3 p1, Vector3 p2, int segments)
	{
		return 0f;
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
