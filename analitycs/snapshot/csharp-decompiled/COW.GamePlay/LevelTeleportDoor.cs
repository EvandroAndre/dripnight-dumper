using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW.GamePlay;

public class LevelTeleportDoor : BaseLevelObject
{
	private enum ANLJIOCDCCJ
	{
		NONE,
		Acite_Show,
		Active_Hide,
		Streamer_Show,
		Streamer_Hide
	}

	public enum FHHGDLPCCJE
	{
		EModelEffect,
		ELineEffect,
		EStartEffect
	}

	public HCBGDFOPAIJ TeleportDoorType;

	public FOEHKGKAPJK TeleportDoorStyle;

	public int GroupID;

	public bool ProvideBuff;

	public int BuffID;

	public Transform[] TeleportPoints;

	public float TeleportPointRadius;

	public string Region;

	public string MapGroup;

	public GameObject ArrowObj;

	public GameObject PairedEffect;

	public GameObject TeleportEffect;

	public Collider TeleportTrigger;

	private uint GEAJLLKCFLK;

	private uint OGALNMDAPEE;

	private TeleportDoorArrowController BCBKLOMJBBA;

	private Dictionary<uint, uint> LPAOHMNGGHJ;

	private EntityVisualEffectManager HJCIADKBDMF;

	private LevelTeleportDoor FOMIGEBBFAO;

	private BitArrayBoolean CKPOPNCOINH;

	private GameObject MNANJMHCIBB;

	private TeleportDoor OKOJBFIKDFA;

	private TeleportDoorProperty PEODGKEAENG;

	private UIModelMatch AKBEAPBHMGL;

	private bool CEPGAIDGMCD;

	private bool ENDKCLEEMMK;

	private uint DLKAEKHLIPP;

	private GameObject EFCKCJLLPBN;

	private GameObject JHAFBIJJEOK;

	private FEKBCHODFLE GELFGDBLHDE;

	private ResourceID DBLGNFIILFA;

	private bool _003CBPKNBBGNGHA_003Ek__BackingField;

	private bool NPDJJFFCJOF;

	private ANLJIOCDCCJ MAOHIOEAMEA;

	protected bool NJMIOHPAJAP;

	public uint m_DestinationLevelObjID;

	private GameObject LHHOKDCGNOE;

	private BitArrayBoolean EAAJHDMKDPL => null;

	private MCDLKHAOJJG CMKLCCIEJCO => null;

	public bool AOLNOJIJKJJ
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool DHAJCMAGIDM => false;

	public EntityVisualEffectManager GetVisualEffectManager()
	{
		return null;
	}

	public bool IsVisible()
	{
		return false;
	}

	public void Init(ResourceID OCCLMDNGINA)
	{
	}

	public override bool Recycle()
	{
		return false;
	}

	public override void OnRecycle()
	{
	}

	protected override void OnOnDestroy()
	{
	}

	public Vector3 GetLineHookPosition()
	{
		return default(Vector3);
	}

	public bool CheckActionValid()
	{
		return false;
	}

	protected override string GetObjectTag()
	{
		return null;
	}

	private void KCMDAGBDLJB()
	{
	}

	protected override void OnStart()
	{
	}

	protected void AAAMPABHMBN()
	{
	}

	public override void OnUpdate(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	protected override void OnUserDefineReplicationInfo()
	{
	}

	protected override int GetMaxRepDataCount()
	{
		return 0;
	}

	private void BLPGMOBGEFO(bool OJEPOBEENEK, bool EIOKHLKJEEL)
	{
	}

	public bool IsActive()
	{
		return false;
	}

	public bool IsParachuteTeleportDoor()
	{
		return false;
	}

	public void OnLocalPlayerEnter()
	{
	}

	public void OnLocalPlayerExit()
	{
	}

	public void OnRemoved()
	{
	}

	public int GetCurHP()
	{
		return 0;
	}

	public void SetCurHP(int JHLNMNMLGPB)
	{
	}

	protected override void OnUpdateVisibleStateByStreamer(Vector3 MHAAFMCMHAC, Vector3 PAFBAHJAAGC)
	{
	}

	private void JMDFPLFCDKE(uint PLNDNBINKOA, ResourceID CICBIIJABAP, GameObject CLACOPMJHDI)
	{
	}

	private void PFLOGPAOFHO(uint PLNDNBINKOA, ResourceID CICBIIJABAP, GameObject CLACOPMJHDI)
	{
	}

	private void AEBCAMPMDFO(uint PLNDNBINKOA, ResourceID CICBIIJABAP, GameObject CLACOPMJHDI)
	{
	}

	private void FMKIDEAAMLE(ANLJIOCDCCJ CBCAJJJCKLH)
	{
	}

	private void KNBIJNKGKBC(ANLJIOCDCCJ CBCAJJJCKLH)
	{
	}

	public void CancelOrDetachEntityVisualEffect(FHHGDLPCCJE BIIDIBMHMPJ)
	{
	}

	private void LMFOGLAEDGK()
	{
	}

	private void KKEAKCBBECB(ANLJIOCDCCJ CBCAJJJCKLH)
	{
	}

	private void IABLAKFABMH()
	{
	}

	private void KEECCIHMINB(uint GGAOIPIHOBP, bool BBPCHCNOECP, Object HACIJIFIDKM)
	{
	}

	public void ShowTeleportEffect()
	{
	}

	private void PHPIAEINBAG(uint GGAOIPIHOBP, bool BBPCHCNOECP, Object HACIJIFIDKM)
	{
	}

	public void InitByServer(uint HIDANNMJCDP, uint ABHFDDCCINN, bool MCPHCPENJHE)
	{
	}

	public void ShowWorkshopTeleportEffect()
	{
	}

	private ResourceID NOELEBABNDD()
	{
		return default(ResourceID);
	}

	private ResourceID KDGCIDJALPD()
	{
		return default(ResourceID);
	}

	private ResourceID JFMCEPHAHKB(FOEHKGKAPJK CCNBNLAPJFM)
	{
		return default(ResourceID);
	}

	public void BecomePair(uint KAONOMAMDCI)
	{
	}

	public virtual void BecomeAlone()
	{
	}

	public bool NeedDelayTransfer()
	{
		return false;
	}

	public void ClientRefreshPrepareTransferEffect(bool AEAPKEDNBGK)
	{
	}

	public void OnPrepareTrasferEffectStateSync(bool OJEPOBEENEK, bool EIOKHLKJEEL)
	{
	}

	public void PrepareTrasferEffectStateSync(bool AEAPKEDNBGK)
	{
	}

	public override bool CreateDynamicallyForUGC(string GDDEBLAFLLG)
	{
		return false;
	}

	private void EMGHDCALAGC()
	{
	}

	private void PLOOALPDEIK()
	{
	}

	public new bool _003C_003EiFixBaseProxy_Recycle()
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnRecycle()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnOnDestroy()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnStart()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUpdate(float P0, float P1)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUserDefineReplicationInfo()
	{
	}

	public int _003C_003EiFixBaseProxy_GetMaxRepDataCount()
	{
		return 0;
	}

	public new void _003C_003EiFixBaseProxy_OnUpdateVisibleStateByStreamer(Vector3 P0, Vector3 P1)
	{
	}

	public bool _003C_003EiFixBaseProxy_CreateDynamicallyForUGC(string P0)
	{
		return false;
	}
}
