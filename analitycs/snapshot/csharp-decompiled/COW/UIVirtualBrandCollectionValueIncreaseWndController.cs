using System.Collections.Generic;
using GCommon;

namespace COW;

internal class UIVirtualBrandCollectionValueIncreaseWndController : UIBaseController
{
	private UIVirtualBrandCollectionValueIncreaseWndView m_View;

	private UIModelVirtualBrand m_Model;

	private uint m_BrandID;

	private Dictionary<uint, uint> m_BrandToIncreaseValue;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public bool SetViewData(HashSet<uint> itemIDs, bool updateAfterRead)
	{
		return false;
	}

	private void ProcessValueIncrease(HashSet<uint> itemIDs, bool resetBeforeCalcul = true)
	{
	}

	private uint FindMaxIncreaseBrand()
	{
		return 0u;
	}

	private bool SetBrand(uint brandID, bool updateAfterRead)
	{
		return false;
	}

	private void OnBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
