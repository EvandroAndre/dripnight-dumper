using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIPaymentController : UINavigationController, IUIModelDataChangeObserver
{
	public enum Tab
	{
		None,
		IAP,
		RebateCard,
		Bundle,
		FirstTime,
		Total,
		Activity,
		Shop,
		DiamondEvent,
		Subscription,
		GrowthFund,
		TopUpEvent,
		MemberShip,
		EvoGunMembership,
		NewBie,
		GrowthFundV2,
		SquadTreasure,
		UpperLimit
	}

	public enum EBundleType
	{
		Default,
		Bundle,
		Newbie,
		UpperLimit
	}

	public class TabInfo
	{
		public string NameLocKey;

		public ETipsType TipsType;

		public Func<bool> Visible;

		public string NoteLocKey;

		public bool LogClick;

		public bool SubTab;
	}

	public class PaymentGotoParams
	{
		public int SubTabIndex;
	}

	public class PaymentTabContentController : UIBaseController
	{
		public virtual void GotoByParams(PaymentGotoParams parameters)
		{
		}

		public virtual void RefreshContent()
		{
		}

		public virtual void OnPopUpWindowListChange(bool isCovered)
		{
		}
	}

	public class ImageIterator
	{
		public enum ImageType
		{
			MainImage,
			SubImage
		}

		[Serializable]
		private sealed class _003C_003Ec
		{
			public static readonly _003C_003Ec _003C_003E9;

			public static Converter<CSVBaseData, string> _003C_003E9__4_0;

			public static Converter<CSVBaseData, string> _003C_003E9__4_1;

			internal string _003Cget_I_003Eb__4_0(CSVBaseData csvBaseData)
			{
				return null;
			}

			internal string _003Cget_I_003Eb__4_1(CSVBaseData csvBaseData)
			{
				return null;
			}
		}

		private static ImageIterator _I;

		public Dictionary<int, int> PoolState;

		public Dictionary<int, List<string>> IndexPool;

		public static ImageIterator I => null;

		private ImageIterator()
		{
		}

		public string Next(ImageType type)
		{
			return null;
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<int, bool> _003C_003E9__7_0;

		internal bool _003Cget_DefaultTab_003Eb__7_0(int t)
		{
			return false;
		}

		internal bool _003C_002Ecctor_003Eb__80_0()
		{
			return false;
		}

		internal bool _003C_002Ecctor_003Eb__80_1()
		{
			return false;
		}

		internal bool _003C_002Ecctor_003Eb__80_2()
		{
			return false;
		}

		internal bool _003C_002Ecctor_003Eb__80_3()
		{
			return false;
		}

		internal bool _003C_002Ecctor_003Eb__80_4()
		{
			return false;
		}

		internal bool _003C_002Ecctor_003Eb__80_5()
		{
			return false;
		}

		internal bool _003C_002Ecctor_003Eb__80_6()
		{
			return false;
		}

		internal bool _003C_002Ecctor_003Eb__80_7()
		{
			return false;
		}

		internal bool _003C_002Ecctor_003Eb__80_8()
		{
			return false;
		}

		internal bool _003C_002Ecctor_003Eb__80_9()
		{
			return false;
		}

		internal bool _003C_002Ecctor_003Eb__80_10()
		{
			return false;
		}

		internal bool _003C_002Ecctor_003Eb__80_11()
		{
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass47_0
	{
		public uint groupId;

		internal bool _003COnNavigationShowed_003Eb__0(ActivityGroupDesc x)
		{
			return false;
		}
	}

	private sealed class _003CInitPrimeEntranceCoroutine_003Ed__76 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIPaymentController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CInitPrimeEntranceCoroutine_003Ed__76(int _003C_003E1__state)
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

	private sealed class _003CRefreshPrimeEntranceLabelCoroutine_003Ed__68 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIPaymentController _003C_003E4__this;

		public int primeLabelAnimationStartValue;

		public int primeLabelAnimationTargetValue;

		private int _003ClevelNeedPoint_003E5__2;

		private float _003CelapsedTime_003E5__3;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CRefreshPrimeEntranceLabelCoroutine_003Ed__68(int _003C_003E1__state)
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

	private static readonly int[] TAB_ORDER;

	private static readonly Dictionary<int, TabInfo> TAB_INFO;

	private Dictionary<int, PaymentTabContentController> m_Tabs;

	private Tab m_CurrentTab;

	private int m_CurrentSubTab;

	private UIPaymentView m_View;

	private UIModelActivity m_ModelActivity;

	private UIModelPayment m_ModelPayment;

	private UIModelEvoPass m_ModelEvoPass;

	private UIModelNewPlayerIAPBundle m_ModelNewPlayerIAPBundle;

	private UIModelPrime m_ModelPrime;

	private UIModelSquadTreasure m_ModelSquadTreasure;

	private Tab m_Tab;

	private PaymentGotoParams m_PaymentGotoParams;

	private uint m_LupUnlockId;

	private bool m_HasTabCreated;

	private float m_EnterTime;

	private bool m_LoggedWaitNetTime;

	private UIPrimePrivilegeBadgeController m_BadgeCtrl;

	private Tab m_ReturnTab;

	private bool m_AutoPopupInviteWnd;

	private GameObject m_PrimeLevelUpVFXObj;

	private GameObject m_PrimePointsLightVFXObj;

	private readonly Dictionary<int, UIPaymentTabItemController> m_TabItems;

	private const string SQUAD_TREASURE_GOTO_KEY = "SQUAD_TREASURE_GOTO_KEY_{0}_{1}";

	private float m_PrimeLabelAnimationDuration;

	private Coroutine m_PrimeLabelAnimationCoroutine;

	private const float SCROLL_VIEW_LOCAL_POSITION_Y = -102f;

	private const float PANEL_BASE_CLIP_REGION_W = 500f;

	private const float LEFT_CONTAINER_LOCAL_POSITION_Y = 262f;

	private const float LEFT_TAB_LOCAL_POSITION_Y = 6f;

	private static int[] TabOrder => null;

	public static Tab DefaultTab => Tab.None;

	public static Tab DefaultChargeTab => Tab.None;

	public static bool CanHandleDebt => false;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void InitTabAndCheckGetPayLevelInfo()
	{
	}

	public void RefreshAll(bool notGoToDefault = false)
	{
	}

	private void CreateTabUI(bool repositon = true)
	{
	}

	private void LogLobbyPerformanceWaitNetTime()
	{
	}

	private void GotoByNavigation()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void OnTabItemGotoTab(object[] parameters)
	{
	}

	private void OnTabItemGotoTabInternal(object[] parameters)
	{
	}

	private void RefreshBG()
	{
	}

	public override void OnNavigationClosed()
	{
	}

	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void Goto(Tab tab, PaymentGotoParams paymentGotoParams = null, uint lupUnlockId = 0u, bool autoPopupInviteWnd = false)
	{
	}

	private void PlayGrowthFundV2UnlockVFX(Tab tab, uint lupUnlockId)
	{
	}

	private void CheckAutoPopupInviteWnd(Tab tab, bool autoPopupInviteWnd)
	{
	}

	private PaymentTabContentController Open(Tab tab)
	{
		return null;
	}

	private void RefreshCurrentTabContent()
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public void RefreshTableAndScrollView(bool needScroll, float dragAmoung = 1f)
	{
	}

	protected override void OnPopupWindowListChange()
	{
	}

	private void TryGotoSquadTreasure()
	{
	}

	public override bool OverwriteBackButtonLogic()
	{
		return false;
	}

	private void RefreshPrimeEntrance()
	{
	}

	private void RefreshPrimePointsLabelStyle(bool isMax)
	{
	}

	private IEnumerator RefreshPrimeEntranceLabelCoroutine(int primeLabelAnimationStartValue, int primeLabelAnimationTargetValue)
	{
		return null;
	}

	private float EaseInCubic(float x)
	{
		return 0f;
	}

	private void RefreshPrimeEntranceLabelDirectly()
	{
	}

	private void ResetPrimeChangeFlag()
	{
	}

	private IEnumerator InitPrimeEntranceCoroutine()
	{
		return null;
	}

	private void InitPrimeEntrance()
	{
	}

	private void OnPrimeBtnClick()
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

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	public void _003C_003EiFixBaseProxy_OnPopupWindowListChange()
	{
	}

	public bool _003C_003EiFixBaseProxy_OverwriteBackButtonLogic()
	{
		return false;
	}
}
