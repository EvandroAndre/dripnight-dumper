using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UILabNavigationController : UINavigationController
{
	private class UICommonGuideData
	{
		public string PlayerPrefKey;

		public CommonGuideSetting Setting;

		public UIButton FinishGuideBtn;

		public UIWidget GuidingWidget;

		public UIAnchor.Side Side;

		public uint SortID;
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Comparison<UICommonGuideData> _003C_003E9__50_0;

		internal int _003CSetGuideSetting_003Eb__50_0(UICommonGuideData a, UICommonGuideData b)
		{
			return 0;
		}
	}

	private sealed class _003CDelayScrollViewResetPosition_003Ed__39 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UILabNavigationController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CDelayScrollViewResetPosition_003Ed__39(int _003C_003E1__state)
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

	public const string NAVIGATION_TITLE_KEY = "T_34_XY_LAB_SYS";

	private const string OPEN_UI_PLAYER_PREF_KEY = "UILABNAVIGATION_OPENUI";

	private const string NAVIGATION_HELP_TIPS_KEY = "T_34_XY_LAB_HELP";

	private const string GUIDE_LENGENDARY_KEY = "T_34_XY_HYPERBOOK_GUIDE6";

	private const string GUIDE_HYPERBOOK_KEY1 = "T_34_XY_HYPERBOOK_OPENTIME";

	private const string GUIDE_HYPERBOOK_KEY2 = "T_34_XY_HYPERBOOK_OPENDEC";

	private const string GUIDE_VIRTUALBRAND_KEY1 = "T_36_DY_VB_GUIDE";

	private const string GUIDE_KEY_STEP1 = "LabGuideLangendary";

	private const string GUIDE_KEY_STEP2 = "LabGuideHyperBook";

	private const string GUIDE_KEY_STEP3 = "LabGuideVirtualBrand";

	private const string GUIDE_KEY_STEP4 = "LabGuideTailor";

	private const uint LEGEND_CLOTH_SYSTEM_ID = 1u;

	private const uint HYPER_BOOK_SYSTEM_ID = 2u;

	public const uint VIRTUAL_BRAND_SYSTEM_ID = 3u;

	public const uint TAILOR_SYSTEM_ID = 4u;

	private const uint IP_COLLAB_SYSTEM_ID = 5u;

	private const float DELAYCALL_GAP = 0.1f;

	private UILabNavigationView m_View;

	private Coroutine m_ScrollViewResetPositionCoroutine;

	private readonly Queue<UICommonGuideData> m_GuideDataQueue;

	private uint m_DelayCallGuide;

	private ulong m_AccountID;

	private GameObject m_EntranceIconIPVFXGameObject;

	private GameObject m_EntranceIconVFXGameObject;

	private GameObject m_EntranceIconIPCDNFXGameObject;

	private List<bool> m_OpenList;

	private List<Transform> m_LocateTransformList;

	private List<bool> m_HasGuideShow;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public override void OnNavigationClosed()
	{
	}

	protected override void OnHelpButtonClick(object[] param)
	{
	}

	private void RefreshLabNavigationEntranceState(uint systemID, GameObject entrance, UILabel footnoteLabel, GameObject openState, GameObject notOpenState)
	{
	}

	private void RefreshCollabSpecialCDNIconAndVFX()
	{
	}

	private void RefreshHyperBookTips()
	{
	}

	private void RefreshLegendClothTips()
	{
	}

	private void PrepareLabEntrances()
	{
	}

	private void StartDelayScrollViewResetPosition()
	{
	}

	private IEnumerator DelayScrollViewResetPosition()
	{
		return null;
	}

	private void ReMoveScrollView()
	{
	}

	private void OnBookEntranceBtnClick()
	{
	}

	private void OnLegendClothEntranceBtnClick()
	{
	}

	private void OnVirtualBrandEntranceBtnClick()
	{
	}

	private void OnTailorEntranceBtnClick()
	{
	}

	private void OnIPCollabEntranceBtnClick()
	{
	}

	private void AddEventDelegate()
	{
	}

	public static bool OnEntranceBtnClickCheck(uint systemID)
	{
		return false;
	}

	private static void WriteOpenUIPlayerPref()
	{
	}

	private void InitGuideInfo()
	{
	}

	private void SetGuideSetting()
	{
	}

	private void StartGuide()
	{
	}

	private void DelayCallExcuteGuide()
	{
	}

	private void ExcuteGuide()
	{
	}

	private void ExcuteNext()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	public void _003C_003EiFixBaseProxy_OnHelpButtonClick(object[] P0)
	{
	}
}
