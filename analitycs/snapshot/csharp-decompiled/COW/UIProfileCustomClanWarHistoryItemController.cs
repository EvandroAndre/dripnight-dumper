using GCommon;
using UnityEngine;

namespace COW;

public class UIProfileCustomClanWarHistoryItemController : UIProfileCustomCollectionItemBaseController, UITable2.IUITable2Item
{
	private UIProfileCustomClanWarHistoryItemView m_View;

	private ProfileCustomClanHistoryLeaderBoardData m_Data;

	private UIModelClan m_ModelClan;

	private UIModelUser m_ModelUser;

	private bool m_IsClanHonorRegionGet;

	private bool m_IsClanHonorGlobalGet;

	private bool m_IsClanHonorWarTitleGet;

	private int m_GloryNum;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void SetViewData(ProfileCustomModuleData data)
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

	public override void ShowBgByBriefBox()
	{
	}

	private void OnUIUpdate(int dataSource, int moduleId)
	{
	}

	private void OnGotoGloryBtnClick()
	{
	}

	private void RefreshClanGloryItem()
	{
	}

	private void OnClanHonorLeaderBoardUpdate(object[] data)
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
