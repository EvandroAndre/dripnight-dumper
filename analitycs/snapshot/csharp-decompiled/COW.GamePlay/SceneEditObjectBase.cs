using System;
using System.Collections.Generic;
using COW.Gameplay.UGC;
using RuntimeGizmos;
using UnityEngine;
using message;

namespace COW.GamePlay;

public class SceneEditObjectBase : MonoBehaviour
{
	public delegate void DCJDFGMHGBB();

	public delegate void EDPLBNLDFPF();

	public delegate void DIHABBLCABM();

	public delegate void LEOPCHLLPKG();

	private enum IEBPNKLNFMA
	{
		None,
		SceneEdit,
		Timeline
	}

	private struct DJAHMFOBECK(int MDFHMBHHGGF, int OGECPGHMIHA)
	{
		public int BIKBLPKNGFB = 0;

		public int PKKLJJBBJGB = 0;

		public override int GetHashCode()
		{
			return 0;
		}

		public override bool Equals(object HACIJIFIDKM)
		{
			return false;
		}

		public int _003C_003EiFixBaseProxy_GetHashCode()
		{
			return 0;
		}

		public bool _003C_003EiFixBaseProxy_Equals(object P0)
		{
			return false;
		}
	}

	public enum KHADGBOGLBG
	{
		None,
		Driving,
		Driven
	}

	public enum LMOFHMAFDPP
	{
		None,
		Free,
		XYZ,
		XZ,
		XY,
		YZ
	}

	public class IPLGJPKIDPI
	{
		private SceneEditObjectBase AGMHDIBOHKK;

		public bool HLGJHPKMKLF;

		public float JNELOPONLJP;

		private List<Mesh> ACGPBELCAEC;

		private List<Matrix4x4> MLENEBMFOLK;

		private MaterialPropertyBlock MHACKKIBMNN;

		private Material EKPFIBPEDLO;

		private Vector4[] LNNCAJKJHOA;

		private float OMHEAOGDJFP;

		private FollowCamera DIOGKKIMMBJ;

		private Animation JEDBFPJIADC;

		public IPLGJPKIDPI(SceneEditObjectBase IOAJIKFPKPK)
		{
		}

		private FollowCamera AKJPOGOBGPD()
		{
			return null;
		}

		public void NFKCKLAHIHH()
		{
		}

		public void PDGJIBABJFK()
		{
		}

		private void LNJNMFJKKLN()
		{
		}

		public void NLJPKPDDLAF()
		{
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Predicate<Collider> _003C_003E9__217_0;

		public static Predicate<Collider> _003C_003E9__385_0;

		internal bool BJPNHFCOFCD(Collider NFOAOEHOFCH)
		{
			return false;
		}

		internal bool LIEMKOLHFOO(Collider NFOAOEHOFCH)
		{
			return false;
		}
	}

	private const float PCHMECEOBAJ = 1000f;

	private string mLogicEntityID;

	protected int BIKGFOEONLA;

	protected uint NPHKMACOFMD;

	protected Transform FKEMOMBMHEM;

	private DCJDFGMHGBB m_ABNNOALIJHD;

	private EDPLBNLDFPF m_HBHOPMDGDDI;

	private DIHABBLCABM m_EBAJHMDNHBH;

	private LEOPCHLLPKG m_PDLOBIPKBAC;

	private NGIALHFGCPL OCLLIAGHKHH;

	private bool PIFIFGEGFDE;

	protected SceneEditPrefabConfigData ILNEMDBDJGE;

	public SceneEditObjectAttrBase AttrBase;

	private SceneEditObjectScalableItem PJPKJLPIHCB;

	protected GameObject LLLGJAFNPMM;

	private KMOACBCEPEO PFFHOHOFIOL;

	private List<Collider> HEAJOGLGFMJ;

	private List<Collider> MDDAIGFHCJA;

	private List<SceneEditObjectBase> CODFIFNGDEK;

	public bool Selected;

	public bool ShowSelected;

	private EJECBGMHHBI CPFJKKJHDND;

	private DOBGEJFCPOF GDFNDCBAIHP;

