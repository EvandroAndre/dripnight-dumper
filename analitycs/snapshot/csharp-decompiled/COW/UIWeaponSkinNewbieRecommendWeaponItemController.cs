using GCommon;

namespace COW;

public class UIWeaponSkinNewbieRecommendWeaponItemController : UIBaseController
{
	private UIWeaponSkinNewbieRecommendWeaponItemView m_View;

	private uint m_WeaponId;

	private NewbieWeaponRecommendDetailData m_Data;

	private bool m_IsCDN;

	private uint m_ShowType;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetWeaponId(uint weaponId, uint showType)
	{
	}

	private void RefreshView()
	{
	}

	private void OnItemClick()
	{
	}

	private string GetCdnUrlByLanguage(string originUrl)
	{
		return null;
	}

	private void OnRecommendIconClick()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
