using System;
using GCommon;

namespace COW;

public class UIHudActivityPopupController : UIBaseController
{
	public class InstantiationContext : IDisposable
	{
		private readonly ResourceID m_PreviousResourceID;

		public InstantiationContext(ResourceID resID)
		{
		}

		public void Dispose()
		{
		}
	}

	private static ResourceID m_ResourceID;

	private UIHudActivityPopupView m_View;

	private float m_delayCallTime;

	private int m_TopAnchorAbsolute;

	private int m_BottomAnchorAbsolute;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetMessage(string message, ResourceID showIcon, float duration, int yOffset = 0)
	{
	}

	private void CancelDelayCall()
	{
	}

	private void Update()
	{
	}

	protected override void OnDestroy()
	{
	}

	public void SetDepth(int depth)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}
}
