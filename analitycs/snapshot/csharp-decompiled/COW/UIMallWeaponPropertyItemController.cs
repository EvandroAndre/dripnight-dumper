using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIMallWeaponPropertyItemController : UIBaseController
{
	private UIMallWeaponPropertyItemView m_View;

	private WeaponScoreName m_ScoreName;

	private List<GameObject> m_UpIconList;

	private List<GameObject> m_DownIconList;

	private Color COLOR_SCORE_RED;

	private Color COLOR_SCORE_GREEN;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetUIData(WeaponScoreName name, uint wpid, uint skinId = 0u)
	{
	}

	private void SetUIData(uint wpid, uint skinId = 0u)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
