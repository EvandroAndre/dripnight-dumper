using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace COW.GamePlay;

internal class InWaterCarControllerComponent : MonoBehaviour, LEDGHNBKNPP
{
	private sealed class CILKBGJBAHM : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int CBPPJACCGOH;

		private object MHDKFGLHFKH;

		public InWaterCarControllerComponent KOKNHFGCGLN;

		public bool OBHJMCMFIOH;

		public float LLNANNNALIE;

		private bool BPCPCJIAFMM;

		private float CGAANGJDDHE;

		private AnimationState GDKCDCDJLPI;

		private float KBJJNHBLNOM;

		private float AAPGLGDHNMI;

		private float PELEANGJLAI;

		private float BGKEBACLKAN;

		private float JFEPOJAAMDK;

		private float PABBEEBPJLM;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public CILKBGJBAHM(int CBPPJACCGOH)
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

	private sealed class CECMMHDFBLI : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int CBPPJACCGOH;

		private object MHDKFGLHFKH;

		public bool OBHJMCMFIOH;

		public InWaterCarControllerComponent KOKNHFGCGLN;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public CECMMHDFBLI(int CBPPJACCGOH)
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

	private VehicleControllerInterface MIMGOFLAMDI;

	private NECCOAEBECB MMAMGCKKMPI;

	public Rigidbody rigid;

	public Transform VehicleBody;

	public bool EnableBodyRotation;

	public Animation AnimCompnent;

	public string InWaterSoundClip;

	private bool LHDOGDJMIFG;

	private Vector3 GDFKKJDGCND;

	private CarInWaterParam PKBOMOJOMBM;

	public float MaxVerticalLean;

	public float MaxHorizontalLean;

	public float VerticalLeanScale;

	public float HorizontalLeanScale;

	public float VerticalLeanSlow;

	public float HorizontalLeanSlow;

	private float FIFIINLBDAN;

	private float AKJCNLJPIMM;

	public float m_MinAudioValumn;

	public float m_MinAudioPitch;

	private GameObject IMLPOMCLKJL;

	private AudioSource LCBKFNHAOKC;

	public VehicleEffect[] WaterEffects;

	private bool ICMNEPFKCPB;

	private float DMPEDEJJGPI;

	private float LNPCEFFLKGI;

	private bool CLAPEPFKFOK;

	private Collider LHEDPMFLPAO;

	private float DIHDNCLKKKO;

	private IEnumerator FHGKJCAEEAN;

	public bool NeedWaterSound;

	public bool NOHCHPHIJHP => false;

	public bool FGPBMIOINOE
	{
		set
		{
		}
	}

	public bool NJHEMAJLAMM => false;

	private float LLFMDKPDHFD => 0f;

	private float LLNANNNALIE => 0f;

	public void Init(CarInWaterParam KDJNEHDAAFL, VehicleControllerInterface AICBEDFDNIG)
	{
	}

	public void StartEngine()
	{
	}

	public void KillEngine()
	{
	}

	public void VehicleUpdateInput(bool NCPIMBDABPG, bool FGBKMCEIMNI, Vector3 PMIKOMKJPBF)
	{
	}

	public void VehicleUpdateInput(float NCPIMBDABPG, float FGBKMCEIMNI, Vector3 PMIKOMKJPBF)
	{
	}

	public void VehicleLazyFixedUpdate(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	public void UpdateWheels()
	{
	}

	public void UpdateInWater(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	private void DENLJBDGFHO(float HOGHEFNINAE)
	{
	}

	private void LPPKMOEOGIH(float HOGHEFNINAE)
	{
	}

	public void EnterWaterTrigger(Collider GLJGHEAPBOF)
	{
	}

	public void ExitWater(bool BCCNMIHFBGE)
	{
	}

	public bool HasExitedWater()
	{
		return false;
	}

	private bool IAELGCCAGDP(float DFNHOKCIIJK)
	{
		return false;
	}

	public bool CheckEnteredWater(int PMNDMAKPFGE)
	{
		return false;
	}

	public bool CheckExitedWater(int PMNDMAKPFGE)
	{
		return false;
	}

	private bool LKNBDBGLNIA()
	{
		return false;
	}

	public void DisableWheelSimulation(bool NPHAJOAELIL)
	{
	}

	public void PlayTransformingAnim(bool OBHJMCMFIOH, bool HNIOHDJLGEO)
	{
	}

	protected void CNIGCJEFANP()
	{
	}

	private IEnumerator BHNHJMGNGGK(bool OBHJMCMFIOH)
	{
		return null;
	}

	private AnimationState KGKLNAPMLHM()
	{
		return null;
	}

	private void FAPGDFMDFAF(bool OBHJMCMFIOH)
	{
	}

	private IEnumerator IGJECLOBEHP(bool OBHJMCMFIOH, float LLNANNNALIE)
	{
		return null;
	}

	private void ONOJPLKIEPA()
	{
	}

	public void StartInWaterSound()
	{
	}

	public void StopInWaterSound()
	{
	}

	private void PHCBEEJPKJB()
	{
	}

	private void OOCLKJPGFDP()
	{
	}
}
