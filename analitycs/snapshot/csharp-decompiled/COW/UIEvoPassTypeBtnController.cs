using GCommon;

namespace COW;

public class UIEvoPassTypeBtnController : UIBaseController, IUIModelDataChangeObserver
{
	private UIEvoPassTypeBtnView m_View;

	private ClientEvoPassData m_Data;

	private UIModelEvoPass m_ModelEvoPass;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetData(ClientEvoPassData data)
	{
	}

	private void OnTypeClick()
	{
	}

	public void Refresh()
	{
	}

	public UIToggleButton GetToggleButton()
	{
		return null;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
