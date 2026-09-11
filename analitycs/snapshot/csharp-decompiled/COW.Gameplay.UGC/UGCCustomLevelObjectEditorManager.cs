using System;
using System.Collections.Generic;
using GCommon;
using message;

namespace COW.Gameplay.UGC;

public class UGCCustomLevelObjectEditorManager : SingletonModule<UGCCustomLevelObjectEditorManager>
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<int> _003C_003E9__29_0;

		public static Action<int> _003C_003E9__45_0;

		internal void _003CLoadExistedCustomResources_003Eb__29_0(int codeOfLoadingCustomRes)
		{
		}

		internal void _003CLoadShopPackageData_003Eb__45_0(int codeOfLoadingCustomRes)
		{
		}
	}

	public static uint CUSTOMLEVELOBJECT_ITEMID;

	private Dictionary<uint, SceneEditPrefabConfigDataForCustomLevelObject> m_CustomLevelObjectCompatibleConfigData;

	private Dictionary<uint, WorkShopCustomLevelObjectResourceContentConfigData> m_CustomLevelObjectCompatibleResourceContentData;

	private Dictionary<uint, UGCCustomLevelObjectConfigData> m_DynamicCustomLevelObjectConfigsByPrefabId;

	private Dictionary<string, uint> m_DynamicPrefabUUIDToPrefabId;

	private Dictionary<string, UGCCustomLevelObjectEditorPackageInfo> m_CustomLevelObjectPackageInfos;

	private Dictionary<string, UGCCustomLevelObjectEditorPackageInfo> m_DynamicCustomLevelObjectPackageInfos;

	private Dictionary<string, UGCCustomLevelObjectEditorInfo> m_CustomLevelObjectInfos;

	private uint m_CustomLevelObjectIdCounter;

	public Dictionary<uint, SceneEditPrefabConfigDataForCustomLevelObject> CustomLevelObjectCompatibleConfigData => null;

	public Dictionary<string, uint> DynamicPrefabUUIDToPrefabId => null;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public void Clear()
	{
	}

	public UGCCustomLevelObjectConfigData GetConfigByPrefabId(uint prefabId)
	{
		return null;
	}

	public bool BuildLevelObjectInfo(string prefabUUID, UGCCustomLevelObjectEditorPackageInfo packageInfo, out UGCCustomLevelObjectEditorInfo levelObjectInfo)
	{
		levelObjectInfo = null;
		return false;
	}

	public UGCCustomLevelObjectEditorInfo GetLevelObjectInfoByItemId(uint itemId)
	{
		return null;
	}

	public UGCCustomLevelObjectEditorInfo GetLevelObjectInfo(string bytesId)
	{
		return null;
	}

	public bool RegisterAllBuildInPackageInfo()
	{
		return false;
	}

	public bool LoadAllExistedPackageInfo()
	{
		return false;
	}

	public bool LoadBuildInCustomTypeMap()
	{
		return false;
	}

	public void LoadDescription()
	{
	}

	public void RegisterDynamicPackageInfo(UGCResourceShopMetaData metaData)
	{
	}

	public void RegisterPackageInfo(string packageId, UGCCustomLevelObjectEditorPackageInfo packageInfo, bool isDynamic)
	{
	}

	public Dictionary<string, UGCCustomLevelObjectEditorPackageInfo> GetAllPackageInfo()
	{
		return null;
	}

	public UGCCustomLevelObjectEditorPackageInfo GetPackageInfo(string packageId)
	{
		return null;
	}

	public UGCCustomLevelObjectEditorPackageInfo GetPackageInfoByItemId(uint itemId)
	{
		return null;
	}

	public void LoadExistedCustomResources()
	{
	}

	public bool BuildResourceContentConfigData(UGCCustomLevelObjectConfigData configData, EUGCAssetProviderType type)
	{
		return false;
	}

	public UGCCustomLevelObjectConfigData BuildDynamicCustomLevelObjectConfigData(UGCCustomLevelObjectEditorPackageInfo packageInfo, UGCCustomLevelObjectEditorSetting.PrefabData settingPrefabData)
	{
		return null;
	}

	public WorkShopCustomLevelObjectResourceContentConfigData GetPrefabResourceContentConfigData(uint prefabId)
	{
		return null;
	}

	public bool BuildDynamicPrefabConfigData(string prefabUUID, uint customPrefabId, UGCResourceShopMetaData metaData)
	{
		return false;
	}

	public bool BuildPrefabConfigData(string prefabUUID, uint customPrefabId, string packageId)
	{
		return false;
	}

	private bool BuildPrefabConfigDataInternal(SceneEditPrefabConfigDataForCustomLevelObject configData, string prefabUUID, string packageId)
	{
		return false;
	}

	public void UnRegisterPrefabConfigData(uint prefabId)
	{
	}

	public SceneEditPrefabConfigDataForCustomLevelObject GetPrefabConfigData(uint prefabId)
	{
		return null;
	}

	public SceneEditPrefabConfigDataForCustomLevelObject GetPrefabConfigDataByUUID(string prefabUUID, string shopResourceID = "", string shopResourceVersion = "")
	{
		return null;
	}

	public bool GetPrefabConfigDataByEntityType(string entityType, ref List<uint> prefabIds)
	{
		return false;
	}

	public bool MergeGameDataWithCustomLevelObjectData(JOEANMPIFAB sourceGameData, GNHAFLDPNJI sourceResourceData)
	{
		return false;
	}

	public bool MergeEntityDataWithPrefab(PLMKOPJMIEP source, INAMDLOFOHF sourceEditorData)
	{
		return false;
	}

	public bool InitAttributes()
	{
		return false;
	}

	public bool ReloadPackageInfo(UGCCustomLevelObjectEditorPackageInfo packageInfo)
	{
		return false;
	}

	public bool LoadReferencedShopPackageData(UGCResInfo resInfo)
	{
		return false;
	}

	public bool LoadShopPackageData(UGCResourceShopMetaData metaData)
	{
		return false;
	}

	public bool ReloadCustomObjPackageInfoIfNeeded(UGCCustomLevelObjectEditorPackageInfo packageInfo)
	{
		return false;
	}

	public string GetEntityTypeByItemId(uint itemId)
	{
		return null;
	}

	public uint GenerateCustomLevelObjectId()
	{
		return 0u;
	}

	public void RemoveSimulationDataFromItemPrefabDic(UGCCustomLevelObjectEditorPackageInfo packageInfo)
	{
	}

	public UGCCustomLevelObjectEditorPackageInfo GetNewestPackageInfoByShopResourceID(string shopResourceID)
	{
		return null;
	}
}
