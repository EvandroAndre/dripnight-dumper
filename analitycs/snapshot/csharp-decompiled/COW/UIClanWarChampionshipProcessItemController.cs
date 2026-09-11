using GCommon;
using proto;

namespace COW;

public class UIClanWarChampionshipProcessItemController : UIBaseController
{
	private UIClanWarChampionshipProcessItemView m_View;

	private GuildWarTournamentDesc m_Data;

	private UIModelClanWarChampionship m_ModelClanWarChampionship;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetData(GuildWarTournamentDesc data)
	{
	}

	public void RefreshView()
	{
	}

	private string GetStageText()
	{
		return null;
	}

	protected override void OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
