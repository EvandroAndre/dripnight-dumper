using GCommon;

namespace COW;

public class UIUGCLikeIndicatorController : UIBaseController
{
	private UIUGCLikeIndicatorView m_View;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(float likeRate, ulong likeCount, ulong unlikeCount, bool isWorkshopDetail = false)
	{
	}

	private void OnLikeBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
