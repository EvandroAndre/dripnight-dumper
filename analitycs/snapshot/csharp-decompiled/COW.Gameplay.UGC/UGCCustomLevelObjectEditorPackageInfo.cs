using System.Collections.Generic;
using message;

namespace COW.Gameplay.UGC;

public class UGCCustomLevelObjectEditorPackageInfo
{
	public UGCCustomLevelObjectPackageConfigData ConfigData;

	public UGCResInfo ResInfo;

	public OOCHHFPFBMG CustomTypeMap;

	public UGCCustomLevelObjectEditorManifest.ManifestData ManifestData;

	public UGCCustomLevelObjectEditorSetting.SettingData SettingData;

	public string DescriptionText;

	public bool IsCustomResourcesLoaded;

	public byte[] DynamicPackageBytes;

	public UGCResourceShopMetaData ShopMetaData;

	public string PackageId => null;

	public bool IsDynamicPackage => false;

	public bool IsDownloaded()
	{
		return false;
	}

	public bool LoadDynamicPackageBytes()
	{
		return false;
	}

	public bool LoadResInfo()
	{
		return false;
	}

	public bool LoadFullData()
	{
		return false;
	}

	public void UnloadFullData()
	{
	}

	public bool IsFullyLoaded()
	{
		return false;
	}

	private bool BuildRelevantLevelObjectInfoByConfig()
	{
		return false;
	}

	public List<uint> GetItemIds()
	{
		return null;
	}

	public void RemoveSimulationDataFromItemPrefabDic(uint itemId)
	{
	}

	public bool Init(byte[] gameBytes, string manifestText, string settingText, string descriptionText, bool isCalledByTools = false)
	{
		return false;
	}
}
