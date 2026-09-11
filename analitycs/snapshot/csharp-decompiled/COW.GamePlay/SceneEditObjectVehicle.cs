using COW.GamePlay.UGCRuntime;

namespace COW.GamePlay;

public class SceneEditObjectVehicle : SceneEditObjectAttrBase
{
	public float EngineTorque;

	public float BrakeTorque;

	public float HighSpeedSteerAngle;

	public float HighSpeedSteerAngleAtspeed;

	public float MaxSpeed;

	public float IdleBrakeInput;

	public float CrashMessFactor;

	public float CrashMaxSpeed;

	public float CrashMinDamage;

	public float CrashMaxDamage;

	public float ExplodeDelay;

	public float ExplodeRange;

	public int ExplodeDamage;

	public float BurnTime;

	public int BurnDamage;

	public float BurnInterval;

	public int HP;

	public float GearShiftingDelay;

	protected uint EHMLIJNOMGP;

	protected uint LMHDNCFLIIP;

	protected uint NPHKMACOFMD;

	protected uint NINIEBLJPMO;

	protected string LKDBNFJDJNK;

	protected virtual void Awake()
	{
	}

	public override void ApplyDataStoreToSceneEditObj(long DLMGDEAFLHD, UGCSimpleValue GPFPIAMCEMI, bool ODIKHPAIHNM = true)
	{
	}

	public void _003C_003EiFixBaseProxy_ApplyDataStoreToSceneEditObj(long P0, UGCSimpleValue P1, bool P2)
	{
	}
}
