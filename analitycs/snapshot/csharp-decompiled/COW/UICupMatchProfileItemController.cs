using GCommon;

namespace COW;

internal class UICupMatchProfileItemController : UIBaseController
{
	private UICupMatchProfileItemView m_View;

	private UINetworkTexture m_HeadTexture;

	private UISprite m_HeadIcon;

	private UILabel m_Name;

	private UISprite m_LeaderIcon;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(bool isRight, BaseProfileInfo info, bool isLeader = false)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
