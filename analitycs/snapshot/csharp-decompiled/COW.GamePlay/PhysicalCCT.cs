using System;
using System.Collections.Generic;
using COW.Gameplay.UGC;
using UnityEngine;

namespace COW.GamePlay;

public class PhysicalCCT : MonoBehaviour
{
	public class DINPGKHDLID
	{
		public JPHBHMMPHJG BAAEBKEINAD;

		public Vector3 DGFLGBEOGPG;

		public Vector3 OCFGFDKKNGO;

		public Vector3 HFDDPIPAKKO;

		public Vector3 HKBBJNAEJDK => default(Vector3);

		public bool JDFKKCPBAEL()
		{
			return false;
		}
	}

	[Serializable]
	public struct GroundingState
	{
		public bool IsGrounded;

		public Vector3 GroundNormal;

		public Vector3 SnapToGroundDisplacement;

		public JPHBHMMPHJG Mover;

		public Vector3 MoverVelocityAtPosition;

		public Vector3 MoverAngularVelocityAtPosition;
	}

	public float SlopeLimit;

	public float StepOffset;

	public float SkinWidth;

	public float Radius;

	public float Height;

	public float MinMoveDistance;

	public bool IsServerDriven;

	public float Mass;

	private float KKPIOJIGCPC;

	public float MaxSpeed;

	public bool UseGravity;

	public float GravityScale;

	private Vector3 OFMNHEKGKJF;

	public bool EnableRotateWithGravity;

	public bool UseLerpForRotateWithGravity;

	public bool IsRotatingWithGravity;

	public bool SmoothMovement;

	public float ControlMoveSensibility;

	public float LoseControlMoveSensibility;

	public float RotateSensibility;

	public float UpDirectionRotateSensibility;

	public bool UseCustomPushForce;

	public float CustomPushForce;

	public float JumpHeight;

	public int JumpMaxCount;

	public int JumpCount;

	public bool CanMoveInAir;

	public bool InteractiveRigidbodyHandling;

	public FPBBNIOAPMA InteractionType;

	public bool NotifyCollisionEvents;

	public bool SolveMovementCollisions;

	public int MaxCollisionResolveCount;

	public bool ShouldDetectGroundHit;

	public bool ForbidUphillMovementWhenSliding;

	public bool SlightMove;

	public Vector3 CharacterUp;

	public Vector3 CharacterForward;

	public Vector3 CharacterRight;

	public CollisionFlags CurrentCollisionFlags;

	private List<DINPGKHDLID> ILPPEHHHEPP;

	private List<JPHBHMMPHJG> NHDJLAKEPFE;

	public GroundingState CurrentGroundState;

	public GroundingState LastGroundState;

	public const float GroundDetectionBackDistance = 0.002f;

	private RaycastHit[] OKEPFMLCHNE;

	private bool FJAPEAGKDGK;

	private int PAOHLKFONKL;

	public float DeltaTime;

	private Vector3 FKGJAGPEMHK;

	private Vector3 ABONFHJMNJM;

	public Vector3 Velocity;

	private Quaternion NMPLLNMKDMB;

	public Vector3 AdditionalForceToApply;

	private LJJABOHJEIN MPIKIEFFLCH;

	private UGCPhysicsManager _003CMBIFJFOMCCP_003Ek__BackingField;

	private CharacterController ENDHJJBKCPO;

	private Transform LHPNHGBMBLJ;

	private Vector3 IAEHDKMACNB;

	private Vector3 JNPEKEMHLBH;

	private Vector3 GELAJFHLHCL;

	private float GCDFPIPOBLO;

	private float LBKMCDNBJON;

	public Vector3 NDGHIFFIFCM => default(Vector3);

	public Vector3 PKJFONINBHB
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public float INBOFNIKGPC => 0f;

	public bool NFGHFDFIDAN => false;

	public bool PCCNPGFEOCL => false;

	public bool NJHEMAJLAMM => false;

	public bool PENGDILEOHJ => false;

	public Vector3 MOEFFAIDCBP => default(Vector3);

	public Vector3 NNGHAEBNCCF => default(Vector3);

	public Quaternion KKCMGANOIKI
	{
		get
		{
			return default(Quaternion);
		}
		set
		{
		}
	}

	public UGCPhysicsManager FIPNDOADBHO
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	internal void DDHLJMNHJAG(float EIOKHLKJEEL)
	{
	}

