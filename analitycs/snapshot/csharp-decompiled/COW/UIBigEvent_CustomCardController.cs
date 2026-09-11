using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIBigEvent_CustomCardController : UINavigationController, IUIModelDataChangeObserver, IGuideQueueContainer, IBigEventTemplateIdentifier
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<AwardDesc, BaseItemInfo> _003C_003E9__41_0;

		public static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003E9__45_0;

		internal BaseItemInfo _003COnCardDrawScuess_003Eb__41_0(AwardDesc item)
		{
			return null;
		}

		internal CommonRewardItemInfo _003CShowDrawResult_003Eb__45_0(BaseItemInfo item)
		{
			return null;
		}
	}

	private sealed class _003CDelayRunGuideQueueCoroutine_003Ed__52 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIBigEvent_CustomCardController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDelayRunGuideQueueCoroutine_003Ed__52(int _003C_003E1__state)
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

	private sealed class _003CIEDestroyAnimation_003Ed__48 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIBigEvent_CustomCardController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CIEDestroyAnimation_003Ed__48(int _003C_003E1__state)
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

	private UIBigEvent_CustomCardView m_View;

	private UIModelBigEventTemplate m_UIModelBigEventTemplate;

	private UIModelBigEvent_CustomCard m_UIModelCustomCard;

	private List<UIBaseController> m_LeftBtnControllers;

	private UIBigEvent_CustomCardGive_BtnItemController m_GiveItemController;

	private UIBigEvent_CardProgressController m_CardProgressController;

	private UICustomCardMainBaseController m_CardMainController;

	private ResourceID m_StageLightEffectVFXResID;

	private GameObject m_StageLightEffectVFXGO;

	private GuideQueue m_GuideQueue;

	private Coroutine m_DelayRunGuideQueueCoroutine;

	private string m_strDrawKey;

	private string m_strWishKey1;

	private string m_strWishKey2;

	private int audio_track;

	private bool isPlayDrawCardAnim;

	private UIBigEvent_CustomCard_TokenItemController m_DrawTokenCtrl;

	private UIBigEvent_CustomCard_TokenItemController m_WishTokenCtrl;

	private bool m_hasInitTemplateUI;

	private List<BaseItemInfo> mlistCacheDrawAwards;

	private GameObject m_DrawAnimation;

	private AutoOpenIntegrationData m_AutoOpenIntegrationData;

	private EBigEventTemplateUseType _003CTemplateUseType_003Ek__BackingField;

	public EBigEventTemplateUseType TemplateUseType
	{
		get
		{
			return _003CTemplateUseType_003Ek__BackingField;
		}
		set
		{
			_003CTemplateUseType_003Ek__BackingField = value;
		}
	}

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public Vector3 GetProgressThumbPosition()
	{
		return default(Vector3);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void ShowPeakDayPopWnd()
	{
	}

	public override void OnNavigationClosed()
	{
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	protected override void OnPopupWindowListChange()
	{
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	private void OnRuleBtnClick()
	{
	}

	private void OnCloseBtnClick()
	{
	}

	private void OnSkipBtnClick()
	{
	}

	private void InitEffect()
	{
	}

	private void InitTokenOwnedShowState()
	{
	}

	private void InitCloseBtnShowState()
	{
	}

	private void GetUseTypeFromProvider()
	{
	}

	private void InitLeftTopTitleCDNAndOpenTime()
	{
	}

	private void RefreshGridLeftBtns()
	{
	}

	private void OnCardDrawScuess(object[] data)
	{
	}

	private void ProcessAnimEvt(object[] data)
	{
	}

	private void ClearCache()
	{
	}

	private void BeginPlayDrawAnim()
	{
	}

	public void ShowDrawResult()
	{
	}

	private void PlayDropBoxAnim()
	{
	}

	private void EndPlayDrawAnim()
	{
	}

	private IEnumerator IEDestroyAnimation()
	{
		return null;
	}

	private void TryStopAnimation(string evt)
	{
	}

	private void AddGuideQueueSteps()
	{
	}

	private void StartDelayRunGuideQueueCoroutine()
	{
	}

	private IEnumerator DelayRunGuideQueueCoroutine()
	{
		return null;
	}

	public bool IsAvailable()
	{
		return false;
	}

	public bool IsStepAvailable(string stepKey, out UIWidget targetWidget, out UIButton finishButton)
	{
		targetWidget = null;
		finishButton = null;
		return false;
	}

	public GameObject GetGuideMask()
	{
		return null;
	}

	public UICommonGuideController OpenGuideController(string stepKey)
	{
		return null;
	}

	public UIPopupWindowController GetOrShowPopupWindow(Type type)
	{
		return null;
	}

	private void OnGotoNavigation(uint entranceType, int tabIndex = 0)
	{
	}

	public virtual EBigEventTemplateType GetTemplateType()
	{
		return EBigEventTemplateType.None;
	}

	public void OnTemplateUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	public void _003C_003EiFixBaseProxy_OnPopupWindowListChange()
	{
	}
}
