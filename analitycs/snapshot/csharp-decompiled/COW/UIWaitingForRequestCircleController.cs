using GCommon;

namespace COW;

internal class UIWaitingForRequestCircleController : UIWaitingForRequestController
{
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public virtual void SetMaskState(bool state)
	{
	}

	public void SetWaitRemind(string remind)
	{
	}
}
