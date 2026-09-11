using System;
using System.Collections.Generic;
using UnityEngine;
using message;

namespace COW;

public class BRMatchReviewHeatmapRenderer
{
	private struct PlayerTimedPos
	{
		public long Ms;

		public int PosX;

		public int PosZ;

		public bool IsFromFake;

		public bool IsDeathSample;

		public int LifeSegment;
	}

	private struct PendingDot
	{
		public int SlotIdx;

		public int PosX;

		public int PosZ;

		public int FacingDX;

		public int FacingDZ;

		public Vector2 UiPos;

		public bool IsPrecise;

		public bool IsFromFake;
	}

	private struct TeamMemberPos
	{
		public int PosX;

		public int PosZ;
	}

	private struct FakeAIEntry
	{
		public int Ms;

		public int RemainingCount;

		public int Seq;
	}

	private struct KillEvent
	{
		public long Ms;

		public uint VictimPlayerId;

		public int PosX;

		public int PosZ;

		public int DeathPosX;

		public int DeathPosZ;

		public bool HasDeathPos;
	}

	private struct LifeStateEvent
	{
		public long Ms;

		public uint PlayerId;

		public bool IsDead;

		public int Priority;

		public int Sequence;
	}

	private struct KillFXEntry
	{
		public int PoolIdx;

		public float ReleaseAtUnscaledTime;
	}

	private struct LifeWindow
	{
		public long StartMs;

		public long EndMs;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<FakeAIEntry> _003C_003E9__101_0;

		public static Comparison<KillEvent> _003C_003E9__104_0;

		internal int _003CBuildFakeAITimeline_003Eb__101_0(FakeAIEntry a, FakeAIEntry b)
		{
			return 0;
		}

		internal int _003CSetKillEventData_003Eb__104_0(KillEvent a, KillEvent b)
		{
			return 0;
		}
	}

	private const int HEATMAP_DOT_SIZE = 100;

	private const float HEATMAP_DOT_ALPHA = 0.25f;

	private const int PRECISE_DOT_SIZE_X = 28;

	private const int PRECISE_DOT_SIZE_Y = 36;

	private const float PRECISE_DOT_ALPHA = 1f;

	private static readonly Color HEATMAP_DOT_COLOR;

	private static readonly Color PRECISE_DOT_COLOR;

	public static bool DebugColorFakeArrowBlack;

	private static readonly Color FAKE_DEBUG_PRECISE_COLOR;

	private static readonly Color FAKE_DEBUG_HEATMAP_COLOR;

	private const string DOT_SCALE_NODE_NAME = "UIBRMatchReviewHeatmapDot_Scale";

	private const string HEATMAP_SPRITE_NAME = "FF_Quality_point";

	private const string PRECISE_SPRITE_NAME = "Minimap_enemeySign";

	private const byte DOT_SPRITE_MODE_NONE = 0;

	private const byte DOT_SPRITE_MODE_HEATMAP = 1;

	private const byte DOT_SPRITE_MODE_PRECISE = 2;

	private const string KILL_FX_ANIM_CLIP = "UIFX_UIBRMatchReviewHeatmapDot_Red";

	private const string KILL_FX_NODE_NAME = "UIFX_UIBRMatchReviewHeatmapDot_Red";

	private const float KILL_FX_DURATION_SEC = 1.1f;

	private Transform m_MapPanel;

	private Transform m_Container;

	private GameObject m_DotPrefab;

	private List<UISprite> m_DotPool;

	private List<Transform> m_DotRootPool;

	private List<byte> m_DotSpriteModes;

	private readonly HashSet<int> m_RenderedSlotsThisTick;

	private readonly HashSet<int> m_RealPlayerOwnedSlots;

	private UIAtlas m_PreciseAtlas;

	private UIAtlas m_HeatmapAtlas;

	private List<float> m_DotFacingAngles;

	private const int FACING_MIN_MOVE = 200;

	private List<JLNBGDGBHKL> m_Positions;

	private Dictionary<uint, List<PlayerTimedPos>> m_PlayerPosTimeline;

	private List<uint> m_PlayerOrder;

	private Dictionary<uint, int> m_PlayerToDotIdx;

	private UIMapUtil.MapOffsetContext m_MapOffsetContext;

	private bool m_Initialized;

	private Vector3 m_DotScale;

	private readonly List<PendingDot> m_PendingDots;

	private uint m_LocalPlayerID;

	private Dictionary<uint, NGKNJIMOHBM> m_PlayerInfoDict;

	private HashSet<uint> m_MyTeamPlayerIds;

	private Dictionary<byte, uint> m_ShortToFullPlayerId;

	private long m_EnemyLayerRevealTimeMs;

	private uint m_PrecisePosDistance;

	private uint m_AIHideDistance;

	private uint m_FullAIThreshold;

	private uint m_SemiAIRandomRadius;

	private float m_RefreshIntervalMs;

