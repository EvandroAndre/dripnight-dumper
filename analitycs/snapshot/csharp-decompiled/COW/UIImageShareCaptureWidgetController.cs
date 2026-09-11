using GCommon;
using UnityEngine;

namespace COW;

public class UIImageShareCaptureWidgetController : UIBaseController
{
	private UIImageShareCaptureWidgetView m_View;

	private UIBRRankIconController m_BRRankIconController;

	private UICSRankIconController m_CSRankIconController;

	private GameObject m_PrimeAvatarFrame;

	private ResourceID m_AvatarFrameRes;

	private UIPrivilegeIconController m_PrivilegeIconController;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void UpdatePlayerBasicInfo(EShareLadderIconType iconType)
	{
	}

	private void RefreshPrimeAvatarFrame(BaseProfileInfo profile, Transform parent)
	{
	}

	private void RefreshPrimeBadge(Transform parent, bool vertical = false)
	{
	}

	private void SetPrivilegeIcon(uint mainType, uint subType, Transform parent)
	{
	}

	private void UpdateBanner(uint bannerId)
	{
	}

	public void UpdateBanner(BannerData bannerdata)
	{
	}

	private void UpdatePlayerBasicInfo_P()
	{
	}

	private void UpdateBanner_P(uint bannerId)
	{
	}

	public void UpdateBanner_P(BannerData bannerdata)
	{
	}

	public void SetTarget(GameObject target, bool hasTopBar, bool hasLeftBar, bool isLandScape, float logoScale, EShareLadderIconType icontype = EShareLadderIconType.None, EShareFFLogoAnchorPos ffLogoAnchorPos = EShareFFLogoAnchorPos.Left, uint brSeasonId = 0u, uint csSeasonId = 0u, bool isProfileInfo = false)
	{
	}

	public void UpdateSpecialLogo(string logoResource, bool isLandSpace, Vector3 adjustPosition, int adjustWidth = 0, int adjustHeight = 0, EShareFFLogoAnchorPos ffLogoAnchorPos = EShareFFLogoAnchorPos.Left)
	{
	}

	public void HideFFLogo()
	{
	}

	private void UpdateFFLogoPos(bool isLeft)
	{
	}

	private void UpdateSeasonInfo(uint brSeasonId = 0u, uint csSeasonId = 0u)
	{
	}

	public GameObject GetLeftTopBg()
	{
		return null;
	}

	public GameObject GetLeftBottomBg()
	{
		return null;
	}

	private void SetCSUIwithScore(int rank, int rankpoint, int peakRankPos)
	{
	}

	public void SetBRUIwithScore(int rank, int rankpoint, uint peakRankPos)
	{
	}

	public void SetUIDLabelVisible(bool isVisible)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
