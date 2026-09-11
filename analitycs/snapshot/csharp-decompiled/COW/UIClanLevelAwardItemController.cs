using GCommon;
using proto;

namespace COW;

public class UIClanLevelAwardItemController : UIBaseController
{
	private UIClanLevelAwardItemView m_View;

	private const float DELAY_UNLOCK_ANIM = 1.83f;

	private const float DELAY_LOCK_ANIM = 0.63f;

	private uint m_DelayCallPlayLockAnim;

	private uint m_DelayCallPlayUnlockAnim;

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

	public void SetViewData(ExchangeStoreItemDesc desc, bool islock, bool isConvert = false)
	{
	}

	private void _003CSetViewData_003Eb__8_0()
	{
	}

	private void _003CSetViewData_003Eb__8_1()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
