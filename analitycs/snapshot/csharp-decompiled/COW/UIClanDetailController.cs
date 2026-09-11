using GCommon;
using proto;

namespace COW;

public class UIClanDetailController : UIPopupWindowController
{
	private UIClanDetailsView m_View;

	private UIBaseProfileInfoController m_BaseProfile;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetUIdata(ClanInfoBasic claninfo, AccountInfoBasic clancaptaininfo)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
