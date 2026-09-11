using System.Collections.Generic;
using GCommon;

namespace COW;

public class UILocationSettingController : UILocationSettingBaseController
{
	private UIModelAreaLeaderBoard m_ModelAreaLeaderBoard;

	protected override void OnUIInit()
	{
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
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

	protected override bool ShowCsPeakTip()
	{
		return false;
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

	public bool _003C_003EiFixBaseProxy_ShowCsPeakTip()
	{
		return false;
	}
}
