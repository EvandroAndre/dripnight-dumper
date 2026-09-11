using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;

namespace COW;

internal class UIUGCMatchResultCommentController : UIPopupWindowController, IUIModelDataChangeObserver
{
	public enum ELikeState
	{
		None,
		Like,
		DisLike
	}

	public enum ESubsAction
	{
		Cancel,
		None,
		Add
	}

	private sealed class _003C_003Ec__DisplayClass40_0
	{
		public UGCCreatorLabelConfig authorLabelConfig;

		internal void _003CSetViewData_003Eb__0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass63_0
	{
		public UIPopupMessageBoxController quitDialog;

		internal void _003COnBtnGameClick_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass66_0
	{
		public UIPopupMessageBoxController quitDialog;

		internal void _003COnBtnCraftlandClick_003Eb__1()
		{
		}
	}

	private sealed class _003CExpUp_003Ed__51 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIUGCMatchResultCommentController _003C_003E4__this;

		public float CurExp;

		public float MaxExp;

		public float NewExp;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CExpUp_003Ed__51(int _003C_003E1__state)
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

	private sealed class _003CPlayCreatorLevelUpAni_003Ed__52 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIUGCMatchResultCommentController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CPlayCreatorLevelUpAni_003Ed__52(int _003C_003E1__state)
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

	private UIUGCMatchResultCommentView m_View;

	private SceneEditSlotInfo m_SlotInfo;

	private WorkshopMatchResultData m_CreatorInfo;

	private UIModelSceneEdit m_ModelSceneEdit;

	private UIModelGroup m_ModelGroup;

	private UIModelMapOpeningInfo m_ModelOpeningInfo;

	private EUGCScene m_Src;

	private bool m_CanBeSub;

	private bool m_Subscribed;

	private ELikeState m_LikeState;

	private ulong m_LikeCount;

	private ulong m_SubCount;

	private uint m_ExpSpeed;

	private uint m_PreExp;

	private uint m_PreLevel;

	private uint m_PreMaxExp;

	private WorkShopLevelExp m_PreData;

	private uint m_NewExp;

	private uint m_NewLevel;

	private uint m_NewMaxExp;

	private WorkShopLevelExp m_NewData;

	private string m_SurveyUrl;

	private uint m_SurveyClickNum;

	private ulong m_GroupID;

	private bool m_IsSubsBefore;

	private ESubsAction m_SubsAction;

	private bool m_IsClickMapComment;

	private bool m_IsClickMoreMaps;

	private bool m_IsClickNewGame;

	public Action onCloseAction;

	public ELikeState LikeState => ELikeState.None;

	public ESubsAction SubscribeAction => ESubsAction.Cancel;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestroy()
	{
	}

	protected override void OnUIClose()
	{
	}

	public void SetViewData(SceneEditSlotInfo slotInfo, WorkshopMatchResultData creatorInfo)
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private void OnAuthorNameClick()
	{
	}

	private void OnClickExpButton()
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void RefreshCDNMapIcon(SceneEditSlotInfo info)
	{
	}

	private void ReSizeMapSize()
	{
	}

	private void RefreshIcon()
	{
	}

	private void InitSubscribeState()
	{
	}

	private void UpdateSubscribeState()
	{
	}

	private void RefreshCreatorInfo()
	{
	}

	private IEnumerator ExpUp(float CurExp, float NewExp, float MaxExp)
	{
		return null;
	}

	private IEnumerator PlayCreatorLevelUpAni()
	{
		return null;
	}

	private void OnCloseMaskClick()
	{
	}

	private void OnBtnShareClick()
	{
	}

	private void OnBtnSubscribeClick()
	{
	}

	private void ShowConfirmWindow()
	{
	}

	private void OnOkBtnClick()
	{
	}

	private void OnCancelBtnClick()
	{
	}

	public void OnMapBtnClick()
	{
	}

	private void OnBtnLikeClick()
	{
	}

	private void OnBtnDisLikeClick()
	{
	}

	private void OnBtnCommentClick()
	{
	}

	private void OnBtnGameClick()
	{
	}

	private void OnPlayAgainConfirmBtnClick()
	{
	}

	private void PlayAgain(object[] data)
	{
	}

	private void OnBtnCraftlandClick()
	{
	}

	private void OnGoToCraftlandConfirmBtnClick()
	{
	}

	private void OnSurveyBtnClick()
	{
	}

	private void _003CRefreshCDNMapIcon_003Eb__45_0()
	{
	}

	private void _003CRefreshCDNMapIcon_003Eb__45_1()
	{
	}

	private void _003COnBtnGameClick_003Eb__63_0()
	{
	}

	private void _003COnBtnCraftlandClick_003Eb__66_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
