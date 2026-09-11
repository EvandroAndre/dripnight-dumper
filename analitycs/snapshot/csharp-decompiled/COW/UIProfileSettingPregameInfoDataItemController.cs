using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIProfileSettingPregameInfoDataItemController : UIBaseController, IUIModelDataChangeObserver
{
	private UIProfileSettingPregameInfoDataItemView m_View;

	private EAccount.Choices m_DataType;

	private UIModelProfile m_ModelProfile;

	private ELoadingBattleType m_LoadingBattleType;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void SetViewData(ELoadingBattleType loadingBattleType, EAccount.Choices eDataType, BattleStatsInfo statsInfo)
	{
	}

	public void ShowGuide(Transform rootGuide, int depth)
	{
	}

	private void RefreshSelectState()
	{
	}

	private void OnBtnClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
