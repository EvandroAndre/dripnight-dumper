using GCommon;
using UnityEngine;

namespace COW;

public class UIHudSceneEditTemplateUploadView : UIBaseView
{
	public UITexture TextureCover;

	public UIPanel PopMenuContainer;

	public UIInput InputDesc;

	public UIToggle ToggleEditable;

	public UIToggle TogglePublic;

	public UIButton BtnUpload;

	public UIButton BtnTipsPublic;

	public UIButton BtnTipsEditState;

	public UIInput InputName;

	public UIToggle ToggleUnownable;

	public UIToggle ToggleUneditable;

	public GameObject EditState;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
