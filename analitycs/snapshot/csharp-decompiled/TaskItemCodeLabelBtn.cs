using System;
using UnityEngine;

public class TaskItemCodeLabelBtn : MonoBehaviour
{
	public UILabel NumberLabel;

	public GameObject EnableRoot;

	public GameObject DisableRoot;

	public UIButton Btn;

	public GameObject ErrorIcon;

	private int CodeNumber;

	private Action<int, TaskItemCodeLabelBtn> inputCallBack;

	public void InitInfo(int code, bool isEnable, Action<int, TaskItemCodeLabelBtn> callBack)
	{
	}

	public void SetErrorState()
	{
	}

	public void OnInput()
	{
	}
}