	private float m_PreciseRefreshIntervalMs;

	private float m_SemiAIDecoyIntervalMs;

	private const int FAKE_AI_ZONE_SAMPLE_ATTEMPTS = 6;

	private const float DEATH_GLIDE_MAX_SPEED_MPS = 60f;

	private uint m_MinNeighborInRadius;

	private float m_GroupRadius;

	private float m_GroupRadiusSq;

	private float m_LastRenderTimeMs;

	private List<OFCOMIFFOLO> m_SafeZones;

	private int m_CurrentSafeZoneCenterX;

	private int m_CurrentSafeZoneCenterZ;

	private int m_CurrentSafeZoneRadius;

	private bool m_HasActiveSafeZone;

	private List<TeamMemberPos> m_TeamPositions;

	private Dictionary<uint, List<FakeAIEntry>> m_FakeAITimeline;

	private bool m_IsSemiAIMatch;

	private readonly List<KillEvent> m_SortedKillEvents;

	private readonly List<LifeStateEvent> m_SortedLifeStateEvents;

	private int m_NextKillEventIdx;

	private int m_NextLifeStateEventIdx;

	private readonly HashSet<uint> m_DeadPlayerIds;

	private long m_LastKillTickMs;

	private long m_LastLifeStateTickMs;

	private readonly List<KillFXEntry> m_ActiveKillFX;

	private Dictionary<uint, List<LifeWindow>> m_PlayerLifeWindows;

	private Dictionary<uint, List<PlayerTimedPos>> m_PlayerDeathSamples;

	public void Init(Transform mapPanel, UIMapUtil.MapOffsetContext mapOffsetContext, GameObject dotPrefab)
	{
	}

	public void SetPlayerContext(uint localPlayerId, Dictionary<uint, NGKNJIMOHBM> playerInfoDict, HashSet<uint> myTeamPlayerIds)
	{
	}

	public void SetEnemyLayerRevealTimeMs(long revealTimeMs)
	{
	}

	public void SetConfig(MatchReviewParamData paramData)
	{
	}

	private static uint ToWorldIntDistance(float meters)
	{
		return 0u;
	}

	public void SetPositionData(List<JLNBGDGBHKL> positions)
	{
	}

	private void BuildPlayerPosTimeline()
	{
	}

	private void BuildPlayerLifeWindows()
	{
	}

	private void AddLifeWindow(uint playerId, long startMs, long endMs)
	{
	}

	private void TagTimelineLifeSegments()
	{
	}

	private void InjectDeathSamplesIntoTimeline()
	{
	}

	private static bool IsDeathSampleEntry(PlayerTimedPos p)
	{
		return false;
	}

	private void RemoveAllInjectedDeathSamples()
	{
	}

	private static int CompareTimedPosByMs(PlayerTimedPos a, PlayerTimedPos b)
	{
		return 0;
	}

	private static int FindClosingLifeSegment(List<LifeWindow> windows, long deathMs)
	{
		return 0;
	}

	private bool HasDeathSinceSample(uint playerId, long sampleMs, long curMs)
	{
		return false;
	}

	private void BuildShortPlayerIdLookup()
	{
	}

	private int CountPositionTimelineSamples()
	{
		return 0;
	}

	public void BuildFakeAITimeline(List<HJNFDCJPPDE> allEvents)
	{
	}

	private int GetRemainingFakeAI(uint playerId, float timeMs)
	{
		return 0;
	}

	public void SetSafeZoneData(List<OFCOMIFFOLO> safeZones)
	{
	}

	public void SetKillEventData(List<HJNFDCJPPDE> allEvents, HashSet<uint> myTeamPlayerIds)
	{
	}

	private void AddLifeStateEvent(HJNFDCJPPDE evt, int sequence)
	{
	}

	private void AddLifeStateEvent(long ms, uint playerId, bool isDead, int priority, int sequence)
	{
	}

	private static int CompareLifeStateEvent(LifeStateEvent a, LifeStateEvent b)
	{
		return 0;
	}

	private static long VictimMsKey(long ms, uint playerId)
	{
		return 0L;
	}

	private void CollectEnemyDeathSample(HJNFDCJPPDE deathEvt, HashSet<uint> myTeamPlayerIds)
	{
	}

	public void UpdateToTime(float currentTimeMs)
	{
	}

	private bool ShouldHideEnemyLayer(long curMs)
	{
		return false;
	}

	private void HideEnemyLayerForSuppressedPhase(float currentTimeMs)
	{
	}

	private void UpdateLifeState(long curMs)
	{
	}

	private void ApplyLifeStateEvent(LifeStateEvent evt)
	{
	}

	private void UpdateKillFXState(long curMs)
	{
	}

	private void RenderHeatmapTick(float currentTimeMs)
	{
	}

	private void CollectRealPlayerPendingDots(long curMs)
	{
	}

	private void RenderPendingDotsWithClusterFilter()
	{
	}

