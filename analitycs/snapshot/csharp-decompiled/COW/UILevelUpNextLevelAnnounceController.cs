using System;
using System.Collections.Generic;
using GCommon;

namespace COW;

public class UILevelUpNextLevelAnnounceController : UIPopupWindowController
{
	private UILevelUpNextLevelAnnounceView m_View;

	private uint m_NewLevel;

	private Action m_CloseAction;

	public Action ClosAction
	{
		set
		{
		}
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIClose()
	{
	}

	public void SetAnnounceLevelData(List<LevelEntranceData> UnlockLevelDataList, List<LevelEntranceData> announceLevelDataList, uint level)
	{
	}

	public bool IsGuest()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
