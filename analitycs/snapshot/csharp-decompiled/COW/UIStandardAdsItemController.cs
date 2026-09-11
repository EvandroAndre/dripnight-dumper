using GCommon;

namespace COW;

public class UIStandardAdsItemController : UIBaseController
{
	private UIStandardAdsItemView m_View;

	public int AdIndex;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public virtual void RefreshUIData(UIModelLobbyAds.AdInfo info)
	{
	}

	public virtual void OnCenterIn(bool isLeft)
	{
	}

	public virtual void OnCenterFinish()
	{
	}

	public virtual void OnCenterOut(bool isLeft)
	{
	}

	public void SetTextureSize(float width, float height)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
