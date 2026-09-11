using GCommon;
using UnityEngine;
using proto;

namespace COW;

internal class UIClanTrendHighLightShowItemController : UIBaseController
{
	private UIClanTrendHighLightShowItemView m_View;

	private Vector3 m_BriefBoxShowPos;

	private ClanHighLightInfo m_MemberInfo;

	private UIClanTrendPageController m_Parent;

	private ClanMember m_ClanMemeberInfo;

	private UIBRRankIconController m_BRRankIconController;

	private UICSRankIconController m_CSRankIconController;

	private UIModelClanTrend m_ModelTrend;

	private UIModelClan m_ModelClan;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void SetViewData(ClanHighLightInfo info)
	{
	}

	private void OnProfileInfoBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
