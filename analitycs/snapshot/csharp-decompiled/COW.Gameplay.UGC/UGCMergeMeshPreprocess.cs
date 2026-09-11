using System.Collections.Generic;
using COW.GamePlay;
using UnityEngine;
using message;

namespace COW.Gameplay.UGC;

public class UGCMergeMeshPreprocess
{
	public class CreateLevelObjectInfo
	{
		public string m_entityID;

		public OLEDMLOHNFH m_resItem;

		public LMPGHJKDOJH m_itemProto;

		public AFAJGEBMGIP m_itemTransform;

		public INAMDLOFOHF m_itemEntityData;
	}

	private sealed class _003C_003Ec__DisplayClass15_0
	{
		public IPIFNFDIIKK repItem;

		internal bool _003CBuildGenerateInfo_003Eb__0(IPIFNFDIIKK item)
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass18_0
	{
		public UGCMergeMeshGenerator.MergeObjectData obj;

		internal bool _003CBuildUGCRes_003Eb__0(HICLJGDBALL.HFNGFDGEJKJ info)
		{
			return false;
		}
	}

	private List<UGCMergeMeshGenerator.MergeObjectData> m_mergeInputObjects;

	public List<HICLJGDBALL.HFNGFDGEJKJ> m_generateObjectList;

	private Dictionary<string, SceneEditObjectBase> m_cacheSceneEditObjectMap;

	public Dictionary<string, SceneEditObjectBase> m_mergedSceneObjectMap;

	public JBBDIJHHPLK m_resPackage;

	public List<CreateLevelObjectInfo> m_resultCreateLevelObjectList;

	public List<UGCMergeMeshGenerator.MergedObjectResult> m_cacheResult;

	public List<INAMDLOFOHF> m_resultEntityDataList;

	public bool IsSkipEntity(string entityID)
	{
		return false;
	}

	public void Clear()
	{
	}

	public bool CheckCanMerge(SceneEditObjectBase editObj, List<string> ignoreIds = null)
	{
		return false;
	}

	public void BuildMergeGroup(SceneEditObjectBase group, List<string> ignoreIds = null)
	{
	}

	public void ProcessMerge()
	{
	}

	public void BuildPackage()
	{
	}

	public void BuildGenerateInfo(HICLJGDBALL.HFNGFDGEJKJ generateUnitInfo, SceneEditObjectBase objParent, List<IPIFNFDIIKK> repItemsCache)
	{
	}

	public void BuildTemplatePackage(string templateId)
	{
	}

	private SceneEditObjectBase GetSceneEditObject(string entityID)
	{
		return null;
	}

	private NMENPLHEPCD BuildUGCRes(UGCMergeMeshGenerator.MergedObjectResult result)
	{
		return null;
	}

	public void BuildMergeObjForCustomLevelObject(SceneEditObjectCustom editObj, UGCMergeMeshGenerator.MergedObjectResult result)
	{
	}

	public UGCMergeMeshGenerator.MergeObjectData BuildMergeObj(SceneEditObjectBase editObj)
	{
		return null;
	}

	private UGCMergeMeshGenerator.MergeObjectData BuildMergeObjData(SceneEditObjectBase editObj)
	{
		return null;
	}

	private UGCMergeMeshGenerator.MergeObjectData buildMergeObjectDataByMeshRenderers(UGCMergeMeshGenerator.MergeObjectData mergeObjData, MeshRenderer[] mrList)
	{
		return null;
	}
}