	private void SweepUnrenderedDots()
	{
	}

	public void ForceRefreshOnNextUpdate()
	{
	}

	public void SetHeatmapVisible(bool visible)
	{
	}

	public void SetIconScale(Vector3 scale)
	{
	}

	public void ClearAll()
	{
	}

	public void Reset()
	{
	}

	private void DestroyContainer()
	{
	}

	private UISprite GetOrCreateDot(int index)
	{
		return null;
	}

	private void DestroyPool()
	{
	}

	private void HideAllDots()
	{
	}

	private Transform GetDotRootTransform(int slotIdx)
	{
		return null;
	}

	private void SetDotSpriteMode(UISprite dot, int slotIdx, byte mode)
	{
	}

	private static int BinarySearchAtOrBefore(List<PlayerTimedPos> list, long curMs)
	{
		return 0;
	}

	private void ResolveKillFXPose(KillEvent evt, out int posX, out int posZ, out int facingDX, out int facingDZ)
	{
		posX = default(int);
		posZ = default(int);
		facingDX = default(int);
		facingDZ = default(int);
	}

	private void PlayKillFX(uint deadPlayerId, int posX, int posZ, int facingDX, int facingDZ)
	{
	}

	private void TickKillFXReleases()
	{
	}

	private void ReleaseAllKillFXSlots()
	{
	}

	private void ReleaseKillFXSlot(int slotIdx)
	{
	}

	private static void SetKillFXNodeActive(Transform root, bool active)
	{
	}

	private static Transform FindChildRecursive(Transform root, string name)
	{
		return null;
	}

	private bool IsKillFXReserved(int idx)
	{
		return false;
	}

	private int EnsureDotSlot(uint playerId)
	{
		return 0;
	}

	private static void LerpAndFacing(PlayerTimedPos prev, bool hasNext, PlayerTimedPos next, long curMs, out int outX, out int outZ, out int facingDX, out int facingDZ)
	{
		outX = default(int);
		outZ = default(int);
		facingDX = default(int);
		facingDZ = default(int);
	}

	private static bool IsFakeToRealPositionTransition(PlayerTimedPos prev, PlayerTimedPos next)
	{
		return false;
	}

	private static bool IsImplausibleDeathGlide(PlayerTimedPos prev, PlayerTimedPos next)
	{
		return false;
	}

	private static bool SameLifeSegment(PlayerTimedPos a, PlayerTimedPos b)
	{
		return false;
	}

	private void RenderDotAt(int slotIdx, int posX, int posZ, int facingDX, int facingDZ, bool isFromFake)
	{
	}

	private void ApplyFacingRotation(UISprite dot, int slotIdx, int facingDX, int facingDZ)
	{
	}

	private static bool HasUsableFacing(int facingDX, int facingDZ)
	{
		return false;
	}

	private bool TryGetLastFacingAngle(uint playerId, out float angle)
	{
		angle = default(float);
		return false;
	}

	private void SetFacingAngle(int slotIdx, float angle)
	{
	}

	private void CollectFakeAIPendingDots(long curMs)
	{
	}

	private void ResolveDecoyOnRing(uint pid, int decoyIndex, long kf, float frac, int centerX, int centerZ, out int fakeX, out int fakeZ)
	{
		fakeX = default(int);
		fakeZ = default(int);
	}

	private static float KeyframeAngle(uint pid, int decoyIndex, long kf, float frac)
	{
		return 0f;
	}

	private static ulong HashKeyframe(uint pid, int decoyIndex, long keyframe)
	{
		return 0uL;
	}

	private static float Unit(ulong h)
	{
		return 0f;
	}

	private bool TryResolveDecoyOnRingInsideZone(uint pid, int decoyIndex, long kf, float frac, int centerX, int centerZ, ref int fakeX, ref int fakeZ)
	{
		return false;
	}

	private bool ClampPointIntoZone(ref int x, ref int z)
	{
		return false;
	}

	private int AllocateAnonymousDotSlot(ref int cursor)
	{
		return 0;
	}

	private void CollectTeamPositions(long curMs)
	{
	}

	private bool ShouldSkipPlayer(uint playerId, int posX, int posZ, bool isFromFake)
	{
		return false;
	}

	private bool IsWithinDistanceOfAnyTeammate(int posX, int posZ, int distance)
	{
		return false;
	}

	private bool IsWithinPreciseDistance(int posX, int posZ)
	{
		return false;
	}

	private static int GridDistance(int x1, int z1, int x2, int z2)
	{
		return 0;
	}

	private void ComputeActiveSafeZone(float currentTimeMs)
	{
	}

	private bool IsInsideSafeZone(int posX, int posZ)
	{
		return false;
	}

	public Vector2 WorldIntToLocalPos(int worldIntX, int worldIntZ)
	{
		return default(Vector2);
	}

	private int _003CBuildPlayerPosTimeline_003Eb__86_0(uint a, uint b)
	{
		return 0;
	}
}
