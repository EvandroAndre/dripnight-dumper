using GCommon;
using proto;

namespace COW;

internal class UIClanWarEmblemHistoryItemController : UIEasyListItemController
{
	public class GloryData
	{
		public ClanLeaderboardItem item;

		public bool isRegion;
	}

	public class ClanWarEmblemData
	{
		public GloryData gloryData;

		public GuildWarTitleRecordInfo guildWarTitleRecordInfo;
	}

	private UIClanWarEmblemHistoryItemView m_View;

	private GloryData m_GloryData;

	private GuildWarTitleRecordInfo m_TitleData;

	private UIModelLeaderBoardTitle m_ModelLeaderBoardTitle;

	private UIModelClanWarV2 m_ModelClanWarV2;

	private UIModelClanWarChampionship m_ModelClanWarChampionship;

	private UIModelClan m_ModelClan;

	private uint m_titleId;

	private bool m_isSelected;

	private bool m_CanSelect;

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

	public void SetGlory(GloryData gloryData)
	{
	}

	private void OnGloryRuleBtnClick()
	{
	}

	public override void OnItemBtnSelect()
	{
	}

	private void OnItemSelect(uint titleId)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}
}
