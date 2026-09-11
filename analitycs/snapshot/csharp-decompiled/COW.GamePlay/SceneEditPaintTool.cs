using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW.GamePlay;

public class SceneEditPaintTool : MonoBehaviour
{
	public enum AGDLPAPNDME
	{
		Basic,
		Cloud,
		Race
	}

	public enum JEGJLFACAID
	{
		Official,
		Customize
	}

	public enum KNAOHIHOAJD
	{
		Single,
		Multiple
	}

	public enum MDONBOGAEPH
	{
		Pending,
		Before,
		Painting,
		AfterPainting,
		Generating,
		Generated
	}

	public enum NFKAPLFNBAD
	{
		Solid,
		Hollow
	}

	public enum IPBBFIHNGOI
	{
		None,
		Square,
		Triangle,
		Circle,
		Custom
	}

	public enum KPIFDHNOJHD
	{
		Preview1,
		Preview2
	}

	private sealed class BPMONFHODNC
	{
		public int LIKPJDHGPFG;

		internal bool FIMEJKBNFJL(int FADOEDJHAGD)
		{
			return false;
		}
	}

	private sealed class EKJBHCCGACN
	{
		public int LIKPJDHGPFG;

		internal bool MJDGHEHAEGA(int FADOEDJHAGD)
		{
			return false;
		}
	}

	private Camera CNMDPPGAALA;

	private UISceneEditGameScene KKOJLHGDDEN;

	private SceneEditAgent MCKAIJDKEJP;

	private UIHudNewSceneEditItemPanelController ELABEMBMABN;

	private static readonly string EPBMIHABILO;

	public Color LassoPolyColor;

	public Color GridLineColor;

	public Color GridPointColor;

	public Color LineColor;

	private const int DCDGHHOFHBO = 10;

	private bool FCNHOEFJDMB;

	private DEHKNJOKJEA OBIBFJPDIEF;

	private ODIKGGABAKM HCGBBGIEFPJ;

	private AGDLPAPNDME AFCKAONNCHN;

	private JEGJLFACAID AGFANFHDKGG;

	private KNAOHIHOAJD CDNLELMCLCF;

	private NFKAPLFNBAD IBIJLFJFMKK;

	private IPBBFIHNGOI CHMMNOMFDFC;

	private MDONBOGAEPH KDNBLLMNOMK;

	public float INTERVAL_MAX;

	private float HHJEBNEMCMN;

	private float COONGFIMHHP;

	private int JHHENPICJHE;

	private int MJKOIIPFIHK;

	private List<int> FGFFBGBCMJI;

	private int BJBOEDNDMBP;

	public KPIFDHNOJHD mCurPreviewIndex;

	private SceneEditObjectBase PMBLKELHMBK;

	private SceneEditObjectBase AOJFMJJHJFP;

	private UIHudSceneEditPaintPanelController EJLLHMDNHOB;

	private Vector3 BOMOCKGPJJG;

	private int MEILJKMKAOJ;

	private List<Vector3> GDJCPAPLHEH;

	private List<Vector2> OPINGHGHMNO;

	private readonly List<Vector3> EDIFEGNIKHO;

	private readonly List<Vector3> KPPDLMMFGBM;

	private readonly List<Vector3> MBDLNPMJNIP;

	public bool AutoAdjustInterval;

	private Dictionary<int, Bounds> HIJNHKOLFKK;

	public bool mRefresh;

	private List<Vector3> BMOBMMBIBII;

	private List<Vector2> DNEDPGINCJK;

	private Plane IHDFABGPFPO;

	private bool FPBOIIABCDN;

	private bool NKJJPOOONPD;

	private Vector3 ILEJLBHHOJO;

	private bool HIMEIPPGOCA;

	private Vector3 JCLECPGPHCM;

	private float IBKFCOKOMPL;

	private bool EMNPEOMNEJI;

	private float KPIGGNELJJB;

	private bool EKGAEAMCNIP;

	private List<JLFABCODABC> PHFHLEGOPCH;

	private bool FFLLMNBLPMG;

	private uint OMOMOAAONPJ;

	private uint PDCJCIEHGIJ;

	private Camera PDKBCPOIPKK => null;

	private UISceneEditGameScene FLJLOCJKDCN => null;

	private SceneEditAgent BCCMOEBJDBL => null;

	private UIHudNewSceneEditItemPanelController FIHALDPFHMA => null;

	public bool EBOMFHEOPLL
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private DEHKNJOKJEA KCKJKCGMGNK => null;

	private ODIKGGABAKM PHPBICONJPA => null;

	public AGDLPAPNDME IJEHABFGEMD
	{
		get
		{
			return AGDLPAPNDME.Basic;
		}
		set
		{
		}
	}

	public JEGJLFACAID HKMOJKNLIKO
	{
		get
		{
			return JEGJLFACAID.Official;
		}
		set
		{
		}
	}

	public KNAOHIHOAJD PBGGLKGLCOC
	{
		get
		{
			return KNAOHIHOAJD.Single;
		}
		set
		{
		}
	}

