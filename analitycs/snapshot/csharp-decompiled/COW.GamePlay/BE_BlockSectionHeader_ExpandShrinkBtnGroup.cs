using COW.Gameplay.UGC.BlockEdit;
using UnityEngine;

namespace COW.GamePlay;

public class BE_BlockSectionHeader_ExpandShrinkBtnGroup : MonoBehaviour, JINIKKACLOC
{
	public enum CMAMEHNFEGH
	{
		HideAll,
		ShowExpandOnly,
		ShowShrinkOnly,
		ShowAll
	}

	public UIButton AddBtn;

	public UIButton DelBtn;

	public UIWidget AddBtnWidget;

	public UIWidget DelBtnWidget;

	public UISprite AddIcon;

	public UISprite DelIcon;

	private CMAMEHNFEGH IOFFHHGNFON;

	private UIWidget DPAPBCMAJMO;

	private BE_DataBlock IOFGNFNCLFP;

	private OEHCJLCDDIE BIGKACGKLHO;

	private Transform PMKEBIPFHFI;

	private int NPMOJIDCPBF;

	private int CGJEBPAMCII;

	private int DONEPGJDLFB;

	private int JPCKOKKFLPH;

	private Vector3 HLJICHCAGAD;

	private Vector3 HJPBCPFAJDI;

	private BlockData BMEKHBBBHPC;

	public CMAMEHNFEGH IMBDICDCAAN => CMAMEHNFEGH.HideAll;

	public UIWidget PICONKICOIL => null;

	public BE_DataBlock FHIHMBIIDKO
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public BE_ProcessBlock MONFFKHMKOM => null;

	public OEHCJLCDDIE MFFOEFMNKLA
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public Transform PCLGHFLMICA => null;

	Vector2 JINIKKACLOC.DKGDEOLICEI => default(Vector2);

	public ValueData JBPMMFDNCCN
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public BlockData FDEPPEODEAN => null;

	public BodyData MPEFPBPMMJE => null;

	private BE_BodyBlock LHKDHLIBLII => null;

	private int GBEPFLGDGMN => 0;

	private void Awake()
	{
	}

	public void SetValue(string GPFPIAMCEMI)
	{
	}

	public void UpdateDepth(int HOEICAABLAP = 1)
	{
	}

	public void Init(BlockData POANKHIAKCN)
	{
	}

	public void UpdateState()
	{
	}

	public CMAMEHNFEGH CalculateState(BlockData POANKHIAKCN)
	{
		return CMAMEHNFEGH.HideAll;
	}

	public void SetState(CMAMEHNFEGH CBCAJJJCKLH)
	{
	}

	private void AHHHABPHHEI()
	{
	}

	private void JDAFPJBFKKE()
	{
	}

	private bool DCAJOGCFLJK(ValueData LABNPBJKCDN, BlockEditMacroCommand DILLOMAPNIL)
	{
		return false;
	}

	private bool FMCNIHIOMLE(ValueData LABNPBJKCDN, BlockEditMacroCommand DILLOMAPNIL)
	{
		return false;
	}
}
