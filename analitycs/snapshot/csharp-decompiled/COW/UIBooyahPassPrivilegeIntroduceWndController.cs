using System.Collections.Generic;
using GCommon;

namespace COW;

internal class UIBooyahPassPrivilegeIntroduceWndController : UIPopupWindowController
{
	private UIBooyahPassPrivilegeIntroduceWndView m_View;

	private List<UIBooyahPassPrivilegeIntroduceItemController> m_ItemList;

	private UIModelBooyahPass m_ModelBooyahPass;

	private CommonRewardWindowStyleBaseController m_StyleBaseCtrl;

	private const string WINDOW_TITLE = "PrivilegeIntroduceWnd";

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void RefereshBgView()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void RefreshBottomBtnView()
	{
	}

	private void OnUnlockBtnClick()
	{
	}

	private void RefreshItemHighLight(EPrivilegeIndex index)
	{
	}

	private void RefreshView()
	{
	}

	private void RefreshCdnByIndex(EPrivilegeIndex index)
	{
	}

	public void ShowPrivilegeInfoByIndex(EPrivilegeIndex index)
	{
	}

	public void SetViewData(EPrivilegeIndex tabIndex)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
