using GCommon;

namespace ReactUI;

public sealed class UIVariableBindImageByFormat : UIVariableBind
{
	private static ResourceManager m_Res;

	private string format;

	private string spriteBind;

	private bool autoFitNativeSize;

	private bool autoDisable;

	private bool refreshImageOnInitial;

	private UISprite m_image;

	private UITexture m_rawImage;

	private UIVariable imageVariable;

	protected override void BindVariables()
	{
	}

	protected override void UnbindVariables()
	{
	}

	private void RefreshImage()
	{
	}

	private void RefreshDisableStatus(UISprite img)
	{
	}

	private new void Awake()
	{
	}
}
