using System.Collections.Generic;
using GCommon;

namespace COW;

public class UILocationSettingClanController : UILocationSettingBaseController
{
	public enum EClanLocationPage
	{
		LeaderBoard,
		ClanEdit
	}

	private UIModelLeaderBoard m_ModelLeaderBoard;

	private UIModelClan m_ModelClan;

	private EClanLocationPage m_ClanLocationPage;

	protected override void OnUIInit()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public void SetClanLocationPage(EClanLocationPage page)
	{
	}

	protected override void InitBtnStateInfo()
	{
	}

	protected override List<LocationAreaDes> GetAllCountryList()
	{
		return null;
	}

	protected override List<LocationAreaDes> GetProvinceListByCountryID()
	{
		return null;
	}

	protected override List<LocationAreaDes> GetCityListByProvinceID()
	{
		return null;
	}

	protected override bool HasCityAreaDescByProvinceID()
	{
		return false;
	}

	protected override bool HasProvinceAreaDescByCountryID()
	{
		return false;
	}

	protected override void HandleChangeLocation(uint areaId)
	{
	}

	protected override void ChangeTipLabel()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_InitBtnStateInfo()
	{
	}

	public List<LocationAreaDes> _003C_003EiFixBaseProxy_GetAllCountryList()
	{
		return null;
	}

	public List<LocationAreaDes> _003C_003EiFixBaseProxy_GetProvinceListByCountryID()
	{
		return null;
	}

	public List<LocationAreaDes> _003C_003EiFixBaseProxy_GetCityListByProvinceID()
	{
		return null;
	}

	public bool _003C_003EiFixBaseProxy_HasCityAreaDescByProvinceID()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_HasProvinceAreaDescByCountryID()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_HandleChangeLocation(uint P0)
	{
	}

	public void _003C_003EiFixBaseProxy_ChangeTipLabel()
	{
	}
}
