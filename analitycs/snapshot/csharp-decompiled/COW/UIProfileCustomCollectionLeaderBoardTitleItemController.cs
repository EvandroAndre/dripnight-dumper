using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIProfileCustomCollectionLeaderBoardTitleItemController : UIProfileCustomCollectionItemBaseController, UITable2.IUITable2Item
{
	private sealed class _003C_003Ec__DisplayClass9_0
	{
		public GuildWarPlayerTitleInfo clanTitle;

		internal void _003CSetViewData_003Eb__0()
		{
		}
	}

	private UIProfileCustomCollectionLeaderBoardTitleItemView m_View;

	private UILeaderBoardTitleCommonController m_LeaderBoardTitleCommonController;

	private LeaderBoardTitleShowingParams m_LeaderBoardTitleShowingParams;

	private UIModelLeaderBoardTitle m_ModelLeaderBoardTitle;

	private uint m_TitleID;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override ProfileCustomDragDropItem GetDragDropItem()
	{
		return null;
	}

	public override GameObject GetIcon()
	{
		return null;
	}

	public override void SetViewData(ProfileCustomModuleData data)
	{
	}

	private void OnUIUpdate(int dataSource, int moduleId)
	{
	}

	public override void ShowBgByBriefBox()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_SetViewData(ProfileCustomModuleData P0)
	{
	}

	public void _003C_003EiFixBaseProxy_ShowBgByBriefBox()
	{
	}
}
