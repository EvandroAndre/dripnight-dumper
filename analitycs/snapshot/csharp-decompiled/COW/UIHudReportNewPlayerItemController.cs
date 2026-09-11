using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIHudReportNewPlayerItemController : UIEasyListItemController
{
	private UIHudReportNewPlayerItemView m_View;

	private CandidateReporteeData m_Data;

	private static readonly Dictionary<uint, string> RelationKeyDic;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnSelectBtnClick()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	public void DisableSelection()
	{
	}

	public void SetSelected(bool selected)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
