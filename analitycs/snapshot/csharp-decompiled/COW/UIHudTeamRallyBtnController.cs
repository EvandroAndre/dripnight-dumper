using GCommon;

namespace COW;

internal class UIHudTeamRallyBtnController : UIBaseController
{
	private UIHudTeamRallyBtnView m_View;

	private float m_CooldownEndTime;

	private bool m_IsInCooldown;

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

	public void SetViewData()
	{
	}

	private void RefreshView()
	{
	}

	private void SetButtonEnabled(bool enabled)
	{
	}

	private void UpdateCooldownDisplay(float remaining, float total)
	{
	}

	private void ResetCooldownDisplay()
	{
	}

	private void ResetView()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void Update()
	{
	}

	private void OnRallyBtnClick()
	{
	}

	private void StartLocalCooldown()
	{
	}

	private void OnTeamRallyCooldownSync(uint requesterPlayerID)
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

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
