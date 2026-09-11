using GCommon;

namespace COW;

internal class UIHudSuicideController : UIBaseController
{
	private UIHudSuicideView m_View;

	private float m_SuicideEndTime;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void Update()
	{
	}

	public float Progress()
	{
		return 0f;
	}

	private void OnBtnClick()
	{
	}

	private void OnCancelBtnClick()
	{
	}

	private void OnPreparationCancel(GEvent param)
	{
	}

	private void OnExecuteSuicide()
	{
	}

	private void ResetStatus()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
