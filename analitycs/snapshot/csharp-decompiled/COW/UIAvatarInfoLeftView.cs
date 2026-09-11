using GCommon;
using UnityEngine;

namespace COW;

public class UIAvatarInfoLeftView : UIBaseView
{
	public UIButton FolderBtn;

	public UISprite FolderIconExtend;

	public UISprite FolderIconShrink;

	public UIScrollView AvatarListExtendScrollView;

	public UIEasyList ExtendGrid;

	public UIScrollView AvatarListShrinkScrollView;

	public UIEasyList ShrinkGrid;

	public GameObject AvatarFilterGird;

	public GameObject RightFilter;

	public GameObject LeftFilter;

	public UIButton KeyartBtn;

	public GameObject UIAvatarInfoLeft;

	public GameObject BigBg;

	public TweenAlpha TweenPosFolder;

	public Transform DownloadLeftTopPos;

	public Transform DownloadCentrePos;

	public UIButton SearchEntrence;

	public UIButton ClearBtn;

	public UIButton SearchBtn;

	public UIButton SearchQuitBtn;

	public UIInput SearchInputShrink;

	public UIInput SearchInputExpand;

	public GameObject SearchContainer;

	public GameObject SearchNoResultContainerExtend;

	public GameObject SearchNoResultContainerShrink;

	public GameObject PrimeShareClothesLock;

	public UIButton ButtonCancel;

	public UILabel LabelSharerDescription;

	public UIWidget PresetAgentHighLight;

	public GameObject BG;

	public UIWidget PresetAutoScrollBottom;

	public UIWidget PresetAutoScrollTop;

	public UIWidget PresetAgentHighLightShrink;

	public GameObject PresetAgentHighLightShrinkGo;

	public GameObject PresetAgentHighLightGo;

	public Transform NewCharacterGuideTransform;

	public UIPanel NewCharacterGuidePanel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
