using GCommon;
using UnityEngine;

namespace COW;

public class UIPrimePrivilegeBannerController : UIBaseController
{
	private UIPrimePrivilegeBannerView m_View;

	private UIBaseProfileInfoController m_ProfilePreview;

	private UIModelCollection m_ModelCollection;

	private GameObject m_PrimeAvatarFrame;

	private uint m_HeadID;

	private uint m_BannerID;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void UpdateHeadPicAndBanner(uint headID, uint bannerId)
	{
	}

	public void UpdataHeadPic(uint headID)
	{
	}

	public void UpdateBriefBanner(uint bannerId)
	{
	}

	public void UpdatePersonalProfileAndAvatarFrame()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
