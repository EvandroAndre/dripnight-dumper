namespace COW;

public abstract class UIFrontEndPreviewUIComponentTemplateBaseController<T> : UIFrontEndPreviewUIComponentBaseController where T : UIFrontEndPreviewUIComponentBaseView
{
	protected T m_View;

	public T GetView()
	{
		return null;
	}

	protected abstract T InitBaseView();

	protected override void OnUIInit()
	{
	}
}
