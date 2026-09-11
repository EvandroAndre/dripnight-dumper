using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

internal class UIBigEventMainBaseController : UIBigEventNaviPopBaseController, IUIModelDataChangeObserver
{
	public class BigEventEntranceView
	{
		public UIModelBigEvent.EBigEventEntranceID EntranceID;

		public UIButton BtnObj;

		public GameObject OpenObj;

		public GameObject GreyObj;

		public GameObject RedPoint;

		public UINetworkTexture CDNIcon;

		public GameObject DefaultIcon;

		public UILabel LabelIntroduce;

		public GameObject UIFXObj;

		public ResourceID UIFXResID;

		public GameObject BubbleObj;

		public GameObject BubbleBGObj;

		public UINetworkTexture BubbleCDN;

		public UILabel BubbleLabel;

		public BigEventEntranceView(UIModelBigEvent.EBigEventEntranceID entranceID, UIButton btnObj, GameObject openObj, GameObject greyObj, GameObject redPoint, UILabel labelInroduce, GameObject uifxObj, ResourceID uifxResID)
		{
		}
	}

	protected class BigEventEntranceViewData
	{
		public UIModelBigEvent.EBigEventEntranceID EntranceID;

		public bool IsLoadUIFX;

		private bool isShowBubble;

		private uint bubbleKey;

		private Action<UIModelBigEvent.EBigEventEntranceID> onBubbleCallback;

		public BigEventEntranceViewData(UIModelBigEvent.EBigEventEntranceID entrance_id)
		{
		}

		public bool ShowBubble(BigEventEntranceSettingDesc desc, Action<UIModelBigEvent.EBigEventEntranceID> callback)
		{
			return false;
		}

		public void Clear()
		{
		}

		private void _003CShowBubble_003Eb__6_0()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass44_0
	{
		public UIBigEventMainBaseController _003C_003E4__this;

		public UIModelBigEvent.EBigEventEntranceID entranceID;

		internal void _003CInitBigEventBtnEntrance_003Eb__0()
		{
		}
	}

	private sealed class _003CNaviCoroutine_003Ed__43 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float effectTime;

		public List<EventDelegate> actionList;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CNaviCoroutine_003Ed__43(int _003C_003E1__state)
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

	protected UIModelBigEvent m_ModelBigEvent;

	protected UIModelActivity m_ModelActivity;

	private uint m_DelayCallId;

	protected UIButton m_BtnPeakDay;

	protected UILabel m_PeakDayLabel;

	protected GameObject m_PeakDayIconUIFX;

	protected GameObject m_PeakDayRedPoint;

	protected UIBigEventPeakDayWndBaseController m_PeakDayCtrl;

	protected bool m_HasPeakDayOpened;

	protected float m_PeakDayDelayLength;

	public Dictionary<int, BigEventEntranceView> m_EntranceViewDict;

	protected Dictionary<int, BigEventEntranceViewData> m_EntranceViewDataDict;

	private Coroutine m_NaviCoroutine;

	public bool EnableAutoPeakday;

	protected string BigEventPeakDayKey => null;

	public override UIModelBigEvent.EBigEventEntranceID GetEntranceId()
	{
		return UIModelBigEvent.EBigEventEntranceID.Main;
	}

	public virtual string GetEntranceOverStateTipKey()
	{
		return null;
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	public override void OnNavigationClosed()
	{
	}

	protected virtual bool AutoOpenPeakDayWndEnabled()
	{
		return false;
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public virtual UIBigEventPeakDayWndBaseController GetPeakDayWndCtrl()
	{
		return null;
	}

	public virtual bool NeedRefreshPeakDayBtn()
	{
		return false;
	}

	public string GetPeakDayTitleKey()
	{
		return null;
	}

	public virtual void RefreshView()
	{
	}

	public bool IsOpeningPeakDay()
	{
		return false;
	}

	public void InitBtnPeakDay(UIButton btnPeakDay, UILabel peakDayLabel, GameObject peakDayRedPoint, GameObject peakdayIconUIFX = null)
	{
	}

	protected virtual void OnWebViewClose(object[] data)
	{
	}

	protected virtual void OnBtnPeakDayClick()
	{
	}

	protected virtual void RefreshPeakDayBtnView()
	{
	}

	protected virtual void AutoOpenPeakDayWnd(float time, bool autoOpenEnabled = true, bool needDelayShowPeakDay = true)
	{
	}

	protected virtual void OpenPeakDayWnd()
	{
	}

	public void RefreshBigEventBtnEntrance(BigEventEntranceView entranceView)
	{
	}

	protected virtual void OnEntranceViewBubbleCompleteCallback(UIModelBigEvent.EBigEventEntranceID entranceID)
	{
	}

	public void LoadEntranceEffect(BigEventEntranceView entranceView)
	{
	}

	public BigEventEntranceView GetEntranceViewById(UIModelBigEvent.EBigEventEntranceID entranceID)
	{
		return null;
	}

	protected BigEventEntranceViewData GetEntranceViewDataById(UIModelBigEvent.EBigEventEntranceID entranceID)
	{
		return null;
	}

	public void AddBigEventBtnEntranceCDN(UIModelBigEvent.EBigEventEntranceID entranceID, UINetworkTexture cdnIcon, GameObject defaultIcon)
	{
	}

	public void AddBigEventBtnEntranceBubbleObj(UIModelBigEvent.EBigEventEntranceID entranceID, GameObject bubbleObj, GameObject bubbleBGObj, UINetworkTexture bubbleCdn, UILabel bubbleLabel)
	{
	}

	private IEnumerator NaviCoroutine(List<EventDelegate> actionList, float effectTime)
	{
		return null;
	}

	public void InitBigEventBtnEntrance(UIModelBigEvent.EBigEventEntranceID entranceID, UIButton btnEntrance, GameObject openObj = null, GameObject greyObj = null, GameObject onceRedPoint = null, UILabel labelIntroduce = null, GameObject uifxObj = null, uint uifxResID = uint.MaxValue, EventDelegate.Callback onBtnClick = null)
	{
	}

	protected void ClearAllEntranceViewData()
	{
	}

	protected bool CheckEntranceState(UIModelBigEvent.EBigEventEntranceID entranceID)
	{
		return false;
	}

	protected virtual void OnGoToNavigation(UIModelBigEvent.EBigEventEntranceID entranceID)
	{
	}

	protected virtual bool IsShowEntranceRedDot(UIModelBigEvent.EBigEventEntranceID entranceID)
	{
		return false;
	}

	public virtual void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public virtual uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void SetTitelView(UILabel labelDate, UINetworkTextureExt cdnTexture, int cdnType)
	{
	}

	public string GetGetBigEventParamStrByLangeFormat(string paramStr)
	{
		return null;
	}

	protected bool CheckEventOpenInfo()
	{
		return false;
	}

	private void _003CAutoOpenPeakDayWnd_003Eb__34_0()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	public UIModelBigEvent.EBigEventEntranceID _003C_003EiFixBaseProxy_GetEntranceId()
	{
		return UIModelBigEvent.EBigEventEntranceID.Main;
	}
}
