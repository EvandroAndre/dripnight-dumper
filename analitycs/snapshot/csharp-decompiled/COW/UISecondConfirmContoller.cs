using System;
using System.Collections.Generic;
using GCommon;

namespace COW;

public class UISecondConfirmContoller : UIPopupWindowController
{
	public enum Style
	{
		IconGoods,
		TextGoods,
		OneText,
		CheckBoxText,
		SpriteLabel,
		TextWithIconGoods
	}

	protected UISecondConfirmView m_View;

	private List<BaseItemInfo> m_Items;

	private string m_OneText;

	private string m_CheckBoxText;

	private string m_SpriteName;

	private string m_SpriteLabelText;

	private bool m_ForceFullScreen;

	private Action m_ConfirmAction;

	private Action m_CancelAction;

	private Action m_OnDestroyAction;

	private Action<bool> m_CheckBoxSelectedAction;

	protected bool m_AutoCloseOnConfirm;

	private List<ResourceID> m_IconResList;

	private ulong m_EndTime;

	private uint m_DelayCall;

	private string m_CountDownLabelFormat;

	private Action m_OnCountDownFinished;

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

	private void OnAssetRefresh(object[] param)
	{
	}

	protected void OnCancelClick()
	{
	}

	protected virtual void OnConfirmClick()
	{
	}

	private void OnCheckBoxClick()
	{
	}

	public void SetData(Style style, List<BaseItemInfo> goods = null, string oneText = "", string CheckBoxText = "", bool autoCheck = false, bool forceFullScreen = false, string spriteLabelText = "", string strSpriteRes = "", List<ResourceID> iconResList = null)
	{
	}

	private void CreateIconGoodss()
	{
	}

	private void CreateTextGoods()
	{
	}

	private void CreateTextWithIconGoods()
	{
	}

	private void CreateOneText()
	{
	}

	private void CreateCheckBoxText(bool autoCheck = false)
	{
	}

	private void CreateSpriteLabel()
	{
	}

	public bool IsCheckBoxSelected()
	{
		return false;
	}

	public void RefreshSLLabel(string text)
	{
	}

	public void SetTitle(string title)
	{
	}

	public void SetConfirmBtnText(string text)
	{
	}

	public void SetCancelBtnText(string text)
	{
	}

	public void SetConfirmBtnTextWithCountDownAction(string format, int duration, Action onCountDownFinish = null)
	{
	}

	private void CountDown()
	{
	}

	private void CancelCountDown()
	{
	}

	public void SetConfirmText(string text)
	{
	}

	public void ShowCancelButton()
	{
	}

	public void SetConfirmCallback(Action action)
	{
	}

	public void SetCancelCallback(Action action)
	{
	}

	public void SetCloseCallback(EventDelegate.Callback action)
	{
	}

	public void SetOnDestroyCallback(Action action)
	{
	}

	public void SetCheckboxCallback(Action<bool> action)
	{
	}

	public override void EnterByReturn()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_EnterByReturn()
	{
	}
}
