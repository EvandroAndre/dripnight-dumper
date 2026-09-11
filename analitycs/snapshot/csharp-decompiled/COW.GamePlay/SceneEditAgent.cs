using System;
using System.Collections;
using System.Collections.Generic;
using COW.Gameplay.UGC;
using GCommon;
using RuntimeGizmos;
using UnityEngine;
using message;

namespace COW.GamePlay;

public class SceneEditAgent : MonoBehaviour, FDACAOPGNJK
{
	private enum ODICEJCEMBN
	{
		None,
		Selected,
		PreSelect,
		PreDrag
	}

	public class NIMFEJFJHPP
	{
		public SceneEditObjectBase HACIJIFIDKM;

		public KDHKEDFHDHF JJLCPPNJDFG;
	}

	public enum KJKBMNKHHNN
	{
		None,
		Orthographic,
		Rotate
	}

	private sealed class NHNDPGOEBPA
	{
		public SceneEditAgent KOKNHFGCGLN;

		public List<CNGBCLDDJEF> BMDHOAHLPCJ;

		internal void NLDJFIEIAAO(SceneEditObjectBase HACIJIFIDKM)
		{
		}
	}

	private sealed class CJODHFNJBIH
	{
		public SceneEditAgent KOKNHFGCGLN;

		public SceneEditObjectBase HACIJIFIDKM;

		internal void OHJHDOCFNKN()
		{
		}
	}

	private sealed class AMJICEFFMFK : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int CBPPJACCGOH;

		private object MHDKFGLHFKH;

		public List<JLFABCODABC> MNOKNECOMFA;

		public SceneEditAgent KOKNHFGCGLN;

		private List<JLFABCODABC>.Enumerator PONFFGBIJKK;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public AMJICEFFMFK(int CBPPJACCGOH)
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

		private void FCCDBLLBMAO()
		{
		}

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class GFCHEFPPBPG : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int CBPPJACCGOH;

		private object MHDKFGLHFKH;

		public int[] HNIDEKPIBNC;

		public List<Vector3> GECAOGMINLL;

		public List<Vector3> KHJGFPDJGPP;

		public List<Vector3> OADKLOPNOGL;

		public SceneEditAgent KOKNHFGCGLN;

		private List<SceneEditPrefabConfigData> LMMILIKPBJD;

		private int PJPJJIDHDIE;

		private int DMEJBNIPEMO;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public GFCHEFPPBPG(int CBPPJACCGOH)
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

	private sealed class CJDFDBMCEJM : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int CBPPJACCGOH;

		private object MHDKFGLHFKH;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public CJDFDBMCEJM(int CBPPJACCGOH)
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

	private sealed class ABLEJEFDOKI : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int CBPPJACCGOH;

		private object MHDKFGLHFKH;

		public float IFDHHGECCCM;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public ABLEJEFDOKI(int CBPPJACCGOH)
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

	public Vector3 WorldCenter;

	public Vector3 CameraOriginalPos;

	private Transform NFPOAAOKAKN;

	private Vector3 NMMDIIFFLKK;

	private Quaternion FPDKNNMADNE;

	public SceneEditObjectBase m_LastSelectedObj;

	private SceneEditOutlineOrderManager IHFOFDPIHBC;

	private Dictionary<uint, ItemEditAttributeBaseConfig> HPLDJKCKBDN;

	private Dictionary<uint, List<ItemEditAttributeUIData>> BKPIJCNAHKA;

	private Dictionary<uint, ItemFunctionAttributeBaseConfig> DPBFNEACEFM;

	public IJKOCMOLBKM AddType;

	private EUGCAssetProviderType KIALEPDIPJM;

	private KCJDEKIJAKH ABINONMNHBG;

	private SceneEditPrefabConfigData DAMOAPILDCP;

	private SceneEditObjectBase GPJOGMMDPJH;

	private List<SceneEditObjectBase> IKPCEMNLIGL;

	public List<CNGBCLDDJEF> OperateRecord;

	public List<CNGBCLDDJEF> ModifyRecord;

	private HIMMHCLHMGK OCKOAGABGDM;

	private SceneEditGridMesh IDLKCJDCNCB;

