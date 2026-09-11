using GCommon;

namespace COW;

public class UIHudBigHeadProgressBarController : UIHudDGGProgressBarController
{
	private UIBigHeadGameScene m_UIBigHeadGameScene;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnRankChange(object[] data)
	{
	}

	protected override void UpdateBarDetail(bool isLocalLeading)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_UpdateBarDetail(bool P0)
	{
	}
}
