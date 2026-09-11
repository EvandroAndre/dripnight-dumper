using GCommon;
using UnityEngine;

namespace COW;

public class UIStandardItemMAXCController : UIEasyListItemController
{
	public UIStandardItemMAXCView m_View;

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

	public void SetData(BaseItemInfo newItemInfo)
	{
	}

	public void SetBtnClickEvent(EventDelegate.Callback callback)
	{
	}

	public virtual void SetQualityBG()
	{
	}

	public void SetBtnState(bool enable)
	{
	}

	public void SetClaimedState(bool show)
	{
	}

	public void SetOwnedState(bool show)
	{
	}

	public void SetHighLightState(bool show)
	{
	}

	public GameObject GetHighLight()
	{
		return null;
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

	public BaseItemView2 GetBaseInfoView()
	{
		return null;
	}

	public ResourceID _003C_003EiFixBaseProxy_GetResID()
	{
		return default(ResourceID);
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
