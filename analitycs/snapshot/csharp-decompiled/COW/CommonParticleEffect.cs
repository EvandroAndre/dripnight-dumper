using GCommon;
using UnityEngine;

namespace COW;

public class CommonParticleEffect : ReusableObject
{
	public bool AutoDestory;

	public float DelayDestoryTime;

	private float m_DelayDestroyMoment;

	protected ParticleSystem[] m_Particles;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	protected virtual void Update()
	{
	}

	public bool IsParticleAlive()
	{
		return false;
	}

	public void Play()
	{
	}

	public void Stop()
	{
	}
}
