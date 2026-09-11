using GCommon;

namespace COW;

internal class UIHudWeaponAffixTipController : UIBaseController
{
	private const float AUTO_CLOSE_DELAY = 2f;

	private UIHudWeaponAffixTipView m_View;

	private uint m_DelayCall;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override bool RecyleDontDestroy()
	{
		return false;
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void SetData(bool showIcon, string iconName)
	{
	}

	private void OnDelayCall()
	{
	}

	public bool _003C_003EiFixBaseProxy_RecyleDontDestroy()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