	internal void IGCOMLFHLFI(float EIOKHLKJEEL)
	{
	}

	internal void EPMLLJBOIND(float EIOKHLKJEEL)
	{
	}

	internal void DIGIBDAIFIM(float EIOKHLKJEEL)
	{
	}

	internal void NNLAOHBFOBJ(float EIOKHLKJEEL)
	{
	}

	internal void BJPDFOEDNOK(float EIOKHLKJEEL)
	{
	}

	internal void ICCEGHOJGGM(float EIOKHLKJEEL)
	{
	}

	internal void PADNHPJAAPE(Vector3 EIOKHLKJEEL)
	{
	}

	internal void KOKDKCOIEBM(float EIOKHLKJEEL)
	{
	}

	internal void ONHKFNMHEHP(bool EIOKHLKJEEL)
	{
	}

	internal void MEHEPJFMDII(bool EIOKHLKJEEL)
	{
	}

	internal void JEOMAGOOEEG(bool EIOKHLKJEEL)
	{
	}

	internal void AIDBHMPDAAF(float EIOKHLKJEEL)
	{
	}

	internal void HNAIEBLLPDG(int EIOKHLKJEEL)
	{
	}

	internal void LPBKCAKJNKB(float EIOKHLKJEEL)
	{
	}

	internal void KIOPAODIJEP(int EIOKHLKJEEL)
	{
	}

	internal void IOJAHDEIBCG(bool EIOKHLKJEEL)
	{
	}

	public void InitCCT(LJJABOHJEIN LMAKHNPFOAB, CharacterController HFHEHBJGCIA, UGCPhysicsManager BPONKFMLCGJ, KOBHLHBJNAI BMGPIMFEGME, bool ECPNPCOLLMD)
	{
	}

	public void ResetCCT()
	{
	}

	public void ForceUnground(int HOKJFEKEJOE = 1)
	{
	}

	public void ForceSetPosition(Vector3 IGDHIDGLOKG)
	{
	}

	public void UpdatePhase1(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	public void UpdatePhase2(float OKJIFBCMDAD, float HOGHEFNINAE)
	{
	}

	private Vector3 HIFJNDOLKPM(Vector3 FKJMCGEFJMD)
	{
		return default(Vector3);
	}

	private CollisionFlags NMAJAPAPKKI(ref Vector3 IGDHIDGLOKG, Vector3 KMFMICABCFL, float HOGHEFNINAE, bool KMPJGKBJOGI)
	{
		return CollisionFlags.None;
	}

	private void OnControllerColliderHit(ControllerColliderHit HDGIHCBAOEN)
	{
	}

	private void AFBJJKDCEAE(JPHBHMMPHJG LGGGMOJDJHL, Vector3 IGDHIDGLOKG, float HOGHEFNINAE, out Vector3 JDIHDDINCAN, out Vector3 EAMMAOGMEOB)
	{
		JDIHDDINCAN = default(Vector3);
		EAMMAOGMEOB = default(Vector3);
	}

	private bool CAIHGBJHGMK(GroundingState CBCAJJJCKLH)
	{
		return false;
	}

	private void LAHJBOBCABN(float HOGHEFNINAE)
	{
	}

	private void LMNDDNGANBH(float HOGHEFNINAE)
	{
	}

	private Vector3 ELONFILCPEE(Vector3 FKJMCGEFJMD, Vector3 GIGHDENFDNK)
	{
		return default(Vector3);
	}

	public Vector3 ReorientVelocityToPlane(Vector3 NECLKFBPMKE, Vector3 NILLBMLEDDG, Vector3 GIGHDENFDNK)
	{
		return default(Vector3);
	}

	private void MIHBBEHFFGK()
	{
	}

	private void BJEOKGINPMP()
	{
	}

	private bool OHOGKOEKCPI(Vector3 IGDHIDGLOKG, Vector3 BAFIFNKBHLC, float CGGPBJKCDEG, int PCIHGMPOMPF, out RaycastHit MPLMJFDDNAO)
	{
		MPLMJFDDNAO = default(RaycastHit);
		return false;
	}

	private bool OJKGLNJNDPJ(Vector3 IGDHIDGLOKG, Vector3 BAFIFNKBHLC, float CGGPBJKCDEG, int PCIHGMPOMPF, out RaycastHit MPLMJFDDNAO)
	{
		MPLMJFDDNAO = default(RaycastHit);
		return false;
	}
}