	public NFKAPLFNBAD MNLIFAKDBPC
	{
		get
		{
			return NFKAPLFNBAD.Solid;
		}
		set
		{
		}
	}

	public IPBBFIHNGOI NLAIFALPNKP
	{
		get
		{
			return IPBBFIHNGOI.None;
		}
		set
		{
		}
	}

	public MDONBOGAEPH OLIMKEJAICP
	{
		get
		{
			return MDONBOGAEPH.Pending;
		}
		set
		{
		}
	}

	public float OPDPAKGLIDP
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public float PLFHPEDAJCF
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	private float HNEDBLNJBMK => 0f;

	public List<int> MMEAJAHHCPL => null;

	public int GJOPOLJJFEO
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public KPIFDHNOJHD FCFJGAPMCDA
	{
		get
		{
			return KPIFDHNOJHD.Preview1;
		}
		set
		{
		}
	}

	private UIHudSceneEditPaintPanelController KFBHPOFFEFN => null;

	private List<Vector3> GLIJGEGPEJI => null;

	private List<Vector2> IOHANEKMAMH => null;

	public bool APKMDPLCADL
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool MIKGIGIIFBC
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private void Update()
	{
	}

	private void GDLNKKDIAAE()
	{
	}

	private void MGOFGBMGGBC()
	{
	}

	private void MHCPCKFKPCN()
	{
	}

	private void MMGOJJMMEKJ(Vector3 LOPJCNOKJDO)
	{
	}

	private void PDPDOFJLFCC()
	{
	}

	private void EFEOOAJEKAP()
	{
	}

	private void FPBDOBDCJME()
	{
	}

	private void LKMBDJGMDIE(Vector3 AOGGADPEFCC, Vector3 AGOPFPDMIBM)
	{
	}

	private void KFOBEAINLIA(Vector3 AOGGADPEFCC, Vector3 AGOPFPDMIBM)
	{
	}

	private void DGLBLOOBKMG(Vector3 AOGGADPEFCC, Vector3 AGOPFPDMIBM)
	{
	}

	private void BINJFHHNOHI(Vector3 AOGGADPEFCC, Vector3 AGOPFPDMIBM)
	{
	}

	private void PFKMFAPHNGH(bool ICEGCJMEHEA, List<Vector3> GOLHJNCNDKN)
	{
	}

	private void OFKGMKFOJOD(List<Vector3> GOLHJNCNDKN)
	{
	}

	private void BBGIBJBBKKA()
	{
	}

	private void LAHONFMLNBA()
	{
	}

	private void KHHIGLPHNLO(bool PGHCPGGHGEG)
	{
	}

	private void HPMHLAKEBPE(bool PNFCKIPOHBP = true)
	{
	}

	public void ChangeSelectItem(int LIKPJDHGPFG)
	{
	}

	public void AddSelectItem(int LIKPJDHGPFG)
	{
	}

	public void RemoveSelectItem(int LIKPJDHGPFG)
	{
	}

	public Bounds GetItemBounds(int LIKPJDHGPFG)
	{
		return default(Bounds);
	}

	private bool OIPJILIEEDI(int GEHJJDLAGJJ)
	{
		return false;
	}

	public void ConfirmGenerateItems()
	{
	}

	private void IAKLPDGOGAM(KPIFDHNOJHD OEPBFEIPGDO)
	{
	}

	private void FOBMMGDCCCM(bool MIBHDOJIHJE)
	{
	}

	private void OnDestroy()
	{
	}

	public void TryPaintPreview()
	{
	}

	public void OnAsyncCreateNormalPrefabFinished(GEvent JCONDDPFBKK)
	{
	}

	private void EGBFNHACABP()
	{
	}

	private void COLBECGNNJB()
	{
	}

	private void LNFJKBEGHJK()
	{
	}

	private void JBDMBEHIFDC()
	{
	}

	private void GDPNGIILBIJ()
	{
	}

	private void DJJALDOFOMH()
	{
	}

	public void OnPaintModeChange()
	{
	}

	private void BBCAGHLHMPC()
	{
	}

	private void KJKJGNHIJNL(Vector3 HCPPKIHKCEP)
	{
	}

	private void CNNNOMAHIEF(List<Vector3> GOLHJNCNDKN)
	{
	}

	private void JOOGLBBILEE(int AOGGADPEFCC, int AGOPFPDMIBM)
	{
	}

	private int OOOADKCAHBE()
	{
		return 0;
	}

	private void NKCNAAJPJCM()
	{
	}

	public void CheckTouch()
	{
	}

	public bool CheckHitUi(Vector2 HDFILHFDBKB)
	{
		return false;
	}

	private bool BDBBLAFPEJD(Vector3 OCLFLNINDAP, ref Vector3 AFNNMPBCDCG)
	{
		return false;
	}

	public void InitRefreshCnt()
	{
	}

	public void RegisterRefreshCount()
	{
	}

	private void GJMLNEGDIMC()
	{
	}

	private void MKOKKLEBFOC()
	{
	}

	private void KGIJHANKGFB(HttpErrorCode JJLCPPNJDFG, object KABBEEIIANB)
	{
	}
}
