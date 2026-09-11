using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIActivityIndependentContentController : UIActivityContentController, IUIModelDataChangeObserver
{
	private ActivityGroupDesc m_GroupDesc;

	private List<UIActivityIndependentItemController> m_ItemControllers;

	private UIActivityIndependentContentView m_View;

	private UIModelActivity m_Model;

	private bool m_ShowModel;

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

	public override void SetData(object data)
	{
	}

	private void RefreshActivityInfo()
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_SetData(object P0)
	{
	}
}
