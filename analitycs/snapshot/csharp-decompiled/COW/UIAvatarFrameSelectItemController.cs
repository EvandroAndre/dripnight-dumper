using GCommon;
using UnityEngine;

namespace COW;

public class UIAvatarFrameSelectItemController : UIEasyListItemController
{
	private UIAvatarFrameSelectItemView m_View;

	private GameObject m_AvatarFrameObj;

	private ResourceID m_AvatarFrameRes;

	private AvatarFrameBaseInfo m_Data;

	private UIModelPrime m_ModelPrime;

	private UIModelCollection m_ModelCollection;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void SetViewData(object data, int index)
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
