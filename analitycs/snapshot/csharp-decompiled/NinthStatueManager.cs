using System.Collections.Generic;
using COW;
using COW.GamePlay;
using GCommon;
using UnityEngine;

public class NinthStatueManager : MonoBehaviour
{
	public float Radius;

	public float BornIntterRadius;

	public float BornOuterRadius;

	public float BornRegionAngle;

	public float BornHeight;

	public float BornForward;

	public float ProgressContainer3DHeight;

	public GameObject StatueMainModelGo;

	public AnimationCurve ExtraBackDistanceCurve;

	private Vector3 m_Center;

	private Vector2 m_CenterXZ;

	private float m_InnerRadius;

	private float m_OuterRadius;

	private float m_SectorAngle;

	private float m_HalfAngle;

	private Vector3 m_SectorForward;

	private float m_ForwardAngleDeg;

	private float m_StatueRadius;

	private readonly List<Vector2> m_OccupiedPlayerPositionsXZ;

	private readonly List<Vector2> m_BlockedRadiusIntervals;

	private GameObject m_StatueVfxGo;

	private Animator m_StatueVfxAnimator;

	private uint m_VFXFlags;

	private readonly uint VFX_FLAG_LOW;

	private readonly uint VFX_FLAG_HIGH;

	private readonly uint VFX_FLAG_CLAIMABLE;

	private NinthStatueCameraAnimationManager mNinthStatueCameraAnimationManager;

	private GameObject mNinthStatueCameraAnimationGo05;

	private GameObject mNinthStatueCameraAnimationGo07;

	private UINinthSYSTokenStatueBehaviour mNinthStatueIconBehaviour;

	private GameObject mTokenEdgeVfxGo;

	private bool m_IsInitialized;

	private bool m_IsDisabled;

	private INinthProgressState m_NinthProgressState;

	private VisualInstanceHolder m_StatueBurstVFXHolder;

	private uint m_StatueBurstVFXHolderKey;

	private bool m_IsUISceneDestroyed;

	private readonly string LowDrawTrigger;

	private readonly string HighDrawTrigger;

	private readonly string IdleTrigger;

	private readonly string ClaimableTrigger1;

	private readonly string ClaimableTrigger2;

	private readonly string FinishedTrigger;

	private readonly float ClaimableTrigger2Duration;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void InitStatueMainModel()
	{
	}

	public void Initialize(INinthProgressState ninthProgressState)
	{
	}

	public void OnUISceneLoaded()
	{
	}

	public void OnUISceneDestroyed()
	{
	}

	public void Cleanup()
	{
	}

	private void OnDestroy()
	{
	}

	private void UpdateCachedValues()
	{
	}

	public bool IsPointInStatueRegion(Vector3 point)
	{
		return false;
	}

	public bool IsPointInBornRegion(Vector3 point)
	{
		return false;
	}

	public void GetBornPosAndRotationByRandom(float offset, out Vector3 pos, out Vector3 forward)
	{
		pos = default(Vector3);
		forward = default(Vector3);
	}

	public void GetBornPosAndRotation(List<Vector3> playerPositions, float radius, out Vector3 pos, out Vector3 forward)
	{
		pos = default(Vector3);
		forward = default(Vector3);
	}

	private Vector3 GetBornSectorForward()
	{
		return default(Vector3);
	}

	private bool IsPointInBornRegion(Vector2 pointXZ, Vector2 centerXZ, float innerRadius, float outerRadius, float forwardAngleDeg, float halfAngle)
	{
		return false;
	}

	private bool TryFindBestPointInRegion(List<Vector2> occupiedInRegion, Vector2 centerXZ, float innerRadius, float outerRadius, float forwardAngleDeg, float halfAngle, float playerRadius, out Vector2 bestPoint)
	{
		bestPoint = default(Vector2);
		return false;
	}

	private bool TryFindRandomNonOverlappingPointInRegion(List<Vector2> occupiedInRegion, Vector2 centerXZ, float innerRadius, float outerRadius, float forwardAngleDeg, float halfAngle, float playerRadius, out Vector2 bestPoint)
	{
		bestPoint = default(Vector2);
		return false;
	}

	private bool TryFindBestPointAtAngle(List<Vector2> occupiedInRegion, Vector2 centerXZ, float innerRadius, float outerRadius, float angleDeg, float preferredRadius, float minDisSqReq, out Vector2 bestPoint, out float bestScore)
	{
		bestPoint = default(Vector2);
		bestScore = default(float);
		return false;
	}

	private bool TryFindBestRadiusAtAngle(List<Vector2> occupiedInRegion, Vector2 centerXZ, Vector2 dir, float innerRadius, float outerRadius, float preferredRadius, float minDisSqReq, out float bestRadius, out float bestScore)
	{
		bestRadius = default(float);
		bestScore = default(float);
		return false;
	}

	private bool TryEvaluateFreeRadiusInterval(Vector2 centerXZ, Vector2 dir, List<Vector2> occupiedInRegion, float freeStart, float freeEnd, float preferredRadius, float minDisSqReq, ref float bestRadiusOffset, ref float bestRadius, ref float bestScore)
	{
		return false;
	}

	private bool TryEvaluateRadiusCandidate(Vector2 centerXZ, Vector2 dir, List<Vector2> occupiedInRegion, float radius, float preferredRadius, float minDisSqReq, ref float bestRadiusOffset, ref float bestRadius, ref float bestScore)
	{
		return false;
	}

	private float GetMinDistanceSqToOccupied(Vector2 point, List<Vector2> occupiedInRegion)
	{
		return 0f;
	}

	private int CompareIntervalMin(Vector2 a, Vector2 b)
	{
		return 0;
	}

	private Vector2 GetRandomPointInBornRegion(Vector2 centerXZ, float innerRadius, float outerRadius, float forwardAngleDeg, float halfAngle)
	{
		return default(Vector2);
	}

	private Vector2 GetPointByAngleAndRadius(Vector2 centerXZ, float angleDeg, float radius)
	{
		return default(Vector2);
	}

	private void PlayAnimation(string triggerName)
	{
	}

	private void RefershRewardIcon()
	{
	}

	private void InitVFX()
	{
	}

	private void OnInfoCallback()
	{
	}

	private void OnProgressStatusRefreshCallback()
	{
	}

	private GameObject GetNinthStatueCameraAnimationGo(uint level)
	{
		return null;
	}

	public bool PlayStatueAnimation(uint level, out float duration)
	{
		duration = default(float);
		return false;
	}

	private void OnStatueAnimationStartCallback()
	{
	}

	public void OnStatueAnimationCompleteCallback()
	{
	}

	private void _003COnStatueAnimationCompleteCallback_003Eb__78_0()
	{
	}
}
