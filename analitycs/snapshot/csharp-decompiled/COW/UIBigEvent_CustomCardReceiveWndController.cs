using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIBigEvent_CustomCardReceiveWndController : UIBaseController, IUIModelDataChangeObserver, IEasyList, IBigEventTemplateIdentifier
{
	private struct ProfileInfoShowStatusData
	{
		public int index;

		public ulong account_id;

		public bool success;

		public uint card_id;

		public uint serial;

		public void Clear()
		{
		}
	}

	private sealed class _003CDelayRunGuideQueueCoroutine_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIBigEvent_CustomCardReceiveWndController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDelayRunGuideQueueCoroutine_003Ed__21(int _003C_003E1__state)
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

	private UIBigEvent_CustomCardReceiveWndView m_View;

	private UIModelBigEvent_CustomCard m_UIModelCustomCard;

	private UIModelFriends m_UIModelFriends;

	private List<UIModelBigEvent_CustomCard.CardWishData> m_CardWishDatas;

	private List<CustomCard_CardData> m_CardDatas;

	private UIBigEvent_CustomCard_ProfileInfoController m_ProfileInfoController;

	private string m_strWishKey;

	private Coroutine m_DelayRunGuideQueueCoroutine;

	private ProfileInfoShowStatusData m_Status;

	private List<uint> m_DisplayCards;

	private EBigEventTemplateUseType _003CTemplateUseType_003Ek__BackingField;

	public EBigEventTemplateUseType TemplateUseType
	{
		get
		{
			return _003CTemplateUseType_003Ek__BackingField;
		}
		private set
		{
			_003CTemplateUseType_003Ek__BackingField = value;
		}
	}

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

	protected override void OnUIOpenAsChild()
	{
	}

	private void Update()
	{
	}

	private void RefershCardList()
	{
	}

	private CSCustomCardReceiveListRes.receiveCardInfo GetReceiveCardInfo(uint id)
	{
		return null;
	}

	private void CorrectProfileInfoShowStatusData()
	{
	}

	private void GetNextWishCardProfileInfo()
	{
	}

	private void SetWishGuide()
	{
	}

	private IEnumerator DelayRunGuideQueueCoroutine()
	{
		return null;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	public virtual EBigEventTemplateType GetTemplateType()
	{
		return EBigEventTemplateType.None;
	}

	public void OnTemplateUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpenAsChild()
	{
	}
}
