using GCommon;

namespace COW;

public class UIEvoGunCarouselItemController : UIBaseController
{
	private UIEvoGunCarouselItemView m_View;

	private WeaponSkinUpgradeInfoData _003CSkinUpgradeInfo_003Ek__BackingField;

	private int m_Index;

	public WeaponSkinUpgradeInfoData SkinUpgradeInfo
	{
		get
		{
			return _003CSkinUpgradeInfo_003Ek__BackingField;
		}
		private set
		{
			_003CSkinUpgradeInfo_003Ek__BackingField = value;
		}
	}

	public int Index => 0;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(ResourceID spriteResID, string labelKey, int index)
	{
	}

	public void SetUpgradeInfoData(WeaponSkinUpgradeInfoData info)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
