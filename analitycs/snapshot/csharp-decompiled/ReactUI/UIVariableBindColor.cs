using UnityEngine;

namespace ReactUI;

public sealed class UIVariableBindColor : UIVariableBindBool
{
	private Color enabledColor;

	private Color disabledColor;

	private UISprite m_image;

	private UITexture m_rawImage;

	private Color m_currentColor;

	protected override void OnValueChanged()
	{
	}
}
