using System;
using System.Collections;
using System.Collections.Generic;
using COW;
using COW.GamePlay;
using GCommon;
using UnityEngine;

public class VehicleEffectChange : MonoBehaviour
{
	private sealed class _003CCoVehicleMoveEffectLoopPlay_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public VehicleEffectChange _003C_003E4__this;

		public float spaceTime;

		public float durationTime;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCoVehicleMoveEffectLoopPlay_003Ed__33(int _003C_003E1__state)
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

	private List<GameObject> m_MoveEffectObjects;

	private VehicleSkinData m_VehicleSkinData;

	private GameObject m_VehicleRoot;

	private int m_HorseMoveSound2DTicket;

	private uint m_HorseMoveSound3DTicket;

	private int m_VehicleMoveSound2DTicket;

	private Coroutine m_MoveEffectLoopCoroutine;

	private bool m_HasVehicleMoveEffect;

	private bool m_IsHorseMoveSoundPlaying;

	private float m_MoveEffectSpaceTime;

	private float m_MoveEffectDurationTime;

	private Vehicle m_InGameVehicle;

	private VehicleSkinData m_InGameVehicleSkinData;

	private VisualInstanceHolder m_InGameHorseMoveEffectHolder;

	private readonly List<BoneNameRef> m_InGameHorseMoveEffectBoneNameRefs;

	private bool m_IsInGameHorseMoveEffectShowing;

	internal void InitInGameHorseMoveEffect(Vehicle vehicle)
	{
	}

	internal void ReleaseInGameHorseMoveEffect()
	{
	}

	private void FixedUpdate()
	{
	}

	private void CheckInGameHorseMoveEffectShow()
	{
	}

	private void StartInGameHorseEffectAndSound()
	{
	}

	private void StopInGameHorseSkinEffectAndSound(bool playEndSound)
	{
	}

	private void OnInGameHorseMoveEffectLoaded(GameObject instance)
	{
	}

	private void CacheInGameHorseMoveEffectBoneNameRefs(GameObject go)
	{
	}

	private void ResetInGameHorseMoveEffectBoneNameRefs()
	{
	}

	private GameObject GetInGameVehicleSkinRoot()
	{
		return null;
	}

	private bool ShouldShowInGameHorseMoveEffect()
	{
		return false;
	}

	private VehicleSkinData GetInGameVehicleSkinData(Vehicle vehicle)
	{
		return null;
	}

	private void PlayInGameHorseSpeedLineOneShot(ResourceID soundID)
	{
	}

	public void InitMoveEffect(VehicleSkinData vehicleSkinData, GameObject vehicleRoot)
	{
	}

	public void InitVehicleMoveEffect(VehicleSkinData vehicleSkinData, GameObject vehicleRoot)
	{
	}

	public void StartVehicleMoveEffectLoopPlay(float spaceTime = 5f, float durationTime = 5f)
	{
	}

	public void StopVehicleMoveEffectLoopPlay()
	{
	}

	private IEnumerator CoVehicleMoveEffectLoopPlay(float spaceTime, float durationTime)
	{
		return null;
	}

	public void HorseMoveStartEvent()
	{
	}

	public void HorseMoveEndEvent()
	{
	}

	public void PlayHorseMoveEffect()
	{
	}

	public void StopHorseMoveEffect()
	{
	}

	public void PlayVehicleMoveEffect()
	{
	}

	public void StopVehicleMoveEffect()
	{
	}

	public void PlayVehicleMoveSound()
	{
	}

	public void StopVehicleMoveSound()
	{
	}

	private void SetMoveEffectActive(bool active)
	{
	}

	private void PlayHorseMoveSound()
	{
	}

	private void StopHorseMoveSound()
	{
	}

	private void StopHorseMoveLoopSound()
	{
	}

	private void PlayHorseMoveOneShotSound(ResourceID soundID)
	{
	}

	private void ClearMoveEffects()
	{
	}

	private void OnDisable()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDestroy()
	{
	}
}
