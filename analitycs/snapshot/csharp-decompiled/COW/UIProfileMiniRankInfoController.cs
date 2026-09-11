using GCommon;
using UnityEngine;
using proto;

namespace COW;

internal class UIProfileMiniRankInfoController : UIBaseController
{
	private UIProfileMiniRankInfoView m_View;

	private UIModelPeriodicLadderMatch m_Model;

	private GameObject[] m_CSStarArray;

	private GameObject[] m_CSBlackStarArray;

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

	public void SetViewData(CSPlayerPeriodicRankingInfoRes info)
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
