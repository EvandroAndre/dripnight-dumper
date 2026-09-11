using System;
using UnityEngine;

namespace COW.GamePlay;

internal class FollowCamera : CameraControllerBase, COW.GamePlay.CALHLIPMGMD<UGCCameraConfigRepItem>
{
	protected enum NJHHBOALEDE
	{
		NORMAL,
		SNIPER,
		INROOM
	}

	public static readonly float C_OFFSET_RIGHT;

	public static readonly float C_OFFSET_RIGHT_PASSENGER;

	public static readonly float C_OFFSET_RIGHT_CAMERAMODE;

	public static readonly float C_OFFSET_UP;

	public static readonly float C_OFFSET_FOV;

	public static readonly float C_OFFSET_FOV_SKILLSHIELD;

	public static readonly float C_OFFSET_UP_PASSENGER;

	public static readonly float C_OFFSET_UP_CAMERAMODE;

	public static readonly float C_FOV_NORMAL;

	public static readonly float C_FOV_UGC_1P_MOD;

	public float RightOffset;

	public float UpOffset;

	public float BackOffset;

	public float FOVOffset;

	private static readonly float DIFHKIMAKJC;

	public static readonly float OFFSET_FOR_NORMAL;

	private static readonly float NOOPFEINFBD;

	private static readonly float IIJLDFIOCAN;

	private static readonly float AALFADEJKNI;

	private static readonly float NLKPHOACDPI;

	private static readonly float BPFJAOHCMFB;

	private static readonly float AGHOFHDCJBA;

	private static readonly float EIPHJADJKMD;

	private static readonly float DMPEEDCIBMN;

	private static readonly float KDGJANPGOCJ;

	private static readonly float JGANGKCBLJC;

	public static float OFFSET_FOR_STROP;

	public static readonly float C_OFFSET_UP_SKILLL_SHIELD;

	public static readonly float C_OFFSET_BACK_SKILLL_SHIELD;

	public static readonly float BackOffsetInRoom;

	public static readonly float BackOffsetCannon;

	public float RightOffsetInRoom;

	private static readonly float EONMLKELFDI;

	public float UpOffsetInCreep;

	public float UpOffsetSurf;

	public float UpOffsetCatapult;

	public float UpOffsetOnChair;

	public float UpOffsetOnSeesaw;

	public static readonly float UpOffsetCannon;

	public float m_RightOffset;

	public float m_UpOffset;

	private float LDBMFEKCKJN;

	protected float AFPGMLFMANE;

	public bool IsOnHead;

	public bool NeedUpdate;

	[NonSerialized]
	public float CameraCollisionOffsetRight;

	[NonSerialized]
	public float CameraCollisionOffsetBack;

	private float NEDHHLCNMLB;

	protected bool EHKEKOJDHJK;

	protected GMPGMPFNMFP PCMBDGJNBCB;

	private float DEIJIIJAPLF;

	private bool EPDFCJLCIIP;

	private bool NFAKEGKLIHG;

	private float BKNHMNPAEBI;

	protected NJHHBOALEDE BEJLKPEJHGI;

	protected NJHHBOALEDE KAHHMKMKDEE;

	private HelicopterCameraPassengerPara HBFGJCOAKLD;

	private HelicopterCameraParameter BDJPHBJELPI;

	protected Vector3 ODIJNMJKMOK;

	protected Vector3 CEHKGMOJBLI;

	private bool JBNCGNAHCCG;

	protected Vector3 KOPLIGMDFBA;

	protected Vector3 BLEOAJAOOKO;

	protected GMKPHFNMBOA GLLPGKJBPLD;

	private bool FCCKHCMDMOK;

	private float AFLHNLJIDIK;

	private float CHGGOHGBGPG;

	private float JKNFFNDGECA;

	private float BNOIIFFEOFE;

	private float EDJCLNKDFKG;

	private Quaternion OKCLIHEFIEK;

	private float EDPIPJBNLGG;

	private float OEMMPEKHEID;

	private bool BPNPHIJINMN;