	public Vector3 m_GroupToSelectedDis;

	public string SceneEditObjectName;

	public SceneEditObjectBase Parent;

	protected List<Renderer> KEPOLMHDKCL;

	protected SceneEditObjectSetScale ONINHBHCIGI;

	private bool MOAGJNEIEGP;

	private string DLIBFLEIOPB;

	protected Bounds IMFDILMCEHH;

	private HNDHJGJILHC HGEGDIMKMFM;

	private SceneEditAgent LCALNINNCCE;

	private GAPHGOAAKML BBMLNNGALLJ;

	protected Dictionary<Renderer, Material[]> BKBMNMNOFJM;

	protected Material PPNECKCAAPP;

	private IEBPNKLNFMA FAEJNFNNPEG;

	private Dictionary<Transform, int> KEDKNDJKMFD;

	public bool ShowColliderGizmo;

	private static readonly Color OHBIJCGBNMI;

	private const float BGFNNGIBIDK = 0.02f;

	private const int MDJHKKDKJHM = 16;

	private const int IGACNLNFKIJ = 4096;

	private readonly List<LineRenderer> PNIFGGHKMPC;

	private readonly List<Vector3> CMGEGGMPHHP;

	private GameObject FPEIGLFICIH;

	private Material NEOOOBENKJF;

	private bool _003CABLBNFIPECA_003Ek__BackingField;

	public float BoundExpands;

	public bool IsFromAIAssist;

	public bool IsFromSearch;

	protected List<Collider> GLMKNPOELCB;

	private Dictionary<GameObject, int> JKLKGKLFKEM;

	private List<int> DKGFEHAIKPN;

	private LMOFHMAFDPP GKEFOCILLKI;

	public Vector3 ScaleMin;

	public Vector3 ScaleMax;

	public Vector3 ScaleStep;

	public Vector3 RelativePosToCenter;

	private Vector3 PBCMOBHLJOO;

	private Vector3 OOJDLEJCHHK;

	private Plane GPHDEGIGDLH;

	private float JAODHOJIEGH;

	private float JPGMMGEHMAG;

	protected Material ABPKACMMBFP;

	private IPLGJPKIDPI JDGNPHFLNJO;

	private Vector3 HICOMAKEHJK;

	private Vector3 HAFGNDGPGOP;

	private Quaternion CHDJJEFOKAB;

	private Vector3 NBPGGJKMBHA;

	private Vector3 LDDCLPINKOI;

	private Quaternion ENPNCFBBFOJ;

	private Vector3 GFGPIELCNEK;

	private Vector3 FCMIDIIBFPB;

	private Vector3 NHFMFCAJMBB;

	private Quaternion KDFHOJBPCDP;

	private Vector3 EBLPNMGEPGB;

	private Vector3 DIGNMOGJNPA;

	public int m_TempIndex;

	private bool HJGMHENLFHN;

	private bool KGLJJGICNGM;

	private bool AKIEJBMFGCG;

	private static Mesh HLOMAGPMMPO;

	private Renderer[] NHCFEAPNMLF;

	private bool MIEMAKKEKCE;

	private bool DHJFPCFAAEH;

	protected Renderer[] BHFAKBFMKDB;

	private GameObject GEDFEPLFIHI;

	private MeshRenderer MDBEDEDENMP;

	protected virtual bool DMENECJABLD => false;

	public bool LOEDJLIDGBD => false;

	public int NKOKDGIKMLB => 0;

	public uint JEKGAPGLFPL => 0u;

	public Transform BECDIOKCAAD => null;

	public Vector3 MOEFFAIDCBP
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public Vector3 LEGLEFICFDP
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public Vector3 BOPJJFOKNJC
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public Vector3 EIAGBFMOGAE => default(Vector3);

	public Vector3 IFEMIOECNLN
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public Quaternion LFCNHAJBHEE
	{
		get
		{
			return default(Quaternion);
		}
		set
		{
		}
	}

	public Quaternion POBFCFOFPMA
	{
		get
		{
			return default(Quaternion);
		}
		set
		{
		}
	}

