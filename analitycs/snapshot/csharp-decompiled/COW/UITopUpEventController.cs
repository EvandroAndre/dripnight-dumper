using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using proto;

namespace COW;

public class UITopUpEventController : UIPreviewBaseController, IUIModelDataChangeObserver
{
	public enum TopUpEventPageType
	{
		Payment,
		Activity
	}

	private sealed class _003CIERefreshArrowObject_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UITopUpEventController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CIERefreshArrowObject_003Ed__32(int _003C_003E1__state)
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

	private const uint TOTALWIDTH = 510u;

	private const uint AWARDEXPRESSION = 1u;

	private const uint MAX_ITEM_CNT = 7u;

	private const uint MIN_PROGRESSBAR_LENGTH = 50u;

	private TopUpEventPageType m_TopUpEventPageType;

	private int m_CurrentSubTabIndex;

	private AwardDesc m_CurrentPreviewItem;

	private bool m_IsInPreview;

	private ActivityGroupDesc m_GroupDesc;

	private List<UITopUpEventItemController> m_ItemControllers;

	private List<UITopUpEventProgressItemController> m_ProgressItemControllers;

	private UITopUpEventView m_View;

	private UIModelActivity m_Model;

	private bool m_ShowModel;

	private List<uint> m_CanClaimActivityIDList;

	protected bool m_IsHideByPreviewPop;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override UIWidget GetFrontEndPreviewBorder()
	{
		return null;
	}

	protected override FrontendPreviewType GetPreviewUIType()
	{
		return FrontendPreviewType.Lobby;
	}

	protected override void OnUIInit()
	{
	}

	public void OnPreviewStateChange(bool needShow, bool needRefresh = false)
	{
	}

	private void OpenPreviewInternal()
	{
	}

	private void HidePreview()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void RefreshPreviewItem()
	{
	}

	public override bool IsAutoCalculatePreviewPanelSize()
	{
		return false;
	}

	private void ShowPreview(object[] parameters)
	{
	}

	public void RefreshContent()
	{
	}

	private void RefreshViewInternal()
	{
	}

	public void GotoByParams(UIPaymentController.PaymentGotoParams parameters)
	{
	}

	public void SetViewData(ActivityGroupDesc activityGroupDesc, bool isInternal = false)
	{
	}

	private void RefreshAllClaimBtn(List<ClientActivityDesc> activityDescList)
	{
	}

	private IEnumerator IERefreshArrowObject()
	{
		return null;
	}

	private void OnCDNLoaded()
	{
	}

	public void SetPageType(TopUpEventPageType type)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private int SortByCondtionValue(ClientActivityDesc a, ClientActivityDesc b)
	{
		return 0;
	}

	public void OnPopUpWindowListChange(bool isCovered)
	{
	}

	private void OnClaimAllBtnClick()
	{
	}

	private void OnClickHintBtn()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public bool _003C_003EiFixBaseProxy_IsAutoCalculatePreviewPanelSize()
	{
		return false;
	}
}
