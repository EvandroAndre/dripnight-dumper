using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using message;

namespace COW.GamePlay;

internal abstract class LevelMissileBase : BaseLevelObject, LPLNCIDKGLI
{
	protected class LJBAALIHDEE
	{
		public int BFIGJHLLIGB;

		public float DDKINBPHPNL;

		public uint CEBCGPCHIMH;

		public uint OLGIBOPIOKD;

		public Vector3 PHEOMEDPGED;

		public Quaternion GBHPAJHAAMF;

		public uint IMJNHIABGFB;

		public uint BKBFMLIIMGC;

		public Vector3 AALEAHDJAMC;

		public Quaternion DOGHPBHDLCJ;

		public Vector3 AAPGPMPKMBD;

		public float APGPEEMBFOI => 0f;

		public bool POMDGJDMPMG()
		{
			return false;
		}

		public Vector3 FHAGBNCJJGA(float GOMNGFFGLKD)
		{
			return default(Vector3);
		}

		public Quaternion DEIMCMOCMEM(float GOMNGFFGLKD)
		{
			return default(Quaternion);
		}
	}

	private sealed class BDBKPOJDCIN
	{
		public LevelMissileBase KOKNHFGCGLN;

		public string DGDDJLEOPBL;

		public Vector3 HDFILHFDBKB;

		public float MMBHKHJHBBF;

		internal void NFBDPBLDLHF(uint GGAOIPIHOBP, bool BBPCHCNOECP, UnityEngine.Object HACIJIFIDKM)
		{
		}
	}

	private sealed class CFAHGPCDBNM : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int CBPPJACCGOH;

		private object MHDKFGLHFKH;

		public LevelMissileBase KOKNHFGCGLN;

		public Vector3 HDFILHFDBKB;

		public bool LBJLBFLLDAH;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public CFAHGPCDBNM(int CBPPJACCGOH)
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

	private EIPAGKDKBPC _003CAHDJLMPLHPG_003Ek__BackingField;

	protected GOPFMCJEBOI BBPPCFHFPKJ;

	public BHGGAEEHJCO FirePlayerID;

	public bool FiredByLocalPlayer;

	private bool _003CJOPCJELNFDG_003Ek__BackingField;

	private FEKBCHODFLE GELFGDBLHDE;

	protected const byte JANGGEEHBCO = 128;

	protected LJBAALIHDEE LAPJPJICGJD;

	protected uint IAPBBEEDLCG;

	protected bool IGOPNCPBEEP;

	protected bool MJLFKHNHJHI;

	public const int TimeoutFrameCount = 200;

	private AttackableEntity _003CPGJCEEGMIHB_003Ek__BackingField;

	protected ResourceID DMJEAMEJNDG;

	protected bool OFEFBAEHBJJ;

	public EIPAGKDKBPC CMLJNBGPOAK
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public float BDNNLINKJCK => 0f;

	public bool OMIDPMGIMBK
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public AttackableEntity EJNNCIIIDMA
	{
		get
		{
			return null;
		}
		protected set
		{
		}
	}

	protected override string GetObjectTag()
	{
		return null;
	}

	protected void ANBILKJDMLE(AttackableEntity MJIFGJPGLAM)
	{
	}

	public virtual void Init(ResourceID GGMIDNEJGNO, EIPAGKDKBPC DJAPBCKDFKA)
	{
	}

	protected void JLFJAJPKOIF()
	{
	}

	public override void OnRecycle()
	{
	}

	public override bool Recycle()
	{
		return false;
	}

	public virtual void Fire(GOPFMCJEBOI KDJNEHDAAFL)
	{
	}

	public override void SyncAction(object[] DJAPBCKDFKA)
	{
	}

	protected virtual void CGBJAIMHNDK(OKMOKCHOHHO CBCAJJJCKLH, uint OJFBGFOOKEK)
	{
	}

	protected void HAGHLDKPBAP(OKMOKCHOHHO CBCAJJJCKLH)
	{
	}

	protected virtual void PJCMEMHNDND(AttackableEntity IMBILFMCIAJ, AttackableEntity PHGIDALCPPO)
	{
	}

	internal void AKHIIHGOPAA(OKMOKCHOHHO CBCAJJJCKLH, uint OJFBGFOOKEK, uint MICLJKJCFIE)
	{
	}

	public override void OnFixedUpdate(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	protected virtual void DEPANMFEFLL(bool DCAPIHJMMBL, GOPFMCJEBOI KDJNEHDAAFL)
	{
	}

	protected virtual void BILBBOKPHCP(bool DCAPIHJMMBL, float HOGHEFNINAE)
	{
	}

	protected virtual void HKKIDIFGFLM(float HOGHEFNINAE)
	{
	}

	protected virtual void BJANNJCGODE(float HOGHEFNINAE)
	{
	}

	protected virtual void GDCFONFOHDL(float HOGHEFNINAE)
	{
	}

	protected bool PHIEFLILNAI(bool KPDCILHJOBF, float HOGHEFNINAE = 0f, float IMKNJGHAHPI = 0f, float FJHPCEDFDEI = 0f, bool OGKEEKCIGEC = false)
	{
		return false;
	}

	public virtual void Explode(Vector3 HDFILHFDBKB, bool LBJLBFLLDAH)
	{
	}

	private IEnumerator LDDLJIJAOEE(Vector3 HDFILHFDBKB, bool LBJLBFLLDAH)
	{
		return null;
	}

	protected virtual void BENDFKJKGPP(Vector3 HDFILHFDBKB, bool LBJLBFLLDAH)
	{
	}

	protected virtual void IGKIMJJPBAM(Vector3 HDFILHFDBKB)
	{
	}

	protected virtual void HDMBENNJAAI()
	{
	}

	protected void INOFPKNHFAA(bool KGOHDEBHENF)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnRecycle()
	{
	}

	public new bool _003C_003EiFixBaseProxy_Recycle()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_SyncAction(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnFixedUpdate(float P0, float P1)
	{
	}
}
