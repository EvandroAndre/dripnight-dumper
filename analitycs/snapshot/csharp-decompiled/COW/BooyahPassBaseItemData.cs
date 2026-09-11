using System.Collections.Generic;
using proto;

namespace COW;

public class BooyahPassBaseItemData
{
	public bool IsPP;

	public EPTarget_Status BaseItemStatus;

	public BooyahPassBaseItemType BaseItemType;

	public uint BaseItemIndex;

	public uint BaseItemGrade;

	public uint ShowRewardPriority;

	public AwardDesc AwardBaseItemDesc;

	public ESpecialItemWithoutDataType SpecialBPPrivilegeType;

	public static BooyahPassBaseItemData DeepCopy(BooyahPassBaseItemData originData)
	{
		return null;
	}

	public bool CanItemClaim()
	{
		return false;
	}

	public bool IsItemLock()
	{
		return false;
	}

	public bool IsBigRewardBaseItem()
	{
		return false;
	}

	public bool IsPrivilegeRewardItem()
	{
		return false;
	}

	public bool isPreviewRewardItem()
	{
		return false;
	}

	public static List<BaseItemInfo> ConvertToAvailableRewardItemInfoList(List<BooyahPassBaseItemData> booyahPassBaseItemDataList, List<BaseItemInfo> result = null)
	{
		return null;
	}

	public static List<BooyahPassBaseItemData> FilterOutPremiumItemData(List<BooyahPassBaseItemData> booyahPassBaseItemDataList)
	{
		return null;
	}
}
