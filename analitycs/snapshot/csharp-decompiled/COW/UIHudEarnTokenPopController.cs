using System;
using GCommon;

namespace COW;

public class UIHudEarnTokenPopController : UIBaseController
{
	private UIHudEarnTokenPopView m_View;

	private uint m_DelayCall;

	private Action m_DelayCallAction;

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

	public void SetData(uint data)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
