using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIHudAuroraInteractPopupController : UIBaseController
{
	private UIHudAuroraInteractPopupView m_View;

	private uint m_DelayCall;

	private List<UIHudAuroraProgressPointView> points;

	private uint m_totalCount;

	public void Init(uint totalCount, uint buffEcaId, string buffTitle)
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetData(float time, uint currentCount)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
