using GCommon;
using proto;

namespace COW;

public class UIActivityBindContentController : UIActivityContentController, IUIModelDataChangeObserver
{
	private ClientActivityDesc m_Desc;

	private UIActivityBindContentView m_View;

	private UIModelActivity m_Model;

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

	private void OnCliamClick()
	{
	}

	private void OnTopUpClick()
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
