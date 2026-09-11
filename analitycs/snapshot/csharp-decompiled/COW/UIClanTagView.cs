using GCommon;
using UnityEngine;

namespace COW;

public class UIClanTagView : UIBaseView
{
	public GameObject ActivitiesContainer;

	public UISprite ActivitiesBG;

	public UIGrid ActivitiesGrid;

	public GameObject TechnicContainer;

	public UISprite TechnicBG;

	public UIGrid TechnicGrid;

	public GameObject SocialContainer;

	public UISprite SocialBG;

	public UIGrid SocialGrid;

	public UIButton ConfirmBtn;

	public UITable Main;

	public GameObject MainTagContainer;

	public UIGrid MainTagGrid;

	public Transform Tips;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
