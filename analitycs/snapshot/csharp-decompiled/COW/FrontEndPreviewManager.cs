using System.Collections.Generic;
using GCommon;

namespace COW;

public class FrontEndPreviewManager : SingletonModule<FrontEndPreviewManager>
{
	private List<FrontEndPreviewComponent> m_FrontEndPreviewComponents;

	public FrontEndPreviewComponent CurrentFrontEndPreviewComponent => null;

	protected override void OnInit()
	{
	}

	protected override void OnCleanup()
	{
	}

	public void AddFrontEndPreviewComponent(FrontEndPreviewComponent frontEndPreviewComponent)
	{
	}

	public void RemoveFrontEndPreviewComponent(FrontEndPreviewComponent frontEndPreviewComponent)
	{
	}

	public void CloseAllPreview()
	{
	}

	public void ClearResourceRefCache()
	{
	}
}
