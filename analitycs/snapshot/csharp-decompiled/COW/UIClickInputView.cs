using UnityEngine;

namespace COW;

public class UIClickInputView : MonoBehaviour
{
	public UIInput TartgetUiInput;

	public UIDragScrollView DragSV;

	private bool m_IsSelect;

	protected virtual void OnClick()
	{
	}

	public virtual void OnSelect(bool isSelected)
	{
	}
}
