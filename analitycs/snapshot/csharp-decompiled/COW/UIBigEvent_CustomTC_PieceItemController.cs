using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using proto;

namespace COW;

public class UIBigEvent_CustomTC_PieceItemController : UIBaseController, IBigEventTemplateIdentifier
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Converter<AwardDesc, BaseItemInfo> _003C_003E9__35_0;

		internal BaseItemInfo _003CShowPieceItemPreview_003Eb__35_0(AwardDesc item)
		{
			return null;
		}
	}

	private sealed class _003CScrollProgress_003Ed__39 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIBigEvent_CustomTC_PieceItemController _003C_003E4__this;

		private int _003CFinalCount_003E5__2;

		private float _003CdeltaCount_003E5__3;

		private float _003CNowCount_003E5__4;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CScrollProgress_003Ed__39(int _003C_003E1__state)
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

	private UIBigEvent_CustomTC_PieceItemView m_View;

	private UIModelBigEventTemplate m_UIModelBigEventTemplate;

	private UIModelBigEvent_CustomTC m_UIModelCustomTC;

	private CustomTCPieceInfo m_PieceInfo;

	private ResourceID m_PieceEffectVFXResID;

	private GameObject m_PieceEffectVFXGo;

	private ResourceID m_ProgressVFXResID;

	private GameObject m_ProgressVFXGo;

	private ResourceID m_PieceTransitionVFXResID;

	private GameObject m_PieceTransitionVFXGo;

	private Animation m_ProgressAnimation;

	private Animation m_RewardAnimation;

	private float m_ProgressTime;

	private uint m_OldProgress;

	private const string TC_PIECE_IN_ANIM = "UIFX_Jumpsuit23B_TCBigEvent_01";

	private const string TC_PIECE_OUT_ANIM = "UIFX_Jumpsuit23B_TCBigEvent_02";

	private const string TC_PROGRESS_LOOP_ANIM = "UIFX_Jumpsuit23B_TCBoxBtn_Ani_C02_Loop";

	private const string TC_PROGRESS_ONCE_ANIM = "UIFX_Jumpsuit23B_TCBoxBtn_Ani_C02_Once";

	private const string TC_PROGRESS_REWARD_ANIM = "UIFX_Jumpsuit23B_TCBoxBtn_Ani_C02_LoopYellow";

	private const string TC_NORMAL_ANIM = "UIFX_Jumpsuit23B_TCPieceItem_Ani_02";

	private const string TC_REWARD_ANIM = "UIFX_Jumpsuit23B_TCPieceItem_Ani_03";

	private uint m_PlayPieceOutAnimitionDelayCall;

	private EBigEventTemplateUseType _003CTemplateUseType_003Ek__BackingField;

	public CustomTCPieceInfo PieceInfo => null;

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

	public void SetViewData(CustomTCPieceInfo pieceInfo, float width, float height)
	{
	}

	public void RefreshViewInfoBeforeAnimation()
	{
	}

	public void RefreshViewInfo()
	{
	}

	private void DestoryEffectVFX()
	{
	}

	public void PlayPieceAnimitionIn()
	{
	}

	public void PlayPieceAfterAnimitionIn()
	{
	}

	public void PlayPieceOutAnimition()
	{
	}

	private void OnClickPieceItemBtn()
	{
	}

	private void ShowPieceItemPreview()
	{
	}

	private void OnClickProgreseBtn()
	{
	}

	private void InitEffectVFX()
	{
	}

	public void StartProgressAnimation()
	{
	}

	private IEnumerator ScrollProgress()
	{
		return null;
	}

	private void RefreshProgressState(CustomTCPieceInfo.TCPieceState state)
	{
	}

	protected override void OnUIOpenAsChild()
	{
	}

	public virtual EBigEventTemplateType GetTemplateType()
	{
		return EBigEventTemplateType.None;
	}

	public void OnTemplateUIInit()
	{
	}

	private void _003CPlayPieceOutAnimition_003Eb__33_0()
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
