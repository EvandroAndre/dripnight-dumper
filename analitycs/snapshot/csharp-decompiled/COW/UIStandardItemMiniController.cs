using GCommon;

namespace COW;

public class UIStandardItemMiniController : UIEasyListItemController
{
	public UIStandardItemMiniView m_View;

	public StatndardItemMiniData m_Data;

	public bool ForceFullScreenPreview;

	public bool FullScreenPreviewForVoicePackage;

	private bool m_NeedTween;

	protected bool m_DetailItemShowTypeIcon;

	protected bool m_ShowItemCount;

	public int Width => 0;

	public int Height => 0;

	protected override ResourceID GetResID()
	{
		return default(ResourceID);
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetForceShowTime()
	{
	}

	public void SetStandItemMiniData(StatndardItemMiniData data, bool hasTween = true)
	{
	}

	public void RefreshView()
	{
	}

	private void RefreshLimitLabel()
	{
	}

	public UIDragScrollView GetItemDragView()
	{
		return null;
	}

	public void UpdateQuantityLabel(string newCount)
	{
	}

	public void SetActiveQualityBg(bool active)
	{
	}

	public void SetQualityBG(bool show)
	{
	}

	public virtual void SetQualityBG()
	{
	}

	public void ShowExpireTime(bool isShow)
	{
	}

	public void RefreshBaseItemView(BaseItemInfo info)
	{
	}

	public void SetQuantityLabelZero()
	{
	}

	public void SetBtnClickEvent(bool useFullScreen = true)
	{
	}

	public void ClearBtnClickEvent()
	{
	}

	public void SetItemBtnState(bool show)
	{
	}

	public void SetCustomBtnClickEvent(EventDelegate.Callback action)
	{
	}

	public void EnableItemBtn()
	{
	}

	public void DisableItemBtn()
	{
	}

	public void SetDetailTypeIconView(bool show)
	{
	}

	public void SetShowItemCount(bool show)
	{
	}

	public virtual void ShowItemPreview()
	{
	}

	public virtual void ShowFullScreenPreview()
	{
	}

	private bool CanUseFullScreenPreview(uint itemId)
	{
		return false;
	}

	private bool IsVoicePackageItem(uint itemId)
	{
		return false;
	}

	public void SetLimitLabelState(bool show)
	{
	}

	public void SetLimitTitleState(bool show)
	{
	}

	public void SetClaimableState(bool show)
	{
	}

	public void SetClaimedState(bool show)
	{
	}

	public void SetLadderGotState(bool show)
	{
	}

	public void SetHighLightState(bool show)
	{
	}

	public void SetGreyBGState(bool show)
	{
	}

	public void SetOwnedState(bool show)
	{
	}

	public void SetDownloadInfoState(bool show)
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	public void SetTweenEnable(bool enable)
	{
	}

	public void SetQuantityIgnoreOne(bool ignore)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public ResourceID _003C_003EiFixBaseProxy_GetResID()
	{
		return default(ResourceID);
	}
}
