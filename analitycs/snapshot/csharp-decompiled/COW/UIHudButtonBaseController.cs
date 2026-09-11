using GCommon;

namespace COW;

public abstract class UIHudButtonBaseController : UIBaseController
{
	protected bool IsButtonDown;

	private UIHudButtonBlockController m_BlockCtrl;

	protected override void OnUIDestory()
	{
	}

	protected virtual void OnBtnDown()
	{
	}

	protected virtual void OnBtnUp()
	{
	}

	protected virtual void OnBtnClick()
	{
	}

	protected void CancelFollowEmoteByOperationInput(bool cancelLeader = true)
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	protected void InitEventTrigger(UIButton button)
	{
	}

	protected abstract string GetMappingName();

	public void SetBlockBtn(bool block)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
