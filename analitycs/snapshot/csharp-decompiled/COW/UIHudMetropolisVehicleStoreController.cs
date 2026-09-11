using GCommon;
using UnityEngine;

namespace COW;

public class UIHudMetropolisVehicleStoreController : UIBaseController, IEasyList
{
	public enum ETab
	{
		Vehicle,
		Flight
	}

	public enum EActionType
	{
		Select,
		InCD,
		NotEnough,
		Unlock,
		Obtain
	}

	public enum EDetailProperty
	{
		None,
		Vehicle_Speed,
		Vehicle_Vitality,
		Flight_HSpeed,
		Flight_VSpeed
	}

	private UIHudMetropolisVehicleStoreView m_View;

	public ETab m_Tab;

	private FMetroItemData m_SelectData;

	private EActionType m_ActionType;

	private UITimeLabelHelper m_TimeHelper;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void Update()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	private void OnClickVehicleTabBtn()
	{
	}

	private void OnClickFlightTabBtn()
	{
	}

	private void OnClickCloseBtn()
	{
	}

	private void OnClickActionBtn()
	{
	}

	private void RefreshItemList()
	{
	}

	private void RefreshCallCDTime()
	{
	}

	private void OnShowChangeFaction(object[] data)
	{
	}

	private void OnCurCoinChanged(int data)
	{
	}

	private void OnUpdateStore(int itemType)
	{
	}

	private void OnSelectVehicle(object[] data)
	{
	}

	private void OnCallVehicleCDFinish()
	{
	}

	private void RefreshActionType()
	{
	}

	private void RefreshFactionInfo()
	{
	}

	private void RefeshDetailInfo()
	{
	}

	public void SetDetailProperty(EDetailProperty prop, float radio, int index)
	{
	}

	public static Color GetDetailPropertyColor(EDetailProperty prop)
	{
		return default(Color);
	}

	public static string GetDetailPropertyName(EDetailProperty prop)
	{
		return null;
	}

	private int SortVehicleList(FMetroVehicleData vehicle1, FMetroVehicleData vehicle2)
	{
		return 0;
	}

	private int SortFlightList(FMetroFlightData flight1, FMetroFlightData flight2)
	{
		return 0;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
