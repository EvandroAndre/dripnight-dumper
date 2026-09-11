using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

internal class UICollectionScoreItemController : UIBaseController
{
	private UICollectionScoreItemView m_View;

	private WeaponScoreName m_ScoreName;

	private Color COLOR_SCORE_RED;

	private Color COLOR_SCORE_GREEN;

	private List<GameObject> m_UpIconList;

	private List<GameObject> m_DownIconList;

	private bool m_CanRefreshByEvent;

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

	public void SetUIData(WeaponScoreName name, uint wpid, uint skinId = 0u)
	{
	}

	public void SetUIData(uint wpid, uint skinId = 0u)
	{
	}

	private void EnapblePropertyScoreTweenAlpha(object[] data)
	{
	}

	private void SetAllScoreTweenAlpha(object[] data)
	{
	}

	private void OnWeaponSkinChanged(object[] data)
	{
	}

	public void SetArrowOffSet(int x)
	{
	}

	public void ChangeScoreColor(Color color)
	{
	}

	public void ForbidRefreshByEvent()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
