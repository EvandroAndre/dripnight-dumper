using System;
using System.Collections.Generic;
using GCommon;

namespace COW;

internal class UIHudSceneEditNumInputWindowController : UIBaseController
{
	private UIHudSceneEditNumInputWindowView m_View;

	private int m_CurrentNum;

	private int m_Min;

	private int m_Max;

	private Action<int> m_CallBack;

	private List<int> m_DefaultNumList;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetData(int num, string definedNum, int max, int min, Action<int> callBack)
	{
	}

	private void OnPriceBtn1Click()
	{
	}

	private void OnPriceBtn2Click()
	{
	}

	private void OnPriceBtn3Click()
	{
	}

	private void OnBtnItem0Click()
	{
	}

	private void OnBtnItem1Click()
	{
	}

	private void OnBtnItem2Click()
	{
	}

	private void OnBtnItem3Click()
	{
	}

	private void OnBtnItem4Click()
	{
	}

	private void OnBtnItem5Click()
	{
	}

	private void OnBtnItem6Click()
	{
	}

	private void OnBtnItem7Click()
	{
	}

	private void OnBtnItem8Click()
	{
	}

	private void OnBtnItem9Click()
	{
	}

	private void OnBtnItemDelClick()
	{
	}

	private void OnBtnItemOKClick()
	{
	}

	private void OnBtnMaskClick()
	{
	}

	private void CheckAndSetNumTxt()
	{
	}

	private bool PreConfirmCheckAndSetNumTxt()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
