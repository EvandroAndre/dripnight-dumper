using GCommon;

namespace COW;

public class UIGachaLuckySpinController : UIPopupWindowController
{
	private sealed class _003C_003Ec__DisplayClass9_0
	{
		public UIGachaLuckySpinController _003C_003E4__this;

		public UIGachaController ctrl;

		internal void _003CShowLuckySpinPhase1_003Eb__0()
		{
		}
	}

	private UIGachaLuckySpinView m_View;

	private ILuckySpinContent m_LuckySpin;

	private uint m_Delay1;

	private uint m_Delay2;

	private bool m_Clicked;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnTapToCloseClick()
	{
	}

	public void Init(ILuckySpinContent luckySpin)
	{
	}

	public void ShowLuckySpinPhase1()
	{
	}

	public void ShowLuckySpinPhase2()
	{
	}

	private void _003CShowLuckySpinPhase2_003Eb__10_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
