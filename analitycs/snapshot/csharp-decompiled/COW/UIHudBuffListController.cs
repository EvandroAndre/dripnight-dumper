using System.Collections.Generic;
using COW.GamePlay;
using GCommon;

namespace COW;

internal class UIHudBuffListController : UIBaseController
{
	private sealed class _003C_003Ec__DisplayClass6_0
	{
		public OAICFPKEJNE bevData;

		internal bool _003COnBuffBehaviorChanged_003Eb__0(OAICFPKEJNE temp)
		{
			return false;
		}

		internal bool _003COnBuffBehaviorChanged_003Eb__1(OAICFPKEJNE temp)
		{
			return false;
		}

		internal bool _003COnBuffBehaviorChanged_003Eb__2(OAICFPKEJNE temp)
		{
			return false;
		}
	}

	private UIHudBuffListView m_View;

	private List<OAICFPKEJNE> m_CurrentBuffBehaivorList;

	private List<UIHudBuffListItemController> m_ItemControllers;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected void OnBuffBehaviorChanged(object[] param)
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void RefreshUI()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
