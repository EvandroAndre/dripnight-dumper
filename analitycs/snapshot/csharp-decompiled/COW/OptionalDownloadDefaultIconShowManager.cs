using System.Collections.Generic;
using GCommon;

namespace COW;

public class OptionalDownloadDefaultIconShowManager : SingletonModule<OptionalDownloadDefaultIconShowManager>
{
	private Dictionary<uint, Dictionary<uint, ResourceID>> m_OptionalSpecialCollectionDict;

	private Dictionary<uint, ResourceID> m_OptionalDownloadDefaultIconShowDict;

	private Dictionary<uint, ResourceID> m_OptionalDownloadClothresIconShowDict;

	protected override void OnCleanup()
	{
	}

	protected override void OnInit()
	{
	}

	public ResourceID GetItemDefaultShowIconByItemID(uint itemID)
	{
		return default(ResourceID);
	}

	public ResourceID GetItemDefaultShowIconByItem(BaseItemInfo item)
	{
		return default(ResourceID);
	}

	public ResourceID GetItemDefaultShowIconByItem(CSSharedItemData cssItemData)
	{
		return default(ResourceID);
	}

	public ResourceID GetItemDefaultIconByItemType(uint type, uint subType, uint OtherType)
	{
		return default(ResourceID);
	}

	protected uint GetDictKeyByItemType(uint type, uint subType, uint otherInfo)
	{
		return 0u;
	}

	protected bool CheckIsSpeicalType(uint type, uint subType)
	{
		return false;
	}

	protected bool CheckIsClothresType(uint type, uint subType)
	{
		return false;
	}

	public float GetItemUnDownloadedSpriteAlpha(uint id)
	{
		return 0f;
	}
}
