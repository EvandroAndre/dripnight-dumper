using GCommon;
using UnityEngine;

namespace COW;

public class UIBooyahPassPreviewSmallItemController : UIEasyListItemController
{
	private UIBooyahPassPreviewSmallItemView m_View;

	private UIModelBooyahPass m_ModelBooyahPass;

	private FrontEndPreviewComponent m_FrontEndPreviewComponent;

	private BooyahPassBaseItemData m_Data;

	private BaseItemInfo m_ItemInfo;

	private UIStandardItemMiniController m_ItemCtrl;

	private Vector3 m_OriginPos;

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

	public void SetFrontEndPreviewComponent(FrontEndPreviewComponent frontEndPreviewComponent)
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	private void SetIconPosition()
	{
	}

	public override void OnItemBtnClick()
	{
	}

	public override void OnItemBtnSelect()
	{
	}

	public override void OnItemBtnUnSelect()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}
