using System.Collections.Generic;
using COW.GamePlay;
using GCommon;

namespace COW;

internal class UIHudTeleportKnockDownResultController : UIBaseController
{
	private GIDJFFAEINE m_TeleportKnockDownSkill;

	private List<UIHudTeleportKnockDownResultItemController> m_UIItems;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void Hide()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void SetResult(GIDJFFAEINE skill, List<uint> playerIds)
	{
	}

	private void LateUpdate()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_Hide()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
