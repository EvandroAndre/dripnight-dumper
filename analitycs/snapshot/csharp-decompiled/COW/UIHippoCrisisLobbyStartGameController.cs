using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using message;
using tcp;

namespace COW;

public class UIHippoCrisisLobbyStartGameController : UILobbyBaseStartGameController, IUIModelDataChangeObserver
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<MapModeData, uint> _003C_003E9__41_0;

		internal uint _003CChangeGroupMode_003Eb__41_0(MapModeData x)
		{
			return 0u;
		}
	}

	private sealed class _003CCloseGroupModePanel_003Ed__43 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float seconds;

		public UIHippoCrisisLobbyStartGameController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CCloseGroupModePanel_003Ed__43(int _003C_003E1__state)
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

	private const int InviteGroupBoxPanelDepth = 30;

	private bool m_FirstOpenModesPanel;

	private bool m_FirstOpenDifficultyModesPanel;

	private bool m_IsNeedPreStart;

	private bool m_AutoChangeToGroup;

	private UIHippoCrisisLobbyStartGameView m_View;

	private CMDBIPLGLGA m_GroupMode;

	private CMDBIPLGLGA m_CachedGroupMode;

	private BitArrayBoolean m_GroupModeSelectEnable;

	private const uint GroupModeSelectNormalLogic = 1u;

	private uint m_StartGameCoolDownResumeDelayID;

	private bool m_NeedChangePanelDepth;

	private int CustomPanelDepth;

	private UIModelUser m_ModelUser;

	private UIModelMapOpeningInfo m_ModelMap;

	private UIModelGroup m_ModelGroup;

	private UIModelCustomRoom m_ModelCustomRoom;

	private UIModelInventory m_ModelInventory;

	private UIModelMatch m_ModelMatch;

	private UIModelHippoCrisis m_ModelHippoCrisis;

	private UIHippoCrisisLobbyGroupStartGameController m_GroupCtrl;

	private UILobbyV2StartGameTeamModesPanelController m_StartGameTeamModesPanelController;

	private UIHippoCrisisLobbyDifficultyPanelController m_DifficultyPanelCtrl;

	private UIHippoCrisisRankIconController m_HippoCrisisRankIconCtrl;

	private uint m_CommonColor;

	private uint m_HardColor;

	private MapModeData m_SelectedMapData
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private UILobbyV2StartGameTeamModesPanelController StartGameTeamModesPanelController => null;

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

	public void RefreshCachedUISelectedData(object[] data)
	{
	}

	private void OnGroupChangeGroupModeNtf(object[] data)
	{
	}

	private void OnCreateGroupFail(object[] data)
	{
	}

	private void OnFefreshAfterRestartMatchMaking(object[] data)
	{
	}

	private void ChangePublicState(object[] args)
	{
	}

	public void RefreshGroupLeaderView(object[] objs)
	{
	}

	private void ChangeGroupMode(object[] args)
	{
	}

	private void ChangeGroupMode(CMDBIPLGLGA mode, EGroup.CreateFromType fromType = EGroup.CreateFromType.CreateFromType_OWNSELF)
	{
	}

	private void RevertGroupMode(CMDBIPLGLGA mode)
	{
	}

	private IEnumerator CloseGroupModePanel(float seconds)
	{
		return null;
	}

	private void CloseGroupModePanel()
	{
	}

	private void CloseDifficultyPanel()
	{
	}

	private void CloseModeSelectionPanels(object[] data)
	{
	}

	private void OnEndMatchMaking(object[] data)
	{
	}

	private void OnMatchmakingShow()
	{
	}

	private void OnMatchmakingHide()
	{
	}

	private void OnGroupQuit()
	{
	}

	private void OnGroupCreateSuccess(object[] param)
	{
	}

	private void OnJoinNtf(object[] data)
	{
	}

	private void OnGroupInfoSync(object[] data)
	{
	}

	private void SetOverMaskShow(bool show)
	{
	}

	private void RefreshLadderContainerView()
	{
	}

	private void UpdateSelectedGroupModeUI()
	{
	}

	private void UpdateSelectDifficultyUI(object[] args)
	{
	}

	private void UpdateSelectedMapModeUI()
	{
	}

	private void OpenGroupUI()
	{
	}

	public void SetDefaultMode()
	{
	}

	private void OnEnterGameBtnClick()
	{
	}

	private void OnPreStartBtnClick()
	{
	}

	private void OnPreStartBtnClickFromAdjustBtn()
	{
	}

	private void OnTeamModeBtnClick()
	{
	}

	private void OnAdjustDifficultyModeBtnClick()
	{
	}

	private void OnLadderBtnClick()
	{
	}

	private void OnPentaBtnClick()
	{
	}

	private void OnSquardBtnClick()
	{
	}

	private void OnDuoBtnClick()
	{
	}

	private void OnSoloBtnClick()
	{
	}

	private void EnableModeSelectionButtons(bool v)
	{
	}

	private bool QuitToSolo()
	{
		return false;
	}

	private bool CheckGroupMode()
	{
		return false;
	}

	public override bool CheckPlayerLimits(CMDBIPLGLGA groupMode, bool showTips = true)
	{
		return false;
	}

	private bool IsSoloSupported(MapModeData mapData, bool showTips = true)
	{
		return false;
	}

	public void CloseGroupCtrl()
	{
	}

	public void RefreshRightBottomGroupModeUI()
	{
	}

	private void RefreshStartBtn()
	{
	}

	public UIWidget GetPreStartWidgetForGuide()
	{
		return null;
	}

	public UIButton GetEnterGameBtnForGuide()
	{
		return null;
	}

	public UIWidget GetEnterGameBtnWidgetForGuide()
	{
		return null;
	}

	private void RefreshDefaultLabelText()
	{
	}

	private void PreStartCompleted()
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private void _003COnEnterGameBtnClick_003Eb__61_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public bool _003C_003EiFixBaseProxy_CheckPlayerLimits(CMDBIPLGLGA P0, bool P1)
	{
		return false;
	}
}
