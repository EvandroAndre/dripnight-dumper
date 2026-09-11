using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UITutorialIndicatorController : UIBaseController
{
	private sealed class _003COnNextFrame_003Ed__75 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UITutorialIndicatorController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003COnNextFrame_003Ed__75(int _003C_003E1__state)
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

	private UITutorialIndicatorView m_View;

	private UITutorialIndicatorCharacterController m_UICharacter;

	private UITutorialIndicatorHandController m_UIHand;

	private const float TextIntervalWithCircle = 85f;

	private const float TextIntervalWithCharacter = 50f;

	private const int DefaultCircleWidth = 100;

	private const int DefaultCircleThinnerWidth = 98;

	private const int DefaultCircleThinnerEffectWidth = 88;

	private const int DefaultRectWidth = 300;

	private const int DefaultRectHeight = 100;

	private const int SafeAreaBorder = 40;

	private const int OriginalDepth = 29;

	private Dictionary<int, Quaternion> m_ArrowQuaternionDict;

	private Dictionary<int, Vector2> m_ArrowAnchorPixelOffetDict;

	private TutorialSetting m_TutSetting;

	private Transform m_ButtonTrans;

	private UIWidget m_BindWidget;

	private TutorialWidgetVariable m_BindWidgetVariable;

	private EventDelegate m_TmpClickEvent;

	private float m_CachTextWidth;

	private AdjacentEdge m_CachAdjacentEdge;

	private TutorialUIType m_CachHintType;

	private float m_CacheTopOffset;

	private Vector3 m_CacheHintOffset;

	private bool m_IsMaskAll;

	private bool m_StopOnPressWithUIEventTrigger;

	private Vector3 m_IndicatorOffset;

	private UIRoot m_UIRoot;

	private readonly Vector3 HintWithCharacterHintPos;

	private readonly Vector3 HandDragUpHintPos;

	private bool m_bIsForceComplete;

	private UIButton m_ForceExecute;

	private uint m_uMaskAllOverTimerActID;

	private WaitForEndOfFrame m_waitFrame;

	private Coroutine m_coroutine;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void OnClickMaskBtn()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override void OnUIOpen()
	{
	}

	public void Reset()
	{
	}

	public void SetIndicatorOffset(Vector3 localOffset)
	{
	}

	private Vector3 GetIndicatorWorldOffset()
	{
		return default(Vector3);
	}

	private void ResetChilds()
	{
	}

	public void ShowTutorialAtPosition(UIButton bindBtn, UIWidget bindWidget, TutorialSetting tutSetting, TutorialWidgetVariable widgetVariable, AdjacentEdge adjacentEdge, Vector3 hintOffsetPos, bool stopOnPressWithUIEventTrigger, bool hideCharacterWithNoBindWidget, ArrowCustomSettings customArrowSettings)
	{
	}

	private void CustomizedPostionByEventType()
	{
	}

	public void SetArrowCustomSettings(GameObject arrowContainer, ArrowCustomSettings settings)
	{
	}

	private void SetDepth(TutorialDepthType depthType, int depthOffset = 1)
	{
	}

	private void SetDepth(bool abovePopup, int depthOffset = 1)
	{
	}

	public void SetPanelDepth(int depth)
	{
	}

	private bool CheckHintCharacterNeedShow(TutorialUIType hintType)
	{
		return false;
	}

	private void SetHintCharacterActive(bool active)
	{
	}

	public void UpdatePosition(Transform showTrans, bool changed = true)
	{
	}

	public void UpdateWholePosition(Transform showTrans)
	{
	}

	private void Update()
	{
	}

	private AdjacentEdge GetAdjacentEdge(Vector3 position)
	{
		return AdjacentEdge.None;
	}

	private void ArrowRotateAndSetPosForAdjacentEdge(AdjacentEdge adjacentEdge, GameObject arrowContainer)
	{
	}

	private void SetHintTextTransform(float textWidth, AdjacentEdge adjacentEdge, TutorialUIType hintType, float topOffset, Vector3 hintOffsetPos)
	{
	}

	private void AdjustPosInSafeArea(float leftDelta, float rightDelta, float topDelta, float bottomDelta)
	{
	}

	private void BindCircleAndRectWithTrans(UIWidget sizeWidget, TutorialWidgetVariable widgetVariable = null)
	{
	}

	private void SetButtonClickEventDelegate(UIButton button)
	{
	}

	private void RemoveButtonClickEventDelegate(Transform buttonTransform)
	{
	}

	private void FinishCurrentTutoOnClick()
	{
	}

	private bool CheckTargetInScreen()
	{
		return false;
	}

	public void FinishCurrentTutorial(object[] param)
	{
	}

	public bool IsForceComplete()
	{
		return false;
	}

	public void SetForceComplete()
	{
	}

	public void ForceComplete()
	{
	}

	public void OpenMaskAll(UIButton bindBtn = null)
	{
	}

	public void CloseMaskAll()
	{
	}

	public void PlayShrinkTwoLine()
	{
	}

	public void DisableShrinkTwoLine()
	{
	}

	public void PlayShrinkOneLine()
	{
	}

	public void DisableShrinkOneLine()
	{
	}

	public void StartTapOnEmptyClose()
	{
	}

	private IEnumerator OnNextFrame()
	{
		return null;
	}

	public void StopTapOnEmptyClose()
	{
	}

	private void OnClickEmptySpaceClose()
	{
	}

	public void SetTutorialHandLocalTrans(Vector3 pos, Vector3 scale)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}
}
