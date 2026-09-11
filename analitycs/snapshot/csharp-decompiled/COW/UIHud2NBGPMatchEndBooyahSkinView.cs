using System.Collections.Generic;
using UnityEngine;

namespace COW;

public class UIHud2NBGPMatchEndBooyahSkinView : MonoBehaviour
{
	public GameObject Name_Feedback;

	public UILabel Label;

	public VFXCreateHelper UIFXFeedback;

	public GameObject BottomBG_TeamFeedback;

	public List<GameObject> SpecialHideNode;

	public Animation Anim;

	public string NormalAnimName;

	public string FeedbackAnimName;

	public TweenPosition FeedbackTweenPosition;

	public TweenScale FeedbackTweenScale;

	public void HideSpecialHideNode(bool hide)
	{
	}

	private void Start()
	{
	}
}
