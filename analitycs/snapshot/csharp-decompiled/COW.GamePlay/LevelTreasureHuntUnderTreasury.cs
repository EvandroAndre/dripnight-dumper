using System.Collections.Generic;
using GCommon;
using UnityEngine;
using message;

namespace COW.GamePlay;

public class LevelTreasureHuntUnderTreasury : BaseLevelObject
{
	public Transform m_ModelTrans;

	public Transform m_ColliderTrans;

	public Transform m_CenterTrans;

	public string m_ButtonResName;

	public Transform m_ButtonTrans;

	public string m_FrontDoorResName_A;

	public string m_FrontDoorResName_B;

	public string m_FrontDoorBreakResName;

	public Transform m_FrontDoorTrans;

	public Transform m_FrontDoorTrans_1;

	public string m_BackDoorResName;

	public Transform m_BackDoorTrans;

	public string m_TreasuryResName;

	public Transform m_TreasuryTrans;

	private float AACBGABLEKI;

	private bool HGCMCPMJPFI;

	private LBCJHDBJBJB MAOHIOEAMEA;

	private FBDBINGCMID JEOKPGACJHK;

	private readonly Dictionary<ResourceID, uint> EGJOIDNJECH;

	private readonly Dictionary<ResourceID, GameObject> PPGONADBMGE;

	private EntityVisualEffectManager EINPMFNJINA;

	private TreasureHuntButtonEffectView DHCPCGHPHNO;

	private Collider EAGBALDJNCK;

	private GameObject ANGCEIEILAB;

	private Animator NOICLGPMAAJ;

	private TreasurehuntUnderTreasuryEffectView PGPPEJGJGIN;

	private TreasureHuntFrontDoorEffectView MMNAFNCBAHM;

	private bool DFDEHPOCJCO;

	private ETreasureHuntMapIconState BJJBHHPMMIK;

	private uint ADEPIDAOAEM;

	private uint CLFLBFPKIIG;

	private bool MJMONCKNFPO;

	private uint LMBMEPIPKBG;

	private uint NMDMGCFJIKL;

	public bool GNCFHMOMOKP
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public ETreasureHuntMapIconState NBNAEBCMIEH
	{
		get
		{
			return ETreasureHuntMapIconState.None;
		}
		set
		{
		}
	}

	public LBCJHDBJBJB KFIKKKKOLNA => LBCJHDBJBJB.ETreasureHuntUnderTreasury_Closed;

	public FBDBINGCMID CNEHHKMHNHH => FBDBINGCMID.ETreasureHuntMapStateType_None;

	private EntityVisualEffectManager GOKDPINCDCJ()
	{
		return null;
	}

	protected override string GetObjectTag()
	{
		return null;
	}

	protected override void OnStart()
	{
	}

	protected override void OnUserDefineReplicationInfo()
	{
	}

	protected override int GetMaxRepDataCount()
	{
		return 0;
	}

	private void LGKMMLFIEHI(uint LALADOJHOBE, uint GCJPAAPKMMA)
	{
	}

	public override bool Recycle()
	{
		return false;
	}

	private void OECHPGECOKF()
	{
	}

	public override void OnRecycle()
	{
	}

	protected override void OnOnDestroy()
	{
	}

	public override void DoAction(object[] DJAPBCKDFKA)
	{
	}

	public override void SyncAction(object[] DJAPBCKDFKA)
	{
	}

	protected override void OnUpdateVisibleStateByStreamer(Vector3 MHAAFMCMHAC, Vector3 PAFBAHJAAGC)
	{
	}

	protected override void FLFHMOGHICH(bool GMLCCOIKJGD)
	{
	}

	public void UpdateMapState(FBDBINGCMID KAEBMCCOBIG, bool KMFDPOHNHED)
	{
	}

	public void ChangeMapIconState(ETreasureHuntMapIconState DMBNAOLEBEF)
	{
	}

	private void OCHDAAKJPDJ()
	{
	}

	private void PBBHKODBELH(uint JDHNCLHNJIP, ResourceID JMIMKLAELHE, GameObject KGJNMPHDKAB)
	{
	}

	private void JINPEEBDMKB(uint JDHNCLHNJIP, ResourceID JMIMKLAELHE, GameObject KGJNMPHDKAB)
	{
	}

	private void DHMEHDPDBMG(uint JDHNCLHNJIP, ResourceID JMIMKLAELHE, GameObject KGJNMPHDKAB)
	{
	}

	private void HOMJJOAHBCG(uint KAELLNBLHFE)
	{
	}

	private void FFIECOGKIEF(uint JDHNCLHNJIP, ResourceID JMIMKLAELHE, GameObject KGJNMPHDKAB)
	{
	}

	private void KEGNDCCKFAM()
	{
	}

	private void FDFNOJBFLGD()
	{
	}

	private void MGJIGDGGCCH()
	{
	}

	private void KJGHACFBOEK(uint JDHNCLHNJIP, ResourceID JMIMKLAELHE, GameObject KGJNMPHDKAB)
	{
	}

	private void FIBECNIKHHO()
	{
	}

	public void ForceTryShowModel()
	{
	}

	public void ResetNeedSyncModel()
	{
	}

	private void PKCKHPDOHMH()
	{
	}

	private void EGNOKIJDCHC()
	{
	}

	public void RefreshTreasuryVisible(bool EOGOGFLCEHL)
	{
	}

	private void PBKFNKAMMPD(object[] JCONDDPFBKK)
	{
	}

	private void OOAPJOIDAAM(ResourceID GGMIDNEJGNO, Transform GJDLFMIFHMG, ManagedVisualInstanceHolder.OnManagedInstanceAttached CEHELPAIELA = null)
	{
	}

	private void FAMONLJBCEJ(ResourceID GGMIDNEJGNO)
	{
	}

	private void MALBKGNHOGA()
	{
	}

	private ResourceID KPIIDGHKEDN(string PEHJODPGACF)
	{
		return default(ResourceID);
	}

	private void KIFAKBGPHPG()
	{
	}

	private void MLMJIGFOBOD(ResourceID GGMIDNEJGNO)
	{
	}

	private void BHOOIFBNHPC(ResourceID GGMIDNEJGNO)
	{
	}

	private void POMOPCMLGKP()
	{
	}

	public bool CheckOpenDoorTrigger()
	{
		return false;
	}

	public void SetTriggerInfo(Collider BKLOFDMOMEF)
	{
	}

	public void ReSetTriggerInfo()
	{
	}

	private void ALEHBFCHHGO()
	{
	}

	private Transform PNAMBKPBJIC()
	{
		return null;
	}

	private ResourceID CLOCGLDELGK()
	{
		return default(ResourceID);
	}

	private ResourceID OOLKKBAMIJI()
	{
		return default(ResourceID);
	}

	public ResourceID GetDigAnimResId()
	{
		return default(ResourceID);
	}

	private void DCBKFKBIPAC()
	{
	}

	private void GJFDFBOFFJC()
	{
	}

	private void GLACPFJIKMI()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnStart()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUserDefineReplicationInfo()
	{
	}

	public int _003C_003EiFixBaseProxy_GetMaxRepDataCount()
	{
		return 0;
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

	public void _003C_003EiFixBaseProxy_DoAction(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_SyncAction(object[] P0)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUpdateVisibleStateByStreamer(Vector3 P0, Vector3 P1)
	{
	}

	public void _003C_003EiFixBaseProxy_FLFHMOGHICH(bool P0)
	{
	}
}
