using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW.GamePlay;

internal class MountableAnimal : AmphibiousVehicle
{
	public Transform FrontPivot;

	public Transform BackPivot;

	public string[] DefaultSkinResourceNames;

	public float WalkMaxSpeedScale;

	public float InWaterMaxSpeedScale;

	public float FireMaxSpeedScale;

	public HorseParam horseParam;

	public float JumpTime;

	public float JumpMaxAngle;

	public float MinAirTimeToAllowJump;

	public float stopKeepLerpMove;

	public float keepMoveStateDuringIdle;

	public float Fix3pJumpVelFrame;

	private float MKDKKGDIAEE;

	public float PivotHeight;

	public float OffSetHeight;

	public float checkLandDeltaTime;

	public float CheckFallHeight;

	private MountableAnimalAnimator EPJICDJEIKN;

	public HorseObstacleAvoidance m_ObstacleAvoidance;

	private Transform ADGIBEIMNOD;

	private float ALJKDBDNKDB;

	private Queue<Vector3> LCNGKEIJNIE;

	private Vector3 IHMJLEICPKL;

	private Vector3 KPNNIBMDNJI;

	private Vector3 HKNCDMLBAGE;

	private bool BOMBMAIJNKE;

	private float PNKDEIEMACA;

	private static int HCDLGBKJABE;

	private readonly EntityVisualEffectManager EINPMFNJINA;

	private VisualInstanceHolder PKLOMAKDOHA;

	private GMPGMPFNMFP IDKDAHNCILH;

	private float ABBJMFDHEBA;

	private float NIEDPJCKIHG;

	private float KGHDEDEAHDG;

	public float SteerSmoothFactor;

	private float LDIHCPKGCCD;

	private Func<Collider, bool> IKPNOLBBEOD;

	public HorseColliderOpt horseColliderOpt;

	public CustomBounds[] m_CustomBounds;

	private bool DADLGICDAJG;

	private GameObject FPGLBIOJJHF;

	public float FNECECFELEF
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public override EControlMode JEKCMOCKMGF => EControlMode.Default;

	public override bool OCIJCPDJBEF => false;

	protected override void OnAwake()
	{
	}

	public override void ApplyVechileControl(FDDEPNLACNI JIHJLBFECCO, Vector3 PMIKOMKJPBF)
	{
	}

	private void ONIEDJGHJGP(FDDEPNLACNI JIHJLBFECCO, ref Vector3 PMIKOMKJPBF)
	{
	}

	private bool OFCJPAMMMFA()
	{
		return false;
	}

	private bool HILOEDNFLBI()
	{
		return false;
	}

	private bool LJNBBIKMGEF(Vector3 DEAHCLNMEJD)
	{
		return false;
	}

	private static bool DDJEIOBPLNC(Vector3 JHDJCOGLEJC, Vector3 DEAHCLNMEJD, float LJNDNHPGDCA, float ABDEKMCGPON, float MJIFGJPGLAM, int NDJPACKNMOG, float AIMBPFBNFFM, float DIOCMMEODHG, float GCDAMFHKKPO)
	{
		return false;
	}

	protected override void OFLJMNICLFH(JGMIBLONLLA GKKELMDDGBJ)
	{
	}

	public override void RequestAutoDrive(bool PIDINBNGILH)
	{
	}

	public override void StartAutoDrive()
	{
	}

	public override void SyncVehicleStable(bool BAGNKAKIOFJ)
	{
	}

	public override AnimationID GetAnimName()
	{
		return default(AnimationID);
	}

	protected override void BMMODHKDMFN(bool DCAPIHJMMBL)
	{
	}

	public override void SetEnterLevelTrigger(VehicleCollision NGGELGKKGBI, Collider GLJGHEAPBOF, bool PDEMMOBBACC)
	{
	}

	public override void SyncChangeShape(byte OGECPGHMIHA)
	{
	}

	public override void SetupCamera(VehicleDriverCamera NJMENHHJHCJ)
	{
	}

	public override bool SetSeat(int KEMBBPMADFD, BHGGAEEHJCO NDGDFMDIGLC)
	{
		return false;
	}

	protected override void EGHBAPLFLHO(VehicleSkinInfoBase HPAEPPLOBFN = null)
	{
	}

	private void PEAPCJAGMPP()
	{
	}

	protected override void HKNPLOJGOBM()
	{
	}

	protected override void HJADKDOENFI(Player PGEGMKJKOKI)
	{
	}

	public override string GetIconInMap()
	{
		return null;
	}

	public override string GetTeammateVehicleIcon()
	{
		return null;
	}

