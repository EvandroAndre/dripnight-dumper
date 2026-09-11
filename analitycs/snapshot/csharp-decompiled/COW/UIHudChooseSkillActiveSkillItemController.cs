using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudChooseSkillActiveSkillItemController : UIBaseController
{
	private UIHudChooseSkillActiveSkillItemView m_View;

	private uint m_SkillID;

	private IJKMLLKGDPJ m_ChooseSkillMgr;

	private float m_OnPressedTime;

	private bool m_IsPopoverOpen;

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

	public bool SetData(uint skillID)
	{
		return false;
	}

	public void OnDetailBtnClick(GameObject go, bool value)
	{
	}

	private void Update()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
