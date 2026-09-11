using System;
using GCommon;

namespace COW;

public class UIHudReporteeItemController : UIBaseController
{
	public enum EReporteeUIType
	{
		Killer,
		Damager,
		TeamMate
	}

	private CandidateReporteeData m_Data;

	private Action<CandidateReporteeData> m_ClickCB;

	private float m_NamePosY;

	private UIHudReporteeItemView m_View;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnBtnClick()
	{
	}

	public void SetViewData(CandidateReporteeData data, Action<CandidateReporteeData> clickCB, ulong uid, string playerName, CandidateReporteeType type)
	{
	}

	public void SetSelected(ulong uid)
	{
	}

	private void ChangeNamePos(float posY)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
