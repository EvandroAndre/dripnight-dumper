using GCommon;

namespace COW;

public class UIClanWarChampionshipMiniLeaderboardItemController : UIEasyListItemController
{
	private UIClanWarChampionshipMiniLeaderboardItemView m_View;

	private LeaderBoardInfo m_info;

	private bool m_IsSelf;

	private UIModelClanWarChampionship m_ModelClanWarChampionship;

	private UIModelClan m_ModelClan;

	private UIModelClanWarV2 m_ModelClanWarV2;

	private UIModelLeaderBoard m_ModelLeaderBoard;

	private UIModelLeaderBoardTitle m_ModelLeaderBoardTitle;

	private UILeaderBoardTitleIconController m_TitleIconCtrl;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	private void RefreshBg()
	{
	}

	public void SetIsSelf(bool isSelf)
	{
	}

	public void CheckBelowStartScore()
	{
	}

	private void SetGuildLogo(UISprite logoSprite, UINetworkTexture logoCDN)
	{
	}

	private void SetGuildLogoByInfo(UISprite logoSprite, UINetworkTexture logoCDN, ClanInfo info)
	{
	}

	private void SetGuildLogoByInfo(UISprite logoSprite, UINetworkTexture logoCDN, LeaderBoardInfo info)
	{
	}

	private new void OnItemBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
