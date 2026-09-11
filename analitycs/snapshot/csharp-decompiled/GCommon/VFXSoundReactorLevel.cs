using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GCommon;

public class VFXSoundReactorLevel : MonoBehaviour
{
	public enum LevelEffectType
	{
		Animation
	}

	public enum SmoothType
	{
		Jump,
		Sharpness
	}

	public enum TriggerType
	{
		SpawnVFX
	}

	private sealed class _003CVFXGC_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public VFXSoundReactorLevel _003C_003E4__this;

		public GameObject vfx;

		public int vfxId;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CVFXGC_003Ed__28(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	public float Input;

	public LevelEffectType LevelType;

	public List<Animation> Anims;

	public float TriggerValue;

	public TriggerType TrigType;

	public List<GameObject> VfxPrefabs;

	public float VfxDuration;

	private List<List<GameObject>> m_vfxPools;

	private int m_maxVfxCount;

	private int m_curActivedVfxCount;

	public SmoothType InputSmoothType;

	public float InputSmooth;

	private const float INPUT_DECREASE_BASE = 5E-07f;

	private const float INPUT_DECREASE_MULTIPLIER = 1.2f;

	private float m_inputDecrease;

	private float m_curInput;

	private float m_curInputTemp;

	private float m_cachedPow10InputSmooth;

	private List<AnimationState> m_cachedAnimationStates;

	public void SetInput(float input)
	{
	}

	public void Start()
	{
	}

	public void Init()
	{
	}

	public void OnUpdate()
	{
	}

	private void OnDisable()
	{
	}

	private void SpawnVFX()
	{
	}

	private IEnumerator VFXGC(GameObject vfx, int vfxId)
	{
		return null;
	}

	private void PoolGC()
	{
	}
}
