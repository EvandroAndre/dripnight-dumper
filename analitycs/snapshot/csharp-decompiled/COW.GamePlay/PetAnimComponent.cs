using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using message;

namespace COW.GamePlay;

public class PetAnimComponent : PetAnimComponentBase
{
	private sealed class CCNBMNGPKAL : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int CBPPJACCGOH;

		private object MHDKFGLHFKH;

		public float OBNPLABHICH;

		public PetAnimComponent KOKNHFGCGLN;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public CCNBMNGPKAL(int CBPPJACCGOH)
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

	public GameObject RenderObject;

	public Transform ShowHideEffectPoint;

	public AnimationClip AppearAnim;

	public AnimationClip DisappearAnim;

	public float ShowHideDelay;

	private Action BOEGHNHPIMM;

	public void ChangeAnimCtrlAndModel(GameObject NAGHAPBBLKF, bool BKGEBCMIPPH)
	{
	}

	protected override void FCDDABEFLJG(bool FBMPJEMICLN, out bool JBMPKFAJIHB, out bool EIMJDNFDDAH)
	{
		JBMPKFAJIHB = default(bool);
		EIMJDNFDDAH = default(bool);
	}

	public void UpdateAnim(GJCFANLGPJN DBJBCFOHNLG, byte MDJKOCLLCHC)
	{
	}

	public void ForceUpdateAnim()
	{
	}

	private void ECHOJKKJIAI(GJCFANLGPJN DBJBCFOHNLG, byte MDJKOCLLCHC, bool MFEKPFKOMIK)
	{
	}

	protected override void BDLAEMHDEFI()
	{
	}

	protected override void DNNCLHHJIAP(ResourceID LIKPJDHGPFG)
	{
	}

	private void GCGGDFPMLPA()
	{
	}

	public void ClearShowHideCallback()
	{
	}

	private void KAIKMFKBKKA()
	{
	}

	public void PlayDefaultIdle()
	{
	}

	public void PlayShowAnim(Action CEHELPAIELA)
	{
	}

	public void PlayHideAnim(Action CEHELPAIELA)
	{
	}

	private void IAOHPOGLHJI(AnimationClip KGAAKHKEJLB, ResourceID DHJMMGHNCKJ, Action CEHELPAIELA, float OBNPLABHICH)
	{
	}

	public void OnShowHideImmediately(bool EOGOGFLCEHL)
	{
	}

	private IEnumerator HMDKPLPHJFG(float OBNPLABHICH)
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_FCDDABEFLJG(bool P0, out bool P1, out bool P2)
	{
		P1 = default(bool);
		P2 = default(bool);
	}

	public void _003C_003EiFixBaseProxy_BDLAEMHDEFI()
	{
	}

	public void _003C_003EiFixBaseProxy_DNNCLHHJIAP(ResourceID P0)
	{
	}
}
