using GCommon;
using UnityEngine;

namespace COW;

public class UIHUDIceWallModuleTipPopOverView : UIBaseView
{
	public UILabel BuildDescText;

	public GameObject ContentRoot;

	public UITable BgTable;

	public UISprite BG;

	public GameObject GlooModule;

	public UISprite Icon;

	public UILabel Name;

	public GameObject GlooMaker;

	public UISprite IconMaker;

	public UILabel DescMaker;

	public UILabel NameMaker;

	public Transform UIHUDIceWallModuleTipPopOver;

	public UILabel formText;

	public UILabel CurExp;

	public UISprite ExpProcess;

	public GameObject IceMakerExp;

	public UIWidget emptyWidget;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
