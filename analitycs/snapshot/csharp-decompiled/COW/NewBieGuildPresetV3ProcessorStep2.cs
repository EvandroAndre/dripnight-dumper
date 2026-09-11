namespace COW;

public class NewBieGuildPresetV3ProcessorStep2 : NewBieGuildCommonProcessor
{
	private int m_Depth;

	private UIButton m_GuideButton;

	public NewBieGuildPresetV3ProcessorStep2(UICommonGuideData guideData, UIButton guideButton, int depth)
		: base(NewbieGuideId.None, null)
	{
	}

	public override void DoGuild()
	{
	}

	public new void _003C_003EiFixBaseProxy_DoGuild()
	{
	}
}
