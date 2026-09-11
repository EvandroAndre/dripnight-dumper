using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class TaskGuessCode : BaseTask
{
	public int MaxNumber;

	public int CanInputNumberCount;

	public TaskItemCodeLabelBtn CodeInputItemTemplate;

	public UIGrid CodeInputGrid;

	public List<UILabel> ShowCodeResult;

	public GameObject FinalNumberNoInputRoot;

	public UILabel FinalResultLabel;

	public string CodeInputSound;

	private ResourceID m_CodeInputSoundRes;

	private int m_FinalCode;

	public override void OnStart()
	{
	}

	public void OnCodeInput(int code, TaskItemCodeLabelBtn codeBtn)
	{
	}

	public void _003C_003EiFixBaseProxy_OnStart()
	{
	}
}
