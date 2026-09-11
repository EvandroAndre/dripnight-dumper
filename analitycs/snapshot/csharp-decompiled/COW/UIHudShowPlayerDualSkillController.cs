using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudShowPlayerDualSkillController : UIBaseController
{
	private UIHudShowPlayerDualSkillView m_View;

	private List<UIHudChooseSkillSlotController> m_ActiveSkillCtrlList;

	private Color Blue;

	private Color Orange;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetPlayerID(BHGGAEEHJCO playerID, bool isTeammate)
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
