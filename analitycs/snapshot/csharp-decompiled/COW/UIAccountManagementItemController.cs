using GCommon;
using GarenaMSDK;

namespace COW;

public class UIAccountManagementItemController : UIBaseController
{
	private UIAccountManagementItemView m_View;

	private AccountPlatform m_Platform;

	private bool m_IsMainPlatform;

	private bool m_IsBind;

	public AccountPlatform Platform => AccountPlatform.None;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void SetViewData(AccountPlatform platform)
	{
	}

	public void RefreshBindData()
	{
	}

	private void OnBindBtnClick()
	{
	}

	private void OnUnBindBtnClick()
	{
	}

	private void _003COnUnBindBtnClick_003Eb__12_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
