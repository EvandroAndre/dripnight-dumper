using GCommon;
using message;

namespace COW;

internal class UIFootballSkillSelectController : UIPopupWindowController
{
	private UIFootballSkillSelectView m_View;

	private float m_RemainingTime;

	private float m_TotalTime;

	private float m_StartTime;

	private bool m_StartShow;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override bool ClosedByEsc()
	{
		return false;
	}

	public void SetViewData(IDCBLNGKFFG selectedType, float remainingTime)
	{
	}

	private void Update()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public bool _003C_003EiFixBaseProxy_ClosedByEsc()
	{
		return false;
	}
}
