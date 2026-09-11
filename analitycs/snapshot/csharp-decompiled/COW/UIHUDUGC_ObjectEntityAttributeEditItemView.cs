using GCommon;
using UnityEngine;

namespace COW;

public class UIHUDUGC_ObjectEntityAttributeEditItemView : UIBaseView
{
	public UIButton DeleteBtn;

	public Transform AttributeMenu;

	public UIInput NameInput;

	public GameObject BoolValue;

	public GameObject StandardValue;

	public UIInputEnhance StandardValueUIInput;

	public GameObject Vector2Value;

	public GameObject Vector3Value;

	public UIInputEnhance Vector2InputX;

	public UIInputEnhance Vector2InputY;

	public UIInputEnhance Vector3InputX;

	public UIInputEnhance Vector3InputY;

	public UIInputEnhance Vector3InputZ;

	public GameObject StandardValueBg;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
