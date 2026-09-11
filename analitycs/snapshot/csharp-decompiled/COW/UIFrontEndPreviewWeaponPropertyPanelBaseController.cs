using System.Collections.Generic;
using UnityEngine;

namespace COW;

public abstract class UIFrontEndPreviewWeaponPropertyPanelBaseController : UIFrontEndPreviewUIComponentTemplateBaseController<UIFrontEndPreviewWeaponPropertyPanelBaseView>
{
	protected List<UIFrontEndPreviewWeaponPropertyItemController> m_pvpPropertyItems;

	protected List<UIFrontEndPreviewWeaponPVePropertyItemController> m_pvePropertyItems;

	protected List<WeaponScoreName> m_DetailInfoList;

	private Coroutine m_changeCoroutine;

	private uint m_SkillItemID;

	protected bool m_hasPvp;

	protected bool m_hasPve;

	protected WeaponPropertyPanelMaxFrom m_WeaponPropertyPanelMaxFrom;

	protected uint m_WeaponID;

	protected uint m_ItemID;

	protected uint m_UniqueID;

	protected uint m_PropertyID;

	private const int WEAPONBG_WIDTH = 156;

	private const int WEPONBG_WIDTH_SMALL = 116;

	private const int WEPONBG_WIDTH_MINI = 40;

	protected uint SkillItemID
	{
		get
		{
			return 0u;
		}
		set
		{
		}
	}

	protected override void InitView()
	{
	}

	protected override void OnUIOpenAsChild()
	{
	}

	private void OnDragChange(bool obj)
	{
	}

	private void StopChangeCoroutine()
	{
	}

	private void OnCenterChange(GameObject centeredobject)
	{
	}

	protected virtual void InitPvpItems()
	{
	}

	private void OnWeaponSkillClick()
	{
	}

	public void OnCloseUIExceptMagn()
	{
	}

	public void OnCloseAllUI()
	{
	}

	public void OnSetOrigin()
	{
	}

	public void OnDisVisbleIconTableInfo()
	{
	}

	public void DisplayWeaponPropertyScore(bool show)
	{
	}

	public virtual void OnRefreshWeaponPropertyScore(uint itemID, uint weaponID, WeaponPropertyPanelMaxFrom from = WeaponPropertyPanelMaxFrom.Other, uint uniqueId = 0u, uint propertyId = 0u)
	{
	}

	protected void RefreshWeaponIcon()
	{
	}

	protected void RefreshPveWeaponIcon()
	{
	}

	protected void RefreshNormalBtn()
	{
	}

	protected void RefreshPveNormalBtn()
	{
	}

	protected virtual bool OnRefreshPVP(uint itemID, uint weaponID)
	{
		return false;
	}

	public static int CompareWeaponScores(SortableWeaponScoreName a, SortableWeaponScoreName b)
	{
		return 0;
	}

	public void SetSkillItemID(uint skillItemID)
	{
	}

	protected virtual void InitPveItems()
	{
	}

	protected virtual bool OnRefreshPVE(uint itemID)
	{
		return false;
	}

	private void OnPveDetailBtnClicked()
	{
	}

	protected virtual void RefreshCustomizeStyle()
	{
	}

	private bool _003CRefreshWeaponIcon_003Eb__31_0(WeaponSkinBaseInfo x)
	{
		return false;
	}

	private bool _003CRefreshPveWeaponIcon_003Eb__32_0(WeaponSkinBaseInfo x)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_InitView()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpenAsChild()
	{
	}
}
