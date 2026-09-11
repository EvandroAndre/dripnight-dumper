using GCommon;
using UnityEngine;

namespace COW.GamePlay;

public class LevelArcShield : BaseLevelObject
{
	private enum JJDNAECPMPH
	{
		DoNothingWhenFire,
		DestroyWhenFire,
		HideWhenFire
	}

	public BoxCollider AnyBoxCollider;

	private MMOMNDBFKAC IGPICOFLFBB;

	private PhyXShield OCAGKICHOMI;

	private byte JJPKANONOGL;

	private uint KEJOLKCHCJP;

	public GameObject ColliderObject;

	public Transform Model;

	private ArcShieldModelComponent AIINFILDFFM;

	private float PFPCFEHCCDD;

	private ushort _003CIOFPMKEKIDF_003Ek__BackingField;

	private ushort _003CFDMDPBDNIBB_003Ek__BackingField;

	private ushort _003CMALICHCJIOI_003Ek__BackingField;

	private float NKBFCDHOJJA;

	private bool JEFHMDOKNME;

	private EntityVisualEffectManager GDFJDDKCPMN;

	private bool BACLBMEBNHH;

	private Vector3 MOFHGGNONMF;

	public ushort HDFCNPJDFDE
	{
		get
		{
			return 0;
		}
		private set
		{
		}
	}

	public ushort IOGONNLBJMO
	{
		get
		{
			return 0;
		}
		private set
		{
		}
	}

	public ushort MNLAGBIHLDD
	{
		get
		{
			return 0;
		}
		private set
		{
		}
	}

	protected override string GetObjectTag()
	{
		return null;
	}

	protected override int GetMaxRepDataCount()
	{
		return 0;
	}

	protected override void UnRegisterEntity()
	{
	}

	protected override void OnUserDefineReplicationInfo()
	{
	}

	public static LevelArcShield CreateShield(uint ONFPCIABJJC, uint IMEAIDCGEFD, uint CPDCONFICBP, byte EJMOHKMIPIB, ushort ICNLDNANPLL, ushort IJFOOEENBBG, byte OEOKLGFPLDC, float HBDABCBCKFC, float GLPLIHEECAP)
	{
		return null;
	}

	private void PDPAAFOHDNK()
	{
	}

	private void INKNBKKOHHK()
	{
	}

	private void AECEBACPCPB()
	{
	}

	private void EIKOGHLIJKO()
	{
	}

	public void DestroyShield()
	{
	}

	public override void OnRecycle()
	{
	}

	public override bool Recycle()
	{
		return false;
	}

	public override void OnUpdate(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	public void Init(uint CPDCONFICBP, byte EJMOHKMIPIB, ushort ICNLDNANPLL, ushort IJFOOEENBBG, byte OEOKLGFPLDC, float HBDABCBCKFC, float GLPLIHEECAP)
	{
	}

	private void DHCMMOLJAPA()
	{
	}

	private void AIAHKFACPLC()
	{
	}

	private void GMILMKEKMOJ()
	{
	}

	private void KFOLHOPJBAC(ushort OJEPOBEENEK, ushort EIOKHLKJEEL)
	{
	}

	private void MIGHBGKPCAJ(bool OJEPOBEENEK, bool EIOKHLKJEEL)
	{
	}

	private void ALLOHNNGPDP()
	{
	}

	protected override void OnOnDestroy()
	{
	}

	private void CCBEMAIKPFA()
	{
	}

	private void NLFICCHGJAA()
	{
	}

	private EntityVisualEffectManager MMNGNEJFCGP()
	{
		return null;
	}

	protected override void OnUpdateVisibleStateByStreamer(Vector3 MHAAFMCMHAC, Vector3 PAFBAHJAAGC)
	{
	}

	private void FNHECJEMNCB()
	{
	}

	private void JNJADANLFCI()
	{
	}

	private void PIKEKLEIJEF()
	{
	}

	private void IDHBKKFMLIP()
	{
	}

	private void LDEMJDNHMEE(uint JDHNCLHNJIP, ResourceID JMIMKLAELHE, GameObject IBDNJDLJPDG)
	{
	}

	public void OnShieldDestroyVisual()
	{
	}

	public int _003C_003EiFixBaseProxy_GetMaxRepDataCount()
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_UnRegisterEntity()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUserDefineReplicationInfo()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnRecycle()
	{
	}

	public new bool _003C_003EiFixBaseProxy_Recycle()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUpdate(float P0, float P1)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnOnDestroy()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUpdateVisibleStateByStreamer(Vector3 P0, Vector3 P1)
	{
	}
}
