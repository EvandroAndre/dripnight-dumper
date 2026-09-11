using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UINewBieDailyQuizWindowController : UIPopupWindowController, IUIModelDataChangeObserver
{
	private UINewBieDailyQuizWindowView m_View;

	private UIStandardItemMiniController m_ResultRewardItemController;

	private RookieAnswer m_CurrentQuizData;

	private readonly List<NewBieDailyQuizChoiceData> m_ChoiceDataList;

	private int m_CurrentAnswer;

	private bool m_IsCorrect;

	private UIModelChat m_ModelChat;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIOpen()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void InitDailyQuiz()
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private void OnCloseBtnClick()
	{
	}

	private void OnAnswerBtnClick()
	{
	}

	private void MarkDailyQuizAnswered()
	{
	}

	private void OnChoiceBtnClick(int index)
	{
	}

	private void ShowResult(bool isCorrect)
	{
	}

	private void SetResultBgCDN(UINetworkTexture networkTexture, AdType adType)
	{
	}

	private void OnOkBtnClick()
	{
	}

	private void InitRewardItems()
	{
	}

	private void BuildChoiceData()
	{
	}

	private void RefreshChoiceView()
	{
	}

	private void RefreshChoiceSelectState()
	{
	}

	private void RefreshSingleChoiceState(GameObject gameObject, bool isSelected)
	{
	}

	private void RefreshResultView(bool isCorrect)
	{
	}

	private void SetResultFallbackBgVisible(bool isVisible)
	{
	}

	private void SetChoiceButtonActive(bool isActive)
	{
	}

	private void SetRewardData(UIStandardItemMiniController rewardController, BaseItemInfo rewardItem)
	{
	}

	private void _003COnUIInit_003Eb__8_0()
	{
	}

	private void _003COnUIInit_003Eb__8_1()
	{
	}

	private void _003COnUIInit_003Eb__8_2()
	{
	}

	private void _003COnUIInit_003Eb__8_3()
	{
	}

	private void _003CSetResultBgCDN_003Eb__19_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
