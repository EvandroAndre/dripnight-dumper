using GCommon;
using message;

namespace COW;

public class UILadderMatchSelectGameModeItemController : UIBaseController
{
	private UILadderMatchSelectGameModeItemView m_View;

	private NIKKALKPIBO m_GameMode;

	private DLBMPCCFKKM m_MatchMode;

	private MapModeData m_MapModeData;

	protected override void OnUIInit()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public void SetViewData(NIKKALKPIBO gameMode, DLBMPCCFKKM matchMode, MapModeData mapModeData)
	{
	}

	private void OnClickBtn()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
