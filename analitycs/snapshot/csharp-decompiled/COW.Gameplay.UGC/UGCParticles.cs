using System.Collections.Generic;
using COW.GamePlay.UGCRuntime;
using UnityEngine;
using message;

namespace COW.Gameplay.UGC;

public class UGCParticles : MonoBehaviour
{
	public enum EPlayState
	{
		None,
		Play,
		Stop,
		Pause,
		PauseAndReset
	}

	private GameObject m_GO;

	private GameObject m_Particles;

	private ParticleSystem m_ParticleSystem;

	private UGCResParticles m_ResParticles;

	private string m_UGCEntityID;

	private UGCPlayableRepItem m_PlayableRep;

	private UGCLoopableRepItem m_LoopableRep;

	private UGCParticlesRepItem m_ParticlesRep;

	private bool m_OriLoop;

	private bool m_Playing;

	private bool m_Reset;

	private bool m_UpdatePlay;

	private bool m_UpdateFlag;

	private bool m_UpdateLoop;

	private EPlayState m_State;

	private float m_Duration;

	private float m_PlayTime;

	private int m_PlayCount;

	private bool m_Loop;

	private bool m_OldLoop;

	private UGCLogicEntity m_Entity;

	private object[] m_EventArgs;

	public static UGCParticles Create(GameObject go, string entityID)
	{
		return null;
	}

	private void Init()
	{
	}

	public void OnDestory()
	{
	}

	private void RemoveChangeNotify()
	{
	}

	public void LoadResource(string resUUID)
	{
	}

	private void ResParticlesChanged(UGCResource res)
	{
	}

	private void RefreshParticleSystem()
	{
	}

	private void OnShapeTextureChanged(UGCResource res)
	{
	}

	private void OnShapeMeshChanged(UGCResource res)
	{
	}

	private void OnRenderMaterialChanged(UGCResource res)
	{
	}

	private void OnRenderMeshChanged(UGCResource res)
	{
	}

	private void RefreshVisibility()
	{
	}

	private void OnPlayingChange(bool value)
	{
	}

	private void OnFlagChange(int value)
	{
	}

	private void OnLoopTypeChange(int value)
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Update()
	{
	}

	private void DispatchLoopAndEndEvent()
	{
	}

	private void SetElapsedPercentage(float value)
	{
	}

	private void UpdateState()
	{
	}

	private Vector2 GetConstantMinMax(float value, float random)
	{
		return default(Vector2);
	}

	private AnimationCurve GetAnimationCurve(float multiplier, List<KMMBMMJAKNE> list)
	{
		return null;
	}

	private ParticleSystem.MinMaxCurve GetMinMaxCurve(float value, float random, List<KMMBMMJAKNE> list)
	{
		return default(ParticleSystem.MinMaxCurve);
	}

	private void _003CLoadResource_003Eb__27_0(bool succ, UGCResParticles resObj)
	{
	}
}
