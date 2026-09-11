using System;
using System.Collections;
using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIUGCMyWorksPublishCheckController : UIPopupWindowController, IUIModelDataChangeObserver
{
	private sealed class _003C_003Ec__DisplayClass132_0
	{
		public UIUGCMyWorksPublishCheckController _003C_003E4__this;

		public string cdnUrl;

		internal void _003CStartTutorialCoverDownload_003Eb__0(byte[] downloadedBytes)
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass26_0
	{
		public UIInput input;

		public Func<string, bool, string> originalDisplayModifier;

		internal string _003CInitInputPlaceholder_003Eb__0(string text, bool fixArabic)
		{
			return null;
		}
	}

	private sealed class _003COnLostFocusCoroutine_003Ed__45 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public UIUGCMyWorksPublishCheckController _003C_003E4__this;

		object IEnumerator<object>.Current => null;

		object IEnumerator.Current => null;

		public _003COnLostFocusCoroutine_003Ed__45(int _003C_003E1__state)
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

	private UIUGCMyWorksPublishCheckView m_View;

	private SceneEditSlotInfo m_CurSlotInfo;

	private UIModelSceneEdit m_ModelSceneEdit;

	private UIModelCheckNameValid m_ModelCheckNameValid;

	private UIWaitingForRequestCircleController m_LoadingUI;

	private bool m_Published;

	private int m_CheckUnaccessedIconWidth;

	private int m_CheckInvalidIconWidth;

	private Action<uint, uint, bool> m_OnConfirmCallback;

	private bool m_IsTutorialMode;

	private bool m_TutorialDefaultsApplied;

	private const string NameInputPlaceholderLocKey = "T_54_JH_WS_ENTERMAPNAME";

	private const string DescriptionInputPlaceholderLocKey = "T_54_JH_WS_ENTERMAPDESC";

	private const uint InputUneditedTextColor = 1886417151u;

	private int m_NameLabelWidth;

	private Vector3 m_NameLabelPosition;

	private float m_NameLostFocusDelay;

	private string m_NamePrevValue;

	private Coroutine m_NameLostFocusCoroutine;

	private bool m_NameValidValue;

	private bool m_NameChecking;

	private bool m_NameFocused;

	private bool m_NameEditedValue;

	private int m_GenreLabelWidth;

	private Vector3 m_GenreLabelPosition;

	private bool m_GenreEdited;

	private Vector3 m_TagTablePosition;

	private Vector3 m_TagTxtPosition;

	private List<UIWorkshopTagsItemController> m_TagItemControllers;

	private const float OverflowTagWidth = 40f;

	private bool m_TagEdited;

	private int m_DescriptionLabelWidth;

	private Vector3 m_DescriptionLabelPosition;

	private string m_DescriptionPrevValue;

	private bool m_DescriptionEditedValue;

	private bool m_DescriptionDirty;

	private bool m_InGameDirty;

	private bool m_DescriptionFocused;

	private bool m_CoverDirty;

	private byte[] m_ServerCoverBytes;

	private UIModelSceneEdit_CDNDownLoad m_CoverDownload;

	private UIModelSceneEdit_CDNDownLoad m_TutorialCoverDownload;

	private bool m_TutorialCoverPending;

	private bool m_OriginalEnablePreview;

	private bool m_PreviewEdited;

	private static Action<UIUGCMyWorksPublishCheckController> m_OnTutorialReady;

	private static UIUGCMyWorksPublishCheckController s_ActiveInstance;

	private bool m_NameValid
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private bool m_NameEdited
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	private bool m_DescriptionEdited
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static UIUGCMyWorksPublishCheckController ActiveInstance => null;

	public static event Action<UIUGCMyWorksPublishCheckController> OnTutorialReady
	{
		add
		{
		}
		remove
		{
		}
	}

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

	public override bool ClosedByEsc()
	{
		return false;
	}

	public void SetViewData(SceneEditSlotInfo slotInfo)
	{
	}

	private void ApplyModification()
	{
	}

	private void OnResetModification()
	{
	}

	public void SetConfirmCallback(Action<uint, uint, bool> callback)
	{
	}

	public virtual void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	public virtual uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OpenLoadingUI()
	{
	}

	private void CloseLoadingUI()
	{
	}

	private void InitInputPlaceholder(UIInput input, string locKey)
	{
	}

	private void ApplyInputTextColor(UIInput input, bool hasBeenEdited)
	{
	}

	private void OnUIOpenName()
	{
	}

	private bool IsNameLocalValid()
	{
		return false;
	}

	private IEnumerator OnLostFocusCoroutine()
	{
		return null;
	}

	private void OnSetViewDataName()
	{
	}

	private void OnConfirmName()
	{
	}

	private void OnResetName()
	{
	}

	private void RefreshNameInputTextColor()
	{
	}

	private void RefreshNameCheck()
	{
	}

	private void OnNameDirtyWordCheck(bool access)
	{
	}

	private void OnUIOpenGenre()
	{
	}

	private void OnSetViewDataGenre()
	{
	}

	private void RefreshGenre()
	{
	}

	private void OnConfirmGenre()
	{
	}

	private void OnResetGenre()
	{
	}

	private void RefreshGenreCheck()
	{
	}

	private void OnUIOpenTag()
	{
	}

	private void OnSetViewDataTag()
	{
	}

	private void OnConfirmTag()
	{
	}

	private void OnResetTag()
	{
	}

	private void RefreshTagCheck()
	{
	}

	private void RefreshTagTable()
	{
	}

	private void OnUIOpenDescription()
	{
	}

	private void OnSetViewDataDescription()
	{
	}

	private void OnConfirmDescription()
	{
	}

	private void OnResetDescription()
	{
	}

	private void RefreshDescriptionInputTextColor()
	{
	}

	private void RefreshDescriptionCheck()
	{
	}

	private void RefreshCover()
	{
	}

	private void OnUIOpenCover()
	{
	}

	private void OnConfirmCover()
	{
	}

	private void OnResetCover()
	{
	}

	private void OnSetViewDataCover()
	{
	}

	private void RefreshCoverCheck()
	{
	}

	private void OnUIOpenPreview()
	{
	}

	private void OnSetViewDataPreview()
	{
	}

	private void OnConfirmPreview()
	{
	}

	private void OnResetPreview()
	{
	}

	private void OnBtnScenePreviewToggle()
	{
	}

	private void OnBtnScenePreviewHelpClick()
	{
	}

	private void RefreshPreviewState()
	{
	}

	private void OnUIOpenBottom()
	{
	}

	private void OnSetViewDataBottom()
	{
	}

	private void OnEditItemChanged()
	{
	}

	private void RefreshBtnPublish()
	{
	}

	private bool AllEditValid()
	{
		return false;
	}

	private bool AllEditEdited()
	{
		return false;
	}

	private bool SomethingEdited()
	{
		return false;
	}

	private static bool ArrayEquals(uint[] a, uint[] b)
	{
		return false;
	}

	private void OnBtnReset()
	{
	}

	private void OnBtnCancel()
	{
	}

	private void OnBtnPublish()
	{
	}

	private void NotifyTutorialReady()
	{
	}

	private void TryAutoApplyTutorialDefaults()
	{
	}

	protected override void OnUIClose()
	{
	}

	public UIWidget GetTutorialPublishButtonWidget()
	{
		return null;
	}

	public void SetTutorialMapName(string mapName)
	{
	}

	public void ApplyTutorialDefaults(string mapName, string mapDescription, string mapGenreId, string mapTagIdsCsv, string mapCoverResId, string mapCoverCdnUrl)
	{
	}

	private string ApplyTutorialCover(string mapCoverResId, string mapCoverCdnUrl)
	{
		return null;
	}

	private void StartTutorialCoverDownload(string cdnUrl)
	{
	}

	private void OnTutorialCoverDownloaded(byte[] bytes, string cdnUrl)
	{
	}

	private void CommitTutorialCoverBytes(byte[] bytes, string sourceTag)
	{
	}

	private static string ResolveTutorialCoverDownloadUrl(string url)
	{
		return null;
	}

	private void CancelTutorialCoverDownload()
	{
	}

	private static List<uint> ParseTutorialTagIds(string csv)
	{
		return null;
	}

	private void _003COnUIOpenName_003Eb__43_0()
	{
	}

	private void _003COnUIOpenName_003Eb__43_1()
	{
	}

	private void _003COnUIOpenName_003Eb__43_2()
	{
	}

	private void _003COnUIOpenGenre_003Eb__55_0()
	{
	}

	private void _003COnUIOpenGenre_003Eb__55_1(WorkshopGenreID data)
	{
	}

	private void _003COnUIOpenTag_003Eb__66_0()
	{
	}

	private void _003COnUIOpenTag_003Eb__66_1(List<uint> data)
	{
	}

	private void _003COnUIOpenDescription_003Eb__82_0()
	{
	}

	private void _003COnUIOpenDescription_003Eb__82_1()
	{
	}

	private void _003COnUIOpenDescription_003Eb__82_2()
	{
	}

	private void _003COnUIOpenCover_003Eb__94_0()
	{
	}

	private void _003COnUIOpenCover_003Eb__94_1()
	{
	}

	private void _003COnUIOpenCover_003Eb__94_2()
	{
	}

	private void _003COnSetViewDataCover_003Eb__97_0(byte[] downloadedBytes)
	{
	}

	private void _003COnBtnReset_003Eb__116_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	public bool _003C_003EiFixBaseProxy_ClosedByEsc()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
