namespace GCommon;

public class UIPopupSpecialWindowController : UIPopupWindowController
{
	protected override string AnimationConfogPath()
	{
		return null;
	}

	public override int MinGroupDepth()
	{
		return 0;
	}

	protected override void OnUIOpen()
	{
	}

	public virtual void OnBackButtonClick()
	{
	}

	public virtual void OnEnterButtonClick()
	{
	}
}
