using System.Collections.Generic;
using GCommon;
using UnityEngine;
using tcp;

namespace COW;

public class UIRoomListItemController : UIEasyListItemController
{
	private sealed class _003C_003Ec__DisplayClass19_0
	{
		public UIRoomListItemController _003C_003E4__this;

		public bool solo;

		public ECustomRoomJoinType joinType;

		internal void _003CJoinProcess_003Eb__0(string code, string group, string groupAbbr)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass20_0
	{
		public UIRoomListItemController _003C_003E4__this;

		public bool solo;

		internal void _003CSpectateProcess_003Eb__0(string code, string group, string groupAbbr)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass27_0
	{
		public UIPopupMessageBoxController quitDialog;

		internal void _003CGenerateBatchPopMenuData_003Eb__4()
		{
		}
	}

	private UIRoomListItemView m_View;

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

	private UIRoomListSettingPreviewMinController m_RoomListSettingPreviewMinCtrl;

	private GameObject m_AdvEffect;

	private bool m_IsSocialRoomMode;

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

	private void OnPreviewJoinPlayClick(ulong roomId)
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

	private void OnJoinGameClick()
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

	private bool IsSocialRoomMode(uint gameMode)
	{
		return false;
	}

	private void HighlightRoomItem(RoomBasicInfo info)
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

	private void _003CGeneratePopMenuData_003Eb__24_0(object obj)
	{
	}

	private void _003CGeneratePopMenuData_003Eb__24_1(object obj)
	{
	}

	private void _003CJoinOB_003Eb__25_0()
	{
	}

	private void _003CJoinOB_003Eb__25_1()
	{
	}

	private void _003CGenerateBatchPopMenuData_003Eb__27_0(object obj)
	{
	}

	private void _003CGenerateBatchPopMenuData_003Eb__27_2(object obj)
	{
	}

	private void _003CGenerateBatchPopMenuData_003Eb__27_1(object obj)
	{
	}

	private void _003CGenerateBatchPopMenuData_003Eb__27_3()
	{
	}

	private void _003CRefreshCDNMap_003Eb__30_0()
	{
	}

	private void _003CPlayTweenAnim_003Eb__37_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
