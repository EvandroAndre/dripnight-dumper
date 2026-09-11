using UnityEngine;
using message;

namespace COW.GamePlay;

public class LevelObjectInstrument : BaseLevelObject
{
	public enum FCOOMPJBHHD
	{
		Create,
		Use,
		FirstUse
	}

	public TweenRotation m_Rotation;

	public GameObject m_GlowVfx;

	public Transform m_FlyRoot;

	public GameObject m_BightVfx;

	private GameObject LNBNJGLJCLG;

	private bool LNJOAPBJLMM;

	private bool GFGGPEAHAAA;

	private uint JGIGKOCJPMP;

	private uint PDJHCMFKHBJ;

	private uint KCLLMIMGBLK;

	private const string OENLGCCJJDO = "VFX_SixthPrism";

	private const string CGDCKIINNMN = "SOUND_GAMEMISSION_PRISMUSED";

	private FEKBCHODFLE GELFGDBLHDE;

	protected override string GetObjectTag()
	{
		return null;
	}

	protected override void OnStart()
	{
	}

	public override void SyncAction(object[] DJAPBCKDFKA)
	{
	}

	public override void DoAction(object[] DJAPBCKDFKA)
	{
	}

	protected override void OnOnDestroy()
	{
	}

	public DCNKCHPIMAB GetCurrentState()
	{
		return DCNKCHPIMAB.ELEVELINSTRUMENT_STATE_IDLE;
	}

	protected override void OnUserDefineReplicationInfo()
	{
	}

	protected override int GetMaxRepDataCount()
	{
		return 0;
	}

	private void LNPFBIKECBO()
	{
	}

	private void BMPOEMJNKEJ(byte OJEPOBEENEK, byte EIOKHLKJEEL)
	{
	}

	private void OLBOPJBAELJ(KOHPOCGIPCL NBLHNPAHGNA)
	{
	}

	private void OCODKPHJCPH(GIGMHBMJOFE NBLHNPAHGNA)
	{
	}

	private void NGKKEECNDJN()
	{
	}

	private void DCCGPIOGJPG()
	{
	}

	public override void OnRecycle()
	{
	}

	public override bool Recycle()
	{
		return false;
	}

	private void NEIPHNKAELF(uint GGAOIPIHOBP, bool BBPCHCNOECP, Object HACIJIFIDKM)
	{
	}

	private void KLDIGKDIFAJ(GameObject CLACOPMJHDI)
	{
	}

	private void CNHKJFOIELC()
	{
	}

	private void HFJHCLLJJAF()
	{
	}

	public bool HasCurrentPlayerUsed()
	{
		return false;
	}

	public bool HasUsed()
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OnStart()
	{
	}

	public void _003C_003EiFixBaseProxy_SyncAction(object[] P0)
	{
	}

	public void _003C_003EiFixBaseProxy_DoAction(object[] P0)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnOnDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUserDefineReplicationInfo()
	{
	}

	public int _003C_003EiFixBaseProxy_GetMaxRepDataCount()
	{
		return 0;
	}

	public new void _003C_003EiFixBaseProxy_OnRecycle()
	{
	}

	public new bool _003C_003EiFixBaseProxy_Recycle()
	{
		return false;
	}
}
