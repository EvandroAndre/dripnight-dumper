using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudMetropolisMapAreaController : UIBaseController
{
	private UIHudMetropolisMapAreaView m_View;

	private ICEGOFFPFMB m_Game;

	private uint m_CurSelectArea;

	private Dictionary<uint, UIHudMetropolisMapAreaItemController> m_AreaItemCtrlDict;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private int SortArea(Transform tr1, Transform tr2)
	{
		return 0;
	}

	public void RefreshAreaOnShowMap()
	{
	}

	private void OnShowMetropolisAreaOnMap(object[] param)
	{
	}

	private void OnMetropolisAreaStateChange(object[] param)
	{
	}

	private void OnMetropolisAreaStateEndTimeChange(object[] param)
	{
	}

	private void OnMetropolisAreaGameChange(object[] param)
	{
	}

	private void OnMetropolisAreaSelect(object[] param)
	{
	}

	private void OnMetropolisAreaTrack()
	{
	}

	public void OnBtnCloseClick()
	{
	}

	private void OnBtnOpenMissionClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
