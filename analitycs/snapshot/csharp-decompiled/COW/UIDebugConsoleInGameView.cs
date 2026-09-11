using GCommon;
using UnityEngine;

namespace COW;

public class UIDebugConsoleInGameView : UIBaseView
{
	public UIButton Close;

	public UIButton Run;

	public UIButton HelpBtn;

	public UIInput SearchInput;

	public UIButton SearchBtn;

	public UIInput CommandInput;

	public UILabel Cmd;

	public UILabel SearchKeyword;

	public UITable2 CmdTable;

	protected override void OnInit(Transform holder)
	{
	}

	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
