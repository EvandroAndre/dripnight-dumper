using UnityEngine;

namespace COW;

public class TailorLockBar : MonoBehaviour
{
	public UISprite Icon;

	public UILabel Title;

	public UIButton Button;

	public UIButton DisplayBtn;

	public GameObject DisplayArrow;

	public UIWidget Widget;

	public UILabel Process;

	private bool m_DisllayAll;

	private ETailorLockBarType m_Type;

	private const string PROGRESSFORMAT = "([FABF00]{0}[-]/{1})";

	private const string PROGRESSFINISHFORMAT = "([FFFFFF]{0}/{1})";

	private uint m_TailorID;

	public void SetData(string title, bool enableBtn, ETailorLockBarType tailorLockBarType, uint tailorID, bool showDisplay = false)
	{
	}

	public void Refresh()
	{
	}

	private void RefreshProgress()
	{
	}

	private void OnBtnClick()
	{
	}

	private void OnDisplayBtnClick()
	{
	}

	public void RefreshDisplayState(bool displayAll)
	{
	}

	public Vector2 GetSize()
	{
		return default(Vector2);
	}
}
