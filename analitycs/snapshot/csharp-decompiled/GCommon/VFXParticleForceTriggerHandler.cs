using System.Collections.Generic;
using UnityEngine;

namespace GCommon;

public class VFXParticleForceTriggerHandler : MonoBehaviour
{
	private VFXParticleForce m_VfxForce;

	private ParticleSystem m_ParticleSystem;

	private List<ParticleSystem.Particle> m_InsideParticle;

	private Matrix4x4 m_CachedLocalToWorldMatrix;

	private Matrix4x4 m_CachedWorldToLocalMatrix;

	private static int s_ParticleCount;

	private static int s_LastFrameCount;

	public void Initialize(VFXParticleForce force, ParticleSystem ps)
	{
	}

	public void OnParticleTrigger()
	{
	}
}
