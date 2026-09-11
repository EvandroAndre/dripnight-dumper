using System.Collections.Generic;
using COW.GamePlay;
using GCommon;

namespace COW;

public class UIHudWolfTaskController : UIBaseController
{
	private class WolfTaskButton
	{
		public UIButton button;

		public UISprite icon;

		public UITweener[] anim;

		public MICOLHIEIOC info;

		public void OnButtonClick()
		{
		}

		public void RefreshIcon()
		{
		}
	}

	private UIHudWolfTaskView m_View;

	private List<WolfTaskButton> m_ButtonList;

	private List<MICOLHIEIOC> m_TaskList;

	private bool m_ButtonOpen;

	private float m_cdTime;

	private float m_tarTime;

	private bool m_Dead;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnDestroy()
	{
	}

	protected override void OnUIOpen()
	{
	}

	private void ToggleButtons()
	{
	}

	private void InitTaskButton(UIButton button, UISprite icon)
	{
	}

	private void OnRoleChange(object[] data)
	{
	}

	private void OnRefreshWolfTask(object[] data)
	{
	}

	private int Cmp(MICOLHIEIOC infoA, MICOLHIEIOC infoB)
	{
		return 0;
	}

	private void OnRefreshSkillCD(object[] data)
	{
	}

	private void SetTaskCoolDown(bool value)
	{
	}

	private void LateUpdate()
	{
	}

	public UIButton GetTutorialBtn()
	{
		return null;
	}

	public UIWidget GetTutorialWidget()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}
}
