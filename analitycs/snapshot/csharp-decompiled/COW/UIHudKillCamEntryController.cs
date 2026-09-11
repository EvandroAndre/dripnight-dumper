using GCommon;

namespace COW;

internal class UIHudKillCamEntryController : UIBaseController
{
	private UIHudKillCamEntryView m_View;

	private uint m_KillCamAutoHideDelayCallID;

	private uint m_AutoKillCamDelayCallID;

	private float m_StartShowTime;

	private const float KILLCAM_ENTRY_MAX_TIME = 15f;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void OnKillCamEntryShow()
	{
	}

	private void RefreshSpecialSkillTip()
	{
	}

	private void ResetAndHideUI()
	{
	}

	protected void Update()
	{
	}

	protected void CancelAllDelayCalls()
	{
	}

	protected override void RefreshVisibility(bool move = false)
	{
	}

	private void OnUIHudKillCamEntryClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshVisibility(bool P0)
	{
	}
}