	public Vector3 JHABBPMFBIK
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public Vector3 JBHENAIINDC
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public NGIALHFGCPL FGDFHFGPNIH
	{
		get
		{
			return NGIALHFGCPL.Editable;
		}
		set
		{
		}
	}

	public SceneEditPrefabConfigData GLOJIGILFII => null;

	public SceneEditObjectScalableItem HGFNDFGILPH => null;

	public GameObject DAGCFDAIEDN => null;

	public bool ODECAADMPEH => false;

	public List<Collider> JLLOGNNMPCP => null;

	public List<Collider> IGJHJIEPOBH => null;

	public List<SceneEditObjectBase> IPFLCOIHCBL => null;

	public bool LGEEGKAMPMO => false;

	public EJECBGMHHBI OMECHMFBDHI => EJECBGMHHBI.None;

	public DOBGEJFCPOF LJJIBDCGMMA => DOBGEJFCPOF.Outline;

	public int LNNEFINLJEF => 0;

	public bool DBJPAICBEIC => false;

	public string ANIJFLPHFFD
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string HMCALJLNMNC
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	protected SceneEditAgent BCCMOEBJDBL => null;

	protected virtual bool BNLIMCHECHI => false;

	protected GAPHGOAAKML ONCFBEDAEPH => null;

	public bool PANBCHPKNAA
	{
		get
		{
			return false;
		}
		private set
		{
		}
	}

	public List<Collider> FOEPPBHIHGD => null;

	public List<int> CKOHMCFGHOJ => null;

	public LMOFHMAFDPP MOEEDDNKNIK
	{
		get
		{
			return LMOFHMAFDPP.None;
		}
		set
		{
		}
	}

	public bool HLGJHPKMKLF => false;

	public IPLGJPKIDPI GDDMDLMMIAA => null;

	public Vector3 JJPHPBHFPLO => default(Vector3);

	protected virtual bool LDIBNDOJHGG => false;

	public event DCJDFGMHGBB ABNNOALIJHD
	{
		add
		{
		}
		remove
		{
		}
	}

	public event EDPLBNLDFPF HBHOPMDGDDI
	{
		add
		{
		}
		remove
		{
		}
	}

	public event DIHABBLCABM EBAJHMDNHBH
	{
		add
		{
		}
		remove
		{
		}
	}

	public event LEOPCHLLPKG PDLOBIPKBAC
	{
		add
		{
		}
		remove
		{
		}
	}

	protected virtual AGKINNABLGO LBCDJMAPELL(out string PFDHJBOJJGH)
	{
		PFDHJBOJJGH = null;
		return AGKINNABLGO.Success;
	}

	public void ApplyPositionFromDataStore(Vector3 GPFPIAMCEMI)
	{
	}

	public void ApplyLocalPositionFromDataStore(Vector3 GPFPIAMCEMI)
	{
	}

	public void ApplyTangentPositionFromDataStore(Vector3 GPFPIAMCEMI)
	{
	}

	public void ApplyLocalScaleFromDataStore(Vector3 GPFPIAMCEMI)
	{
	}

	public void ApplyRotationFromDataStore(Quaternion GPFPIAMCEMI)
	{
	}

	public void ApplyLocalRotationFromDataStore(Quaternion GPFPIAMCEMI)
	{
	}

	public void ApplyEulerAnglesFromDataStore(Vector3 GPFPIAMCEMI)
	{
	}

	public void ApplyLocalEulerAnglesFromDataStore(Vector3 GPFPIAMCEMI)
	{
	}

	private void AECNHBHNPIP(Vector3 GPFPIAMCEMI)
	{
	}

	private void JELHFKJIBCL(Vector3 GPFPIAMCEMI)
	{
	}

	private void JOILJAEBHCI(Vector3 GPFPIAMCEMI)
	{
	}

	private void PGNLFFIEKDP(Vector3 GPFPIAMCEMI)
	{
	}

	private void BOAEHGLGBHL(Quaternion GPFPIAMCEMI)
	{
	}

	private void IFICMNFPAME(Quaternion GPFPIAMCEMI)
	{
	}

	private void HLKIIAALINA(Vector3 GPFPIAMCEMI)
	{
	}

