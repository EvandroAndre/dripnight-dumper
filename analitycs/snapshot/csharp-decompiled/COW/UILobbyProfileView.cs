using GCommon;
using UnityEngine;

namespace COW;

public class UILobbyProfileView : UIBaseView
{
	public UIWidget Root;

	public Transform profileContainer;

	public UIProgressBar HPBar;

	public UISprite HPBarFG;

	public UILabel accountId;

	public UILabel ExpLabel;

	public UIButton BtnRename;

	public Transform TipsContainer;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
