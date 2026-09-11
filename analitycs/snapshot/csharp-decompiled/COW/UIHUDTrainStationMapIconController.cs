using COW.GamePlay;
using GCommon;
using UnityEngine;
using message;

namespace COW;

public class UIHUDTrainStationMapIconController : UIBaseController
{
	private UIHUDTrainStationMapIconView m_View;

	private KNHIDGDGBKE m_StationState;

	private OPICPDCLKAG m_LevelObjectType;

	private uint m_LevelObjectID;

	private UITimeLabelHelper m_TimeLabelHelper;

	private uint m_DelayShowReviveZoneTicket;

	private bool IsTrainArrived => false;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void InitLevelObjectInfo(OPICPDCLKAG levelObjectType, uint levelObjectID)
	{
	}

	public uint GetLevelObjectID()
	{
		return 0u;
	}

	public OPICPDCLKAG GetLevelObjectType()
	{
		return OPICPDCLKAG.Invalid;
	}

	public void RefreshData(EighthTrainStation station, bool isHalfJoinOrReEnter)
	{
	}

	private void DelayShowReviveZoneRoot()
	{
	}

	private void RefreshStateShow()
	{
	}

	private void Update()
	{
	}

	public bool CheckPositionInArea(Vector3 position)
	{
		return false;
	}

	private void _003CDelayShowReviveZoneRoot_003Eb__14_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
