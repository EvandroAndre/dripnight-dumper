using GCommon;
using proto;

namespace COW;

public class UILegendClothVaultFeatureItemController : UIBaseController
{
	private UILegendClothVaultFeatureItemView m_View;

	private LegendClothVaultFeature m_FeatureType;

	private LegendClothPrivilege m_Data;

	private uint m_LegendId;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void SetData(LegendClothPrivilege data, uint legendId)
	{
	}

	private void OnBtnFeatureClick()
	{
	}

	private void OnFeatureShow(object[] data)
	{
	}

	private void SetQualityBG(EInventory.RareType rare)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