	private float ICACHOHOHBE;

	private float EGBFNCMPJNA;

	private float BBKLALOBAFF;

	private Vector2 ANDPBFPFDDD;

	private AnimationCurve BCMLFHNGOAI;

	private bool KHMJBBGJAGD;

	private EJLMPAKOEKH NLCADAGGFGK;

	private OJGMOBAAGPA DBKONCICMFG;

	private float HAFILKIBGKF;

	private float BBBICPJHACL;

	private float NIOAMAPGOFE;

	private float DCIHIFBGCML;

	private float HJPGEKAMNEI;

	private float IHLAOODAPEK;

	private float EFBEKKACJMF;

	private float JGFFOLAEKMJ;

	private float IPPHCLNGMOC;

	private float MMLILLAMFCG;

	protected virtual float DLMBENJNCEA => 0f;

	public virtual float GEGDCOEKLPN => 0f;

	protected Player BIPDKDICFAC => null;

	public Vector3 NEKAMAEJCAK => default(Vector3);

	public bool LILAHDDPJMG => false;

	public bool IAGDGLGBCKG => false;

	public override Vector3 FNAMPFFAMBD => default(Vector3);

	public override Quaternion DEIEGHLADGP => default(Quaternion);

	private void Start()
	{
	}

	public void SetOffestRightAndBack()
	{
	}

	public void SetOffestFOV()
	{
	}

	public virtual float GetFovNormal()
	{
		return 0f;
	}

	private bool NHEAFOKMEBG()
	{
		return false;
	}

	private bool OFBHDFKGIKK(Player PGEGMKJKOKI)
	{
		return false;
	}

	private bool JCBGDDEIPDH(Player PGEGMKJKOKI)
	{
		return false;
	}

	public virtual float GetCapSuleOffsetZ()
	{
		return 0f;
	}

	private bool CGECKPKAEMJ(Player PGEGMKJKOKI, bool GHBDCCDFOJF)
	{
		return false;
	}

	protected virtual float BBHBLKMMLKK(Player PGEGMKJKOKI)
	{
		return 0f;
	}

	protected virtual float GBAEBHHKPMI(Player PGEGMKJKOKI, Vector3 AIFMLGFBPOO, Vector3 JNINPJDKGNA)
	{
		return 0f;
	}

	protected virtual float KIPEIJMCALI(Player PGEGMKJKOKI)
	{
		return 0f;
	}

	private float BJKDMADJPFK(Vector3 MNBPEEDKIAD, Vector3 DEHAJEONOJM, float PHGIDALCPPO, float DMIIKFIIPNE, string KIGMDNDHFBD = null)
	{
		return 0f;
	}

	private bool LMBBNHIJDNE(GMPGMPFNMFP NBLHNPAHGNA, string OIMMPDFABCD)
	{
		return false;
	}

	protected float PKGABDBHHGC(Vector3 MNBPEEDKIAD, Vector3 DEHAJEONOJM, bool EDJEJGLIGJN, float EHEDPFODENC, string KIGMDNDHFBD = null)
	{
		return 0f;
	}

	private Quaternion GDLGHEBNAMP(Quaternion OHGEALHBDNI)
	{
		return default(Quaternion);
	}

	public void ForceUpdate()
	{
	}

	private FDACAOPGNJK JPCNMEKJECD(Player PGEGMKJKOKI)
	{
		return null;
	}

	protected override void AAJBLNPFLOB()
	{
	}

	protected Player JPOOEONMEJE()
	{
		return null;
	}

	protected virtual Quaternion BAEGCHLNCDD()
	{
		return default(Quaternion);
	}

	private Quaternion NLCJDOCLCPF(bool EEPALPBMAKE = false)
	{
		return default(Quaternion);
	}

	protected Quaternion EDGKJCLFFDL()
	{
		return default(Quaternion);
	}

	protected Vector3 AHCBLOCABDP(Player PGEGMKJKOKI, bool EEPALPBMAKE = false)
	{
		return default(Vector3);
	}

