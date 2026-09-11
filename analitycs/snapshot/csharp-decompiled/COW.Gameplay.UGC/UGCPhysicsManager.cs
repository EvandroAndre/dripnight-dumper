using COW.GamePlay;
using COW.GamePlay.UGCRuntime;
using UnityEngine;
using message;

namespace COW.Gameplay.UGC;

public class UGCPhysicsManager : IUGCRunner<CLMPMGMIDGD>
{
	public const uint NUM_UGC_LAYERS = 32u;

	public const int DEFAULT_LAYER_INDEX = 0;

	public readonly uint DEFAULT_LAYER;

	private readonly uint[] m_collisionMatrix;

	private float _003CCCTCollisionThreshold_003Ek__BackingField;

	private const float DEFAULT_CCT_COLLISION_THRESHOLD = 200f;

	private Vector3 m_OriginalGravity;

	public static bool EnableTrsSync;

	public static uint TrsSyncSmoothingMethod;

	public static float TrsSyncMaxErrorAccumulationSeconds;

	public static float TrsSyncMinError;

	public static float TrsSyncMaxPositionError;

	public static float TrsSyncPredictRatio;

	public static float TrsSyncPredictBlendRatio;

	private UGCPhysicsModule m_ClientModule;

	public float CCTCollisionThreshold
	{
		get
		{
			return _003CCCTCollisionThreshold_003Ek__BackingField;
		}
		private set
		{
			_003CCCTCollisionThreshold_003Ek__BackingField = value;
		}
	}

	private UGCPhysicsModule ClientModule => null;

	public bool LoadRuntimeData(CLMPMGMIDGD runtimeData)
	{
		return false;
	}

	public bool UnloadRuntimeData()
	{
		return false;
	}

	public KOBHLHBJNAI GetPlayerCCTConfig()
	{
		return default(KOBHLHBJNAI);
	}

	public int GetPlayerPhysicalLayerIndex()
	{
		return 0;
	}

	public uint GetPlayerExtraLayerCollisionMask()
	{
		return 0u;
	}

	public bool UsePhysicalCCTForPlayer()
	{
		return false;
	}

	public KOBHLHBJNAI GetCCTConfig(string entityID)
	{
		return default(KOBHLHBJNAI);
	}

	public uint LayerIndexToLayer(int layerIndex)
	{
		return 0u;
	}

	public static int ConvertGSLayer2ClientExtraLayer(int layerIndex)
	{
		return 0;
	}

	public uint ConvertToClientPhysicalLayer(int physicalLayerIndex)
	{
		return 0u;
	}
}
