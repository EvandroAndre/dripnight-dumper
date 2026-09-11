using System;
using System.Collections.Generic;
using GCommon;
using UnityEngine;
using message;

namespace COW;

public class UIHudSceneEditPlotEditorDialogueInspectorController : UIBaseController, IUIModelDataChangeObserver
{
	private enum ESoundState
	{
		Playing,
		Stop
	}

	private enum EMoreSettingsState
	{
		Open,
		Close
	}

	private enum EOptionsState
	{
		Open,
		Close
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static EventDelegate.Callback _003C_003E9__23_1;

		internal void _003COnUIInitFieldSelectSpeaker_003Eb__23_1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass17_0
	{
		public int index;

		public UIHudSceneEditPlotEditorDialogueInspectorController _003C_003E4__this;

		internal void _003COnUIInitFieldIndex_003Eb__1()
		{
		}
	}

	private sealed class _003C_003Ec__DisplayClass23_0
	{
		public HMJODCEJBFF dialogue;

		public CHEOJCABHJJ actor;

		public UIHudSceneEditPlotEditorDialogueInspectorController _003C_003E4__this;

		internal void _003COnUIInitFieldSelectSpeaker_003Eb__2()
		{
		}
	}

	private UIHudSceneEditPlotEditorDialogueInspectorView m_View;

	private UIModelUGCPlotEdit m_Model;

	private UIHudSceneEditPlotEditorDropdownController m_IndexDropdown;

	private UIHudSceneEditPlotEditorDropdownController m_SpeakerDropdown;

	private UIHudSceneEditPlotEditorDropdownController m_SelectSpeakerDropdown;

	private UIHudSceneEditPlotEditorDropdownController m_ContentEffectDropdown;

	private UIHudSceneEditPlotEditorDropdownController m_PlaySoundDropdown;

	private ESoundState m_SoundState;

	private GameObject m_SoundGameObject;

	private float m_SoundLength;

	private uint m_SoundDelayCallId;

	private EMoreSettingsState m_MoreSettingsState;

	private EOptionsState m_OptionsState;

	private List<UIHudSceneEditPlotEditorInspectorOptionItemController> m_OptionControllers;

	private MPGMIACDBGN m_CurSelectPlot
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private int m_CurSelectPlotIndex => 0;

	private HMJODCEJBFF m_CurSelectDialogue
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private int m_CurSelectDialogueIndex => 0;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void RefreshViewData()
	{
	}

	private void OnBtnNewDialogueClick()
	{
	}

	private void OnUIInitFieldIndex()
	{
	}

	private void OnRefreshViewDataFieldIndex()
	{
	}

	private void OnUIInitFieldSpeaker()
	{
	}

	private void OnRefreshViewDataFieldSpeaker()
	{
	}

	private void OnUIInitFieldSelectSpeaker()
	{
	}

	private void OnRefreshViewDataFieldSelectSpeaker()
	{
	}

	private void OnUIInitFieldSpeakerIcon()
	{
	}

	private void OnRefreshViewDataFieldSpeakerIcon()
	{
	}

	private void OnUIInitFieldSpeakContent()
	{
	}

	private void OnRefreshViewDataFieldSpeakContent()
	{
	}

	private void OnUIInitFieldFrameStyle()
	{
	}

	private void OnRefreshViewDataFieldFrameStyle()
	{
	}

	private void OnUIInitFieldContentEffect()
	{
	}

	private void OnRefreshViewDataFieldContentEffect()
	{
	}

	private void OnUIInitFieldPlaySound()
	{
	}

	private void OnRefreshViewDataFieldPlaySound()
	{
	}

	private void OnUIInitFieldSelectSound()
	{
	}

	private void OnRefreshViewDataFieldSelectSound()
	{
	}

	private string GetSoundShowLabel(string soundId)
	{
		return null;
	}

	private void OnFieldSelectSoundBtnPlayClick()
	{
	}

	private void PlayDialogueSound()
	{
	}

	private void StopDialogueSound()
	{
	}

	private void OnUIInitFieldSoundVolume()
	{
	}

	private void OnRefreshViewDataFieldSoundVolume()
	{
	}

	private void OnUIInitGroupMoreSettings()
	{
	}

	private void OnRefreshViewDataGroupMoreSettings()
	{
	}

	private void MoreSettingsTurnToState(EMoreSettingsState state)
	{
	}

	private void OnUIInitGroupOptions()
	{
	}

	private void OnRefreshViewDataGroupOptions()
	{
	}

	private void OnBtnAddOptionClick()
	{
	}

	private void OptionsTurnToState(EOptionsState state)
	{
	}

	public uint GetInterestedPropID(UIBaseModel model)
	{
		return 0u;
	}

	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	private void _003COnUIInitFieldIndex_003Eb__17_0()
	{
	}

	private void _003COnUIInitFieldSpeaker_003Eb__20_0()
	{
	}

	private void _003COnUIInitFieldSpeaker_003Eb__20_1()
	{
	}

	private void _003COnUIInitFieldSpeaker_003Eb__20_2()
	{
	}

	private void _003COnUIInitFieldSelectSpeaker_003Eb__23_0()
	{
	}

	private void _003COnUIInitFieldSpeakerIcon_003Eb__25_0()
	{
	}

	private void _003COnUIInitFieldSpeakerIcon_003Eb__25_1(string strValue, int intValue)
	{
	}

	private void _003COnRefreshViewDataFieldSpeakerIcon_003Eb__26_0(UIAtlas atlas, string spriteName)
	{
	}

	private void _003COnUIInitFieldSpeakContent_003Eb__27_1()
	{
	}

	private void _003COnUIInitFieldSpeakContent_003Eb__27_0()
	{
	}

	private void _003COnUIInitFieldFrameStyle_003Eb__29_0()
	{
	}

	private void _003COnUIInitFieldFrameStyle_003Eb__29_1(string strValue, int intValue)
	{
	}

	private void _003COnRefreshViewDataFieldFrameStyle_003Eb__30_0(UIAtlas atlas, string spriteName)
	{
	}

	private void _003COnUIInitFieldContentEffect_003Eb__32_0()
	{
	}

	private void _003COnUIInitFieldContentEffect_003Eb__32_1()
	{
	}

	private void _003COnUIInitFieldPlaySound_003Eb__35_0()
	{
	}

	private void _003COnUIInitFieldPlaySound_003Eb__35_1()
	{
	}

	private void _003COnUIInitFieldSelectSound_003Eb__42_0()
	{
	}

	private void _003COnUIInitFieldSelectSound_003Eb__42_1(string resourceName, int itemId)
	{
	}

	private void _003COnUIInitFieldSoundVolume_003Eb__48_0()
	{
	}

	private void _003COnUIInitGroupMoreSettings_003Eb__52_0()
	{
	}

	private void _003COnUIInitGroupOptions_003Eb__58_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
