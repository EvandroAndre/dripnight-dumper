using UnityEngine;

namespace COW;

public class UISceneEditSlotInfoView : MonoBehaviour
{
	public UILabel SlotNameTxt;

	public UILabel AuthorTxt;

	public UILabel UpdateTimeTxt;

	public UILabel ResourceTxt;

	public UILabel CostTxt;

	public UISprite ProgressFront;

	public UIProgressBar CostProgressBar;

	public UILabel LikeTxt;

	public UILabel SubscribeTxt;

	public UIInput DescInput;

	public UILabel GameModeTxt;

	public UILabel DescText;

	public void RefreshUI(SceneEditSlotInfo info)
	{
	}
}
