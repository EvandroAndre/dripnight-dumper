using GCommon;
using UnityEngine;

namespace COW;

public class UIUGCUserCenterLevelInfoController : UIBaseController, IEasyList, IUIModelDataChangeObserver
{
	private sealed class _003C_003Ec__DisplayClass10_0
	{
		public uint level;

		internal bool _003CRefreshLevelRewardRankView_003Eb__0(WorkShopLevelExp data)
		{
			return false;
		}
	}

	private UIModelSceneEdit m_Model;

	private UIUGCUserCenterLevelInfoView m_View;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	private void OnUpdatePersonServer()
	{
	}

	private void OnUpdatePersonInfo(object[] data)
	{
	}

	private void RefreshLevelRewardRankView()
	{
	}

	private void OnViewLevelsRewardBtnClick()
	{
	}

	private void OnLevelRewardMaskBtnClick()
	{
	}

	private void HideLevelRewardPanel()
	{
	}

	private void ShowPreviewItem(object[] data)
	{
	}

	private void OnRankRewardLevelUp(object[] data)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
