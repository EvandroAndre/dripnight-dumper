using GCommon;

namespace COW.HUD;

internal class UIHudAssistantTextController : UIBaseController
{
	private UIHudAssistantTextView m_View;

	private const float SHOW_ASSISTANT_LINE_DURATION = 3f;

	private uint m_delayCallID;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void ShowLine(string name, string line)
	{
	}

	private void HideUI()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
