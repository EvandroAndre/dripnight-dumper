using GCommon;
using UnityEngine;

namespace COW;

public class UIHUDUGC_SceneObjectEntityAttributeEditItemView : UIBaseView
{
	public UILabel name;

	public GameObject StandardValue;

	public UIInputEnhance StandardValueUIInput;

	public GameObject StandardValueBg;

	public GameObject BoolValue;

	public GameObject Vector2Value;

	public GameObject Vector3Value;

	public UIInputEnhance Vector2InputX;

	public UIInputEnhance Vector2InputY;

	public UIInputEnhance Vector3InputX;

	public UIInputEnhance Vector3InputY;

	public UIInputEnhance Vector3InputZ;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
