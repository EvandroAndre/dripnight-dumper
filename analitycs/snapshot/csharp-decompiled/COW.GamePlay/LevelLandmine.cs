using System;
using System.Collections;
using System.Collections.Generic;
using COW.GamePlay.UGCRuntime;
using GCommon;
using UnityEngine;

namespace COW.GamePlay;

internal class LevelLandmine : BaseLevelObject
{
	private sealed class IBPPGAFIJPF
	{
		public string DGDDJLEOPBL;

		public LevelLandmine KOKNHFGCGLN;

		internal void EJOGDAJLBDK(uint GGAOIPIHOBP, bool BBPCHCNOECP, UnityEngine.Object HACIJIFIDKM)
		{
		}
	}

	private sealed class OHOEJKDNLLA
	{
		public string DGDDJLEOPBL;

		public LevelLandmine KOKNHFGCGLN;

		internal void CFILEEFBFOA(uint GGAOIPIHOBP, bool BBPCHCNOECP, UnityEngine.Object HACIJIFIDKM)
		{
		}
	}

	private sealed class CDPHHJACMCG : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int CBPPJACCGOH;

		private object MHDKFGLHFKH;

		public LevelLandmine KOKNHFGCGLN;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public CDPHHJACMCG(int CBPPJACCGOH)
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

	public Landmine m_Landmine;

	public ResourceID m_SetStayEffectID;

	public GameObject m_SetStayEffect;

	public GameObject m_EffectNode;

	public GameObject m_StartEffect;

	public GameObject m_WarningEffect;

	public SphereCollider m_LandmineTrigger;

	private CJHNFGDBOGD FMELHKINBKG;

	private GMECHKEDOJP ADECKCPNEBN;

	private float DACNJCDGDNB;

	private int FJNEDFNLELE;

	private bool BJPDGKAHHJK;

	private bool DACAGNMPNJL;

	private GameObject ECFPNAIMDME;

	private uint AMHIIHPDEAH;

	private Player DHKEAPLKHKA;

	private BHGGAEEHJCO MGLHKMDKAGI;

	private float LGDGNLBEPPK;

	private FEKBCHODFLE GELFGDBLHDE;

	private uint PMCJLONCKDM;

	private ParticleSystem.MinMaxGradient CNKKGKECMPC;

	private ParticleSystem.MinMaxGradient EIJBHPPCOIN;

	private ResourceID IIGGCJLOBKF;

	private ResourceID FDCHEJPLEBI;

	protected override string GetObjectTag()
	{
		return null;
	}

	protected override int GetMaxRepDataCount()
	{
		return 0;
	}

	public float GetExplodeRange()
	{
		return 0f;
	}

	public void Init(HENEHAGJCLI DLOMCIHJJJG, uint OBMFMAKFDDL, uint KFMNLPAHBJA, ResourceID GGMIDNEJGNO, object[] DJAPBCKDFKA)
	{
	}

	private bool HOCJDBFGLLC(FDAEPHMIEPC.NHMNBDFPMJP CCNBNLAPJFM)
	{
		return false;
	}

	public Player GetOwner()
	{
		return null;
	}

	public BHGGAEEHJCO GetOwnerID()
	{
		return default(BHGGAEEHJCO);
	}

	public override void SyncAction(object[] DJAPBCKDFKA)
	{
	}

	private void EDMPAFGFDEB()
	{
	}

	private void LJMLBKJOPKF()
	{
	}

	public override bool Recycle()
	{
		return false;
	}

	public override void OnRecycle()
	{
	}

	private void NLGMAHCENHJ()
	{
	}

	private void FBDNBDAGOKN()
	{
	}

	private bool BEPNCBGEEBD()
	{
		return false;
	}

	private bool AODKLFPKNCC()
	{
		return false;
	}

	private void LLOADEFMONN()
	{
	}

	private void JMDFPLFCDKE(uint PLNDNBINKOA, ResourceID CICBIIJABAP, GameObject CLACOPMJHDI)
	{
	}

	private IEnumerator EAEENEPGAJL()
	{
		return null;
	}

	private void DFECDKNHAAP(bool PLNBKKNHAKO)
	{
	}

	private void EKFBGGLLHCP()
	{
	}

	public void OnPlayerEnterTrigger(BHGGAEEHJCO FPIDBLAMNLN)
	{
	}

	public void OnPlayerExitTrigger(BHGGAEEHJCO FPIDBLAMNLN)
	{
	}

	public void EnterTrigger(bool AKKFKCKNEOC, bool PEOCPGCOLFJ, bool MAEBJILNLGP)
	{
	}

	public void ExitTrigger(bool AKKFKCKNEOC, bool PEOCPGCOLFJ, bool MAEBJILNLGP)
	{
	}

	private void AAAMPABHMBN()
	{
	}

	private void DMBLGMCDGFF(object[] DJAPBCKDFKA)
	{
	}

	private void HIDKLCEEGGE(uint KFMNLPAHBJA)
	{
	}

	public override void OnSyncUGCEntityProperty(long OGDNBBJKNFD, UGCSimpleValue EIOKHLKJEEL)
	{
	}

	protected void PAMFCIBOEII()
	{
	}

	public override void RecycleForInGameReload()
	{
	}

	private void AJOKCPAIHDM()
	{
	}

	public int _003C_003EiFixBaseProxy_GetMaxRepDataCount()
	{
		return 0;
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

	public void _003C_003EiFixBaseProxy_OnSyncUGCEntityProperty(long P0, UGCSimpleValue P1)
	{
	}

	public void _003C_003EiFixBaseProxy_RecycleForInGameReload()
	{
	}
}