	private void OLAIDDLEOAH(Vector3 GPFPIAMCEMI)
	{
	}

	public virtual bool EnableTangent()
	{
		return false;
	}

	public virtual bool EnableTag()
	{
		return false;
	}

	public virtual bool EnableGraphScript()
	{
		return false;
	}

	public virtual string GetUGCTypeNameForConfig()
	{
		return null;
	}

	public void SetVisibility(KMOACBCEPEO PIDINBNGILH, bool KGOHDEBHENF)
	{
	}

	public bool HasInvisibilityFlag(KMOACBCEPEO PIDINBNGILH)
	{
		return false;
	}

	protected void BGBCCOOABAN()
	{
	}

	public KMOACBCEPEO GetInvisibilityFlags()
	{
		return KMOACBCEPEO.None;
	}

	public void ClearAllInvisibilityFlags()
	{
	}

	private DOBGEJFCPOF ILLKBFHDCGA()
	{
		return DOBGEJFCPOF.Outline;
	}

	public void GetAllChildren(List<SceneEditObjectBase> PCGMOOHAIDE, bool GDLFMJIKCDM = false)
	{
	}

	public void SetParent(SceneEditObjectBase FKODMCNOBDM, List<CNGBCLDDJEF> BMDHOAHLPCJ = null, int DDNJKMPIHEC = -1)
	{
	}

	public bool HasParent()
	{
		return false;
	}

	public bool IsOnGround()
	{
		return false;
	}

	protected virtual void MGKLOJHDMIC()
	{
	}

	public virtual void AfterLogicEntityReady(INAMDLOFOHF OEPHMNFCKNO)
	{
	}

	public virtual void InitPrefabData(int NIBBKONKPHP, SceneEditPrefabConfigData JCONDDPFBKK, Vector3 BJFKBNELIDN, Vector3 DDFHNMADDGN = default(Vector3), Vector3 GLPLIHEECAP = default(Vector3))
	{
	}

	protected virtual void PGALLKFOIOH()
	{
	}

	private void EKLDIPGANHN()
	{
	}

	private void OnDestroy()
	{
	}

	protected virtual void IENCOHENCGG()
	{
	}

	public void ReInitMeshRenderers()
	{
	}

	protected virtual void HGJPAHAENLN()
	{
	}

	public void SetVisible(bool KGOHDEBHENF)
	{
	}

	public void RefreshVisualAfterModelChanged()
	{
	}

	protected virtual void GGHBJKDGFBE()
	{
	}

	protected virtual void EILFOPFEHBD()
	{
	}

	protected void LAOJCEKEIEE(bool AGDMDPMCCLI)
	{
	}

	protected void IGDPFBIFHJI()
	{
	}

	private void LNGHIBOJCIH()
	{
	}

	private void OKIFIDJFLJI()
	{
	}

	public void ForceRefreshMaterial()
	{
	}

	private void JONLKOPEBMG()
	{
	}

	public void ResetSelectedMaterial()
	{
	}

	public virtual Bounds GetRenderBound()
	{
		return default(Bounds);
	}

	public void OnSelected(bool PFCBBDKABBN)
	{
	}

	public void UpdateSelectionDisplayState(EJECBGMHHBI GCJPAAPKMMA, bool GENFLELLDDI = false)
	{
	}

	private void HIHMNCJIJKG(EJECBGMHHBI LALADOJHOBE, EJECBGMHHBI GCJPAAPKMMA, DOBGEJFCPOF CEPCNEHMHNI, DOBGEJFCPOF EKACMOFPAMC)
	{
	}

	private EJECBGMHHBI FIBCMPILDPM()
	{
		return EJECBGMHHBI.None;
	}

	private void JFMHBMEGAKD(DOBGEJFCPOF GGAOKBAMALB)
	{
	}

	private void PCKNLHBGAIL(DOBGEJFCPOF GGAOKBAMALB, EJECBGMHHBI CBCAJJJCKLH)
	{
	}

	private void KIBJEGLBBCC()
	{
	}

	private void MBLNPLDAKKE()
	{
	}

