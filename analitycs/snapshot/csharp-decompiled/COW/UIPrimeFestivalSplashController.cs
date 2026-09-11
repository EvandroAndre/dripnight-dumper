using GCommon;

namespace COW;

public class UIPrimeFestivalSplashController : UIPopupWindowController
{
	private UIPrimeFestivalSplashView m_View;

	private PrimeFestivalPopupData m_Data;

	private UIModelPrime m_ModelPrime;

	private uint m_DelayCall;

	private string IN_ANIM;

	private string IDLE_ANIM;

	private string SHOW_OPEN_ANIM;

	private string OUT_ANIM;

	private string OPEN_IDLE_ANIM;

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

	public void SetViewData(PrimeFestivalPopupData data)
	{
	}

	private void OnClaimBtnClick()
	{
	}

	private void OnOpenEnvelopeBtnClick()
	{
	}

	private void OnCloseBtnClick()
	{
	}

	private void _003COnCloseBtnClick_003Eb__15_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
