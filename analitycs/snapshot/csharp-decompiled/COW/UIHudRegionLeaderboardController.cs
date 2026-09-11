using GCommon;
using UnityEngine;

namespace COW;

internal class UIHudRegionLeaderboardController : UIBaseController
{
	private class CurMatchEasyList : IEasyList
	{
		private UIHudRegionLeaderboardController m_Owner;

		public CurMatchEasyList(UIHudRegionLeaderboardController owner)
		{
		}

		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		public void CloseItemController(UIEasyListItemController itemController)
		{
		}
	}

	private class RegionRankEasyList : IEasyList
	{
		private UIHudRegionLeaderboardController m_Owner;

		public RegionRankEasyList(UIHudRegionLeaderboardController owner)
		{
		}

		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}

		public void CloseItemController(UIEasyListItemController itemController)
		{
		}
	}

	private UIHudRegionLeaderboardView m_View;

	private GameModeStatsConfigManager.GameModeStatsConfig m_Config;

	private bool m_DataGet;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnPersistentDataGet()
	{
	}

	private void OnToggle(UIToggleButton t)
	{
	}

	private void OnBtnCloseClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