	private SceneEditPaintTool CCEELBHMBME;

	private EMOBFGCJAFC KMCINPHKAGM;

	private SceneEditBoxSelectTool OCKIIJODACO;

	private bool NCJLMMFBAAK;

	private bool DKNELPFOCHG;

	private bool IKBGOCFEINM;

	private FEBFFFJCNJK FJEMEKKBKHD;

	private bool _003CEGGLMCILCNN_003Ek__BackingField;

	private bool FBPCMONPDFD;

	private BJJBCNEJPEF KMJFIIOMAAB;

	private DEEMJPOOMMK PPLIGALDAHP;

	private float JCFFLJNNLHC;

	private float OJOBFFAONOM;

	private float JKDNNLLMNHK;

	private Player HAALKPAHONE;

	private HNDHJGJILHC HGEGDIMKMFM;

	private GameObject LKKNJADFLBA;

	private float JPIBHBIGEEI;

	private float MFLBAFNCPKG;

	private UIModelSceneEdit DAAFGKPMOAL;

	private SceneEditObjectBase HKAOBGMCENP;

	private SceneEditObjectBase IHGKOHNKKEA;

	private SceneEditObjectBase AFMKECDMIKM;

	private List<SceneEditObjectBase> _003CHEJBBKNBPHD_003Ek__BackingField;

	private bool FDLHDDOOHPC;

	private bool MJGEHOJOMHF;

	private bool BAGJCOHEKPB;

	private bool LKIHCILJEBL;

	private bool CGFGJNAHLPC;

	public Vector2 DragObjOffset;

	private Camera BAGLCCLIOEK;

	private TransformGizmo IPGHHGGACFB;

	private bool GKFODOBJLFE;

	private bool DGBANAFAOKD;

	private Vector2 ICIDNAMAKPP;

	private bool KECIOJNHKCN;

	private ODICEJCEMBN LJLNJLABJFD;

	private SceneEditObjectBase DCFHECEHAOJ;

	private float DANLIIFPPOE;

	private SceneEditObjectBase ICFLJMJEDEF;

	private bool LMBPHNFLFEB;

	private EAdjustType CFLICAODKDC;

	private bool OKBJDDNBEPA;

	private bool OLFBEGFIEKP;

	private bool CHKFHKCFDIJ;

	private bool LKHHNNJACJC;

	private uint KJBGLOHCNKL;

	private HashSet<string> DLBEJLCENCA;

	private HashSet<uint> DPPLFENDLHI;

	private List<ItemEditAttributeCacheValueBase> EABIJDCDFEC;

	private Coroutine CKDPCLGOIPO;

	private Coroutine JIOGCLOOFPD;

	private List<SceneEditObjectBase> IDHLBDGMEAH;

	private EGOAELDFMFO BMOIGLBMNGI;

	private UserControlHandler CDPGFMJOMPJ;

	private bool OALKAAMHFCH;

	private bool HFIDNAICMLH;

	private bool BLEJKINKOJP;

	private bool NDMGHJPFPIC;

	private bool ALJFAGDLDOA;

	private bool BCFLEDMECKK;

	private bool AKOOFCHJHPO;

	private bool HMGDCHEPION;

	private bool ECKKEFOJKML;

	public bool IsScaling;

	private float CFPGHPLEMPD;

	private const float HHHBCGFEEPJ = 326f;

	private const float JOOGIDJAMIN = 300f;

	private const float ECDIMPGNOAF = 3f;

	private UserControlHandler FNABFLOLJNN;

	private Vector3 OBMODDFMHMN;

	private Vector3 JBHFGPLPHJH;

	private Quaternion KDDNFAEAPEK;

	private Quaternion CICBBGEIPBO;

	private float BDDDHNEOJDH;

	private float DAEJHOLGMON;

	private KJKBMNKHHNN HCODPCAFHJM;

	public uint OOFAMFPFDPL => 0u;

	public int IFHLCJCLBOM => 0;

	public int LMPNJMIPDDD => 0;

	public int MEJHEIJFCDN => 0;

	public int JLIBIJKJILG => 0;

	public Transform BECDIOKCAAD => null;

	public SceneEditOutlineOrderManager ICHHAOAMLAK => null;

