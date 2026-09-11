namespace ReactUI;

public sealed class UIVariableBindSpriteResource : UIVariableBind
{
	public enum EFitSizeType
	{
		none,
		nativeSize,
		widthHeight
	}

	private string spriteBind;

	private string fillAmountBind;

	private EFitSizeType autoFitSizeType;

	private int autoFitMaxWidth;

	private int autoFitMaxHeight;

	private bool autoDisable;

	private bool refreshImageOnInitial;

	private UISprite m_image;

	private UIVariable imageVariable;

	private UIVariable fillAmountVariable;

	private UIAtlas m_defaultAtlas;

	protected override void BindVariables()
	{
	}

	protected override void UnbindVariables()
	{
	}

	private void RefreshImage()
	{
	}

	private void RefreshFillAmount()
	{
	}

	private void RefreshDisableStatus(UISprite img)
	{
	}

	private new void Awake()
	{
	}

	private void OnEnable()
	{
	}
}
