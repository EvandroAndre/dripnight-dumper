using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW.GamePlay;

public class LevelRevivePoint : BaseLevelObject, IQuickChatLevelObject
{
	private sealed class JOFHMAGKCPD
	{
		public VisualInstanceHolder PEHCEJKGBBE;

		internal void EHKAIEMOLAN()
		{
		}
	}

	private sealed class FEAJLHGOGLC : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int CBPPJACCGOH;

		private object MHDKFGLHFKH;

		public LevelRevivePoint KOKNHFGCGLN;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public FEAJLHGOGLC(int CBPPJACCGOH)
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

	public GameObject m_Collider;

	public GameObject ControlZoneFenceTrans;

	private GameObject HGIPFJMALPB;

	public Collider m_ReviveInteractCollider;

	public GameObject m_LaserTrans;

	public Color[] ActivatedStateColorArray;

	public Color[] SoloActivatedStateColorArray;

	public Color[] CapturedStateColorArray;

	public Color[] CoolDownStateColorArray;

	public GameObject GroundRevivePos;

	public bool IsSoloRevivePoint;

	private byte AFIEIBCBJNB;

	private bool NPDJJFFCJOF;

	private Color[] JONGAPMMGCF;

	public GameObject VFXPillarTrans;

	public GameObject SheleterParent;

	private MFLHGFJAOMA MBGOAOBNPNJ;

	private CMHCKKJBOFL MAOHIOEAMEA;

	private uint KHJDKNJALEK;

	private GameObject AOCKGCFKFJE;

	private int CFJAOEKBFAP;

	private bool BPFIACNGBLK;

	public bool m_IsReadyToDestroy;

	private Dictionary<BHGGAEEHJCO, byte> BIFFCIJDBIC;

	private VisualInstanceHolder FDMPDDAHKHM;

	private VisualInstanceHolder IMOHJNNDKFB;

	private VisualInstanceHolder GHDHCJAAFJI;

	private VisualInstanceHolder JDLENMJAKLN;

	private VisualInstanceHolder AAHIIIFCINM;

	private VisualInstanceHolder EBBHMMMMDFJ;

	private VisualInstanceHolder BPEIBJDLHKN;

	private VisualInstanceHolder FMDLLOOKFEF;

	private VisualInstanceHolder AMDCPIJGMDD;

	private VisualInstanceHolder ABKBJNIPFFC;

	private bool AEEPOBOFKMM;

	private bool EILBPCIPBMF;

	private HashSet<LevelSummonedCoffin> DOLMJGLJOGO;

	private FadeEffect OAFIFMMCEIN;

	public CMHCKKJBOFL KFIKKKKOLNA => CMHCKKJBOFL.RevivePointState_None;

	public int NNLLOEIBBKC => 0;

	public bool JGCBDNJECIP => false;

	protected override void OnAwake()
	{
	}

	public ResourceID GetActivityIconRes()
	{
		return default(ResourceID);
	}

	public bool UseActivityIconResWhenSolo()
	{
		return false;
	}

	private IEnumerator PNAFHILBOOO()
	{
		return null;
	}

	private void NIKLDFOLOJD()
	{
	}

	private void OECHPGECOKF()
	{
	}

	protected override void OnOnDestroy()
	{
	}

	private void CFJLOEMDLEL()
	{
	}

	public void ChangeModelRes(MFLHGFJAOMA AOFCDPKJKJO)
	{
	}

	protected override string GetObjectTag()
	{
		return null;
	}

	protected override int GetMaxRepDataCount()
	{
		return 0;
	}

	protected override void OnUserDefineReplicationInfo()
	{
	}

	protected override void OnPRIInitialized()
	{
	}

	private void KNIEMAPPJJL(bool CMMHKOOLJCF = false)
	{
	}

	private void DHHFPPKDJFA()
	{
	}

	protected virtual void OCHDAAKJPDJ(byte OJEPOBEENEK, byte EIOKHLKJEEL)
	{
	}

	private void KCPEAJOIFBG(bool EOGOGFLCEHL)
	{
	}

	protected virtual void OFCDBGDDLKO(byte OJEPOBEENEK, byte EIOKHLKJEEL)
	{
	}

	protected virtual void KFLNJGHCMOA(int OJEPOBEENEK, int EIOKHLKJEEL)
	{
	}

	public bool CanCapture()
	{
		return false;
	}

	private bool AOBKDIMDNAF()
	{
		return false;
	}

	private bool HMLJKAPIOIA()
	{
		return false;
	}

