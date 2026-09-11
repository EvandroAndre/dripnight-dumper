using GCommon;
using UnityEngine;

namespace COW;

public class UIBooyahPassPreviewBaseItemController : UIEasyListItemController
{
	private UIBooyahPassPreviewBaseItemView m_View;

	protected UIModelBooyahPass m_ModelBooyahPass;

	private UIStandardItemMidController m_ItemMidCtrl;

	private BooyahPassBaseItemData m_Data;

	private Vector3 m_OriginPos;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void ShowHighLight(object[] data)
	{
	}

	public void InitCdnView()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	private void RefreshPrivilegeView()
	{
	}

	private void ShowPreview()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
