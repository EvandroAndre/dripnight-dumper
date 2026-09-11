using GCommon;

namespace COW;

public class UIUGCMyWorksMapChecklistItemController : UIBaseController
{
	private UIUGCMyWorksMapChecklistItemView m_View;

	public UIUGCMyWorksMapChecklistController.ItemData ItemData;

	private UIUGCMyWorksMapChecklistController m_ParentController;

	private bool m_Expanded;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(UIUGCMyWorksMapChecklistController.ItemData itemData, UIUGCMyWorksMapChecklistController parent)
	{
	}

	public void SetCheckDone(bool value)
	{
	}

	private void OnBtnExpandClick()
	{
	}

	private void OnBtnGotoClick()
	{
	}

	public void Expand()
	{
	}

	public void Unexpand()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