	private bool FOEMIMHKKIF()
	{
		return false;
	}

	private bool NNDHNPNOCPB(Collider GLJGHEAPBOF)
	{
		return false;
	}

	public void OnTriggerEnter(Collider GLJGHEAPBOF)
	{
	}

	public void OnTriggerExit(Collider GLJGHEAPBOF)
	{
	}

	private void OIBNKJCABBL()
	{
	}

	private void MOFBOMKBAFG()
	{
	}

	protected override void OnUpdateVisibleStateByStreamer(Vector3 MHAAFMCMHAC, Vector3 PAFBAHJAAGC)
	{
	}

	private void JOCNADOHCLI(bool EOGOGFLCEHL)
	{
	}

	private void IKDPPJLOJCG(bool EOGOGFLCEHL)
	{
	}

	private void EOLEPOMCNIG(bool EOGOGFLCEHL)
	{
	}

	private void EBNGLMLCKNL(bool EOGOGFLCEHL)
	{
	}

	private void IIBAONDGFGA(bool EOGOGFLCEHL)
	{
	}

	private void LINKEEPELOH()
	{
	}

	private void LINKEEPELOH(Color[] OBNGFCLDENO)
	{
	}

	private void IJGNIKFJLFG(bool EOGOGFLCEHL)
	{
	}

	public override void OnRecycle()
	{
	}

	public override void OnReUse()
	{
	}

	public void TryApplyPOIMissionCompletedState()
	{
	}

	public override bool Recycle()
	{
		return false;
	}

	public void PrepareForDestroy()
	{
	}

	public bool IsMultiTeamInTrigger()
	{
		return false;
	}

	public bool IsInChargeTrigger()
	{
		return false;
	}

	public int TeammateCountInTrigger(BHGGAEEHJCO OBMFMAKFDDL)
	{
		return 0;
	}

	public void OnAddPlayer(uint OBMFMAKFDDL)
	{
	}

	public void OnRemovePlayer(uint OBMFMAKFDDL)
	{
	}

	public void OnSyncTriggerPlayers(List<uint> EGCEDNNLAIE)
	{
	}

	private void HMLMEHOMDEK(object[] JCONDDPFBKK)
	{
	}

	private void PLOJJEKNBPO(object[] JCONDDPFBKK)
	{
	}

	private bool ABNAOELKKAI(ulong DNIIJMENOJH)
	{
		return false;
	}

	private void ALAIAGIMBFA(ulong OJEPOBEENEK, ulong EIOKHLKJEEL)
	{
	}

	private void GOIJNDBKLNA(ulong EIOKHLKJEEL)
	{
	}

	public void ReplaceShelterModel()
	{
	}

	public void RegisterSummonedCoffin(LevelSummonedCoffin EPJFJDMJEOF)
	{
	}

	public void UnRegisterSummonedCoffin(LevelSummonedCoffin EPJFJDMJEOF)
	{
	}

	private void NOMGBCNFOOJ(int OJEPOBEENEK, int EIOKHLKJEEL)
	{
	}

	private void ONGFAAKJAKP(bool OJEPOBEENEK, bool EIOKHLKJEEL)
	{
	}

	public float GetCoffinRatio()
	{
		return 0f;
	}

	private void FFFANKPMLKP(CMHCKKJBOFL CBCAJJJCKLH)
	{
	}

	private void OHOFHEBOJHL(CMHCKKJBOFL CBCAJJJCKLH, float GOMNGFFGLKD)
	{
	}

	private void NKJIHMMPNIE(GameObject CLACOPMJHDI)
	{
	}

	private void CCALPPHOEHP(GameObject CLACOPMJHDI)
	{
	}

	private void BGHCOJKOKHB(GameObject CLACOPMJHDI)
	{
	}

	public override void RecycleForInGameReload()
	{
	}

	private void EMLKBIIJOHH(GameObject CLACOPMJHDI)
	{
	}

	public void _003C_003EiFixBaseProxy_OnAwake()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnOnDestroy()
	{
	}

	public int _003C_003EiFixBaseProxy_GetMaxRepDataCount()
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_OnUserDefineReplicationInfo()
	{
	}

	public void _003C_003EiFixBaseProxy_OnPRIInitialized()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUpdateVisibleStateByStreamer(Vector3 P0, Vector3 P1)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnRecycle()
	{
	}

	public void _003C_003EiFixBaseProxy_OnReUse()
	{
	}

	public new bool _003C_003EiFixBaseProxy_Recycle()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_RecycleForInGameReload()
	{
	}
}
