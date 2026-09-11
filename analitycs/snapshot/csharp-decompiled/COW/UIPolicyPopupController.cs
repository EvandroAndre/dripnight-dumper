using System;
using GCommon;

namespace COW;

public class UIPolicyPopupController : UIPopupSpecialWindowController
{
	public class Config
	{
		public string Title;

		public string Content;

		public string Tips;

		public string OKTxt;

		public string CancelTxt;

		public Action OnOk;

		public Action OnCancel;

		public bool InitChecked;

		public bool URLHide;
	}

	private const string URL = "https://www.garena.sg/privacy";

	private UIPolicyPopupView m_View;

	private Action m_OnOK;

	private Action m_OnCancel;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIClose()
	{
	}

	public void SetUIData(Config config)
	{
	}

	private void OnBtnOKClick()
	{
	}

	private void OnBtnCancelClick()
	{
	}

	private void OnCheckChanged()
	{
	}

	private void OnURLClick()
	{
	}

	public override void OnBackButtonClick()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_OnBackButtonClick()
	{
	}
}
