using System.Collections.Generic;
using UnityEngine;

public class SceneExtensionInfo : MonoBehaviour
{
	private static SceneExtensionInfo _instance;

	public bool version2018;

	public int lightmapNum;

	public List<LightmapAreaInfo> areaLightmaps;

	private LightmapData[] _003CLightmapDataArr_003Ek__BackingField;

	private int[] LightmapRefCount;

	private const int LightmapBlockSize = 3;

	private int extraPrefabLightmapNum;

	private List<LightmapData> LightmapDataArrWithExtra;

	private Dictionary<string, RuntimePrefabStat> extraPrefabLightmaps;

	public const int P_blockSize = 100;

	public const int L_blockSize = 50;

	public const int S_blockSize = 30;

	public static int ReplaceSceneOffsetConst;

	public RepalceSceneLightMapConfig ReplaceSceneLightMapConf;

	private const float shadowOnlyScale = 0.01f;

	public bool hasShadowmask;

	public bool skipLightmapFile;

	public static bool bakingMode;

	public static bool enableAlert;

	public const string c_NegScaleMeshName = "__NegScaleMesh__";

	private bool isBaseScene;

	private bool hack_isUGCWorkshopMainScene;

	public static int baseSceneLmLength;

	public SimulationStreamer simulateStreamer;

	public List<SceneExtensionInfoExtData> extensionDatas;

	private Dictionary<int, LightmapData> pendingLightmaps;

	public static SceneExtensionInfo instance
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	public LightmapData[] LightmapDataArr
	{
		get
		{
			return _003CLightmapDataArr_003Ek__BackingField;
		}
		private set
		{
			_003CLightmapDataArr_003Ek__BackingField = value;
		}
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public void InitLightmaps()
	{
	}

	public void InitLightmapInfo()
	{
	}

	public void InitLightmapTextures()
	{
	}

	public void LoadPendingLightmaps()
	{
	}

	public void RefreshLightmapNum()
	{
	}

	public void ResizeLightmapNum(int newLightmapNum)
	{
	}

	public void LoadLightmap(LightmapTextureInfo info)
	{
	}

	public void UnloadLightmap(LightmapTextureInfo info)
	{
	}

	public void LoadLightmap(LightmapTextureInfo2 info)
	{
	}

	public void UnloadLightmap(LightmapTextureInfo2 info)
	{
	}

	public void LoadLightmap(int[] lightmapIndexes, Texture2D[] lightmaps, Texture2D[] shadowmasks)
	{
	}

	public void UnloadLightmap(int[] lightmapIndexes, Texture2D[] lightmaps, Texture2D[] shadowmasks)
	{
	}

	public bool IsUGCWorkshopMainScene()
	{
		return false;
	}

	public int LoadLightmapEx(RuntimePrefabLightmap info)
	{
		return 0;
	}

	public void UnloadLightmapEx(RuntimePrefabLightmap info)
	{
	}

	public void ClearLightmapEx()
	{
	}

	public void AddToPendingLightmaps(int lmID, LightmapData lmData)
	{
	}

	public static bool UseBoundsForStreamBlocks(string sceneName)
	{
		return false;
	}
}
