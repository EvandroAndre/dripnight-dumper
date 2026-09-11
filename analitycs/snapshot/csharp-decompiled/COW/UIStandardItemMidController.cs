using GCommon;

namespace COW;

public class UIStandardItemMidController : UIEasyListItemController
{
	public UIStandardItemMidView m_View;

	protected BaseItemInfo m_BaseItemInfo;

	private bool m_CanNotEquipTitleForAvartar;

	public bool ForceFullScreenPreview;

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

	public void SetData(BaseItemInfo newItemInfo, bool showIPTag = true)
	{
	}

	public void SetBtnClickEvent(EventDelegate.Callback callback)
	{
	}

	public void SetBtnClickPreviewTip()
	{
	}

	public void AddBtnClickEvent(EventDelegate.Callback callback)
	{
	}

	public void SetLockState(bool IsLock)
	{
	}

	public virtual void SetQualityBG()
	{
	}

	public void SetClaimedState(bool show)
	{
	}

	public void SetClaimedText(string text, UILabel.Overflow? overflowMethod = null)
	{
	}

	public void SetHighLightState(bool show)
	{
	}

	public void SetGreyBGState(bool show)
	{
	}

	public void SetQualityBG(bool show)
	{
	}

	public void UpdateQuantityLabel(string newCount)
	{
	}

	public void SetQuantityLabel(bool value)
	{
	}

	private void SetIPTag()
	{
	}

	public void SetIPTagPosAndScale(float posX, float posY, float scaleX, float scaleY)
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	private void ShowItemPreview()
	{
	}

	public ResourceID _003C_003EiFixBaseProxy_GetResID()
	{
		return default(ResourceID);
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
