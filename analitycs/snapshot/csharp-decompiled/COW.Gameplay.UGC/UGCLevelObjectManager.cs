using System.Collections.Generic;
using COW.GamePlay;
using COW.GamePlay.UGCRuntime;
using GCommon;
using UnityEngine;
using message;

namespace COW.Gameplay.UGC;

public class UGCLevelObjectManager
{
	private sealed class _003C_003Ec__DisplayClass14_0
	{
		public UGCLevelObjectManager _003C_003E4__this;

		public Transform parent;

		public string ugcEntityID;

		public Vector3 pos;

		public Quaternion rot;

		public Vector3 scale;

		public string archTypeID;

		public SceneEditPrefabConfigData csvConfig;

		internal void _003CCreateLevelObjectFromUGCLogicEntity_003Eb__0(uint tid, bool ret, Object modelRes)
		{
		}
	}

	private readonly FJEEGHOAKOG m_OwnerGame;

	private readonly UGCEntityDataStore m_DS;

	private readonly IUGCModuleArchTypeMgr m_ArchTypeManager;

	private HashSet<uint> loadingRes;

	public UGCLevelObjectManager(FJEEGHOAKOG game, UGCEntityDataStore ds)
	{
	}

	public void OnDestroy()
	{
	}

	public void AddLoadTicket(uint ticket)
	{
	}

	public void RemoveLoadTicket(uint ticket)
	{
	}

	private void CancelAllResLoad()
	{
	}

	public GameObject CreateUGCLevelObjectFromPrefabData(AFAJGEBMGIP prefabData, string archTypeID, int layer = -1)
	{
		return null;
	}

	public void CreateUGCLevelObject(string ugcEntityID, string archTypeID, SceneEditPrefabConfigData csvConfig, OKFGLFKOBEJ sublevel, bool canCombineMesh, GameObject obj)
	{
	}

	private BaseLevelObject AddExtraScript(GameObject obj, string archTypeID, uint itemID)
	{
		return null;
	}

	private void AddAOShadow(GameObject obj, ResourceID ShadowResID, ResourceID AOFieldsResID)
	{
	}

	private uint GetIDFromUGCEntityID(string typename, string entityID)
	{
		return 0u;
	}

	private void CreateLevelObjectFromUGCLogicEntity(string archTypeID, string ugcEntityID)
	{
	}

	private void RemoveLevelObjectFromUGCLogicEntity(string archTypeID, string ugcEntityID)
	{
	}

	private void HandleAddLevelMorphObject(string archTypeID, string ugcEntityID)
	{
	}

	private GameObject InstantiatePrefabFromAPI(string ugcEntityID, string archTypeID)
	{
		return null;
	}

	private GameObject CreateEmptyGameObject(string ugcEntityID)
	{
		return null;
	}
}
