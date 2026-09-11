using System;
using GCommon;
using UnityEngine;

namespace COW;

public class UIPopupMessageBoxController : UIPopupSpecialWindowController
{
	public enum EButtonStyle
	{
		None,
		OKOnly,
		OKCancel,
		OKClose
	}

	public enum EStandardMessageBoxType
	{
		Info,
		Suggestion,
		Warning,
		Error,
		Hint,
		Exception
	}

	public class MessageBoxInfo
	{
		public string Title;

		public string Info;

		public string OKText;

		public string CancelText;

		public EButtonStyle ButtonStyle;

		public Action OnOK;

		public Action OnCancel;

		public Action OnClose;

		public bool NoCloseButton;

		public string note;

		public int DelayShowOK;
	}

	private UIPopupMessageBoxView m_View;

	protected EButtonStyle m_ButtonStyle;

	protected bool m_NoCloseButton;

	protected Action m_OnOK;

	protected Action m_OnCancel;

	protected Action m_OnClose;

	protected Action m_OnBeforeForceClose;

	private float m_DuraTime;

	private bool m_IsRetry;

	private uint m_LastTime;

	private int m_DelayTime;

	private uint m_DelayCallTid;

	private string m_OkTextKey;

	private int m_DelayShowOK;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void Awake()
	{
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIClose()
	{
	}

	public override void BeforeForceClose()
	{
	}

	private void SetBGAlpha()
	{
	}

	public void ShowStandardMessageBox(string info, EStandardMessageBoxType mbType, Action onOK = null, Action onCancel = null, EButtonStyle buttonStyle = EButtonStyle.OKOnly, bool isColorfulInfo = false, string note = "", Transform par = null, string okTextKey = "", Func<bool> confirmDelayCallFunc = null, Action onBeforeForceClose = null, string cancelTextKey = "", Action onClose = null)
	{
	}

	protected void ActivateDelayExit()
	{
	}

	protected void UpdateDelayExitView()
	{
	}

	public void ShowMessageBox(string title, string info, EButtonStyle buttonStyle = EButtonStyle.OKCancel, Action onOK = null, Action onCancel = null, bool isColorfulInfo = false)
	{
	}

	public void ShowMessageBox(MessageBoxInfo info)
	{
	}

	public void SetRetryStatus(uint time)
	{
	}

	private void UpdateRetryStatus(uint time)
	{
	}

	private void Update()
	{
	}

	private void OnBtnOKClick()
	{
	}

	protected void OnBtnCancelClick()
	{
	}

	protected void UpdateView()
	{
	}

	public override bool ClosedByEsc()
	{
		return false;
	}

	public override void OnEnterButtonClick()
	{
	}

	public void SetPopupMessageInfo(string message)
	{
	}

	public override void Show()
	{
	}

	public void SetOfflineTipsVisible(bool visible)
	{
	}

	public void OpenOfflinePlayTips(Action onOfflinePlayClick)
	{
	}

	public void SetTipContainerVisible(bool visible)
	{
	}

	public void OpenWorkshopReportTip(Action onFeedbackClick)
	{
	}

	public void _003C_003EiFixBaseProxy_Awake()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_BeforeForceClose()
	{
	}

	public bool _003C_003EiFixBaseProxy_ClosedByEsc()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnEnterButtonClick()
	{
	}

	public void _003C_003EiFixBaseProxy_Show()
	{
	}
}