	public HIMMHCLHMGK NJFFPCEFNLL => null;

	public SceneEditGridMesh GDDCGPHPGGJ => null;

	public SceneEditPaintTool IEKKEIBGCGF => null;

	public EMOBFGCJAFC EMOBFGCJAFC
	{
		get
		{
			return EMOBFGCJAFC.Single;
		}
		set
		{
		}
	}

	public SceneEditBoxSelectTool FILJIGHJACJ => null;

	public bool NHEEAOGAOHL
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool IMHAOMOIOBB
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool DIEOPIPKFHE
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public FEBFFFJCNJK FEBFFFJCNJK
	{
		get
		{
			return FEBFFFJCNJK.Aim;
		}
		set
		{
		}
	}

	public bool ADOAIHJAOEF
	{
		get
		{
			return false;
		}
		private set
		{
		}
	}

	public bool APPLMHFCFFI
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public DEEMJPOOMMK ENOGFMIGHFN
	{
		get
		{
			return DEEMJPOOMMK.Perspective;
		}
		set
		{
		}
	}

	public int HOBNNFMOBEP
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public SceneEditObjectBase PELNIEAKBKL
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public float LABDAAIMPMD => 0f;

	public SceneEditObjectBase IFPMMNGNGAG
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public SceneEditObjectBase EGPMPKCHGEB
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public List<SceneEditObjectBase> COAGKAHDEEI
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	public bool PANBCHPKNAA
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool BJFIAIPPJAB
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool MDBOINMCAHK
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool MCBAMJFDLGH
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool PNBDONEJFOF
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public Camera PDKBCPOIPKK => null;

	public TransformGizmo LOCBANGEDPJ => null;

	public bool NODONGFINFB
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private List<ItemEditAttributeCacheValueBase> FLKDACHNEDD => null;

	public bool CHCAPIPJNGC
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool MDNAOBGNJMP
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool GMOGCANIIIA
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool KOPOBAOEILI
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private UserControlHandler NPBPCAPOMFJ => null;

	public KJKBMNKHHNN DCHMLDFEIIM
	{
		get
		{
			return KJKBMNKHHNN.None;
		}
		set
		{
		}
	}

