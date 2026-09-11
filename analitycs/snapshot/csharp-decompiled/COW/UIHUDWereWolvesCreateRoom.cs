using System;
using System.Collections.Generic;
using GCommon;
using message;
using proto;

namespace COW;

internal class UIHUDWereWolvesCreateRoom : UIPopupWindowController, IUIModelDataChangeObserver
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<string> _003C_003E9__55_0;

		internal void _003COnConfirm_003Eb__55_0(string s)
		{
		}
	}

	private const int TOGGLE_GROUP_ID = 117;

	protected const int ROOM_CODE_MAX_LENGTH = 10;

	protected const uint Const_GameModeID = 37u;

	protected const uint Const_MapID = 8u;

	protected const int POPMENU_WIDTH = 240;

	protected uint m_LevelLimitNum;

	protected UIWereWolvesCreateRoomView m_View;

	protected UIModelCustomRoom m_CustomRoomModel;

	protected Dictionary<string, CSVBaseData> m_CsvDataMap;

	protected Dictionary<string, CSVBaseData> m_CsvDefaultParamsMap;

	protected Dictionary<uint, UIWereWolvesRoomParamItemController> m_GameParamControllerList;

	protected Dictionary<uint, uint> m_DefaultParamsMap;

	protected Dictionary<uint, uint> m_CurParamsMap;

	protected List<uint> m_GameSettingTypes;

	protected UIRoomCardListController m_RoomCardCtrl;

	protected UIStandardTabController m_TabCtrl;

	protected UIPopMenuSmallControler m_PlayerCountPopMenuSmallCtrl;

	protected UIPopMenuSmallControler m_WolfCountPopMenuSmallCtrl;

	protected UIPopMenuSmallControler m_LevelLimitMenuCtrl;

	protected List<PopMenuData> m_DataList;

	private List<PopMenuData> m_LanguageDataList;

	protected ESocial.Language m_SelectedLanguage;

	protected string m_RoomName;

	protected string m_Code;

	private UISelectLanguageController m_CurLanguagePage;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void Awake()
	{
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected WereWolvesRoomSettingData GetSettingDataByType(JEMFGANHOPH settingType)
	{
		return null;
	}

	protected WereWolvesRoomDefaultParams GetDefaultParmasDataByPlayerCount(uint playerCount)
	{
		return null;
	}

	protected override void OnInitDepth()
	{
	}

	private void InitStandardTabs()
	{
	}

	private void OnRoomSettingClick()
	{
	}

	private void OnGameSettingClick()
	{
	}

	protected virtual void InitDefaultParams()
	{
	}

	private void RefreshDefaultParams(uint playerCount)
	{
	}

	private void InitRoomSetting()
	{
	}

	protected virtual void InitLanguageUIComponent()
	{
	}

	private void InitWolfCountUIComponent()
	{
	}

	private void InitLevelLimitUIComponent()
	{
	}

	protected void GenerateWolfCountMenuData()
	{
	}

	protected void GenerateLevelLimitMenuData()
	{
	}

	private void OnLevelLimitSelected(object obj)
	{
	}

	protected virtual void InitPlayerCountUIComponent()
	{
	}

	protected void GeneratePlayerCountMenuData()
	{
	}

	private void OnPlayerCountMenuSelected(object value)
	{
	}

	private void OnWolfCountMenuSelecte(object value)
	{
	}

	private void InitLanguageList()
	{
	}

	protected virtual void OnLanguageBtnClick()
	{
	}

	private void OnLocLanguageSelect(object obj)
	{
	}

	private void InitGameSetting()
	{
	}

	private void ChangeParamByType(JEMFGANHOPH paramType, uint paramValue)
	{
	}

	private void OnResetGameSetting()
	{
	}

	protected virtual bool NeedCheckRoomCard()
	{
		return false;
	}

	protected virtual void OnConfirm()
	{
	}

	protected virtual void ProcessConfirmRoomInfo()
	{
	}

	protected void RequestCreateRoom()
	{
	}

	protected void RequestGroupCreateRoom()
	{
	}

	private void OnClose()
	{
	}

	private void OnTrapOn(UIToggleButton btn)
	{
	}

	private void OnTrapOff(UIToggleButton btn)
	{
	}

	private void OnPredictOn(UIToggleButton btn)
	{
	}

	private void OnPredictOff(UIToggleButton btn)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_Awake()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnInitDepth()
	{
	}
}
