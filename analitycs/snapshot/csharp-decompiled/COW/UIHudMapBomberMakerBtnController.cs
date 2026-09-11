using System;
using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIHudMapBomberMakerBtnController : UIBaseController
{
	private UIHudMapBomberMakerBtnView m_View;

	private Action m_onChoosePositionClick;

	private bool m_Enable;

	private List<uint> m_ItemIds;

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

	public void SetData(Action onChoosePositionClick, List<uint> itemIds)
	{
	}

	public void SetBomberMakerCount(int bomberMakerCount)
	{
	}

	private void OnBtnClick()
	{
	}

	private void OnBomberMakerCountChange()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
