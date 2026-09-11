using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UICommonGuideController : UIBaseController
{
	private UICommonGuideView m_View;

	private UITutorialIndicatorCharacterController m_UICharacter;

	private UITutorialIndicatorHandTweenController m_UIHand;

	private const float TextIntervalWithCircle = 85f;

	private const float TextIntervalWithCharacter = 40f;

	private const int DefaultCircleWidth = 100;

	private const int DefaultRectWidth = 300;

	private const int DefaultRectHeight = 100;

	private UIStandardGuideMaskController m_GuideMaskCtrl;

	private Dictionary<int, Quaternion> m_ArrowQuaternionDict;

	private Dictionary<int, Vector2> m_ArrowAnchorPixelOffetDict;

	private CommonGuideSetting m_CommonGuideSetting;

	private Transform m_BindWidgetTrans;

	private UIButton m_BindBtn;

	private UIToggle m_BindToggle;

	private EventDelegate m_TmpClickEvent;

	private float m_CachTextWidth;

	private float m_CachTextHeight;

	private UIAnchor.Side m_CachAnchorSide;

	private TutorialUIType m_CachHintType;

	private Action m_CloseAction;

	private Action m_FinishAction;

	private UIWidget m_BindWidget;

	private uint DelayCallId;

	private bool m_NeedFollowTarget;

	private Vector3 m_IndicatorOffset;

	private bool m_HasVirtualTarget;

	private Vector3 m_VirtualTargetLocalPosition;

	private float m_VirtualTargetRadius;

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

	protected override void OnUIClose()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	private void Update()
	{
	}

	public void Reset()
	{
	}

	public void ShowStandaloneArrow(Vector3 localPos, UIAnchor.Side anchorSide)
	{
	}

	public void SetIndicatorOffset(Vector3 localOffset)
	{
	}

	public void SetHintLocalPosition(Vector3 localPosition)
	{
	}

	private Vector3 GetIndicatorWorldOffset()
	{
		return default(Vector3);
	}

	public UIStandardGuideMaskController GetGuideMaskCtrl()
	{
		return null;
	}

	public void ShowGuideWithMask(UIWidget bindWidget, CommonGuideSetting guideSetting, UIAnchor.Side anchorSide, List<EventDelegate> guideMaskAction = null, Transform guideMaskContainer = null, Action onInitAction = null, Action onCloseAction = null, bool needClickClose = false, bool useClickRightRegion = false, bool enableSkip = false, Action skipAction = null)
	{
	}

	public void SetMaskBgAlpha(float alpha)
	{
	}

	public void DisableMaskClickBtn()
	{
	}

	public void ShowGuide(UIWidget bindWidget, CommonGuideSetting guideSetting, UIAnchor.Side anchorSide, bool needFollowTarget = false, Action onInitAction = null, Action onCloseAction = null)
	{
	}

	public void ShowGuide(UIToggle bindToogleNotBtn, UIWidget bindWidget, CommonGuideSetting guideSetting, UIAnchor.Side anchorSide, bool needFollowTarget = false, Action onInitAction = null, Action onCloseAction = null)
	{
	}

	public void ShowGuide(UIButton bindBtn, UIWidget bindWidget, CommonGuideSetting guideSetting, UIAnchor.Side anchorSide, bool needFollowTarget = false, Action onInitAction = null, Action onCloseAction = null)
	{
	}

	public void ShowGuideAtLocalPosition(Vector3 localPosition, float radius, CommonGuideSetting guideSetting, UIAnchor.Side anchorSide, Action onInitAction = null, Action onCloseAction = null)
	{
	}

	public void SetOnCloseCallback(Action callback)
	{
	}

	public void SetOnFinishCallback(Action callback)
	{
	}

	private void InitGuideView(UIWidget bindWidget, CommonGuideSetting guideSetting, UIAnchor.Side anchorSide, bool needFollowTarget = false, Action onInitAction = null, Action OnCloseAction = null)
	{
	}

	public UIWidget GetClickWidget()
	{
		return null;
	}

	public void UpdateDepth(int newDepth)
	{
	}

	public void UpdateGuideMaskDepth(int newDepth)
	{
	}

	private bool CheckHintCharacterNeedShow(TutorialUIType hintType)
	{
		return false;
	}

	private void SetHintCharacterActive(bool active, bool isKelly = true)
	{
	}

	private void ArrowRotateByDirection(UIAnchor.Side anchorSide)
	{
	}

	private void UpdatePosition(Transform showTrans)
	{
	}

	private void SetHintTextTransform(float textHeight, float textWidth, UIAnchor.Side anchorSide, TutorialUIType hintType)
	{
	}

	private void KeepHintInScreen(float textWidth)
	{
	}

	private void BindCircleAndRectWithTrans(UIButton button, UIToggle bindToggleNotBtn, UIWidget sizeWidget)
	{
	}

	private void BindCircleAndRectWithVirtualTarget()
	{
	}

	private void SetGuideElementsLocalPosition(Vector3 localPosition)
	{
	}

	private void ClearVirtualTarget()
	{
	}

	private void SetButtonClickEventDelegate(UIButton button, UIToggle bindToggleNotBtn)
	{
	}

	private void RemoveButtonClickEventDelegate(UIButton bindBtn, UIToggle bindToggle)
	{
	}

	private void Finish()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