	private void MELOEDFFBAF()
	{
	}

	private void JIMMPAIDDBN()
	{
	}

	public virtual void RefreshShowSelected(bool GENFLELLDDI = false)
	{
	}

	public bool HasAnyChild()
	{
		return false;
	}

	public bool HasChild(SceneEditObjectBase HACIJIFIDKM)
	{
		return false;
	}

	public void AddChild(SceneEditObjectBase HACIJIFIDKM)
	{
	}

	public void InsertChild(int NIBBKONKPHP, SceneEditObjectBase HACIJIFIDKM)
	{
	}

	public virtual void RemoveChild(SceneEditObjectBase HACIJIFIDKM, List<CNGBCLDDJEF> BMDHOAHLPCJ)
	{
	}

	protected void IEBGAAEJEJH(SceneEditObjectBase HACIJIFIDKM)
	{
	}

	public virtual void ClearChildren()
	{
	}

	public virtual void Cleanup()
	{
	}

	public virtual void OnMove()
	{
	}

	public virtual void OnRotate()
	{
	}

	public virtual void OnScale()
	{
	}

	public virtual void OnTangentMove()
	{
	}

	public void Destroy(bool LPBPBKGNBKA)
	{
	}

	public virtual void OnRemove(List<CNGBCLDDJEF> BMDHOAHLPCJ, bool DJPJBGKKEPC)
	{
	}

	public virtual void OnUndoRemove()
	{
	}

	public virtual void RemoveIfAllowed(Action<SceneEditObjectBase> DBJBCFOHNLG, SceneEditObjectBase HACIJIFIDKM)
	{
	}

	public void CopyFrom(SceneEditObjectBase GHELIDCBMPH)
	{
	}

	public virtual void Duplicate(SceneEditObjectBase GHELIDCBMPH)
	{
	}

	private void NCPIJAGIAFH(SceneEditObjectBase NKLKEKKLGJC)
	{
	}

	private void HHPIEDDJAED(SceneEditObjectBase GHELIDCBMPH)
	{
	}

	private void KGDAJIGDHCH(INAMDLOFOHF JCONDDPFBKK)
	{
	}

	public void SetCompatibleData(int HDFBONFKNAP, string GIBIGJGLOGA)
	{
	}

	public virtual void SetShopItemInfo()
	{
	}

	public bool IsPresentEffectGenerator()
	{
		return false;
	}

	public bool IsEffectEntityGenerator()
	{
		return false;
	}

	public List<ItemEditAttributeUIData> UseObjectAttributeGenUIData(ItemEditAttributeBaseConfig OEFALJDOOAB)
	{
		return null;
	}

	private void OnDisable()
	{
	}

	public virtual void InitSceneEditBySavedData(string BFFJLIPJPFC)
	{
	}

	public void CollectSceneEditObj(ref List<SceneEditObjectBase> EMANEBGLLJG)
	{
	}

	public virtual Bounds CalculateCombinedBounds()
	{
		return default(Bounds);
	}

	public virtual Bounds CalculateSelfBounds()
	{
		return default(Bounds);
	}

	public bool CheckSelfBounds()
	{
		return false;
	}

	public bool CheckBounds(out string PFDHJBOJJGH)
	{
		PFDHJBOJJGH = null;
		return false;
	}

	public virtual bool CheckSelfPosition()
	{
		return false;
	}

	public bool CheckPosition()
	{
		return false;
	}

	public string GetDisplayName()
	{
		return null;
	}

	public virtual bool FocusCenterAlign()
	{
		return false;
	}

	public virtual void AfterSetParent(SceneEditObjectBase FKODMCNOBDM)
	{
	}

	public bool CheckGroup(out string NNOMFOBGPFL)
	{
		NNOMFOBGPFL = null;
		return false;
	}

	public AGKINNABLGO CheckSave(out string PFDHJBOJJGH)
	{
		PFDHJBOJJGH = null;
		return AGKINNABLGO.Success;
	}

	private bool JFBGCKLCBJN(out string PEHJODPGACF)
	{
		PEHJODPGACF = null;
		return false;
	}

