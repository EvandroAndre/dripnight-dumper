using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIPetNormalGridController : UIBaseController, IEasyList
{
	private UIPetNormalScrollViewView m_View;

	private UIShowType m_ShowGridFlag;

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

	public void ShowActionGridList(List<PetActionData> dataShowList)
	{
	}

	public void ShowSkinGridList(List<PetSkinData> dataShowList)
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void ShowItemAtIndex<T>(int index) where T : UIEasyListItemController
	{
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
