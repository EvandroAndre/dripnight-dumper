using GCommon;

namespace COW;

internal class UIHudBuffIntroController : UIPopupWindowController
{
	private UIHudBuffIntroView m_View;

	private float m_EndTime;

	private float m_TotalTime;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetData(float endTime, uint dataId)
	{
	}

	private void FixedUpdate()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
