using UnityEngine;

namespace GCommon;

public class UIInnerView
{
	private GameObject ui;

	private UIItemVariable[] itemVars;

	private bool inited;

	public virtual void BindVars(GameObject ui)
	{
	}
}
