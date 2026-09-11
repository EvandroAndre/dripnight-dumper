using System.Collections.Generic;
using GCommon;
using UnityEngine;
using tcp;

namespace COW;

public class UITournamentListItemController : UIEasyListItemController
{
	private sealed class _003C_003Ec__DisplayClass16_0
	{
		public UITournamentListItemController _003C_003E4__this;

		public bool solo;

		public ECustomRoomJoinType joinType;

		internal void _003CJoinProcess_003Eb__0(string code, string group, string groupAbbr)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass23_0
	{
		public UIPopupMessageBoxController quitDialog;

		internal void _003CGenerateBatchPopMenuData_003Eb__4()
		{
		}
	}

	private UITournamentListItemView m_View;

	private RoomBasicInfo m_Data;

	private UIModelCustomRoom m_Model;

	private List<CommonPopMenuData> m_List;

	private CommonPopMenuData m_JoinData;

	private CommonPopMenuData m_SpectateData;

	private uint m_DelayCallID;

	private RoomCreateRuleDataManager m_DataManager;

	private ECustomRoomJoinScene m_CustomRoomJoinScene;

	private EUGCScene m_CustomRoomMapScene;

	private UIPrivilegeIconController m_PrivilegeIconController;

	private GameObject m_AdvEffect;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void OnPreviewJoinObserverClick(ulong roomId)
	{
	}

	private void JoinProcess(bool solo = true, ECustomRoomJoinType joinType = ECustomRoomJoinType.ECustomRoomJoinType_Normal)
	{
	}

	private void SpectateProcess(bool solo = true)
	{
	}

	private void OnJoinOBClick()
	{
	}

	private void OnRoomItemClick()
	{
	}

	private void GeneratePopMenuData()
	{
	}

	private void JoinOB()
	{
	}

	public void JoinRoom(ECustomRoomJoinType joinType = ECustomRoomJoinType.ECustomRoomJoinType_Normal)
	{
	}

	private void GenerateBatchPopMenuData()
	{
	}

	public override void SetViewData(object data, int data_index)
	{
	}

	private void OnPreviewClick()
	{
	}

	private void RefreshCDNMap(uint mode, uint templateID = 0u)
	{
	}

	private void UpdateGroupModeStatus(RoomBasicInfo data)
	{
	}

	private void UpdateRoomStatus(ERoom.State status)
	{
	}

	public void SetWidgetWidth(int width)
	{
	}

	public void SetCustomRoomJoinScene(ECustomRoomJoinScene joinScene)
	{
	}

	public void PlayTweenAnim()
	{
	}

	private void SetPrivilegeIcon(uint mainType, uint subType)
	{
	}

	private void _003CGeneratePopMenuData_003Eb__20_0(object obj)
	{
	}

	private void _003CGeneratePopMenuData_003Eb__20_1(object obj)
	{
	}

	private void _003CJoinOB_003Eb__21_0()
	{
	}

	private void _003CJoinOB_003Eb__21_1()
	{
	}

	private void _003CGenerateBatchPopMenuData_003Eb__23_0(object obj)
	{
	}

	private void _003CGenerateBatchPopMenuData_003Eb__23_2(object obj)
	{
	}

	private void _003CGenerateBatchPopMenuData_003Eb__23_1(object obj)
	{
	}

	private void _003CGenerateBatchPopMenuData_003Eb__23_3()
	{
	}

	private void _003CRefreshCDNMap_003Eb__26_0()
	{
	}

	private void _003CPlayTweenAnim_003Eb__31_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
