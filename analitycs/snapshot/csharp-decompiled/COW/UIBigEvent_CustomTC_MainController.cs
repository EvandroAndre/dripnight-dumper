using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIBigEvent_CustomTC_MainController : UIBaseController, IUIModelDataChangeObserver, IBigEventTemplateIdentifier
{
	private enum ShareStatus
	{
		Sharing = 1,
		Submit = 2,
		Receive = 4
	}

	private sealed class _003CScrollProgress_003Ed__52 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIBigEvent_CustomTC_MainController _003C_003E4__this;

		private int _003CFinalCount_003E5__2;

		private float _003CdeltaCount_003E5__3;

		private float _003CNowCount_003E5__4;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CScrollProgress_003Ed__52(int _003C_003E1__state)
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

	private UIModelBigEvent_CustomTC m_UIModelCustomTC;

	private UIModelActivity m_ModelActivity;

	private UIModelBigEventTemplate m_UIModelBigEventTemplate;

	private UIBigEvent_CustomTC_MainView m_View;

	private UIBigEvent_CustomTC_DecipherPopupWndController m_DecipherPopupWndCtrl;

	private bool m_PieceInit;

	private List<UIBigEvent_CustomTC_PieceItemController> m_PieceItemList;

	private ResourceID m_TCRewardPreviewVFXResID;

	private GameObject m_TCRewardPreviewVFXGO;

	private ResourceID m_TCMainInVFXResID;

	private GameObject m_TCMainInVFXGO;

	private ResourceID m_TCMainFirstInVFXResID;

	private GameObject m_TCMainFirstInVFXGO;

	private ResourceID m_TCMainBGVFXResID;

	private GameObject m_TCMainBGVFXGO;

	private ResourceID m_TCCirculateBoxRewardVFXResID;

	private GameObject m_TCCirculateBoxRewardVFXGO;

	private ResourceID m_TCCirculateBoxVFXResID;

	private GameObject m_TCCirculateBoxVFXGO;

	private ResourceID m_ProgressVFXResID;

	private GameObject m_ProgressVFXGo;

	private Animation m_ProgressAnimation;

	private float m_ProgressTime;

	private uint m_OldProgress;

	private const string TC_MAIN_IN_ANIM = "UIFX_Jumpsuit23B_Main_01";

	private const string TC_PROGRESS_LOOP_ANIM = "UIFX_Jumpsuit23B_TCBoxBtn_Ani_C02_Loop";

	private const string TC_PROGRESS_ONCE_ANIM = "UIFX_Jumpsuit23B_TCBoxBtn_Ani_C02_Once";

	private const uint TC_MAIN_LOCK_COLOR = 3284386815u;

	private uint m_OutAnimationPieceId;

	private float m_DelayInAnimTime;

	private uint m_DelayInAnimTimeKey;

	private ClientActivityDesc m_ShareActivity;

	private CustomTCPieceInfo m_CirculatInfo;

	private EBigEventTemplateUseType _003CTemplateUseType_003Ek__BackingField;

	private uint m_ShareStatus;

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

	private void OnClickDecipherBtn()
	{
	}

	private void OnClickPreviewBtn()
	{
	}

	private void OnClickShareBtn()
	{
	}

	private void OnShareClose()
	{
	}

	private void OnCirculateBoxPrgressBtn()
	{
	}

	private void OnCirculateBoxBtn()
	{
	}

	public bool GetDecipherGuide(out UIWidget targetWidget, out UIButton finishButton)
	{
		targetWidget = null;
		finishButton = null;
		return false;
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private void OnDecipherClose(object[] data)
	{
	}

	private void PlayCirculateBoxIn()
	{
	}

	public void StartProgressAnimation()
	{
	}

	private IEnumerator ScrollProgress()
	{
		return null;
	}

	public void CreatePiece()
	{
	}

	private void ClearPieceItem()
	{
	}

	public void RefreshAllView()
	{
	}

	public void RefreshView()
	{
	}

	private void RefreshTokenView()
	{
	}

	public void OnPopupWindowListChange()
	{
	}

	private void CheckPieceOutAniamton()
	{
	}

	public void RefreshShareState()
	{
	}

	public override void OnShare(bool success, int platform)
	{
	}

	public override void OnCopyShareLink(bool success)
	{
	}

	public override void OnSaveSharePhoto(bool success)
	{
	}

	private void SubmitShareActivity()
	{
	}

	private void HideSharImage()
	{
	}

	private void RefreshPieceItem()
	{
	}

	private void RefreshViewCirculateBoxView()
	{
	}

	private void ProcessAnimEvt(object[] data)
	{
	}

	public void PlayAnimationFirstIn()
	{
	}

	public void PlayAnimationIn()
	{
	}

	public void PlayAfterAnimationIn()
	{
	}

	private void ShowPeakDayPopWnd()
	{
	}

	private void InitEffectVFX()
	{
	}

	private void DestoryEffectVFX()
	{
	}

	protected override void OnUIOpenAsChild()
	{
	}

	public EBigEventTemplateType GetTemplateType()
	{
		return EBigEventTemplateType.None;
	}

	public void OnTemplateUIInit()
	{
	}

	private void InitCDN()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnShare(bool P0, int P1)
	{
	}

	public void _003C_003EiFixBaseProxy_OnCopyShareLink(bool P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnSaveSharePhoto(bool P0)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpenAsChild()
	{
	}
}
