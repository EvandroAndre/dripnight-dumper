using GCommon;
using message;

namespace COW.HUD;

public class UIHudToxicBehaviorWarningWndController : UIBaseController
{
	private UIHudToxicBehaviorWarningWndView m_View;

	private int m_TimeLeft;

	private float m_Percent;

	private uint m_DelayCall;

	private EWarningWndType m_WarningWndType;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetToxicBehaviorView()
	{
	}

	public void SetFriendlyReminderView(GLNFAPKACOH friendlyReminderType)
	{
	}

	public void SetCommonView(EWarningWndType eWarningWndType, InGameWarningWndColorType colorType, string title, string content)
	{
	}

	private void SetTitleColor(InGameWarningWndColorType color, string tilte)
	{
	}

	private string GetStringByFriendlyReminderType(GLNFAPKACOH friendlyReminderType)
	{
		return null;
	}

	private void CountDown()
	{
	}

	private void OnCloseBtn()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
