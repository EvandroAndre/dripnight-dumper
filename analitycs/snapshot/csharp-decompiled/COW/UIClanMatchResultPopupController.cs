using GCommon;
using proto;

namespace COW;

public class UIClanMatchResultPopupController : UIPopupWindowController, IUIModelDataChangeObserver
{
	private UIClanMatchResultPopupView m_View;

	private UIModelChampionship m_ModelChampionship;

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

	public void SetResultAttachData(FakeSubmitRes clanMatchResult)
	{
	}

	private void SetClanInfo()
	{
	}

	private void RefreshCupIcon(FakeSubmitRes clanMatchResult)
	{
	}

	protected override void OnUIClose()
	{
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

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
