using System;
using GCommon;
using proto;

namespace COW;

public class UILobbyV2HideoutController : UIBaseController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static OnFinished _003C_003E9__7_0;

		internal void _003CRefreshView_003Eb__7_0()
		{
		}
	}

	private UILobbyV2HideoutView m_View;

	private OptCdnDesc m_HideoutAdDesc;

	private UIModelLobbyAds m_ModelLobbyAds;

	private UICountDownController m_HideoutCountDownController;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnHideoutBtnClick()
	{
	}

	public void RefreshView()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
