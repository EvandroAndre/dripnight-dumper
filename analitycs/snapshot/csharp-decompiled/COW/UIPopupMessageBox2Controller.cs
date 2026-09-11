using System;
using GCommon;

namespace COW;

public class UIPopupMessageBox2Controller : UIPopupWindowController
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
		Hint
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

		public bool NoCloseButton;

		public string note;
	}

	private UIPopupMessageBoxView m_View;

	protected EButtonStyle m_ButtonStyle;

	protected bool m_NoCloseButton;

	protected Action m_OnOK;

	protected Action m_OnCancel;

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

	public void ShowMessageBox(MessageBoxInfo info)
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

	public override void Show()
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

	public void _003C_003EiFixBaseProxy_Show()
	{
	}
}
