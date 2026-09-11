using GCommon;
using UnityEngine;

namespace COW;

public class UIHudTestRecipeView : UIBaseView
{
	public UIButton ToggleRecipeDebug;

	public GameObject Test;

	public GameObject wardrobeBtnTemplate;

	public UIGrid wardrobeTypeGrid;

	public GameObject recipeBtnTemplate;

	public UIEasyList recipeEasyList;

	public GameObject avatarBtnTemplate;

	public UIGrid avatarGrid;

	public UIGrid UtilGrid;

	public UIButton ClearAllRecipeBtn;

	public UICheckboxButton UseDefaultQualityCheckBox;

	public UICheckboxButton UseHighQualityCheckBox;

	public UIButton BroadcastToOthers;

	public UIInput searchInput;

	public UIEasyList searchEasyList;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
