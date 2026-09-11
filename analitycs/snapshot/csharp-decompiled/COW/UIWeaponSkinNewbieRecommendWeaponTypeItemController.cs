using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIWeaponSkinNewbieRecommendWeaponTypeItemController : UIBaseController
{
	private UIWeaponSkinNewbieRecommendWeaponTypeItemView m_View;

	private NewbieWeaponRecommendData m_Data;

	private List<UIWeaponSkinNewbieRecommendWeaponItemController> m_WeaponCtrls;

	private List<NewbieWeaponRecommendDetailData> m_Weapons;

	private UIModelCollection m_ModelCollection;

	private const int MAX_DETAIL_DATA_COUNT = 2;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetData(NewbieWeaponRecommendData data)
	{
	}

	private void OnItemClick()
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
