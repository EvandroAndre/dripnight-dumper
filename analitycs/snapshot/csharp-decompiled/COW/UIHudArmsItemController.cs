using COW.GamePlay;
using GCommon;

namespace COW;

public class UIHudArmsItemController : UIBaseController
{
	private UIHudArmsItemView m_View;

	public static readonly string m_SpriteNamePrefix;

	private uint m_DelayCall;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetData(KCIPKBBMIOJ armsInfo)
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void _003CSetData_003Eb__5_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
