using System.Collections.Generic;
using GCommon;
using UnityEngine;
using message;

namespace COW;

internal class UIHudCSRoundBonusInfoController : UIBaseController
{
	private UIHudCSRoundBonusInfoView m_View;

	private List<GameObject> m_BonusItemList;

	private Color m_DefaultIconColor;

	private const string DEFAULT_CS_ABILITY_POINT_ICON_NAME = "UI_CS_Grow_Icon_Crystal_01";

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetBonusDetailsView(FHCKGNCNMCA res)
	{
	}

	private string GetCSAbilityPointIconName()
	{
		return null;
	}

	private UICoinBonusItem GetBonusItem(int index)
	{
		return null;
	}

	public void RepositionGrid()
	{
	}

	private string GetDescriptionOfBonusType(NALFNCKIBNP bonusType)
	{
		return null;
	}

	private void OnHudSettingChanged(object[] param)
	{
	}

	public bool SetCommonCoinsBonusView(int cnt, NALFNCKIBNP reason)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
