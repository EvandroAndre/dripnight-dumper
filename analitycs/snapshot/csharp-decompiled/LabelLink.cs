using System;
using UnityEngine;

public class LabelLink : MonoBehaviour
{
	public string linkTxt;

	public Action<string> linkAction;

	private void OnClick()
	{
	}

	private void OnDestroy()
	{
	}
}
