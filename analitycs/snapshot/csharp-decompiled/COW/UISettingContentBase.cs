using GCommon;

namespace COW;

public class UISettingContentBase : UIBaseController
{
	protected bool IsIngameShow;

	protected string m_ResetContent;

	public SettingPageType PageType;

	public virtual void SetInGameShow(bool isInGame)
	{
	}

	protected override void OnUIInit()
	{
	}

	protected virtual void InitSettingInfo()
	{
	}

	public virtual void RefreshContent(object[] param)
	{
	}

	protected void LogEventClick(string[] hierarchy)
	{
	}

	public virtual void ProcessReset()
	{
	}

	public virtual void ResetToDefault()
	{
	}

	private void _003CProcessReset_003Eb__8_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
