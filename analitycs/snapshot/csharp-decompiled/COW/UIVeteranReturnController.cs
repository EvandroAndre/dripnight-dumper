using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using message;
using proto;

namespace COW;

internal class UIVeteranReturnController : UIPopupWindowController, IUIModelDataChangeObserver
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<MapModeData, uint> _003C_003E9__50_0;

		internal uint _003CSoloGameBtnClick_003Eb__50_0(MapModeData x)
		{
			return 0u;
		}
	}

	private sealed class _003CPlaceTagPos_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIVeteranReturnController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlaceTagPos_003Ed__38(int _003C_003E1__state)
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

	private UIVeteranReturnView m_View;

	private UIModelVeteran m_VeteranModel;

	private UIModelGroup m_GroupModel;

	private UIModelMapOpeningInfo m_ModelMapOpeningInfo;

	private UIPopupWindowTopBtnController m_TopBtn;

	private List<UIStandardItemMiniController> m_ItemCtrlList;

	private List<AwardDesc> m_RewardList;

	private List<UIVeteranReturnTagController> tagCtrls;

	private DLBMPCCFKKM m_ResultMatchMode;

	private NIKKALKPIBO m_ResultGameMode;

	private List<MapModeData> m_ResultMaps;

	private State m_State;

	private UIVeteranFirstSignInRewardWndController m_FirstSignInRewardCtrl;

	private UIVeteranBarragePanelController m_VeteranBarragePanelCtrl;

	private uint m_DelayCall;

	private uint m_DelayIn;

	private uint m_DelayClose;

	private bool isAttamptToCreatGroup;

	private bool m_IsSelectCSSpecial;

	public uint player_choice;

	private const string SoloLabelKey = "T_40_MF_VETERAN_STARTSOLO";

	private const string GroupLabelKey = "T_40_MF_VETERAN_STARTTEAM";

	private VeteranModeMainDesc m_VeteranModeMainDesc;

	private bool m_HasCloseRewardWnd;

	private bool m_VeteranReturnCanGoTo;

	private uint m_VeteranReturnGopos;

	private string m_VeteranReturnSubGopos;

	public ulong m_StartShowTime;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override bool UseCustomizedAnimation()
	{
		return false;
	}

	protected override void OnUIDestory()
	{
	}

	protected override void OnUIClose()
	{
	}

	private bool IsShowCSSpecialMatchContainer()
	{
		return false;
	}

	private void ShowFirstSignInReward()
	{
	}

	private void SetModeSubView()
	{
	}

	private void SetDefaultBg()
	{
	}

	private void SetMainTitleAndTagView()
	{
	}

	private IEnumerator PlaceTagPos()
	{
		return null;
	}

	private void SetPreGroupView()
	{
	}

	private void SetRightBottomView()
	{
	}

	private void InitViewData()
	{
	}

	private void RefreshUI()
	{
	}

	private void RefreshCSSpecialMatchUI()
	{
	}

	private void ShowBarrage()
	{
	}

	private void OnCSSpecialMatchBtnClick()
	{
	}

	private void OnVeteranReturnSubGOBtnClick()
	{
	}

	private void ClaimFirstSignInReward()
	{
	}

	private void InitResultGameModeAndMatchMode()
	{
	}

	private bool SetGameModeAndMatchMode()
	{
		return false;
	}

	private void SoloGameBtnClick()
	{
	}

	private void GroupGameBtnClick()
	{
	}

	private void OnGroupSuccess(object[] param)
	{
	}

	private void OnStartMatchMaking(object[] param)
	{
	}

	private void OnGameModeUpdate(object[] param)
	{
	}

	private void OnGameModeMainOpen(object[] param)
	{
	}

	private void CloseBtnClick()
	{
	}

	public override bool ClosedByEsc()
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

	private void _003CRefreshUI_003Eb__42_0()
	{
	}

	private void _003CRefreshUI_003Eb__42_1()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public bool _003C_003EiFixBaseProxy_ClosedByEsc()
	{
		return false;
	}
}
