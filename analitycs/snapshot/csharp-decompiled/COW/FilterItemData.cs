using System;

namespace COW;

public class FilterItemData
{
	public string Text;

	public string Deep_Link;

	public UILeaderBoardNewController.DeepLinkLayer DeepLinkLayer;

	public Action<object> CallBack;
}
