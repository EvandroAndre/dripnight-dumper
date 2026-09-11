using GCommon;
using UnityEngine;

namespace COW;

public class UISceneEditUGCRankRewardController : UIPreviewNavigationController, IEasyList
{
	private sealed class _003C_003Ec__DisplayClass8_0
	{
		public uint level;

		internal bool _003CRefreshRewardRankView_003Eb__0(WorkShopLevelExp data)
		{
			return false;
		}
	}

	private UISceneEditUGCRankRewardView m_View;

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

	protected override void OnHelpButtonClick(object[] param)
	{
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	private void OnPreviewBackBtnClick()
	{
	}

	private void ShowPreviewItem(object[] data)
	{
	}

	private void RefreshRewardRankView()
	{
	}

	public void SetViewData()
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	protected override UIWidget GetFrontEndPreviewBorder()
	{
		return null;
	}

	protected override FrontendPreviewType GetPreviewUIType()
	{
		return FrontendPreviewType.Lobby;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnHelpButtonClick(object[] P0)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}
}
