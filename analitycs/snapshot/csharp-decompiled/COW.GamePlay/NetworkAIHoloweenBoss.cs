using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using message;

namespace COW.GamePlay;

internal class NetworkAIHoloweenBoss : NetworkAIPawn
{
	private sealed class MAEBLNNDOPP : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int CBPPJACCGOH;

		private object MHDKFGLHFKH;

		public NetworkAIHoloweenBoss KOKNHFGCGLN;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public MAEBLNNDOPP(int CBPPJACCGOH)
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

	public const int HALLOWEENBOSSATTACKRANGE = 80;

	private const float PFCIKEPJPEF = 1f;

	private GameObject FELADDGKMFP;

	private float KHIJOMMGCIL;

	private bool BAPNICNNLCO;

	private List<HitDetectColliderHelper> NPNPPFBODOC;

	private HalloweenBossColliderHelper OGBCMNFHCEM;

	private List<Collider> HLNJOJBKKMI;

	private Dictionary<BHGGAEEHJCO, Player> EKDEMEIOCEB;

	private const uint NKJOPCJDKBJ = 20u;

	private float FFENLOOFGGB;

	private bool KOLCKAAEECM;

	protected override void OnAwake()
	{
	}

	protected override void OnStart()
	{
	}

	protected override void OnOnDestroy()
	{
	}

	protected override void FNHECJEMNCB()
	{
	}

	public override void ReuseInit(Transform MLBAMPFOCGP, DNFBGBPINLE GDEKAGHDGKC)
	{
	}

	public override void TakeDamage(int PMNNBDDKCCE, BHGGAEEHJCO FNOOENEHBJP, LOAEBBHPMEK AOJANNHGCEA, LLEDPGIGCMO CCFHNBDPCOE = LLEDPGIGCMO.None, int HPPACPHIPCP = -1, Vector3 BAAJEMEJACH = default(Vector3), Vector3 KHNFEFFKMEB = default(Vector3), List<float> LFLPGCMLPFM = null, uint FKDEIFDNMJD = 0u, GLLLEDKLLDA PMMCGNJHOOA = null)
	{
	}

	private void NCDMKEHJHAN(GEvent JCONDDPFBKK)
	{
	}

	protected override void OnDead()
	{
	}

	protected override void OnUpdateVisibleStateByStreamer(Vector3 MHAAFMCMHAC, Vector3 PAFBAHJAAGC)
	{
	}

	public override void OnUpdate(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	private void LNMJFDLBGGD()
	{
	}

	private void EBFFOLPPNGE()
	{
	}

	private IEnumerator HHCMJELBPNN()
	{
		return null;
	}

	public override float GetRefPosHeight()
	{
		return 0f;
	}

	public override bool HudNameEnemyNeedWorldPos()
	{
		return false;
	}

	private void OnTriggerExit(Collider GLJGHEAPBOF)
	{
	}

	private void OnTriggerEnter(Collider GLJGHEAPBOF)
	{
	}

	private void DAGIPLOGOMM()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnAwake()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnStart()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnOnDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_FNHECJEMNCB()
	{
	}

	public void _003C_003EiFixBaseProxy_ReuseInit(Transform P0, DNFBGBPINLE P1)
	{
	}

	public void _003C_003EiFixBaseProxy_TakeDamage(int P0, BHGGAEEHJCO P1, LOAEBBHPMEK P2, LLEDPGIGCMO P3, int P4, Vector3 P5, Vector3 P6, List<float> P7, uint P8, GLLLEDKLLDA P9)
	{
	}

	public void _003C_003EiFixBaseProxy_OnDead()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUpdateVisibleStateByStreamer(Vector3 P0, Vector3 P1)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUpdate(float P0, float P1)
	{
	}

	public float _003C_003EiFixBaseProxy_GetRefPosHeight()
	{
		return 0f;
	}

	public bool _003C_003EiFixBaseProxy_HudNameEnemyNeedWorldPos()
	{
		return false;
	}
}
