using GCommon;
using proto;

namespace COW;

internal class UIMysteryMallItemController : UIBaseController
{
	private UIMysteryMallItemView m_View;

	private BaseItemInfo m_BaseItemInfo;

	protected bool m_IsUniqueAndOwned;

	private MysteryPoolStoreItem m_PoolItemInfo;

	public bool FullScreenPreviewForVoicePackage;

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

	public void SetViewData(MysteryPoolStoreItem poolItem, bool isSuperReward, uint discount)
	{
	}

	private void SetPriceLabel(uint gemsPrice, uint discountPrice)
	{
	}

	private void OnBtnPurchaseClick()
	{
	}

	private void OnBtnPreviewClick()
	{
	}

	private bool CanUseFullScreenPreview(uint itemId)
	{
		return false;
	}

	private bool IsVoicePackageItem(uint itemId)
	{
		return false;
	}

	public void SetLimitTitleState(bool show)
	{
	}

	public void SetClaimedState(bool show)
	{
	}

	public void SetLockState(bool value)
	{
	}

	private void SetIPTag()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
