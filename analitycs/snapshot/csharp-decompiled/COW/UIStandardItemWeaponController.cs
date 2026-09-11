using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIStandardItemWeaponController : UIEasyListItemController
{
	public UIStandardItemWeaponView m_View;

	protected BaseItemInfo m_BaseItemInfo;

	private bool m_CanNotEquipTitleForAvartar;

	public bool ForceFullScreenPreview;

	private bool m_CanNotEquipTitleCustomize;

	private static string CanNotEquipTitle_NOT_HEADADDITIVE;

	private static string CanNotEquipTitle_UNABLE_EQUIP;

	private List<UIMallWeaponPropertyItemController> m_WeaponPropertyItemsList;

	private List<WeaponScoreName> m_WeaponPropertyDetailList;

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

	public void RefreshWeaponPropertyScore(uint itemid)
	{
	}

	private static int CompareWeaponScores(SortableWeaponScoreName a, SortableWeaponScoreName b)
	{
		return 0;
	}

	public void SetBtnClickEvent(EventDelegate.Callback callback)
	{
	}

	public void ShowItemName(bool show)
	{
	}

	public void SetBtnState(bool enable)
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

	public MallWeaponItemView GetBaseInfoView()
	{
		return null;
	}

	public UISprite GetDescargar()
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
