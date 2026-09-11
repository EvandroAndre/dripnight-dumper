using System.Collections.Generic;
using GCommon;
using proto.Login;

namespace COW;

public class UIDebugLoginController : UIPopupWindowController, IUIModelDataChangeObserver
{
	private sealed class _003C_003Ec__DisplayClass12_0
	{
		public List<ServerSettingsData> serverSettings;

		internal void _003CInitServerView_003Eb__0(string server)
		{
		}
	}

	private UIAccountIDNickNameLoginWindowView m_View;

	private const uint BTN_DEFUALT_COLOR = 1608186111u;

	private const uint BTN_GREY_COLOR = 2593823487u;

	private const uint OUTLINE_BLUE = 192872447u;

	private const uint LABEL_GEM_COLOR = 188765951u;

	private EGLJDBDMENB m_UserData;

	private RenameCostData m_CostData;

	private bool m_HasRequestedLogin;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void RefreshViewData()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void InitServerView()
	{
	}

	private void OnInputChange()
	{
	}

	public void OnConfirmClick()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
