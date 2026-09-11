using COW.GamePlay;
using GCommon;

namespace COW;

internal class UIHudSkillCastingController : UIBaseController
{
	private UIHudSkillCastingView m_View;

	private HBLKLJHFJDK m_ActiveSkill;

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

	public void OnCastActiveSkill(object[] param)
	{
	}

	protected void Update()
	{
	}

	public void OnStopActiveSkill(object[] param)
	{
	}

	private void OnCancelCasting()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
