using System;
using GCommon;
using proto;

namespace COW;

public class UIMallV2IntimacyProfileInfoController : UIBaseController
{
	private UIMallV2IntimacyProfileInfoView m_View;

	private Action m_InfoBtnClickCallback;

	private FriendInfo m_SelectFriendInfo;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetInfoBtnClickCallback(Action callback)
	{
	}

	public void OnInfoBtnClick()
	{
	}

	public void SetPlayerInfo(FriendInfo friendInfo, bool force = false)
	{
	}

	public void RefreshPlayerInfoView()
	{
	}

	private void UpdateBanner(uint bannerId)
	{
	}

	private void UpdateBanner(BannerData bannerData)
	{
	}

	private void UpdateHeadPic(uint iid, ulong accountId, string externalIcon, EAccount.ExternalIconStatus externalIconStatus, EAccount.ExternalIconShowType externalIconShowType)
	{
	}

	private void UpdateHeadPic(HeadPicData data)
	{
	}

	public void RefreshPlayerIntimacyValue(uint giftCommodityID, bool isPrimeGift, uint count = 1u)
	{
	}

	public void RefreshPlayerIntimacyValue(GiftItem giftItem, bool isPrimeGift, uint count = 1u)
	{
	}

	public void RefreshPlayerIntimacyValue(uint addValue)
	{
	}

	public void RefreshPlayerIntimacyValue(bool forceUpdate = false)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
