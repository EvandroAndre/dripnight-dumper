using System.Collections.Generic;
using GCommon;
using message;

namespace COW.Gameplay.UGC;

public class UGCResourceShopEditorManager : SingletonModule<UGCResourceShopEditorManager>
{
	public static uint SHOP_LEVEL_OBJECT_CATEGORY;

	public static uint TEMPLATE_LEVEL_OBJECT_CATEGORY;

	private List<UGCResourceShopItem> m_LibraryItems;

	public UGCResourceShopDisplayData SearchDisplayData;

	public Dictionary<string, UGCResourceShopDisplayData> DisplayDataDictionary;

	private GeneralSearch<UGCResourceShopItem> m_SearchOwnedItems;

	public List<UGCResourceShopItem> LibraryItems => null;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public void ClearData()
	{
	}

	private void ClearCommonSearches()
	{
	}

	public string GetDisPlayType(int mainCategory, int subCategory, int sortId)
	{
		return null;
	}

	public string ConvertShopItemShareCode(string source, bool withPrefix)
	{
		return null;
	}

	public static EShopMainCategory GetMainCategory(IHDACHNBFNG resourceType)
	{
		return (EShopMainCategory)0;
	}

	public static IHDACHNBFNG GetResourceType(int mainCategory)
	{
		return IHDACHNBFNG.GameObject;
	}
}
