using System;
using System.Collections.Generic;
using COW.Gameplay.UGC;
using GCommon;

namespace COW;

public class UIHudLobbyContainerController : UIBaseController, IUIModelDataChangeObserver
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<MapModeData, uint> _003C_003E9__25_0;

		public static Action _003C_003E9__28_0;

		public static Action _003C_003E9__28_1;

		public static EventDelegate.Callback _003C_003E9__28_2;

		public static Action _003C_003E9__28_5;

		public static EventDelegate.Callback _003C_003E9__28_6;

		internal uint _003COnOpenGroup_003Eb__25_0(MapModeData x)
		{
			return 0u;
		}

		internal void _003COnShowDownloadPopup_003Eb__28_0()
		{
		}

		internal void _003COnShowDownloadPopup_003Eb__28_1()
		{
		}

		internal void _003COnShowDownloadPopup_003Eb__28_2()
		{
		}

		internal void _003COnShowDownloadPopup_003Eb__28_5()
		{
		}

		internal void _003COnShowDownloadPopup_003Eb__28_6()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass19_0
	{
		public Action cb;

		internal void _003CShowGroupMessageBox_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass26_0
	{
		public UIModelOptionalDownload model;

		public List<uint> tagList;

		public object[] data;

		public ResDownloadType resType;

		public EventLogger.ClickType clickType;

		public string clickString;

		internal void _003COnShowTagDownloadPopup_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass28_0
	{
		public UIModelOptionalDownload modelOptionalDwonload;

		public List<ResourceID> target_id;

		public UGCSimpleDownloadTask ugcDownloadTask;

		public bool downloadAllResOfGameMode;

		public object[] data;

		public ResDownloadType resType;

		public UIModelMapOpeningInfo modelMap;

		public Action _003C_003E9__4;

		internal void _003COnShowDownloadPopup_003Eb__3()
		{
		}

		internal void _003COnShowDownloadPopup_003Eb__4()
		{
		}
	}

	private UIHudLobbyContainerView m_View;

	private UILobbyV2StartGameController m_StartGameController;

	private UILobbyV2InviteGroupBoxController m_InviteGroupBox;

	private UIGameModeMainController m_GameModeMainController;

	private UIModelMapOpeningInfo m_ModelMapOpeningInfo;

	private UIModelGroup m_ModelGroup;

	private UIClickMask m_ClickMask;

	private UIBriefBoxController m_BriefBoxCtrl;

	private float MovingSpeed;

	private int StartGamePanelDepth;

	public UIPopupMessageBoxController m_MessageBox;

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

	protected override void OnUIOpen()
	{
	}

	protected override void OnDestroy()
	{
	}

	private void OnChangeGroupId()
	{
	}

	private void OnRefuseNtf(object[] data)
	{
	}

	private void OnDismissNtf(object[] data)
	{
	}

	private void ShowGroupMessageBox(string details = "", string title = "", Action cb = null)
	{
	}

	private void OnLeaveNtf(object[] data)
	{
	}

	private void OnAcceptJoinNtf(object[] data)
	{
	}

	private void OnClickClickMask()
	{
	}

	private void OnOpenBriefBox(object[] data)
	{
	}

	private void OnOpenMapPanel(object[] data)
	{
	}

	private void OnOpenGroup(object[] data)
	{
	}

	private void OnShowTagDownloadPopup(object[] data)
	{
	}

	private void OnCancelDownload()
	{
	}

	private void OnShowDownloadPopup(object[] data)
	{
	}

	private void OnGroupErr()
	{
	}

	private void OpenInviteGroupBox(GroupInviteMemberType defaultInviteType = GroupInviteMemberType.Friend)
	{
	}

	private void ShowContainer()
	{
	}

	private void HideContainer()
	{
	}

	private void SetControllerState(UIBaseController ctrl, bool state)
	{
	}

	public void SetState(bool state)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void _003COnUIOpen_003Eb__13_0()
	{
	}

	private void _003CShowContainer_003Eb__31_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}
}
