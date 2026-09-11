using GCommon;
using UnityEngine;

namespace COW.GamePlay;

public class LevelBaseDrum : BaseAutoGenIDLevelObject
{
	public enum NLNIACDLBGF
	{
		None,
		OilDrum,
		SmokeDrum,
		EasterEggDrum,
		ShootingTargetDrum,
		FloatingLandColorDrum,
		CyberMushroom
	}

	private OilDrums OCEFGOOBKIO;

	protected BitArrayBoolean CNELANECFHO;

	protected uint GAEOMJBIMDP;

	protected const uint KJNBKBPNNAD = 1u;

	protected new const uint GCKMBDPLDHP = 2u;

	private VisualInstanceHolder PKNNEBIEAOF;

	protected override void OnAwake()
	{
	}

	protected override void OnStart()
	{
	}

	public virtual int GetMaxDurability()
	{
		return 0;
	}

	public virtual ResourceID GetModelResourceID()
	{
		return default(ResourceID);
	}

	public virtual ResourceID GetDamagedEffect()
	{
		return default(ResourceID);
	}

	public virtual ResourceID GetExplodeEffect()
	{
		return default(ResourceID);
	}

	public virtual ResourceID GetExplodeSound()
	{
		return default(ResourceID);
	}

	public virtual NLNIACDLBGF OilDrumType()
	{
		return NLNIACDLBGF.None;
	}

	public virtual float GetEffectTime()
	{
		return 0f;
	}

	public virtual float GetBrokenEffectDurationSecs()
	{
		return 0f;
	}

	public virtual void OnDrumBroken(uint DLNJGACCOCL, uint KIJMNGPDLCO = 0u)
	{
	}

	protected override int GetMaxRepDataCount()
	{
		return 0;
	}

	protected override void OnUserDefineReplicationInfo()
	{
	}

	public float GetRadius()
	{
		return 0f;
	}

	public float GetEffectScale()
	{
		return 0f;
	}

	public bool SetHP(int JHLNMNMLGPB)
	{
		return false;
	}

	protected virtual void HIMIPPBFODF(byte OJEPOBEENEK, byte EIOKHLKJEEL)
	{
	}

	public override void OnUpdate(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	protected override void OnUpdateVisibleStateByStreamer(Vector3 MHAAFMCMHAC, Vector3 PAFBAHJAAGC)
	{
	}

	private void FMKIDEAAMLE()
	{
	}

	public virtual void AttachDrumModel()
	{
	}

	private void GEOMCBIBOHA()
	{
	}

	public void OnModelAttached(GameObject CLACOPMJHDI)
	{
	}

	public void OnModelDetached()
	{
	}

	public bool CanBeUsed()
	{
		return false;
	}

	public override void DoAction(object[] DJAPBCKDFKA)
	{
	}

	protected override string GetObjectTag()
	{
		return null;
	}

	public uint GetLifeTimeMs()
	{
		return 0u;
	}

	public virtual ResourceID GetVFXAutoExplodeResID()
	{
		return default(ResourceID);
	}

	public virtual ResourceID GetVFXDyingResID()
	{
		return default(ResourceID);
	}

	public virtual float GetDyingTime()
	{
		return 0f;
	}

	public virtual void OnBroken()
	{
	}

	private void JGIBIAJGFFE(GameObject CLACOPMJHDI)
	{
	}

	public void _003C_003EiFixBaseProxy_OnAwake()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnStart()
	{
	}

	public int _003C_003EiFixBaseProxy_GetMaxRepDataCount()
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_OnUserDefineReplicationInfo()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUpdate(float P0, float P1)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUpdateVisibleStateByStreamer(Vector3 P0, Vector3 P1)
	{
	}

	public void _003C_003EiFixBaseProxy_DoAction(object[] P0)
	{
	}

	public string _003C_003EiFixBaseProxy_GetObjectTag()
	{
		return null;
	}
}
