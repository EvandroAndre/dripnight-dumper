using GCommon;

namespace COW;

public class UISPHudHighlightPlayerInfoController : UIBaseController
{
	private UISPHudHighlightPlayerInfoView m_View;

	private ulong m_UserID;

	private UISPHudHighlightInfoListController m_ParentController;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetData(ulong userID, string playerName, bool isExpanded)
	{
	}

	public void SetExpanded(bool isExpanded)
	{
	}

	public void SetParentController(UISPHudHighlightInfoListController parent)
	{
	}

	private void OnPlayerNameClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
