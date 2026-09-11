using GCommon;
using UnityEngine;

namespace COW;

public class UIBooyahPassMainBaseItemController : UIBaseController
{
	private UIBooyahPassMainBaseItemView m_View;

	protected UIModelBooyahPass m_ModelBooyahPass;

	private const string ITEM_TITLE = "BaseItem";

	private UIStandardItemMidController m_ItemMidCtrl;

	private BooyahPassBaseItemData m_Data;

	private Vector3 m_OriginPos;

	private GameObject m_UIFX_ShowBigprize;

	private GameObject m_UIFX_ShowGet;

	private GameObject m_UIFX_Unlock;

	public bool PP => false;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnVisibilityChanged()
	{
	}

	protected override void OnUIInit()
	{
	}

	private void ShowHighLight(object[] data)
	{
	}

	public void ShowUnlockEffect()
	{
	}

	public void SetData(BooyahPassBaseItemData data, int lastClickIndex, bool isCycle)
	{
	}

	private void SetPrivilegeRewardView()
	{
	}

	private void SetNormalRewardView()
	{
	}

	private void ClaimRewardByID()
	{
	}

	private void ShowPrivilegePreview()
	{
	}

	private void ShowPreview()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
