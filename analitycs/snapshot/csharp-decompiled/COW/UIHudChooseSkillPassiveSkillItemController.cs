using COW.GamePlay;
using GCommon;
using UnityEngine;

namespace COW;

public class UIHudChooseSkillPassiveSkillItemController : UIBaseController
{
	private UIHudChooseSkillPassiveSkillItemView m_View;

	private uint m_SkillID;

	private bool m_EnableRemove;

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

	public void SetData(uint skillID, bool enableRemove = false)
	{
	}

	public void UpdateRemovedStatus(uint skillID)
	{
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
