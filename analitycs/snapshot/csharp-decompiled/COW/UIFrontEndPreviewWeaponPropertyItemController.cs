using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIFrontEndPreviewWeaponPropertyItemController : UIBaseController
{
	private UIFrontEndPreviewWeaponPropertyItemView m_View;

	private WeaponScoreName m_ScoreName;

	private Color COLOR_SCORE_DEFAULT;

	private Color COLOR_SCORE_RED;

	private Color COLOR_SCORE_GREEN;

	private Color COLOR_WEAPONMAIN_BG;

	private Color COLOR_HACKERSTORE_BG;

	private Vector3 ElitePassNamePos;

	private Vector3 ElitePassBarPos;

	private List<GameObject> m_UpIconList;

	private List<GameObject> m_DownIconList;

	private float m_Property;

	private Color COLOR_DETAIL_BARFG;

	private Color COLOR_DETAIL_DELTABG;

	public float Property => 0f;

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

	public void SetUIData(WeaponScoreName name, uint wpid, uint skinId = 0u, UIFrontEndPreviewWeaponPropertyItemStyle style = UIFrontEndPreviewWeaponPropertyItemStyle.Normal, WeaponPropertyPanelMaxFrom from = WeaponPropertyPanelMaxFrom.Other)
	{
	}

	private void SetUIDataByNameAndScore(int score)
	{
	}

	private void EnapblePropertyScoreTweenAlpha(object[] data)
	{
	}

	private void SetAllScoreTweenAlpha(object[] data)
	{
	}

	public void RefreshUIByStyleAndFrom(UIFrontEndPreviewWeaponPropertyItemStyle style, WeaponPropertyPanelMaxFrom from)
	{
	}

	private void SetArrowOffSet(int x)
	{
	}

	private void SetBarBgColor(Color color)
	{
	}

	public void ChangeColorInDetailPop(float oriProperty)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
