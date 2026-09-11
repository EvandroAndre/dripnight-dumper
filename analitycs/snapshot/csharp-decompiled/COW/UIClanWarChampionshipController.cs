using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIClanWarChampionshipController : UIBaseController, IUIModelDataChangeObserver
{
	private UIClanWarChampionshipView m_View;

	private UIModelClanWarChampionship m_ModelClanWarChampionship;

	private UIModelClanWarV2 m_ModelClanWar;

	private UIModelLeaderBoard m_ModelLeaderBoard;

	private UIClanWarChampionshipInfoController m_InfoController;

	private List<UIClanWarChampionshipProcessItemController> m_ProcessItemCtrls;

	private ClanWarChampionshipStage m_Stage;

	private const uint WEB_VIEW_CONFIG_SUBTYPE = 1u;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void RefreshView()
	{
	}

	private void RefreshTitle()
	{
	}

	private void RefreshLeftStages()
	{
	}

	private void RefreshMatchHistoryBtn()
	{
	}

	private void CheckMatchStateReddot()
	{
	}

	private void RefreshRighiInfo()
	{
	}

	private void OpenRightInfo()
	{
	}

	private void OnMatchStateBtnClick()
	{
	}

	private void OnShareBtnClick()
	{
	}

	public override void BeforeScreenshot()
	{
	}

	public override void AfterScreenshot()
	{
	}

	private void ShowTipsWeb()
	{
	}

	protected override void OnUIDestory()
	{
	}

	void IUIModelDataChangeObserver.OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	uint IUIModelDataChangeObserver.GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	public void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