	public bool ExportTemplate(string NHCHJKFONGK, string JHKJKNFFEAL, byte[] NCCALBIGJAA, List<byte[]> JDPKHNAGJGH, bool MGBPEAAIHLD, out KCJDEKIJAKH HDNAALELHPA)
	{
		HDNAALELHPA = null;
		return false;
	}

	public void SetLayers(int PNLKPJNLDGB)
	{
	}

	public void RestoreLayers()
	{
	}

	public void CollectResourceRef(ResCollectingContext JPPOFGHGPGE, ref HashSet<UGCCustomLevelObjectEditorPackageInfo> IEPLBFNHEAL)
	{
	}

	private void MADCFDFKIHJ()
	{
	}

	private void GABOMJFAGOL()
	{
	}

	private void GMMKMJKOMKC()
	{
	}

	private void KOLOHJEKFJA()
	{
	}

	private void EDDLEGAPMMF()
	{
	}

	private void EOJKEFHOAJK()
	{
	}

	private void GNMFJBBFKJD()
	{
	}

	private void JIGJAPCFOKJ(EJECBGMHHBI CBCAJJJCKLH)
	{
	}

	private void LateUpdate()
	{
	}

	private void ACCOKCJIGED()
	{
	}

	private void ABCOFCNMGAB(Vector3 KCNHGBEDJEC, Vector3 LKHILGKLNPN, Vector3 PEAPJAMNDCK, Vector3 HAFFFILOBGL, Vector3 GGKMIOAJOMJ, Vector3 JIODOKDOMIE, Vector3 LIPHEIKIBPD, Vector3 IPKKKEJFPKC)
	{
	}

	private void NOKKJHGPLMN(Vector3 LMOGBFCEONO, float NMEEAHMNACE)
	{
	}

	private void MABMAKLAJHF(CapsuleCollider KJIMNLOAKOL, Transform MJIFGJPGLAM)
	{
	}

	private void DEACNDMJJDI(Vector3 LMOGBFCEONO, float NMEEAHMNACE, Vector3 LNFAEDLGHHO, int MNIHPDHNPMK)
	{
	}

	private void CAHIJHJOEFM(Vector3 LDKDHHPOJAK, Vector3 IIICFBLMKGC, Vector3 NAKHGGKEJED, float NMEEAHMNACE, bool LPLFCFMEIOJ)
	{
	}

	private void OEBLNHMAHNA(MeshCollider GCJBNNCOAKL)
	{
	}

	private bool DLFCFFJIAEM(MeshCollider GCJBNNCOAKL)
	{
		return false;
	}

	private void EIHBOIGPMAI(Vector3 AOGGADPEFCC, Vector3 AGOPFPDMIBM)
	{
	}

	private void CFEOGINKMEK(int PNLDKNOFPNG)
	{
	}

	private void PNMDPKAJPMJ()
	{
	}

	private Material BBMFKGDLFHH()
	{
		return null;
	}

	private void FAEHDNBOIEG()
	{
	}

	private void GFALLMFOPPN()
	{
	}

	protected List<Renderer> NPNIDEJFNCG(Transform IBDNJDLJPDG)
	{
		return null;
	}

	private void CJLDCHHHCHD()
	{
	}

	private void GJLMKDPDCMG(Axis IIICFBLMKGC, ItemEditAttributeUIDataSliderBar DKLKGHGFNCC)
	{
	}

	protected void FCHCFLAFJPM()
	{
	}

	public bool HasRestrictedScale()
	{
		return false;
	}

	public bool HasRestrictedRotation()
	{
		return false;
	}

	public void CacheOperateData()
	{
	}

	public void CacheModifyData()
	{
	}

	public void CacheRelativeTransform(SceneEditObjectBase ANOJLNEGFBO)
	{
	}

	public void UpdateDrivenModify(SceneEditObjectBase ANOJLNEGFBO)
	{
	}

	public void EnterModify()
	{
	}

	private void GPFJCPBELGA()
	{
	}

	public void CacheCameraRay()
	{
	}

	public bool HasPrefabData()
	{
		return false;
	}

