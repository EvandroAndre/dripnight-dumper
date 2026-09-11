using GCommon;
using UnityEngine;

namespace COW;

public class UIBigEventProgressRewardItemView : MonoBehaviour
{
	public GameObject NormalBox;

	public GameObject ActiveBox;

	public GameObject OpenBox;

	public UISprite NormalSprite;

	public UISprite ActiveSprite;

	public UISprite OpenSprite;

	public UINetworkTexture NormalCdn;

	public UINetworkTexture ActiveCdn;

	public UINetworkTexture OpenCdn;

	public Transform NormalVFX;

	public Transform ActiveVFX;

	public Transform OpenVFX;

	public Transform GrowVFX;

	public UIButton BoxBtn;

	public UILabel darkProgressLabel;

	public UILabel lightProgressLabel;
}
