using GCommon;
using UnityEngine;

namespace COW;

public class UIUGCExitEditorView : UIBaseView
{
	public GameObject HasUnsaved;

	public GameObject NoUnsaved;

	public UIButton BtnSaveAndPublish;

	public UIButton BtnSaveAndExit;

	public UIButton BtnExitWithoutSaving;

	public UIButton BtnUpdate;

	public UIButton BtnExit;

	public UILabel BtnUpdateLabel;

	public UIButton BgButton;

	public UISprite BgBtnSaveAndPublish;

	public UISprite BgBtnUpdate;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
