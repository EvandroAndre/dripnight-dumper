using GCommon;
using UnityEngine;

namespace COW;

public class UIHudSceneEditPlotEditorDialogueInspectorView : UIBaseView
{
	public UITable FieldsTable;

	public GameObject FieldIndex;

	public GameObject FieldIndexDropdownContainer;

	public UIButton BtnNewDialogue;

	public GameObject FieldSpeaker;

	public GameObject FieldSpeakerDropdownContainer;

	public GameObject FieldSpeakContent;

	public UILabel FieldSpeakContentLimitLabel;

	public UIInput FieldSpeakContentInput;

	public GameObject GroupMoreSettings;

	public UIButton GroupMoreSettingsArrowBtn;

	public UIButton FieldFrameStyleSelectBtn;

	public GameObject FieldFrameStyle;

	public GameObject FieldContentEffect;

	public GameObject FieldContentEffectDropdownContainer;

	public GameObject FieldPlaySound;

	public GameObject FieldPlaySoundDropdownContainer;

	public GameObject FieldSoundVolume;

	public UISlider FieldSoundVolumeSlider;

	public UILabel FieldSoundVolumeValueLabel;

	public GameObject FieldSelectSpeaker;

	public GameObject FieldSpeakerIcon;

	public UIButton FieldSpeakerIconSelectBtn;

	public GameObject FieldSelectSpeakerDropdownContainer;

	public GameObject GroupOptions;

	public UILabel GroupOptionsLimitLabel;

	public UIButton GroupOptionsBtnExpand;

	public UIButton GroupOptionsBtnAdd;

	public UIGrid GroupOptionsOptionGrid;

	public UISprite FieldSpeakerIconIcon;

	public UISprite FieldFrameStyleSprite;

	public GameObject FieldSelectSound;

	public UIButton FieldSelectSoundBtnSelect;

	public UILabel FieldSelectSoundLabel;

	public GameObject GroupMoreSettingsArrowBtnArrow;

	public GameObject GroupOptionsBtnExpandArrow;

	public UIScrollView FieldsScrollView;

	public UIButton FieldSelectSoundBtnPlay;

	public Animation FieldSelectSoundPlayingAnimation;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
