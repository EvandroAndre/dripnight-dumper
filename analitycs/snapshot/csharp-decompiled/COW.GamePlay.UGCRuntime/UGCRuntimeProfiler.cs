using System.Collections.Generic;
using System.Diagnostics;
using Unity.Profiling;
using UnityEngine;

namespace COW.GamePlay.UGCRuntime;

public static class UGCRuntimeProfiler
{
	private static bool isRecording;

	private static Stopwatch stopwatch;

	private static int maxFrameCount;

	private static int maxCallDepth;

	private static ProfilerFrame[] frameBuffer;

	private static int frameWriteIndex;

	private static int frameCount;

	private static int globalFrameIndex;

	private static ProfilerFrame currentFrame;

	private static Stack<int> parentStack;

	private static Stack<long> beginTicks;

	private static Stack<long> beginMemory;

	private static Stack<int> sampleIdxStack;

	private static Dictionary<long, int> mergeLookup;

	private static int lastWarningFrame;

	private static int skippedDepthCount;

	private const int SKIPPED_SAMPLE_IDX = -2;

	private static Dictionary<string, ProfilerEntityInfo> allEntitySnapshot;

	private static List<ProfilerEntityInfo> pendingAddEntities;

	private static List<ProfilerEntityInfo> pendingRemoveEntities;

	private static UGCEntityDataStore registeredDataStore;

	private static HashSet<string> effectEntityIds;

	private static HashSet<string> particleEntityIds;

	private static Dictionary<string, ParticleSystem[]> particleSystemCache;

	private static readonly List<ParticleSystem> particleSystemBuffer;

	private static ProfilerRecorder trianglesRecorder;

	private static ProfilerRecorder drawCallsRecorder;

	private static ProfilerRecorder physicsSimulateRecorder;

	private static long lastNonZeroTriangles;

	private static long lastNonZeroDrawCalls;

	private const float NANOSEC_TO_MILLISEC = 1E-06f;

	public static bool IsRecording => false;

	public static int MaxFrameCount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static int MaxCallDepth
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public static void Init(UGCEntityDataStore dataStore, IModeConfig modeConfig = null)
	{
	}

	public static void Shutdown()
	{
	}

	public static void AttachProfilerEntity(UGCLogicEntity entity, string sourceID, string codeID)
	{
	}

	public static void StartRecording()
	{
	}

	public static void StopRecording()
	{
	}

	private static void StartRenderRecorders()
	{
	}

	private static void StopRenderRecorders()
	{
	}

	public static void EndFrame()
	{
	}

	public static void BeginSample(string name)
	{
	}

	public static void EndSample()
	{
	}

	public static List<ProfilerFrame> GetFrameData()
	{
		return null;
	}

	public static void ClearData()
	{
	}

	private static void OnEntityCreatedByDataStore(string archTypeID, string entityID)
	{
	}

	private static void OnEntityRemovedByDataStore(string archTypeID, string entityID)
	{
	}

	private static void TryRegisterEffectEntity(string archTypeID, string entityID)
	{
	}

	private static void FillExtraData(ProfilerFrame frame)
	{
	}

	private static void FillMemoryUsage(UGCProfilerFrameExtraData extra)
	{
	}

	private static void FillRenderUsage(UGCProfilerFrameExtraData extra)
	{
	}

	private static void FillEffectUsage(UGCProfilerFrameExtraData extra)
	{
	}

	private static void RebuildOldestEntitySnapshot(int oldestIndex)
	{
	}
}
