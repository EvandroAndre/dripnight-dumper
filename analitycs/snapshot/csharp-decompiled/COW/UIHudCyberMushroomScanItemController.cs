using GCommon;

namespace COW;

public class UIHudCyberMushroomScanItemController : UIBaseController
{
	private const float m_VfxMaxWeight = 118f;

	private VisualInstanceHolder m_SelfScanningBlueVfxHolder;

	private VisualInstanceHolder m_EnemyScanningRedVfxHolder;

	private UIHudCyberMushroomScanItemView m_View;

	private float m_VfxScale;

	private float m_AllEndTime;

	private uint m_EndDelayCall;

	private uint m_ID;

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

	public void SetData(float scale)
	{
	}

	public void SetInfo(uint id, bool isSelf, float TimeRemaining)
	{
	}

	public void OnEndTime()
	{
	}

	private void SetVfxScale()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
