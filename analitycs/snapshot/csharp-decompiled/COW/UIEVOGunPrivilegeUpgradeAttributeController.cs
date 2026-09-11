using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIEVOGunPrivilegeUpgradeAttributeController : UIBaseController
{
	private UIEVOGunPrivilegeUpgradeAttributesView m_View;

	private List<UICollectionScoreItemController> m_CollectionScoreItemList;

	private SkinOwnAndOpenInfo m_WeaponSkinOwnInfo;

	private List<WeaponScoreName> m_WpScoreNotZeroNameList;

	private GameObject m_VFX;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void AddEventDelegate()
	{
	}

	private void OnPropertyBtnClick()
	{
	}

	private void SetPropertyData()
	{
	}

	private void ChangeScoreLabelColorByChange(bool selected)
	{
	}

	private void SetVFX()
	{
	}

	private void ClearVFX()
	{
	}

	public void SetViewData(SkinOwnAndOpenInfo wpSkinData, List<WeaponScoreName> wpScoreNotZeroNameList = null)
	{
	}

	public void OnSelectNotify()
	{
	}

	public void OnSelect()
	{
	}

	public void OnCancelSelect()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
