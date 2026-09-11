using System.Collections.Generic;

namespace COW;

public class CommonSettingDragableItemData : CommonSettingDragableItemBaseData
{
	public List<CommonSettingDragableSliderItemData> SubItemDatas;

	public CommonSettingItemDataToggleBtns ToggleBtns;

	public bool ShowExpendBtn => false;
}
