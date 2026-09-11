using UnityEngine;

namespace GCommon;

public class UIKeyActionItemController : MonoBehaviour
{
	public UILabel keyName;

	public UIButton keyCodeBtn;

	public UISprite selectedBg;

	private string actionName;

	private void Awake()
	{
	}

	public void SetName(string name)
	{
	}

	public void SetKeyCodeMapName(string name)
	{
	}

	public string GetOptName()
	{
		return null;
	}

	public void SetSelect(bool b)
	{
	}
}
