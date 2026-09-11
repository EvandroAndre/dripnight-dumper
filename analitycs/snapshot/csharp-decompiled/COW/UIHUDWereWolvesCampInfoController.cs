using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIHUDWereWolvesCampInfoController : UIBaseController
{
	private UIHUDWereWolvesCampInfoView m_View;

	private KeyHelperWereWolvesCampHUD m_KeyHelper;

	private float m_EndTime;

	private float m_TotalTime;

	private int lastLeftTimeS;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void ShowData(bool isWolf, int wolfCount, List<byte> teammateWolfsColorIndex, float endTime, bool isPredictToolOwner)
	{
	}

	private void SetWolfTeamateInfo(List<byte> teammateWolfsColorIndex)
	{
	}

	private void Update()
	{
	}

	private void UpdateLeftTimeShow()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
