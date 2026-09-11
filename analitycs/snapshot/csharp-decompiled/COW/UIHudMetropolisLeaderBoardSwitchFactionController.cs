using System;
using GCommon;
using message;

namespace COW;

internal class UIHudMetropolisLeaderBoardSwitchFactionController : UIBaseController
{
	private sealed class _003C_003Ec__DisplayClass5_0
	{
		public UIToggleButton selectButton;

		internal bool _003COnItemSelect_003Eb__0(UIToggleButton value)
		{
			return false;
		}
	}

	public Action<AFBOKKIDEAB> OnSwitchSwitchFaction;

	private UIHudMetropolisLeaderBoardSwitchFactionView m_View;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SelectTabToAll()
	{
	}

	private void OnItemSelect(UIToggleButton selectButton)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