	public Vector3 GetTransPos()
	{
		return default(Vector3);
	}

	public Vector3 GetTransCameraFollowPos()
	{
		return default(Vector3);
	}

	protected override void ODOLOHHIKGN()
	{
	}

	public override void OnCameraChanged()
	{
	}

	public void UpdateCurrentHelicopterPassengerParam(int MMIJLJIPDOD)
	{
	}

	public HelicopterCameraPassengerPara GetCurHelicopterPassengerParam()
	{
		return null;
	}

	public void SetZoomDest(float CNKMEPFCJOM, float FFADCBDFANJ = 0f)
	{
	}

	public void SetZoomDestDefault(float IMKNJGHAHPI = 0f)
	{
	}

	protected void CDJFBHMANCP()
	{
	}

	private float LGPKEFNMIEA(float DHIMHOIDDLC, float FGOMPLJBPAG)
	{
		return 0f;
	}

	private float CCFMBOAPFED(Vector3 GGJMPBKMEKK, Vector3 DEHAJEONOJM, float GBFGOPNBHKA, float DMIIKFIIPNE, string KIGMDNDHFBD = null)
	{
		return 0f;
	}

	public float GetDistanceToTarget()
	{
		return 0f;
	}

	public float GetMaxDistanceToTarget()
	{
		return 0f;
	}

	public void BeginLerpBackOffset(float JDKLLDAPFHO, float NLENLDDGAHH = -1f)
	{
	}

	public void BeginLerpBackRightUpOffset(float JDKLLDAPFHO)
	{
	}

	public void InitBackOffsetFromWorldPosition(Vector3 PGBNKDJKDIL)
	{
	}

	public void InitOffsetOnLerpBegin()
	{
	}

	public void SnapToFollowTarget()
	{
	}

	protected virtual Vector3 IIOAAMFPKBE()
	{
		return default(Vector3);
	}

	private Quaternion CPGKJLGAMPA()
	{
		return default(Quaternion);
	}

	public virtual void RefreshState(UGCCameraConfigRepItem PIHEOEJAPPO)
	{
	}

	public void InitManually(KMBEHIGOKNF LAIDKEINKFG, float FFADCBDFANJ, float HMCHAKDHAKE, float GOKHJBJHCLK, float CGGPBJKCDEG, Vector3 DFNHOKCIIJK, NHMBEJGPEMP CJPNFPLEDPA, CIDCDEOCLBA OAGMEDEPKML, FDACAOPGNJK FPJMDJMMDBL)
	{
	}

	public void UninitManually()
	{
	}

	public void ClearTrans()
	{
	}

	public void SetParameters(float DFPPHOGGGHO, float JCGCNCAAMHN, Vector3 KNFHOLCHMPH, float NPFFFBAHFJH, AnimationCurve OGJPGEGNELF)
	{
	}

	public void SetIsInNinthArea(bool KHMJBBGJAGD)
	{
	}

	private float JGLBPOKGBIN()
	{
		return 0f;
	}

	public void StartZoomoutAnimation(EJLMPAKOEKH OINKNIGKDMO, float GKMMOGFNMGI, float OIJPBAEGEDH, float IOOCBIIBIKN, float OLAFJIEMPIH = 5f, float GPEIEDFFAFF = 0f)
	{
	}

	public void StopZoomOutCameraAnimation(EJLMPAKOEKH OINKNIGKDMO, bool FAEDJCGABAA = false)
	{
	}

	private void JNNAHCOCEEG(ref float HAMGDDDAPBD, ref float PCIMCNIPLEE)
	{
	}

	public void _003C_003EiFixBaseProxy_OnCameraChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_AAJBLNPFLOB()
	{
	}

	public void _003C_003EiFixBaseProxy_ODOLOHHIKGN()
	{
	}

	public Vector3 _003C_003EiFixBaseProxy_get_TransTargetPos()
	{
		return default(Vector3);
	}

	public Quaternion _003C_003EiFixBaseProxy_get_TransTargetRot()
	{
		return default(Quaternion);
	}
}
