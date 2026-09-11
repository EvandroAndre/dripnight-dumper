using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIFrontEndPreviewWeaponPropertyPanelMaxController : UIFrontEndPreviewWeaponPropertyPanelBaseController
{
	private UIFrontEndPreviewWeaponPropertyPanelView m_UIView;

	private bool m_Expanded;

	private const int BASE_HEIGHT = 65;

	private const int PROPERTY_ITEM_HEIGHT = 34;

	private Vector3 m_ExpandPos;

	private int m_ShowLines;

	private bool m_HasExpanded;

	private List<WeaponScoreName> m_PvpScoreList;

	private List<WeaponScoreName> m_PveScoreList;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void InitBaseUIView()
	{
	}

	protected override UIFrontEndPreviewWeaponPropertyPanelBaseView InitBaseView()
	{
		return null;
	}

	protected override void OnUIInit()
	{
	}

	private void OnDetailBtnClicked()
	{
	}

	private void OnDetailPveBtnClicked()
	{
	}

	private void OnDetailPvpPveBtnClicked()
	{
	}

	protected override void InitPvpItems()
	{
	}

	protected override bool OnRefreshPVP(uint itemID, uint weaponID)
	{
		return false;
	}

	public static int CompareConfigSort(WeaponScoreName a, WeaponScoreName b)
	{
		return 0;
	}

	protected override void InitPveItems()
	{
	}

	protected override bool OnRefreshPVE(uint itemID)
	{
		return false;
	}

	private void OnExpandBtnClick()
	{
	}

	private void ResetPropertyShow()
	{
	}

	private void ExpandProperty()
	{
	}

	private int GetLines(int num)
	{
		return 0;
	}

	private void InitPropertyView(int num)
	{
	}

	protected override void RefreshCustomizeStyle()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_InitPvpItems()
	{
	}

	public bool _003C_003EiFixBaseProxy_OnRefreshPVP(uint P0, uint P1)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_InitPveItems()
	{
	}

	public bool _003C_003EiFixBaseProxy_OnRefreshPVE(uint P0)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_RefreshCustomizeStyle()
	{
	}
}
