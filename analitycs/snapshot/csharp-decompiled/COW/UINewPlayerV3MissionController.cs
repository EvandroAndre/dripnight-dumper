using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

internal class UINewPlayerV3MissionController : UIBaseController, IEasyList
{
	private UINewPlayerV3MissionItemController m_DailyBigRewardMission;

	private List<NewPlayerMissionData> m_NormalMissionDataList;

	private UINewPlayerV3MissionView m_View;

	private UIModelNewPlayerV3 m_ModelNewPlayerV3;

	private const int OLD_MISSION_NUM = 3;

	private int m_CurDay;

	private int m_DeafultVerticalLineHeight;

	private float m_DeafultHorizontalLineLocalPosY;

	private int THREE_MISSION_VERTICAL_LINE_HEIGHT;

	private float THREE_MISSION_HORIZONTAL_LINE_LOCALPOSY;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIClose()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	public void SetViewData(int day)
	{
	}

	public void AdjustMissionConPosition(float offsetY)
	{
	}

	private void SetLineBg(int missionsCount)
	{
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public virtual UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
