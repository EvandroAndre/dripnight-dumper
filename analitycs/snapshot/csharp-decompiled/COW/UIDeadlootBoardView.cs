using COW.Graphics;
using GCommon;
using UnityEngine;

namespace COW;

public class UIDeadlootBoardView : UIBaseView
{
	public MultiBillboard MultiBillboard;

	public GameObject Main;

	public Transform HeadContainer;

	public UILabel MessageLabel;

	public UILabel NickNameLabel;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
