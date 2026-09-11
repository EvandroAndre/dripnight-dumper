using GCommon;

namespace COW;

public class UIBriefBoxInteractionItemController : UIBaseController
{
	private UIBriefBoxInteractionItemView m_View;

	private UIBriefBoxInteractionItemData m_Data;

	private UIBriefBoxController m_BriefBoxCtrl;

	private string m_PrimeBgName;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(UIBriefBoxInteractionItemData data)
	{
	}

	private bool ChangePrimeSkin()
	{
		return false;
	}

	private void OnInteractionBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
