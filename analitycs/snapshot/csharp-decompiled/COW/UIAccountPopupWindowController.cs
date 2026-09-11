using GCommon;

namespace COW;

public class UIAccountPopupWindowController : UIPopupWindowController, IUIModelDataChangeObserver
{
	private enum State
	{
		Register,
		Login
	}

	private UIAccountPopupWindowView m_View;

	private State _State;

	private bool m_SavePassward;

	private string m_RegionString;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void Awake()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void OnRightButtonClick()
	{
	}

	private void SetTitle(string title)
	{
	}

	private void ToggleState(State state)
	{
	}

	public void RefreshRegionLabel()
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

	public void _003C_003EiFixBaseProxy_Awake()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
