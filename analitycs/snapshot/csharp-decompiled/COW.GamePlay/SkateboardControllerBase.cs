using System;
using GCommon;
using GCommon.Audio;
using UnityEngine;

namespace COW.GamePlay;

internal abstract class SkateboardControllerBase : Entity, KIFFPOOEIOF, MOOLACGHPHJ
{
	public Player Owner;

	protected JJLCALJHHDF KGAIBJFMLOB;

	protected bool PCGEHPPPAGM;

	protected float POBHLBCOHAE;

	public Rigidbody RigidBody;

	public Transform PlayerPos;

	public StatedTaggedTriggerDelegator WaterOrShoalDelegator;

	public InRoomDelegator EnterRoomDelegator;

	public GameObject[] LocalPlayerOnly;

	private bool _003CJJBONLJNBGK_003Ek__BackingField;

	public float MaxSpeed;

	protected GameObject LPDAKJEEKLE;

	protected Transform FMDDPCAAMNK;

	protected Transform JCLMIKBKPMG;

	private VisualInstanceHolder PKPMICCKHMG;

	private VisualInstanceHolder DGMNCKJCCND;

	private bool EOCKNADJPBE;

	private uint ODFIJNNFIAC;

	private uint ADDEDGOHHML;

	private readonly AudioPlaybackParams_Unity FIGKMNCINAJ;

	private float OIMMKONLHKO;

	private bool _003CBOJFOAHJPEG_003Ek__BackingField;

	private bool _003CEIPIOGMJNGD_003Ek__BackingField;

	private const ForceMode APKHDIPAMOF = ForceMode.VelocityChange;

	public bool OCIJCPDJBEF
	{
		get
		{
			return false;
		}
		protected set
		{
		}
	}

	public abstract bool NJHEMAJLAMM { get; }

	public bool DAOAFMGLPLH => false;

	public bool PIBPEAPFGKF
	{
		get
		{
			return false;
		}
		protected set
		{
		}
	}

	public bool FBPGEMJCEHD
	{
		get
		{
			return false;
		}
		protected set
		{
		}
	}

	public Action CPINEHCNEMJ
	{
		set
		{
		}
	}

	public Action CBCCGIKPIHN
	{
		set
		{
		}
	}

	public bool OPOHJPCHEJH => false;

	public virtual Vector3 GetVelocity()
	{
		return default(Vector3);
	}

	public virtual void Init(JJLCALJHHDF JCONDDPFBKK, Transform HCFDIIDBPAJ, bool DCAPIHJMMBL)
	{
	}

	public virtual void OnGetOn(Player KDJNEHDAAFL)
	{
	}

	public virtual void OnGetOff(Player KDJNEHDAAFL)
	{
	}

	protected void NDHHAMKGAAM(Player KDJNEHDAAFL, Transform FKODMCNOBDM)
	{
	}

	protected void OAEGFBEDLON(Player KDJNEHDAAFL)
	{
	}

	public void SetVisible(bool OGECPGHMIHA)
	{
	}

	public virtual void Jump()
	{
	}

	public virtual void StopJump()
	{
	}

	public virtual void Dash()
	{
	}

	public virtual void StopDash()
	{
	}

	public abstract void ApplyAxisControl(Vector3 AJMKJNOFBKK);

	public abstract bool DriverHasInput();

	public override void OnFixedUpdate(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	protected virtual void KCIJAGPLLNP(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	protected virtual void IHBNKFGODGJ(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	public override void OnUpdate(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	protected virtual void JIMBCHCEGOO(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	protected virtual void HJDMKIKNJBG(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	public virtual void OnForceSync(Vector3 NJEIPFFBIPK)
	{
	}

	protected void PHOFLEOGOKM()
	{
	}

	protected void KINGLELKAAI()
	{
	}

	protected void DBJCMAHBCJM()
	{
	}

	protected void HAIAPNDMEBB(ref VisualInstanceHolder IDMFJBFINDH, Transform FBNOHACOEGK, ResourceID AOFCDPKJKJO, bool KMIAINMMKDN)
	{
	}

	protected bool IJALAMAKGLN()
	{
		return false;
	}

	protected void ENDAPIOGJNA()
	{
	}

	protected void PKJIJOMOCMH()
	{
	}

	protected void NKGHHHPLMLL()
	{
	}

	protected void BJKLINBIOEA()
	{
	}

	protected void IAEMMPKOFBJ(ResourceID AOFCDPKJKJO)
	{
	}

	public void _003C_003EiFixBaseProxy_OnFixedUpdate(float P0, float P1)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUpdate(float P0, float P1)
	{
	}
}
