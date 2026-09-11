using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using message;

namespace COW;

internal class UILobbyV2StartGameTeamModesPanelController : UIBaseController, IUIModelDataChangeObserver
{
	private sealed class _003CReSizeCollider_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIWidget widget;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CReSizeCollider_003Ed__31(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private sealed class _003CRestrictWithinBounds_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UILobbyV2StartGameTeamModesPanelController _003C_003E4__this;

		public int count;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CRestrictWithinBounds_003Ed__32(int _003C_003E1__state)
		{
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
		}
	}

	private UILobbyV2StartGameTeamModesPanelView m_View;

	private UIModelGroup m_ModelGroup;

	private UIModelMapOpeningInfo m_ModelMap;

	private UILobbyBaseStartGameController m_ParentController;

	private UIModelUser m_ModelUser;

	private UIModelHuntingGround m_ModelHuntingGround;

	private ulong m_LastChangePublicTime;

	private const int MaxGroupModesCountPerLine = 3;

	private const int GroupModesBgWidth = 352;

	private const int GroupModesPadding = 4;

	private const int GroupModesBgHeight = 76;

	private const float WidgetEnableAlpha = 1f;

	private const float WidgetDisableAlpha = 0.3f;

	private EventID m_ChangeGroupEventId;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpenAsChild()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	private void AddEventDelegate()
	{
	}

	private void OnTeamSoloBtnClick()
	{
	}

	private void OnPentaBtnClick()
	{
	}

	private void OnSquardBtnClick()
	{
	}

	private void OnSoloBtnClick()
	{
	}

	private void OnDuoBtnClick()
	{
	}

	private void OnClickChangePublic()
	{
	}

	private void onCheckBtnClick()
	{
	}

	private void OnCodeCopyBtnClick()
	{
	}

	private void OnGroupCodeBtnClick()
	{
	}

	private void OnGroupCodeHelperBtnClick()
	{
	}

	private void OnQRCodeBtnClick()
	{
	}

	private void RefreshTeamModesPanel()
	{
	}

	private IEnumerator ReSizeCollider(UIWidget widget)
	{
		return null;
	}

	private IEnumerator RestrictWithinBounds(int count)
	{
		return null;
	}

	private void UpdateGroupInfo()
	{
	}

	private void OnJoinNtf(object[] data)
	{
	}

	private void OnGroupChangeNtf(object[] data)
	{
	}

	private void RefreshGroupCode()
	{
	}

	private void SetGroupCodeData(object[] param)
	{
	}

	private void SetGroupData(object[] args)
	{
	}

	public void UpdateSelectedGroupModeUI()
	{
	}

	private void SetBtnSelected(CMDBIPLGLGA groupMode, bool m_IntraTeamDuel = false)
	{
	}

	public void SelectModeButton(CMDBIPLGLGA targetMode, bool m_IntraTeamDuel = false)
	{
	}

	private void RefreshGroupLeaderView(object[] objs)
	{
	}

	public void OnTeamModeBtnClick()
	{
	}

	private void OnGroupCreate(object[] data)
	{
	}

	public void RefreshAutoMatchUI()
	{
	}

	private void RefreshCSPeakUI()
	{
	}

	public void RevertGroupMode(CMDBIPLGLGA mode, bool m_IntraTeamDuel = false)
	{
	}

	public void SetPanelDepth(int depth)
	{
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

	public void _003C_003EiFixBaseProxy_OnUIOpenAsChild()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
