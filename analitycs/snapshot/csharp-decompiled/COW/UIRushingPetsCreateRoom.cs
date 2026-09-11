using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using message;

namespace COW;

public class UIRushingPetsCreateRoom : UIPopupWindowController, IUIModelDataChangeObserver
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Action<string> _003C_003E9__48_0;

		internal void _003COnConfirm_003Eb__48_0(string s)
		{
		}
	}

	protected const uint Const_PlyerCount = 20u;

	protected const uint Const_MapID = 12u;

	protected const uint Const_GameModeID = 44u;

	protected uint m_LevelLimitNum;

	protected UIRushingPetsCreateRoomView m_View;

	protected Dictionary<string, CSVBaseData> m_CsvDataMap;

	protected UIRoomCardListController m_RoomCardCtrl;

	protected const int ROOM_CODE_MAX_LENGTH = 10;

	protected UIStandardTabController m_TabCtrl;

	protected UIPopMenuSmallControler m_LevelLimitCtrl;

	protected Dictionary<uint, uint> m_DefaultParamsMap;

	protected Dictionary<uint, uint> m_CurParamsMap;

	protected string m_RoomName;

	protected string m_Code;

	protected uint m_GroupMode;

	protected List<PopMenuData> m_DataList;

	protected UIRoomDropListTemplateController roundCountCtrl;

	protected UIRoomDropListTemplateController roundTimeCtrl;

	protected uint roundCount;

	protected uint roundTime;

	protected uint selectRound;

	protected List<uint> m_GameSettingTypes;

	protected List<GameObject> m_GameParamList;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void InitPopMenu()
	{
	}

	protected void GenerateLevelLimitMenuData()
	{
	}

	private void OnLevelLimitSelected(object obj)
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

	private void InitRoomSetting()
	{
	}

	private void InitModeSelectUIComponent()
	{
	}

	private void SetFirstValidGroupMode()
	{
	}

	protected void OnSoloToggleClick()
	{
	}

	protected void OnDuoToggleClick()
	{
	}

	protected void OnQuadToggleClick()
	{
	}

	protected void OnGroupModeToggleClick(uint groupMode)
	{
	}

	protected UIToggleButton GetGroupModeToggleBtn(uint groupMode)
	{
		return null;
	}

	private void InitGameSetting()
	{
	}

	protected RushingPetsRoomSettingData GetSettingDataByType(LDFLOLDLEOH settingType)
	{
		return null;
	}

	private List<PopMenuData> GenerateRoundCountMenuData()
	{
		return null;
	}

	private void OnRoundCountSelected(object obj)
	{
	}

	private List<PopMenuData> GenerateRoundTimeMenuData()
	{
		return null;
	}

	private void OnGameTimeSelected(object obj)
	{
	}

	private void ChangeParamByType(LDFLOLDLEOH paramType, uint paramValue)
	{
	}

	private void OnClose()
	{
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

	protected virtual bool NeedCheckRoomCard()
	{
		return false;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
