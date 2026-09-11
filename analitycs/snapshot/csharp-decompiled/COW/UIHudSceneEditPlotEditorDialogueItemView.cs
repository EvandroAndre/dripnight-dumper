using GCommon;
using UnityEngine;

namespace COW;

public class UIHudSceneEditPlotEditorDialogueItemView : UIBaseView
{
	public UILabel SpeakerLabel;

	public UISprite ContentBound;

	public UIButton Button;

	public BoxCollider ButtonCollider;

	public UILabel ContentLabel;

	public UIGrid OptionsGrid;

	public UISprite Selected;

	public UILabel IndexLabel;

	public GameObject IconFx;

	public UISprite SpeakerIcon;

	public UISprite SpeakerIconActor;

	public UIButton BtnDelete;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
