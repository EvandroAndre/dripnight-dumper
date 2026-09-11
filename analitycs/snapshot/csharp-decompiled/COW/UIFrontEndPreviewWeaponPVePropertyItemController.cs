using GCommon;
using UnityEngine;

namespace COW;

public class UIFrontEndPreviewWeaponPVePropertyItemController : UIBaseController
{
	private UIFrontEndPreviewWeaponPVePropertyItemView m_View;

	private Color COLOR_SCORE_RED;

	private Color COLOR_SCORE_GREEN;

	private Color COLOR_WEAPONMAIN_BG;

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

	public void SetUIData(WeaponScoreName scoreName, uint wpid, uint skinId = 0u, UIFrontEndPreviewWeaponPropertyItemStyle style = UIFrontEndPreviewWeaponPropertyItemStyle.Normal, WeaponPropertyPanelMaxFrom from = WeaponPropertyPanelMaxFrom.Other)
	{
	}

	public void SetArrowOffSet(int x)
	{
	}

	public void RefreshUIByStyleAndFrom(UIFrontEndPreviewWeaponPropertyItemStyle style, WeaponPropertyPanelMaxFrom from)
	{
	}

	private void SetBarBgColor(Color color)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
