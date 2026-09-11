using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using message;

namespace COW.GamePlay;

public class LevelObjectFireDragon : BaseLevelObject
{
	public enum FJNKDDHJMNE
	{
		Create,
		Use
	}

	private sealed class NBALKONMGBF : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int CBPPJACCGOH;

		private object MHDKFGLHFKH;

		public LevelObjectFireDragon KOKNHFGCGLN;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public NBALKONMGBF(int CBPPJACCGOH)
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

	private BoxCollider IMBNDDJPNJF;

	private bool AEDFAGEHAON;

	private bool JAEKECHPNMN;

	private bool DPBNHAPPKNJ;

	public Transform VFXRoot;

	public float FireBallPlayDelayTime;

	public float RecycleDelayTime;

	public string FireBallResouceID;

	private EntityVisualEffectManager DMCNKFEJKIF;

	private uint LBAALABBCOP;

	private Animation CEJIIGMFAMP;

	private Coroutine CFDHIBEKAFJ;

	protected override string GetObjectTag()
	{
		return null;
	}

	protected override void OnAwake()
	{
	}

	public void OnCreate()
	{
	}

	public override void DoAction(object[] DJAPBCKDFKA)
	{
	}

	public override void SyncAction(object[] DJAPBCKDFKA)
	{
	}

	public override bool Recycle()
	{
		return false;
	}

	public override void OnRecycle()
	{
	}

	public void OnLocalPlayerEnter()
	{
	}

	private void OCODKPHJCPH()
	{
	}

	private void OLBOPJBAELJ(PHIBHDKIAMF NBLHNPAHGNA)
	{
	}

	private void LNHBEAFEIAN(ELDKECKEMBD NBLHNPAHGNA)
	{
	}

	protected override void OnModelShowed()
	{
	}

	private bool NEJHKDBFODL()
	{
		return false;
	}

	private void JMBIJGENMOE()
	{
	}

	private void OEKMMDNOJIP(uint JDHNCLHNJIP, ResourceID JMIMKLAELHE, GameObject KGJNMPHDKAB)
	{
	}

	private IEnumerator NAHPHOLBINI()
	{
		return null;
	}

	private void ENCFHIMEAEG()
	{
	}

	private void GIGBMLOOADL()
	{
	}

	public void _003C_003EiFixBaseProxy_OnAwake()
	{
	}

	public void _003C_003EiFixBaseProxy_DoAction(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_SyncAction(object[] P0)
	{
	}

	public new bool _003C_003EiFixBaseProxy_Recycle()
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnRecycle()
	{
	}

	public void _003C_003EiFixBaseProxy_OnModelShowed()
	{
	}
}
