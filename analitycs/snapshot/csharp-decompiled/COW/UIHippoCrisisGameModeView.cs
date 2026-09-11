using GCommon;
using UnityEngine;

namespace COW;

public class UIHippoCrisisGameModeView : UIBaseView
{
	public UIButton BtnModelPick;

	public UILabel ModeName;

	public GameObject openTime;

	public UILabel openPeriod;

	public GameObject LevelContainer;

	public UILabel seasonName;

	public Transform HCRankTrans;

	public UIButton BtnRankIcon;

	public GameObject NoticeBg;

	public UILabel LabelNotice;

	public GameObject GoDownload;

	public Transform TrRootDownload;

	public GameObject GoLevelLimit;

	public UILabel LabelLevelLimit;

	public UILabel MapMode;

	public GameObject UIHippoCrisisGameMode;

	public GameObject NoticeDuoVersion;

	public GameObject VersionUpdateOK;

	public GameObject VersionUpdateNotOK;

	public UIButton RuleBtn;

	public UISprite HC_BG;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
