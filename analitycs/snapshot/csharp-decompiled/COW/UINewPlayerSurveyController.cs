using GCommon;

namespace COW;

public class UINewPlayerSurveyController : UIBaseController, IUIModelDataChangeObserver
{
	protected UINewPlayerSurveyView m_View;

	private string m_link;

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

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void RefreshLink()
	{
	}

	private void onSurveyClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