	public void SwitchCameraProjection()
	{
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void NAHOKBBAIAB(uint NFFPFLGDPLF)
	{
	}

	private void NBEOOADMNIB(float IFDHHGECCCM)
	{
	}

	public static uint GetFloorPlaneLayerMask()
	{
		return 0u;
	}

	public void BindTrackingPlayer()
	{
	}

	private void Update()
	{
	}

	private void FDILOLLEHJI(float HOGHEFNINAE)
	{
	}

	private bool NJIJLCLPMOE()
	{
		return false;
	}

	public void CheckTouch()
	{
	}

	private void FKOFDKCOALM()
	{
	}

	private void MGNDGDODBOM(SceneEditObjectBase JBCDHLNHGIH)
	{
	}

	private void ABKDAJPDOGE(SceneEditObjectBase JBCDHLNHGIH = null)
	{
	}

	private void DIFNHFMDAOD(bool JICGNEPFMDC)
	{
	}

	private bool PECHCKALLPO()
	{
		return false;
	}

	private bool LCIDBMELKJG(SceneEditObjectBase JBCDHLNHGIH)
	{
		return false;
	}

	private bool AJFKMGPBGFI(SceneEditObjectBase BNLCLJOJLLF, SceneEditObjectBase KFHEFJILOFM)
	{
		return false;
	}

	public bool CheckHitAxis()
	{
		return false;
	}

	public void UpdatePoint()
	{
	}

	private void OIAOHCNEPBN(Vector2 IKJDBBDEBMH)
	{
	}

	public void UpdatePickSelect(SceneEditObjectBase JBCDHLNHGIH)
	{
	}

	public bool CheckHitObj(Vector2 KLGGIFKBCGP, out SceneEditObjectBase JBCDHLNHGIH)
	{
		JBCDHLNHGIH = null;
		return false;
	}

	public bool CheckObjInCurGroup(SceneEditObjectBase JBCDHLNHGIH, SceneEditObjectBase LMFHNNEALPF)
	{
		return false;
	}

	public SceneEditObjectBase GetNextGroup(SceneEditObjectBase JBCDHLNHGIH, SceneEditObjectBase LMFHNNEALPF)
	{
		return null;
	}

	public SceneEditObjectBase GetRootObj(SceneEditObjectBase JBCDHLNHGIH)
	{
		return null;
	}

	public SceneEditObjectBase GetTopGroup(SceneEditObjectBase JBCDHLNHGIH)
	{
		return null;
	}

	public uint GetMaxGroupCnt()
	{
		return 0u;
	}

	public bool GroupModify()
	{
		return false;
	}

	public SceneEditObjectBase Group(List<SceneEditObjectBase> GADKGNIOOMP, List<CNGBCLDDJEF> BMDHOAHLPCJ)
	{
		return null;
	}

	public bool UngroupModify()
	{
		return false;
	}

	public float GetAfterStepScale(float PFJFADHEJLJ, Axis IIICFBLMKGC)
	{
		return 0f;
	}

	public float GetValidScale(float PFJFADHEJLJ, Axis IIICFBLMKGC)
	{
		return 0f;
	}

	public float GetValidPosition(float PFJFADHEJLJ, Axis IIICFBLMKGC)
	{
		return 0f;
	}

	public bool CheckCameraPosValid(Vector3 HDFILHFDBKB)
	{
		return false;
	}

	public bool CheckHitUi(Vector2 HDFILHFDBKB)
	{
		return false;
	}

	private bool LMCDDFOOFDJ(Vector2 HDFILHFDBKB)
	{
		return false;
	}

	public bool IsSelected(SceneEditObjectBase JBCDHLNHGIH)
	{
		return false;
	}

	public bool IsHierarchySelected(SceneEditObjectBase JBCDHLNHGIH)
	{
		return false;
	}

	public void SelectTemp(SceneEditObjectBase JBCDHLNHGIH)
	{
	}

	public void DeselectTemp(bool DAPBCAPBHKG = true)
	{
	}

	public void DeselectAll(bool CCKOMJBNMNE = true, bool NFEMHCKDKOB = true)
	{
	}

	public void DeselectCurObj(bool NFEMHCKDKOB = true)
	{
	}

	public void DeselectObj(SceneEditObjectBase JBCDHLNHGIH, bool CCKOMJBNMNE = true, bool NFEMHCKDKOB = true)
	{
	}

	public void SelectObj(SceneEditObjectBase JBCDHLNHGIH, bool NFEMHCKDKOB = true)
	{
	}

	public void RefreshSelectionVisuals()
	{
	}

	private void OnDestroy()
	{
	}

	private void AJFABHKPLPF()
	{
	}

	private void KODKCICLIHK()
	{
	}

	public void UpdateDrivenModify()
	{
	}

	public void UpdateModifyPlaceable()
	{
	}

	private SceneEditObjectBase HKOHEFDAHBG()
	{
		return null;
	}

	public void UpdateSelect()
	{
	}

	private void JJPKJEAPLLP()
	{
	}

	public void UpdateAimSelect()
	{
	}

	private void JJGAJBFPAKP()
	{
	}

	public ItemEditAttributeBaseConfig CheckAndGetItemAttributeConfig(SceneEditPrefabConfigData BADFNAKNAJD)
	{
		return null;
	}

	public List<ItemEditAttributeUIData> CheckAndGetItemAttributeUIData(uint GEHJJDLAGJJ, ItemEditAttributeBaseConfig JNBJLMAKHFG)
	{
		return null;
	}

	public void RefreshCurEditObjectAttributeData(SceneEditPrefabConfigData BADFNAKNAJD, SceneEditObjectBase FIEEMJKGBHB = null)
	{
	}

	public ItemFunctionAttributeBaseConfig CheckAndGetItemFuncAttributeConfig(SceneEditPrefabConfigData BADFNAKNAJD)
	{
		return null;
	}

	public NIMFEJFJHPP AddSceneEditObj(SceneEditPrefabConfigData JCONDDPFBKK, List<CNGBCLDDJEF> BMDHOAHLPCJ, Vector3 HDFILHFDBKB = default(Vector3), Vector3 IPKKCHLDJMA = default(Vector3), Vector3 GLPLIHEECAP = default(Vector3))
	{
		return null;
	}

	public SceneEditObjectBase CreateSceneEditObj(SceneEditPrefabConfigData BADFNAKNAJD, Vector3 HDFILHFDBKB = default(Vector3), Vector3 IPKKCHLDJMA = default(Vector3), bool CNLGGCHBNLL = true, bool IFFMEBIEPAF = true, bool HFOJCEEFOEI = true)
	{
		return null;
	}

	public void RemoveCrosshair(SceneEditObjectBase JBCDHLNHGIH)
	{
	}

	public void ApplyScaleConfigAfterCreateSceneEditObject(SceneEditObjectBase FIEEMJKGBHB, SceneEditPrefabConfigData BADFNAKNAJD)
	{
	}

	public void CancelEdit()
	{
	}

	public void ConfirmEdit()
	{
	}

	public void EnterAddTemplate(KCJDEKIJAKH HDNAALELHPA, GNHAFLDPNJI IFJNLFAOMJH, EUGCAssetProviderType CCNBNLAPJFM)
	{
	}

	public void AddTemplate(KCJDEKIJAKH HDNAALELHPA, EUGCAssetProviderType CCNBNLAPJFM)
	{
	}

	public void EnterAddPrefab(SceneEditPrefabConfigData BADFNAKNAJD, bool JIAJPGAPHDO = false, bool LFDKAJCEHAC = false)
	{
	}

	public void AddPrefab(SceneEditPrefabConfigData BADFNAKNAJD, bool ONJDDAGFGFF = false, bool LFDKAJCEHAC = false)
	{
	}

	public void OnCrosshairScaleChanged()
	{
	}

	public bool CheckAndConfirmAdd()
	{
		return false;
	}

	public void ConfirmAdd()
	{
	}

	public void CancelAdd()
	{
	}

	public void EnterOperate(bool KFFPHKCHBDB = true)
	{
	}

	public void ConfirmOperate()
	{
	}

	public void CancelOperate()
	{
	}

	public void EnterModify(bool GBGBNLDGGJH = false)
	{
	}

	public bool CheckSelectedValid()
	{
		return false;
	}

	public bool CheckAndConfirmModify()
	{
		return false;
	}

	private void OGIMIGNONIG()
	{
	}

	public void CancelModify()
	{
	}

	public void ChangeScaleType(SceneEditObjectBase.LMOFHMAFDPP CCNBNLAPJFM)
	{
	}

	private void KLEKHAIDJDF(SceneEditObjectBase JBCDHLNHGIH)
	{
	}

	public void SetGizmoType(TransformType CCNBNLAPJFM)
	{
	}

	private IEnumerator PLGFMHLNNEH(float IFDHHGECCCM)
	{
		return null;
	}

	public void OnAdjustFloorPlaneMove(bool OMHMKPNMMAM)
	{
	}

	public void OnAdjustFloorPlane(float IHOCAAPJJBG)
	{
	}

	public List<ItemEditAttributeCacheValueBase> GenItemEditAttributeCacheValue(SceneEditPrefabConfigData BADFNAKNAJD, SceneEditObjectBase BPKPPPJCCHI = null)
	{
		return null;
	}

	public void NotifyItemAttributeChanged()
	{
	}

	private void IPJGDJJFBLF(SceneEditObjectAttrBase HBLGDCAJGJE, SceneEditPrefabConfigData BADFNAKNAJD)
	{
	}

	private bool OBICKCKHAOC(SceneEditObjectBase JBCDHLNHGIH)
	{
		return false;
	}

	public void OnModifyBtnDuplicate()
	{
	}

	private void CGMHMBOOPKM()
	{
	}

	private SceneEditObjectBase NGHIHBGEAKM(SceneEditObjectBase GHELIDCBMPH, SceneEditObjectBase FKODMCNOBDM)
	{
		return null;
	}

	public void DeleteSelectedObj()
	{
	}

	public void DeleteSceneEditObj(SceneEditObjectBase JBCDHLNHGIH, List<CNGBCLDDJEF> BMDHOAHLPCJ)
	{
	}

	public void RemoveSceneEditObj(SceneEditObjectBase JBCDHLNHGIH, List<CNGBCLDDJEF> BMDHOAHLPCJ, bool DJPJBGKKEPC = false)
	{
	}

	public void SwitchResMgrMode(bool MIBHDOJIHJE, bool FGEFHGALKCC = false)
	{
	}

	public void UpdateGridLine()
	{
	}

	public void UpdateSnapGridState()
	{
	}

	public void ChangeEditMode(MKHKEEJECEH GGAOKBAMALB)
	{
	}

	public void SetAgentCameraMode(BJJBCNEJPEF GGAOKBAMALB)
	{
	}

	public void ChangeCameraProjection(DEEMJPOOMMK NJMJMPLCCOM)
	{
	}

	private bool LKKEEDAJDNE()
	{
		return false;
	}

	public void KeepCamTran()
	{
	}

	public void NotifyFPVCamTran()
	{
	}

	public void CacheTransform()
	{
	}

	public void RevertTransform()
	{
	}

	public void OnSceneEditObjectPicked(SceneEditObjectBase HACIJIFIDKM)
	{
	}

	public void MarkUIConfigDataDirty(uint LIKPJDHGPFG)
	{
	}

	public void AddEntityAfterCreateSceneEditObject(SceneEditObjectBase JBCDHLNHGIH, SceneEditPrefabConfigData DKLKGHGFNCC, FSceneEditObjectData GPPCPDCBIBL = null)
	{
	}

	public SceneEditObjectBase GetCurFocusObject()
	{
		return null;
	}

	public void AddPlaneToRecorder()
	{
	}

	public void CreateGroupSceneEditObjectsAsync(int[] IAAJAJJPPAG, List<Vector3> GECAOGMINLL, List<Vector3> KHJGFPDJGPP)
	{
	}

	public void CreateAIGroupSceneEditObjectsAsync(List<JLFABCODABC> MNOKNECOMFA)
	{
	}

	public void StopAIGenerateCoroutine()
	{
	}

	private IEnumerator OIEOKMDGJMK(int[] HNIDEKPIBNC, List<Vector3> GECAOGMINLL, List<Vector3> KHJGFPDJGPP = null, List<Vector3> OADKLOPNOGL = null)
	{
		return null;
	}

	private IEnumerator MNIHPKCGMOF(List<JLFABCODABC> MNOKNECOMFA)
	{
		return null;
	}

	private void EJNDOFKFIBK(bool CHDFFDMBMEL)
	{
	}

	private void PILDIJACJOH()
	{
	}

	private void DOGDHPNMCCM()
	{
	}

	private void LKAOMBDIBAD()
	{
	}

	private void AMJGMFAKJAF()
	{
	}

	private UGCTutorialRestrictionManager MKNNPJECKPN()
	{
		return null;
	}

	private void JDLIFMMGCMG()
	{
	}

	private void DFANCDIOCDE()
	{
	}

	public void ProcessFPV()
	{
	}

	public void SetInputEnable(bool GPFPIAMCEMI)
	{
	}

	private void GMJBBLKJJBM()
	{
	}

	public void CameraLookAt()
	{
	}

	public void CameraLookAt(Vector3 MNBPEEDKIAD)
	{
	}

	public void CameraFocus(SceneEditObjectBase HACIJIFIDKM)
	{
	}

	public void ResetAgentRotation()
	{
	}

	public Quaternion GetCameraTrackableEntityAimRotation()
	{
		return default(Quaternion);
	}

	public Vector3 GetCameraTrackableEntityPosition()
	{
		return default(Vector3);
	}

	public Vector3 GetCameraTrackableEntityTopPosition()
	{
		return default(Vector3);
	}

	public Transform GetCameraTrackableEntityTransfrom()
	{
		return null;
	}

	public bool IsCameraTrackableEntityAlive()
	{
		return false;
	}

	public float GetAgentHeightOrSizeRatio()
	{
		return 0f;
	}

	private IEnumerator ODLEFOJEAAG()
	{
		return null;
	}

	public void SetAgentHeightOrSizeRatio(float GOMNGFFGLKD)
	{
	}

	private void AAJBLNPFLOB()
	{
	}
}
