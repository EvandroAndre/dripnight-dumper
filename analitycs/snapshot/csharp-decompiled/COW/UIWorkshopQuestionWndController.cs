using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIWorkshopQuestionWndController : UIPopupWindowController
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<string, bool> _003C_003E9__22_2;

		public static Func<UGCFeedbackOptionConfig, uint> _003C_003E9__23_1;

		internal bool _003COnClickConfirm_003Eb__22_2(string url)
		{
			return false;
		}

		internal uint _003CGetSortedOptionsByType_003Eb__23_1(UGCFeedbackOptionConfig c)
		{
			return 0u;
		}
	}

	private sealed class _003C_003Ec__DisplayClass22_0
	{
		public UIWorkshopQuestionWndController _003C_003E4__this;

		public UIModelSceneEdit model;

		public string desc;

		internal void _003COnClickConfirm_003Eb__0(bool ok, bool hasDirty, string err)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass22_1
	{
		public List<string> screenshotUrls;

		public _003C_003Ec__DisplayClass22_0 CS_0024_003C_003E8__locals1;

		internal void _003COnClickConfirm_003Eb__1(bool success, string submitErr)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass23_0
	{
		public string optionType;

		internal bool _003CGetSortedOptionsByType_003Eb__0(UGCFeedbackOptionConfig c)
		{
			return false;
		}
	}

	private sealed class _003CScrollReportDescToBottomNextFrame_003Ed__34 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIWorkshopQuestionWndController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003CScrollReportDescToBottomNextFrame_003Ed__34(int _003C_003E1__state)
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

	private const string OPTION_TYPE_FEEDBACK = "feedback_type";

	private const string OPTION_TYPE_MODULE = "module";

	private const int DROPDOWN_CELL_WIDTH = 260;

	private const string LOC_KEY_MODULE_LABEL = "T_54_GT_UGC_FEEDBACK_MODULE_LABEL";

	private UIWorkshopQuestionWndView m_View;

	private UIPopMenuSmallControler m_ReportTypeMenu;

	private UIPopMenuSmallControler m_ModuleTypeMenu;

	private readonly List<UGCFeedbackOptionConfig> m_FeedbackOptions;

	private readonly List<UIWorkshopQuestionWndUploadItemController> m_UploadItems;

	private uint m_SelectedReportTypeID;

	private uint m_SelectedModuleTypeID;

	private EventLogger.UGCSurveySceneType m_SurveySceneType;

	private string m_ReportLog;

	private bool m_IsSubmitting;

	private float m_CooldownEndTime;

	private Coroutine m_ReportDescScrollRoutine;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	public override string CustomTitle()
	{
		return null;
	}

	public void SetReportLog(string log)
	{
	}

	public void SetSurveySceneType(EventLogger.UGCSurveySceneType sceneType)
	{
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	private void OnClickConfirm()
	{
	}

	private IEnumerable<UGCFeedbackOptionConfig> GetSortedOptionsByType(string optionType)
	{
		return null;
	}

	private bool CurrentFeedbackShowsModule()
	{
		return false;
	}

	private void RefreshModuleSectionForCurrentFeedback()
	{
	}

	private void GenerateReportTypeData()
	{
	}

	private void OnReportTypeSelected(object obj)
	{
	}

	private void GenerateModuleTypeData()
	{
	}

	private void OnModuleTypeSelected(object obj)
	{
	}

	private void AppendUploadSlot()
	{
	}

	private void OnUploadItemRequestDelete(UIWorkshopQuestionWndUploadItemController item)
	{
	}

	private void OnUploadItemStateChanged(UIWorkshopQuestionWndUploadItemController item)
	{
	}

	private void OnInputChanged()
	{
	}

	private IEnumerator ScrollReportDescToBottomNextFrame()
	{
		return null;
	}

	private void RefreshConfirmButtonState()
	{
	}

	private bool _003CCurrentFeedbackShowsModule_003Eb__24_0(UGCFeedbackOptionConfig c)
	{
		return false;
	}

	private bool _003CRefreshModuleSectionForCurrentFeedback_003Eb__25_0(UGCFeedbackOptionConfig c)
	{
		return false;
	}

	public string _003C_003EiFixBaseProxy_CustomTitle()
	{
		return null;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
