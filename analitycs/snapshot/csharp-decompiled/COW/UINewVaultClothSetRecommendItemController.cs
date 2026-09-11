using System.Collections.Generic;
using GCommon;

namespace COW;

public class UINewVaultClothSetRecommendItemController : UIEasyListItemController
{
	private UINewVaultClothSetRecommendItemView m_View;

	private UIModelAvatar m_ModelAvatar;

	private UIModelInventory m_ModelInventory;

	private uint m_SetID;

	private List<UIStandardItemMAXBController> m_ClothSetList;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	public override void OnItemBtnSelect()
	{
	}

	public override void OnItemBtnUnSelect()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private bool HasMultipleLinkSetId(AvatarWardrobeData item)
	{
		return false;
	}

	private int _003CSetViewData_003Eb__7_0(AvatarWardrobeData item)
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
