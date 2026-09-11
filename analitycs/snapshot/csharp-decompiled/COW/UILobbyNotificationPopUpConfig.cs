using System;
using System.Collections.Generic;

namespace COW;

public static class UILobbyNotificationPopUpConfig
{
	public static Dictionary<uint, Type> ContentTypeDict;

	public static Dictionary<uint, NotifyData> NotifyDataDict;

	public static Dictionary<uint, UILobbyNotificationPopupUIConfig> UIConfigDict;

	static UILobbyNotificationPopUpConfig()
	{
	}
}
