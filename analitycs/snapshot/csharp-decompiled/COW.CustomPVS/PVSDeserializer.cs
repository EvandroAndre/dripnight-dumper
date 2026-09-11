using System;
using System.Collections.Generic;
using GCommon;
using Unity.Collections;
using UnityEngine;

namespace COW.CustomPVS;

public class PVSDeserializer
{
	private byte[] m_CurTileBytes;

	private TextAsset m_CurTileTextAsset;

	private NativeArray<byte> m_CurTileNativeArray;

	private List<int> m_PortalIndexs;

	private List<short> m_PortalGroundHeights;

	private HashSet<ushort> m_PortalIDs;

	private Dictionary<int, ushort> m_PositionIDRemapper;

	private List<KeyValuePair<Bounds, List<int>>> m_CustomTileGroups;

	private Dictionary<int, Bounds> m_CustomTileBounds;

	private int m_RelatedIDCount;

	private int m_RelatedIDPC;

	private int m_PortalBufferCount;

	private int m_PortalBufferPC;

	private Queue<KeyValuePair<int, byte[]>> m_BinaryCache;

	private Queue<KeyValuePair<int, TextAsset>> m_NativeBinaryCache;

	private Queue<KeyValuePair<int, ResourceID>> m_ResIDCache;

	private const int strip_int = 32;

	private const int step_ushort = 2;

	private const int step_int = 4;

	private const int step_float = 4;

	private const string BINARY_VERSION = "version";

	private const string BINARY_SCENE_CONFIG = "-1";

	private const string BINARY_REMAPPER = "-2";

	private const string BINARY_CUSTOM_TILE_CONFIG = "-3";

	private int m_CurTileIndex;

	private int m_CurPortalIndex;

	private int m_CurPortalHeight;

	private Vector3Int m_CurPortalCount;

	private string m_SceneName;

	private uint m_AsyncLoadingTicket;

	private int m_AsyncLoadingTileID;

	private Action<bool, Vector3Int, int> m_OnCheckTileDataHandle;

	private AssetBundleRequest m_AsyncABRequest;

	private AssetBundle m_AB;

	public bool Init(string sceneName)
	{
		return false;
	}

	public static bool UseNativeArray()
	{
		return false;
	}

	public void Clear()
	{
	}

	private string GetABName(string sceneName)
	{
		return null;
	}

	public bool InitSceneConfig(out Bounds bounds, out Vector3Int tileCount)
	{
		bounds = default(Bounds);
		tileCount = default(Vector3Int);
		return false;
	}

	public bool InitPositionIDRemapper()
	{
		return false;
	}

	public Dictionary<int, ushort> GetPositionIDRemapper()
	{
		return null;
	}

	public bool InitCustomTileConfig()
	{
		return false;
	}

	public List<KeyValuePair<Bounds, List<int>>> GetCustomTileGroups()
	{
		return null;
	}

	public Dictionary<int, Bounds> GetCustomTileBounds()
	{
		return null;
	}

	private byte[] LoadBytesFromAB(string assetName)
	{
		return null;
	}

	private TextAsset LoadTextAssetFromAB(string assetName)
	{
		return null;
	}

	private ResourceID GetResourceID(string key)
	{
		return default(ResourceID);
	}

	private ResourceID GetResourceID(int key)
	{
		return default(ResourceID);
	}

	private void ReleaseBytes(ResourceID resId)
	{
	}

	private byte[] LoadBytes(ResourceID resId)
	{
		return null;
	}

	private TextAsset LoadTextAsset(ResourceID resId)
	{
		return null;
	}

	private void LoadTileBytes(int id)
	{
	}

	private void DelegateAsyncLoadABBinary(AsyncOperation asyncOp)
	{
	}

	private void DelegateAsyncLoadBinary(uint ticket, bool succeeded, UnityEngine.Object obj)
	{
	}

	private void HandleTileBinaryAssetLoaded(UnityEngine.Object obj)
	{
	}

	private void OnReadBinaryFinish(byte[] bytes, bool fromCache = false)
	{
	}

	private void OnReadBinaryFinishByNativeData(TextAsset textAsset, bool release = true)
	{
	}

	public void CheckTileData(int tileIndex, Action<bool, Vector3Int, int> callBack)
	{
	}

	private void InvokeOnCheckTileDataHandle(bool isSuccess)
	{
	}

	private ushort GetRelatedID(int i)
	{
		return 0;
	}

	private int GetPortalBufferData(int i)
	{
		return 0;
	}

	public bool IsInPortal(int portalIndex, ushort id)
	{
		return false;
	}

	public List<short> GetPortalGroundHeights()
	{
		return null;
	}

	public HashSet<ushort> GetPortalData(int portalIndex)
	{
		return null;
	}

	public bool HasPositionIDRemapper()
	{
		return false;
	}

	public int CalculateHash(Vector3 position)
	{
		return 0;
	}

	public ushort GetPositionID(Vector3 position)
	{
		return 0;
	}
}
