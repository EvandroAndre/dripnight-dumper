using GCommon;
using UnityEngine;

namespace COW;

public class UIModeSettingAttributeItemView : UIBaseView
{
	public Transform attribute;

	public UIInput NameInput;

	public GameObject BoolValue;

	public UIButton DeleteBtn;

	public UISprite bg;

	public GameObject Vector2Value;

	public GameObject Vector3Value;

	public UIInputEnhance Vector2InputX;

	public GameObject StandardValueBg;

	public UIInputEnhance StandardValueUIInput;

	public GameObject StandardValue;

	public UIInputEnhance Vector2InputY;

	public UIInputEnhance Vector3InputX;

	public UIInputEnhance Vector3InputY;

	public UIInputEnhance Vector3InputZ;

	public UIButton AutoSaveToggle;

	public Transform select;

	public Transform unselect;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
