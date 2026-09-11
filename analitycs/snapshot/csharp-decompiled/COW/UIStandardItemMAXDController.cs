using GCommon;

namespace COW;

public class UIStandardItemMAXDController : UIEasyListItemController
{
	public UIStandardItemMAXDView m_View;

	protected BaseItemInfo m_BaseItemInfo;

	private bool m_CanNotEquipTitleForAvartar;

	public bool ForceFullScreenPreview;

	private bool m_CanNotEquipTitleCustomize;

	private static string CanNotEquipTitle_NOT_HEADADDITIVE;

	private static string CanNotEquipTitle_UNABLE_EQUIP;

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

	public void SetBtnTipsEvent()
	{
	}

	private void ShowItemPreview()
	{
	}

	public virtual void SetQualityBG()
	{
	}

	public void SetClaimedState(bool show)
	{
	}

	public void SetHighLightState(bool show)
	{
	}

	public void SetGreyBGState(bool show)
	{
	}

	public void SetBundleTag()
	{
	}

	public override void SetViewData(object data, int data_index)
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
