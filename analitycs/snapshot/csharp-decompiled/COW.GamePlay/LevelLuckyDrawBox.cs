using System;
using System.Collections;
using System.Collections.Generic;
using COW.PotentiallyVisible;
using GCommon;
using UnityEngine;
using message;

namespace COW.GamePlay;

public class LevelLuckyDrawBox : BaseLevelObject, IPVSItemActive
{
	public enum LJPEBMIJKMK
	{
		ADD,
		REFRESH,
		LEVELUP
	}

	private sealed class AIFBELELKHL : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int CBPPJACCGOH;

		private object MHDKFGLHFKH;

		public Animator LBFLOFBKDJG;

		public AnimationClip KGAAKHKEJLB;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public AIFBELELKHL(int CBPPJACCGOH)
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

	private sealed class JAEDNKJOIML : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int CBPPJACCGOH;

		private object MHDKFGLHFKH;

		public Animator LBFLOFBKDJG;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public JAEDNKJOIML(int CBPPJACCGOH)
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

	private Transform CGPPMHBNDHO;

	public Collider Trigger;

	public GameObject Model;

	public GameObject UsingEffect;

	public Transform LevelEffect;

	private GameObject JGNDEMDKEEO;

	private bool APJLCDCIKDN;

	private uint MCIMDLMNMKB;

	private ResourceID IGCLFPFHHPJ;

	private ResourceID CILHLMEKGOL;

	private EntityVisualEffectManager HJCIADKBDMF;

	private uint IECIKMFBLLO;

	private uint MAOHIOEAMEA;

	protected bool IMIDFBOODAH;

	protected bool ANHEAALMPKK;

	protected List<Renderer> LMKKJDJNCEA;

	protected List<ParticleSystem> PMJLAKMDJDF;

	private uint DMCKHPHJAED;

	private bool MNNKLJBCCHG;

	private bool GOIFNPJJMOH;

	private List<DOCPOKGMOGB> FIOCLALGMDK;

	private uint FFNBLEEOPIM;

	private bool _003CGLJNEBFHDNN_003Ek__BackingField;

	private int CEIBEABIJOH;

	private Coroutine GJOFGDLLOHG;

	private BHGGAEEHJCO MBPMMLMJOHL;

	public bool MOOMNCNADLN => false;

	public bool FPBLCDNLMKK
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	protected override Transform DJDHMIGFFCE => null;

	public List<DOCPOKGMOGB> GetCurrentBoxItems()
	{
		return null;
	}

	public uint GetCurrentLevel()
	{
		return 0u;
	}

	public uint GetBuyCount()
	{
		return 0u;
	}

	public int GetNextLevelUpTimeMs()
	{
		return 0;
	}

	protected override string GetObjectTag()
	{
		return null;
	}

	protected override void OnAwake()
	{
	}

	protected override void FLFHMOGHICH(bool GMLCCOIKJGD)
	{
	}

	protected override void OnOnDestroy()
	{
	}

	public override void OnRecycle()
	{
	}

	public override bool Recycle()
	{
		return false;
	}

	protected override void OnUserDefineReplicationInfo()
	{
	}

	private void BLLOOKFFHGM(uint GNBOOELAHNP, uint LAHMCKAGGCO)
	{
	}

	public bool IsUseByOtherPlayer()
	{
		return false;
	}

	private void OPOCBEBGIPD()
	{
	}

	protected override int GetMaxRepDataCount()
	{
		return 0;
	}

	private void GBGHIIOIDBE(byte OJEPOBEENEK, byte EIOKHLKJEEL)
	{
	}

	private void GHIDOPPJEFA(uint OJEPOBEENEK, uint EIOKHLKJEEL)
	{
	}

	private void ENGMAOBENDH(uint GGAOIPIHOBP, bool CPBHKACJHLG, UnityEngine.Object HACIJIFIDKM)
	{
	}

	private void JPJBBOKDMFN(bool BBEKMHCPMNM)
	{
	}

	protected override void GHHGKFJIEFC()
	{
	}

	protected override void OPDFOLOPHBB()
	{
	}

	private void EILJMAEHEEA(bool BBEKMHCPMNM)
	{
	}

	private IEnumerator IEIIJHLOCGG(Animator LBFLOFBKDJG)
	{
		return null;
	}

	private IEnumerator OBLBKOLDOCM(Animator LBFLOFBKDJG, AnimationClip KGAAKHKEJLB)
	{
		return null;
	}

	protected override void OnModelShowed()
	{
	}

	protected override void JHEFLJNCBPJ()
	{
	}

	private void GGPJKKLENGJ(bool EOGOGFLCEHL)
	{
	}

	protected void GBDDGCMFHPP()
	{
	}

	protected void EEDDNGGLHFN()
	{
	}

	public void SetRenderersActive(bool CJGJFCPPCEJ)
	{
	}

	private void HPEDDOIOEND(bool CJGJFCPPCEJ)
	{
	}

	public override void DoAction(object[] DJAPBCKDFKA)
	{
	}

	public override void SyncAction(object[] DJAPBCKDFKA)
	{
	}

	private void LEGPLMKJJJG(List<NNHOIFJPLHB> NIDOBBCHBIK)
	{
	}

	private void GILMOPHDIEE()
	{
	}

	public bool IsSomeoneUsing()
	{
		return false;
	}

	public void OnLocalPlayerEnter()
	{
	}

	public void OnLocalPlayerExit()
	{
	}

	public void StopUse()
	{
	}

	private void FIJDOLFAOFD()
	{
	}

	private void EBEOBNBLMAK()
	{
	}

	private void OLJBJAAANDJ()
	{
	}

	public Transform _003C_003EiFixBaseProxy_ACGOOENDOPL()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnAwake()
	{
	}

	public void _003C_003EiFixBaseProxy_FLFHMOGHICH(bool P0)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnOnDestroy()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnRecycle()
	{
	}

	public new bool _003C_003EiFixBaseProxy_Recycle()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUserDefineReplicationInfo()
	{
	}

	public int _003C_003EiFixBaseProxy_GetMaxRepDataCount()
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_GHHGKFJIEFC()
	{
	}

	public void _003C_003EiFixBaseProxy_OPDFOLOPHBB()
	{
	}

	public void _003C_003EiFixBaseProxy_OnModelShowed()
	{
	}

	public void _003C_003EiFixBaseProxy_JHEFLJNCBPJ()
	{
	}

	public void _003C_003EiFixBaseProxy_DoAction(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_SyncAction(object[] P0)
	{
	}
}
