using System;
using GCommon;
using UnityEngine;

namespace COW;

public class TraceParticleEffectWithTime : MonoBehaviour
{
	public float Duration;

	public EEaseType EaseType;

	protected ParticleSystem[] m_Particles;

	private Transform m_Target;

	private Vector3 m_TargetPos;

	private float m_StartTime;

	private Vector3 m_StartPosition;

	private bool m_IsCompleted;

	public Action OnCompleteCallback;

	private void Start()
	{
	}

	protected virtual void Update()
	{
	}

	private void LerpToTarget()
	{
	}

	private void ProtectedComplete()
	{
	}

	public void Play(Transform target)
	{
	}

	public void Stop()
	{
	}

	private void OnComplete()
	{
	}

	private void OnDisable()
	{
	}
}
