using System;
using System.Collections.Generic;

namespace COW;

public class TabInfo
{
	public string DeepLink;

	public string Key;

	public List<TabInfo> SubTabs;

	public Action OnClick;

	public string SelectSpriteName;
}
