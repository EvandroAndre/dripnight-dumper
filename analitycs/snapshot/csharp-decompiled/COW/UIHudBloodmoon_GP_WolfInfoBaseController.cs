using GCommon;

namespace COW;

internal abstract class UIHudBloodmoon_GP_WolfInfoBaseController : UIBaseController
{
	protected struct WolfInfoViewRefs
	{
		public UILabel CountDownLabel;

		public UILabel WolfKillLabel;
	}

	private WolfInfoViewRefs m_ViewRefs;

	private UITimeLabelHelper m_CountDownHelper;

	protected abstract void BindWolfInfoView();

	protected override void OnUIInit()
	{
	}

	protected void SetWolfInfoViewRefs(WolfInfoViewRefs viewRefs)
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void SetViewData(int currentKillCount, int targetKillCount)
	{
	}

	public void SetTaskEndServerTime(float taskEndServerTimeSec)
	{
	}

	private void Update()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
