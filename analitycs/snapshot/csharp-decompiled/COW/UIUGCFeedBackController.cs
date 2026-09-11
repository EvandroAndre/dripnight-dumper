using System;
using System.Collections.Generic;
using GCommon;

namespace COW;

internal class UIUGCFeedBackController : UIPopupWindowController
{
	private sealed class _003C_003Ec__DisplayClass21_0
	{
		public UGCFeedBackConfigData config;

		internal bool _003COnSecondItemDeleted_003Eb__0(UGCFeedBackConfigData e)
		{
			return false;
		}
	}

	private UIUGCFeedBackView m_View;

	private UGCFeedBackConfigData m_SelectedFirstQuestionData;

	private UGCFeedBackConfigData m_SelectedSecondSingleQuestionData;

	private List<UGCFeedBackConfigData> m_SelectedSecondMultipleQuestionData;

	private List<UGCFeedBackConfigData> m_FirstQuestionList;

	private List<UGCFeedBackConfigData> m_SecondQuestionList;

	private List<UIUGCSingleSelectItemController> m_CachedFirstItemList;

	private List<UIUGCSingleSelectItemController> m_CachedSecondSingleItemList;

	private List<UIUGCMultipleSelectItemController> m_CachedSecondMultipleItemList;

	private int m_SecondQuestionType;

	private Action m_SubmitCallBack;

	private EventLogger.UGCSurveySceneType m_FeedbackType;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetViewData(EventLogger.UGCSurveySceneType type)
	{
	}

	private void InitFirstQuestion()
	{
	}

	private void RefreshSecondQuestion()
	{
	}

	private void RefreshBtn()
	{
	}

	private void OnFirstItemSelected(object[] data)
	{
	}

	private void OnFirstItemDeleted(object[] data)
	{
	}

	private void OnSecondItemSelected(object[] data)
	{
	}

	private void OnSecondItemDeleted(object[] data)
	{
	}

	private void OnBtnSubmitClick()
	{
	}

	private void OnConfirmBtnClick()
	{
	}

	private void OnMaskClick()
	{
	}

	private void OnInputFieldChanged()
	{
	}

	public void RegisterCallBack(Action cb)
	{
	}

	private bool _003COnFirstItemSelected_003Eb__18_1(UIUGCSingleSelectItemController e)
	{
		return false;
	}

	private bool _003COnFirstItemSelected_003Eb__18_0(UGCFeedBackConfigData e)
	{
		return false;
	}

	private bool _003COnSecondItemSelected_003Eb__20_0(UIUGCSingleSelectItemController e)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
