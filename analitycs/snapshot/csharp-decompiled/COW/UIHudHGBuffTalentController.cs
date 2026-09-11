using GCommon;

namespace COW;

public class UIHudHGBuffTalentController : UIBaseController
{
	private UIHudHGBuffTalentView m_View;

	public bool showweapon;

	private bool showbuff;

	private bool showTalent;

	private UIModelHuntingGround m_Model;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnBtnBuffClick()
	{
	}

	public void UpdateBuffAndTalentStatus(bool show)
	{
	}

	protected override void OnDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}
}
