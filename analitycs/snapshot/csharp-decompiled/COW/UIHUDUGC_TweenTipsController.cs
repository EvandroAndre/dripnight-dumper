using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIHUDUGC_TweenTipsController : UIHUDUGC_InternalHudController
{
	private UGCTweenTipsHudRepItem m_ViewData;

	private uint m_DelayCallID;

	private int m_EventType;

	private string m_Description;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public override void SetEntityID(string entityID)
	{
	}

	public override void DestroyEntity()
	{
	}

	private void OnOpenStateChanged(bool cur)
	{
	}

	private void OnEventTipsTypeChanged(int cur)
	{
	}

	private void OnDescriptionChanged(string cur)
	{
	}

	private void OnParamChanged(List<object> cur)
	{
	}

	private void OnLocSwitchChanged(bool cur)
	{
	}

	private void ShowTweenTips()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_SetEntityID(string P0)
	{
	}

	public void _003C_003EiFixBaseProxy_DestroyEntity()
	{
	}
}
