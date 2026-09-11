using GCommon;
using UnityEngine;

namespace COW;

public class UIPresetAgentView : UIBaseView
{
	public UIButton Button;

	public UIEventListener EventListener;

	public GameObject BubbleContainer;

	public GameObject FastMessageContainer;

	public GameObject LeftBubble;

	public GameObject RightBubble;

	public GameObject LeftWindow;

	public GameObject RightWindow;

	public UISprite BG;

	public UISprite CDProgress;

	public GameObject CancelIcon;

	public GameObject CancelActiveIcon;

	public GameObject NormalIcon;

	public LineRenderer LineRenderer;

	public UIPanel UIPresetAgent;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