	public virtual void OnCrosshairScale(Vector3 GLPLIHEECAP)
	{
	}

	public virtual void BeforeDestroy()
	{
	}

	private void Update()
	{
	}

	private void FEPNJFDAPGE()
	{
	}

	public float GetHeight()
	{
		return 0f;
	}

	private void PGCKDNHADHA()
	{
	}

	protected void FJDBMJNNBMJ()
	{
	}

	public void ShowCrossHairVisualEffect()
	{
	}

	public void InitCrossHairVisualEffect()
	{
	}

	public virtual void OnModifyInit()
	{
	}

	public void CancelAdd()
	{
	}

	protected virtual void DAMABAPIMMF()
	{
	}

	public void ConfirmAdd(List<CNGBCLDDJEF> BMDHOAHLPCJ)
	{
	}

	protected virtual void HGBEAJDPMPK(List<CNGBCLDDJEF> BMDHOAHLPCJ)
	{
	}

	public void ExitModify()
	{
	}

	public virtual void OnExitModify()
	{
	}

	private Vector3 KIMNLPCMJLO(Ray KPJALOBJEED, RaycastHit HDGIHCBAOEN)
	{
		return default(Vector3);
	}

	public void UpdateRayCastDis(BJJBCNEJPEF GGAOKBAMALB)
	{
	}

	private float KMOPNEKMGIB(float PCOPDDLBLMI, float HOGHEFNINAE)
	{
		return 0f;
	}

	public void UpdateDrivingModify()
	{
	}

	public float GetTranslateTarget(float EFJFMJLEHOL, Axis IIICFBLMKGC, Vector3 COHABAFIHDF)
	{
		return 0f;
	}

	private Vector3 GGOBNAONMAO(Axis IIICFBLMKGC)
	{
		return default(Vector3);
	}

	public Vector3 GetAfterTranslate(float PFJFADHEJLJ, Axis IIICFBLMKGC, Vector3 COHABAFIHDF)
	{
		return default(Vector3);
	}

	public Vector3 GetAfterScale(float PFJFADHEJLJ, Axis IIICFBLMKGC, Vector3 COHABAFIHDF)
	{
		return default(Vector3);
	}

	public bool CheckScaleValid(Vector3 GLPLIHEECAP)
	{
		return false;
	}

	private void LPMAFJFJOJF(out Vector3 AFNNMPBCDCG)
	{
		AFNNMPBCDCG = default(Vector3);
	}

	private void DJEGHJPKMIB(Ray KPJALOBJEED, out Vector3 AFNNMPBCDCG)
	{
		AFNNMPBCDCG = default(Vector3);
	}

	public void ResetOperateData()
	{
	}

	public void ResetModifyData()
	{
	}

	protected Vector3 PMOHJKAJGFE(Vector3 IGDHIDGLOKG, Vector3 LMOGBFCEONO, Vector3 IIICFBLMKGC, float AOOCNKPILEO)
	{
		return default(Vector3);
	}

	public void EnterInspector()
	{
	}

	public void ExitInspector()
	{
	}

	public void ChangeStatus(bool JDPPBONHJNC)
	{
	}

	public void RefreshState()
	{
	}

	public void RefreshCrosshairMeshMaterial()
	{
	}

	public bool GetTouchPositionHitPoint(ref Vector3 AFNNMPBCDCG)
	{
		return false;
	}

	private Renderer[] ICACCDGMAMJ()
	{
		return null;
	}

	public Bounds GetOutlineSortBounds()
	{
		return default(Bounds);
	}

	protected virtual Renderer[] BIALMHJPHBL()
	{
		return null;
	}

	private static Mesh OCHAFIHMIMK()
	{
		return null;
	}

	private void MPGJAHEJCAL()
	{
	}

	private Bounds GFMIIHHELFB()
	{
		return default(Bounds);
	}

	private void FFDGLMPCBGL()
	{
	}

	private void DCGPLPDBOMH(SceneEditObjectBase CFCBIHKHDBA, UnityEngine.Object BFIGLMGJKLN)
	{
	}

	private void OIDIDMPAAAH()
	{
	}
}