	public override void OnUpdate(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	private void MNLCGDNADEA()
	{
	}

	private void KOMEJLFLCPL()
	{
	}

	private void BJOOPFBBKPE(Vector3 GJDOFCCEIAC, float HOGHEFNINAE)
	{
	}

	public override void OnFixedUpdate(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	protected override void JGEEBJDNCOE()
	{
	}

	private bool EPMLDOFLCGF(Collider NPEMKNFIIHL)
	{
		return false;
	}

	protected Vector3 OKOPGIIBJNK(bool KKFOGIMLLAC = false)
	{
		return default(Vector3);
	}

	private bool KKCFFGOPLPH()
	{
		return false;
	}

	public override bool CanDriverFire()
	{
		return false;
	}

	public override void ForceBrake()
	{
	}

	private void ANLAONBCPLE(float HLOPPGIIGHC)
	{
	}

	public override void ForceStop(bool CNCDDJLLLHO = false)
	{
	}

	public override bool IsMoving()
	{
		return false;
	}

	public override void RemoveForDestroy(bool ODBECFEKBNJ)
	{
	}

	private void BMHGJOLGLNA()
	{
	}

	public override ResourceID GetDustResourceID()
	{
		return default(ResourceID);
	}

	public override ResourceID GetSpeedLineEffect()
	{
		return default(ResourceID);
	}

	protected override void GBDDGCMFHPP()
	{
	}

	protected override ResourceID NHLHLKPFCLD()
	{
		return default(ResourceID);
	}

	protected override void MOIICJGCEKN(Collision MKPLDLFKAIK)
	{
	}

	public void SetPilotMode(byte PNBCCLOBJPN, byte EIOKHLKJEEL)
	{
	}

	public override void RefreshIdleHoldWeaponAnim()
	{
	}

	private void NMICGDMFIGL()
	{
	}

	private uint PGLENLCEJCF(FDAEPHMIEPC PJMDKPKBBAM)
	{
		return 0u;
	}

	public override void RefreshHealState()
	{
	}

	public override ResourceID GetWeaponHitEffect()
	{
		return default(ResourceID);
	}

	public override ResourceID GetWeaponHitSound()
	{
		return default(ResourceID);
	}

	public override ResourceID GetHitSound()
	{
		return default(ResourceID);
	}

	protected override Bounds CEOKGMFFNCP(Transform HACIJIFIDKM, bool PCBKLELIOMM = false)
	{
		return default(Bounds);
	}

	public override bool CanIgnoreAimAssistBySkill()
	{
		return false;
	}

	protected override void JDNPKCJMLFK(bool OGECPGHMIHA)
	{
	}

	public override void PlayEffect(uint MGGNLEEAPEP)
	{
	}

	protected override bool IICNLIKFPCA()
	{
		return false;
	}

	public EControlMode _003C_003EiFixBaseProxy_get_ControlMode()
	{
		return EControlMode.Default;
	}

	public new void _003C_003EiFixBaseProxy_OnAwake()
	{
	}

	public new void _003C_003EiFixBaseProxy_ApplyVechileControl(FDDEPNLACNI P0, Vector3 P1)
	{
	}

	public bool _003C_003EiFixBaseProxy_get_IsJumping()
	{
		return false;
	}

	public new void _003C_003EiFixBaseProxy_OFLJMNICLFH(JGMIBLONLLA P0)
	{
	}

	public void _003C_003EiFixBaseProxy_RequestAutoDrive(bool P0)
	{
	}

	public void _003C_003EiFixBaseProxy_StartAutoDrive()
	{
	}

	public void _003C_003EiFixBaseProxy_SyncVehicleStable(bool P0)
	{
	}

	public AnimationID _003C_003EiFixBaseProxy_GetAnimName()
	{
		return default(AnimationID);
	}

	public void _003C_003EiFixBaseProxy_BMMODHKDMFN(bool P0)
	{
	}

	public new void _003C_003EiFixBaseProxy_SetEnterLevelTrigger(VehicleCollision P0, Collider P1, bool P2)
	{
	}

	public new void _003C_003EiFixBaseProxy_SyncChangeShape(byte P0)
	{
	}

	public void _003C_003EiFixBaseProxy_SetupCamera(VehicleDriverCamera P0)
	{
	}

	public bool _003C_003EiFixBaseProxy_SetSeat(int P0, BHGGAEEHJCO P1)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_EGHBAPLFLHO(VehicleSkinInfoBase P0)
	{
	}

	public void _003C_003EiFixBaseProxy_HKNPLOJGOBM()
	{
	}

	public void _003C_003EiFixBaseProxy_HJADKDOENFI(Player P0)
	{
	}

	public string _003C_003EiFixBaseProxy_GetIconInMap()
	{
		return null;
	}

	public string _003C_003EiFixBaseProxy_GetTeammateVehicleIcon()
	{
		return null;
	}

	public new void _003C_003EiFixBaseProxy_OnUpdate(float P0, float P1)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnFixedUpdate(float P0, float P1)
	{
	}

	public new void _003C_003EiFixBaseProxy_JGEEBJDNCOE()
	{
	}

	public bool _003C_003EiFixBaseProxy_CanDriverFire()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_ForceBrake()
	{
	}

	public void _003C_003EiFixBaseProxy_ForceStop(bool P0)
	{
	}

	public bool _003C_003EiFixBaseProxy_IsMoving()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_RemoveForDestroy(bool P0)
	{
	}

	public ResourceID _003C_003EiFixBaseProxy_GetDustResourceID()
	{
		return default(ResourceID);
	}

	public ResourceID _003C_003EiFixBaseProxy_GetSpeedLineEffect()
	{
		return default(ResourceID);
	}

	public void _003C_003EiFixBaseProxy_GBDDGCMFHPP()
	{
	}

	public ResourceID _003C_003EiFixBaseProxy_NHLHLKPFCLD()
	{
		return default(ResourceID);
	}

	public void _003C_003EiFixBaseProxy_MOIICJGCEKN(Collision P0)
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshIdleHoldWeaponAnim()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshHealState()
	{
	}

	public ResourceID _003C_003EiFixBaseProxy_GetWeaponHitEffect()
	{
		return default(ResourceID);
	}

	public ResourceID _003C_003EiFixBaseProxy_GetWeaponHitSound()
	{
		return default(ResourceID);
	}

	public ResourceID _003C_003EiFixBaseProxy_GetHitSound()
	{
		return default(ResourceID);
	}

	public Bounds _003C_003EiFixBaseProxy_CEOKGMFFNCP(Transform P0, bool P1)
	{
		return default(Bounds);
	}

	public bool _003C_003EiFixBaseProxy_CanIgnoreAimAssistBySkill()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_JDNPKCJMLFK(bool P0)
	{
	}

	public void _003C_003EiFixBaseProxy_PlayEffect(uint P0)
	{
	}

	public bool _003C_003EiFixBaseProxy_IICNLIKFPCA()
	{
		return false;
	}
}
