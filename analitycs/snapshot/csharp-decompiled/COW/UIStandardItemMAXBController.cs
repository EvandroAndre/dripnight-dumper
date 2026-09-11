using GCommon;
using UnityEngine;

namespace COW;

public class UIStandardItemMAXBController : UIEasyListItemController
{
	public UIStandardItemMAXBView m_View;

	protected BaseItemInfo m_BaseItemInfo;

	private bool m_CanNotEquipTitleForAvartar;

	public bool ForceFullScreenPreview;

	private bool m_CanNotEquipTitleCustomize;

	private static string CanNotEquipTitle_NOT_HEADADDITIVE;

	private static string CanNotEquipTitle_UNABLE_EQUIP;

	public bool NeedShowLaunchTag;

	public bool NeedShowIPTag;

	private UILaunchTagFrameController m_LaunchTag;

	private UIModelInventory m_ModelInventory;

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

	public void SetData(BaseItemInfo newItemInfo)
	{
	}

	public void SetBtnClickEvent(EventDelegate.Callback callback)
	{
	}

	public void SetBtnPreviewEvent()
	{
	}

	public void SetBtnTipsEvent()
	{
	}

	public void OnBtnPreviewClick()
	{
	}

	private void ShowItemPreview()
	{
	}

	public void ShowItemName(bool show)
	{
	}

	public void SetItemNameOverflow(UILabel.Overflow overflow)
	{
	}

	public void SetItemNameColor(Color color)
	{
	}

	public void ShowExpireTime(bool isShow)
	{
	}

	public void SetBtnState(bool enable)
	{
	}

	public void SetCheckIconActive(bool active)
	{
	}

	public virtual void SetQualityBG()
	{
	}

	public void SetClaimedState(bool show)
	{
	}

	public void SetOwnedState(bool show)
	{
	}

	public void SetCanNotEquipState(bool show, bool forAvatar = false)
	{
	}

	public void SetCanNotEquipStateCustomize(bool show, string content)
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

	protected void SetIPTagOrLaunchTag()
	{
	}

	public void SetBundleTag()
	{
	}

	public void SetBoxTag()
	{
	}

	public void SetQualityLabelStyle()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	public void SetHotFixDownload(bool show)
	{
	}

	public void SetOptionalDownloadDontShowState(bool show)
	{
	}

	public BaseItemView2 GetBaseInfoView()
	{
		return null;
	}

	public void SetForceShowTime()
	{
	}

	public void SetQualityLabelStyle(bool show)
	{
	}

	public void SetUGCState(bool show, string state, string time)
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
