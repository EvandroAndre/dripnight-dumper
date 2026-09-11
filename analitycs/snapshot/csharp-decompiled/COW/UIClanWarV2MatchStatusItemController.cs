using GCommon;

namespace COW;

public class UIClanWarV2MatchStatusItemController : UIEasyListItemController
{
	private const string TIME_FORMAT = "{0}\n{1}";

	private UIClanWarV2MatchStatusItemView m_View;

	private UIModelClanWarV2 m_ModelClanWar;

	private UIModelClanWarChampionship m_ModelClanWarChampionship;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
