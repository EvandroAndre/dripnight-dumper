using GCommon;
using UnityEngine;

namespace COW;

public class UIHudSceneEditLocalFilePanelView : UIBaseView
{
	public UIButton BtnClose;

	public UILabel Title;

	public UILabel FileNum;

	public GameObject EmptyLabel;

	public UILabel FileSize;

	public UIScrollView DetailsScrollView;

	public GameObject DetailsEmptyLabel;

	public UILabel DetailsFileTime;

	public UITexture PreviewTexture;

	public UIUGCPreviewForTexture PreviewNetworkTexture;

	public GameObject PreviewImg;

	public GameObject TagContainer;

	public UITable TagContainerTable;

	public GameObject PreviewEmptyLabel;

	public UIButton BtnRename;

	public UIButton BtnDelete;

	public UIEasyList DetailsTable;

	public UIGrid TypeTable;

	public GameObject PreviewMode;

	public GameObject DetailsMode;

	public UIButton BtnDetailsMode;

	public UIInput SearchInput;

	public UIScrollView PreviewScrollView;

	public UIEasyList PreviewTable;

	public UIGrid SortGrid;

	public UIButton BtnSort;

	public UIButton BtnSortName;

	public GameObject SortNameHighLight;

	public UIButton BtnSortDate;

	public GameObject SortDateHighLight;

	public UIButton BtnSortType;

	public GameObject SortTypeHighLight;

	public UIButton BtnSortSize;

	public GameObject SortSizeHighLight;

	public UISprite TipsBg;

	public GameObject SortPanel;

	public UILabel SortNameLabel;

	public UILabel SortDateLabel;

	public UILabel SortTypeLabel;

	public UILabel SortSizeLabel;

	public UILabel SizeTag;

	public UILabel PixelTag;

	public UILabel DateTag;

	public UILabel TypeTag;

	public UILabel DurationTag;

	public UIInput DetailsFileName;

	public UISprite PreviewSprite;

	public UIButton BtnGoToStore;

	public UIButton BtnPreviewMode;

	public UISprite CornerMark;

	public UIButton BtnClear;

	public UIWidget Download;

	public UILabel GoToStore;

	public GameObject FilterPanel;

	public UIButton BtnAll;

	public UIButton BtnMapRef;

	public UISprite FilterTipsBg;

	public UIGrid FilterGrid;

	public UIButton BtnFilter;

	public UIButton HelpBtn;

	public UILabel FilterAllLabel;

	public GameObject FilterAllHighLight;

	public UILabel FilterMapRefLabel;

	public GameObject FilterMapRefHighLight;

	public GameObject iconAll;

	public GameObject iconMapRef;

	public UILabel LabelUse;

	public UIButton BtnUpload;

	public UIButton BtnUse;

	public UISprite SpriteUse;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
