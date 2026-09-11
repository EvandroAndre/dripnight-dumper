using System.Collections.Generic;
using GCommon;

namespace COW;

public class UILocationSettingBaseController : UIPopupWindowController
{
	protected enum CountryClickState
	{
		CanChoose,
		AutoSelect,
		HasNoCountry
	}

	protected enum ProvinceClickState
	{
		CanChoose,
		AutoSelect,
		NotChooseCountry,
		HasNoProvince
	}

	protected enum CityClickState
	{
		CanChoose,
		AutoSelect,
		NotChooseProvince,
		NotChooseCountry,
		HasNoCity
	}

	private sealed class _003C_003Ec__DisplayClass32_0
	{
		public UILocationSettingBaseController _003C_003E4__this;

		public string key;

		internal void _003CSetConfirmBtnState_003Eb__0()
		{
		}
	}

	protected UILocationSettingView m_View;

	protected UIPopMenuSmallControler m_CountryFilterPopMenu;

	protected UIPopMenuSmallControler m_ProvinceFilterPopMenu;

	protected UIPopMenuSmallControler m_CityFilterPopMenu;

	protected List<LocationAreaDes> m_CountryList;

	protected uint m_ChooseCountryID;

	protected uint m_ChooseProvinceID;

	protected uint m_ChooseCityID;

	protected CountryClickState m_CountryClickState;

	protected ProvinceClickState m_ProvinceClickState;

	protected CityClickState m_CityClickState;

	protected BaseLeaderBoardAreaData m_AreaData;

	protected LeaderBoardLocationBtnStateInfoCache m_BtnStateInfoCache;

	protected bool m_IsDuringFirstCountDown;

	protected bool m_IsFirstCountDownFinished;

	protected uint m_CountDownTime;

	protected uint m_CountDownDelayCall;

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void SetupDefaultStateOnInit()
	{
	}

	public void SetViewData()
	{
	}

	protected virtual void ChangeTipLabel()
	{
	}

	protected virtual bool ShowCsPeakTip()
	{
		return false;
	}

	protected void RefreshBtnState()
	{
	}

	protected void SetCityStateByDesc()
	{
	}

	protected void SetProvinceStateByDesc()
	{
	}

	protected void RefreshDefaultProvinceFilterState(bool isDisable)
	{
	}

	protected void RefreshDefaultCountryFilterState(bool isDisable)
	{
	}

	protected void RefreshDefaultCityFilterState(bool isDisable)
	{
	}

	protected void SetConfirmBtnState(bool canClick, bool init = false)
	{
	}

	private void InitPopMenuInfo()
	{
	}

	private void GenerateCountryFilterData()
	{
	}

	private void GenerateProvinceFilterData()
	{
	}

	private void GenerateCityFilterData()
	{
	}

	protected void OnClickCountryFilter(object data)
	{
	}

	private void OnClickProvinceFilter(object data)
	{
	}

	private void OnClickCityFilter(object data)
	{
	}

	protected void OnConfirmBtnClick()
	{
	}

	private void OnCountryTipsBtnClick()
	{
	}

	private void OnProvinceTipsBtnClick()
	{
	}

	private void OnCityTipsBtnClick()
	{
	}

	protected virtual void HandleChangeLocation(uint areaId)
	{
	}

	protected virtual List<LocationAreaDes> GetAllCountryList()
	{
		return null;
	}

	protected virtual List<LocationAreaDes> GetProvinceListByCountryID()
	{
		return null;
	}

	protected virtual List<LocationAreaDes> GetCityListByProvinceID()
	{
		return null;
	}

	protected virtual bool HasCityAreaDescByProvinceID()
	{
		return false;
	}

	protected virtual bool HasProvinceAreaDescByCountryID()
	{
		return false;
	}

	protected virtual void InitBtnStateInfo()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
