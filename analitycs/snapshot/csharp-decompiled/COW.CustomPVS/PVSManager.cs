using System.Collections.Generic;
using UnityEngine;

namespace COW.CustomPVS;

public class PVSManager : MonoSingleton<PVSManager>
{
	public static bool EnableInABMapPatch;

	private PVSIndexer m_Indexer;

	private PVSDeserializer m_Deserializer;

	private Dictionary<ushort, LPVSItemAttacher> m_PVSItems;

	private Dictionary<int, LPVSItemAttacher> m_DynamicPVSItems;

	private Queue<LPVSItemAttacher> m_CachePool;

	private bool m_IsValid;

	private bool m_IsInited;

	private Camera m_MainCamera;

	private int m_CurTileIndex;

	private int m_CurPortalIndex;

	private Vector3 m_LastCameraPos;

	private bool m_InternalIsRunning;

	private bool m_InternalRefreshVisibleDirty;

	public static bool EnablePVS(string sceneName)
	{
		return false;
	}

	public bool InitData(string sceneName)
	{
		return false;
	}

	public string CheckInGameSplitSceneReplace(string sceneName)
	{
		return null;
	}

	public bool CheckMapGameVar(string sceneName)
	{
		return false;
	}

	protected override void OnDestroy()
	{
	}

	public void Clear()
	{
	}

	public void GatherExistingPVSItems()
	{
	}

	private void InternalFindPVSItemsInChildren(GameObject go, ref List<MeshRenderer> rs, ref HashSet<int> instanceIDsHash)
	{
	}

	private Transform GetStreamerRoot(Transform trans)
	{
		return null;
	}

	public LPVSItemAttacher GetLPVSItemAttacherFromPool()
	{
		return null;
	}

	public void RecyleLPVSItemAttacherToPool(LPVSItemAttacher item)
	{
	}

	public void SetValid(bool valid)
	{
	}

	public bool GetValid()
	{
		return false;
	}

	public void AddGO(Vector3 position, GameObject go)
	{
	}

	public void RemoveGO(Vector3 position)
	{
	}

	public void AddPVSItem(ushort id, LPVSItemAttacher item)
	{
	}

	public void RemovePVSItem(ushort id)
	{
	}

	public void AddDynamicPVSItem(int instanceID, LPVSItemAttacher item)
	{
	}

	public LPVSItemAttacher GetDynamicPVSItem(int instanceID)
	{
		return null;
	}

	public bool HasPositionID()
	{
		return false;
	}

	public bool GetPositionID(Vector3 position, out ushort id)
	{
		id = default(ushort);
		return false;
	}

	public bool IsPositionVisible(Vector3 position)
	{
		return false;
	}

	public bool GetCurTileAndPortal(out int tileIndex, out int portalIndex)
	{
		tileIndex = default(int);
		portalIndex = default(int);
		return false;
	}

	private void Update()
	{
	}

	private void DelegateCheckTileDataFinish(bool isSuccess, Vector3Int portalCount, int portalHeight)
	{
	}

	private void InternalResetVisible()
	{
	}

	private void InternalRefreshVisible()
	{
	}

	private void InternalFinalRefreshVisible()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}
}
