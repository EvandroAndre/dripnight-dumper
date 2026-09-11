using System.Collections.Generic;
using GCommon;
using message;
using proto;

namespace COW;

public class UIRushingPetsCustomRoomController : UIRoomBaseController
{
	private Dictionary<uint, uint> m_CurRoomParamMap;

	protected Dictionary<string, CSVBaseData> m_CsvDataMap;

	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override string GetCurrentGameStartInfo()
	{
		return null;
	}

	protected override bool IsShowInfoPanelOpenBtn()
	{
		return false;
	}

	protected override bool IsShowInviteBtn()
	{
		return false;
	}

	protected override bool IsShowLoadOut()
	{
		return false;
	}

	protected override bool IsShowOB()
	{
		return false;
	}

	protected override bool IsShowToggleDisplayTypeBtn()
	{
		return false;
	}

	protected override void OnBtnCustomize()
	{
	}

	protected override void OnBtnGameStartCallBack()
	{
	}

	protected override EInventory.ItemSubType RoomCardType()
	{
		return EInventory.ItemSubType.ItemSubType_NONE;
	}

	protected override void RefreshUIData(bool mapModeChanged)
	{
	}

	protected override List<RoomGameSettingData> PrepareGameSettingData()
	{
		return null;
	}

	protected RushingPetsRoomSettingData GetSettingDataByType(LDFLOLDLEOH settingType)
	{
		return null;
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_RefreshUIData(bool P0)
	{
	}

	public List<RoomGameSettingData> _003C_003EiFixBaseProxy_PrepareGameSettingData()
	{
		return null;
	}
}
