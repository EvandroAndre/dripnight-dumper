using UnityEngine;
using proto;

namespace COW;

public class UIAvatarAwakenStoryItemController : MonoBehaviour
{
	private AvatarAwakenComicData m_Data;

	public UIButton PlayButton;

	public UILabel Desc;

	private uint m_StoryId;

	private UIModelAvatarProfile m_Model;

	public UINetworkTextureExt CDNIMG;

	public GameObject LockGroup;

	public GameObject LockAll;

	public GameObject LockComponent;

	public GameObject LockPos1;

	public GameObject LockPos2;

	public GameObject LockPos3;

	public GameObject LockIcon1;

	public GameObject LockIcon2;

	public GameObject LockIcon3;

	public UILabel LockProgress;

	public UISprite AwakenItemIcon;

	public UIButton LockBtn1;

	public UIButton LockBtn2;

	public UIButton LockBtn3;

	public Animator effectAnim;

	public UISprite LockSprite;

	public UIPanel EffectPanel;

	private StoryShowState m_CurrentState;

	private UICommonGuideController m_GuideCtrl;

	private void Awake()
	{
	}

	public StoryShowState GetCurShowState()
	{
		return StoryShowState.Lock;
	}

	public bool CanCurrentStateUnlock()
	{
		return false;
	}

	public void SetGuideShow(bool show)
	{
	}

	public void RefreshData()
	{
	}

	private StoryShowState GetCurrentShowState(AwakenComic comicInfoBefore, AwakenComic comicInfoCur)
	{
		return StoryShowState.Lock;
	}

	public void SetCDNInfo(AvatarAwakenComicData comicData)
	{
	}

	private void OnPlayButtonClick()
	{
	}

	private void OnUnlockButtonClick_1()
	{
	}

	private void OnUnlockButtonClick_2()
	{
	}

	private void OnUnlockButtonClick_3()
	{
	}

	private void OnUnlockButtonClick()
	{
	}

	private void UpdateAwakenItem()
	{
	}

	private void UpdateButtonState(StoryShowState state)
	{
	}

	private void SetShowState(StoryShowState state)
	{
	}

	private void SetCDN(UINetworkTextureExt cdn, string url)
	{
	}
}
