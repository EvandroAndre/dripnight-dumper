using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UIActivityAccumulateContentController : UIActivityContentController, IUIModelDataChangeObserver
{
	private enum OperateStatus
	{
		GoTo,
		Available,
		Received
	}

	private const int TOTALWIDTH = 490;

	private const int FIRSTOFFSET = 30;

	private ActivityGroupDesc m_GroupDesc;

	private List<UIActivityAccumulateItemController> m_ProgressItemControllers;

	private UIActivityAccumulateContentView m_View;

	private UIModelActivity m_Model;

	private uint m_MaxAccumulate;

	private OperateStatus m_OperateState;

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

	private int SortByCondtionValue(ClientActivityDesc a, ClientActivityDesc b)
	{
		return 0;
	}

	public void RefreshActivityInfo()
	{
	}

	private void RefreshOperateState()
	{
	}

	private void OperationBtnClick()
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
