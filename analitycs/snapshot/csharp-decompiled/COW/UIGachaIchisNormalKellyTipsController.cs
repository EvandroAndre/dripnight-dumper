using GCommon;

namespace COW;

public class UIGachaIchisNormalKellyTipsController : UIBaseController
{
	private const string LOC_KEY_POOL_EMPTY = "T_54_ZT_ICHIS67";

	private const string LOC_KEY_JACKPOT_LOW = "T_54_ZT_ICHIS58";

	private UIGachaIchisNormalKellyTipsView m_View;

	private IchisKellyTipsMode m_Mode;

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

	public void SetTipsMode(IchisKellyTipsMode mode)
	{
	}

	private void ApplyText()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
