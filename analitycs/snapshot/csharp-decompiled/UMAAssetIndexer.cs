using System;
using System.Collections.Generic;
using UMA;
using UnityEngine;

public class UMAAssetIndexer : MonoBehaviour, ISerializationCallbackReceiver
{
	public enum EAssetItemType
	{
		EAssetItemType_Slot,
		EAssetItemType_Overlay,
		EAssetItemType_Race,
		EAssetItemType_TextRecipe,
		EAssetItemType_WardrobeRecipe,
		EAssetItemType_MAX
	}

	[Serializable]
	public class AssetItem
	{
		public string _QualifiedName;

		public int _TypeIndex;

		public string _Name;

		public UnityEngine.Object m_Item;

		public string _Path;

		public UnityEngine.Object _Item => null;

		public Type _Type => null;

		public string _AssetBaseName => null;

		public string AssetName => null;

		public string EvilName => null;

		public static string GetEvilName(UnityEngine.Object o)
		{
			return null;
		}

		public AssetItem(Type Type, string Name, string Path, UnityEngine.Object Item)
		{
		}

		public AssetItem(Type Type, UnityEngine.Object Item)
		{
		}
	}

	public static string SortOrder;

	public static string[] SortOrders;

	public static Dictionary<Type, Type> TypeToLookup;

	public static Type[] Types;

	public bool NoSaveObjectRefs;

	public List<string> IndexedTypeNames;

	public List<AssetItem> Items;

	public UMAMeshAsset BaseMaleBone;

	public UMAMeshAsset BaseFemaleBone;

	internal Dictionary<Type, Dictionary<string, AssetItem>> TypeLookup;

	private static GameObject theIndex;

	private static UMAAssetIndexer theIndexer;

	public static bool IsInstanceLoaded => false;

	public static UMAAssetIndexer Instance => null;

	private static Type GetAssetType(int typeIndex)
	{
		return null;
	}

	private static int GetAssetTypeIndex(Type type)
	{
		return 0;
	}

	public static void Cleanup()
	{
	}

	public void ClearResourceRef()
	{
	}

	public AssetItem GetAssetItem<T>(string Name)
	{
		return null;
	}

	public List<T> GetAllAssets<T>(string[] foldersToSearch = null) where T : UnityEngine.Object
	{
		return null;
	}

	public T GetAsset<T>(int nameHash, string[] foldersToSearch = null) where T : UnityEngine.Object
	{
		return null;
	}

	private void GetEvilAssetNameAndHash(Type type, UnityEngine.Object o, ref string assetName, ref int assetHash)
	{
	}

	public T GetAsset<T>(string name, string[] foldersToSearch = null) where T : UnityEngine.Object
	{
		return null;
	}

	private bool AssetFolderCheck(AssetItem itemToCheck, string[] foldersToSearch = null)
	{
		return false;
	}

	public void AddAsset(Type type, string Name, string Path, UnityEngine.Object o, bool SkipBundleCheck = false)
	{
	}

	private void AddAssetItem(AssetItem ai, bool SkipBundleCheck = false)
	{
	}

	internal void UpdateDictionaries(bool SkipBundleCheck = false)
	{
	}

	public void CreateLookupDictionary(Type type)
	{
	}

	private void UpdateList(bool beforeSerialize = false)
	{
	}

	public Dictionary<string, AssetItem> GetAssetDictionary(Type type)
	{
		return null;
	}

	public void RebuildIndex()
	{
	}

	public UMAMeshData GetBaseBoneData(bool isMale)
	{
		return null;
	}

	void ISerializationCallbackReceiver.OnBeforeSerialize()
	{
	}

	void ISerializationCallbackReceiver.OnAfterDeserialize()
	{
	}
}
