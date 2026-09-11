using COW.GamePlay;
using GCommon;

namespace COW;

public class UIHudDragonResultController : UIBaseController
{
	private UIHudDragonResultView m_View;

	private float m_CloseTime;

	private int m_CurTxtNum;

	private FEKBCHODFLE m_AsyncLoadTickets;

	private ResourceID m_UIEffectId;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnEventHide(object[] data)
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void PlayResultAnim(bool isSuccess)
	{
	}

	private void FixedUpdate()
	{
	}

	public void OnShowResultClick()
	{
	}

	private void OnShareBtnClick()
	{
	}

	public override void BeforeScreenshot()
	{
	}

	public override void AfterScreenshot()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	public void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}
}
