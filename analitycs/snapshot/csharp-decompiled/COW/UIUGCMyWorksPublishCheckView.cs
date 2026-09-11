using GCommon;
using UnityEngine;

namespace COW;

public class UIUGCMyWorksPublishCheckView : UIBaseView
{
	public UIInput NameInput;

	public GameObject NameCheckUnaccessed;

	public UIInput DescriptionInput;

	public GameObject CheckTip;

	public GameObject CheckTipUnaccessed;

	public GameObject CheckTipInvalid;

	public UIButton BtnPublish;

	public GameObject NameCheckInvalid;

	public GameObject GenreCheckUnaccessed;

	public GameObject GenreCheckInvalid;

	public GameObject TagCheckUnaccessed;

	public GameObject TagCheckInvalid;

	public GameObject DescriptionCheckUnaccessed;

	public GameObject DescriptionCheckInvalid;

	public UILabel DescriptionInputLabel;

	public UISprite DescriptionInputBg;

	public GameObject CoverGameMapRoot;

	public UITexture CoverGameMapBg;

	public UINetworkTexture CoverCdnSlotIcon;

	public UITexture CoverGameBitMap;

	public UITexture CoverGameBitOutlineMap;

	public UIButton CoverEditButton;

	public UILabel BtnPublishTxt;

	public GameObject CoverCheckUnaccessed;

	public GameObject CoverCheckInvalid;

	public UIButton BtnLeave;

	public UISprite CoverSlotIcon;

	public GameObject CoverRoot;

	public UIButton GenreButton;

	public UILabel GenreLabel;

	public UIButton TagButton;

	public UIWidget TagContainer;

	public UITable TagTable;

	public GameObject TagTxt;

	public GameObject NameCheckingContainer;

	public UISprite CoverEditButtonNewIcon;

	public UISprite CoverEditButtonEditIcon;

	public UISprite CheckUnaccessedIcon;

	public UISprite CheckInvalidIcon;

	public UIButton BtnReset;

	public UIButton BtnScenePreview;

	public UIToggle BtnScenePreviewToggle;

	public UIButton BtnScenePreviewHelp;

	public GameObject Mask;

	public UILabel TitleLabel;

	public GameObject ControllerRoot;

	public UILabel CheckTipInvalidLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
