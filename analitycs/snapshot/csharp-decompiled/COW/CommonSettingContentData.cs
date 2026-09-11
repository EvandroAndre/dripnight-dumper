using System.Collections.Generic;

namespace COW;

public class CommonSettingContentData
{
	public bool ShowTitle;

	public string TitleKey;

	public string TitleDesc;

	public Dictionary<int, CommonSettingItemDataBase> ItemData;

	public List<int> OrderedItemKeys;

	public bool Show;

	public string RightTopTipKey;
}
