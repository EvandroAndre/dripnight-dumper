namespace COW;

public class UIHudMatchResultHeroicMarkState : UIHudMatchResultStateBase
{
	private EHeroicMarkType m_HeroicType;

	private uint m_HeroicBefore;

	private uint m_HeroicAfter;

	private uint m_RankBefore;

	private uint m_RankAfter;

	private bool isFirstMaster;

	public UIHudMatchResultHeroicMarkState(UIHudMatchResultStateMachine machine)
		: base(null, EUIHudMatchResultState.None)
	{
	}

	protected override bool OnCheck()
	{
		return false;
	}

	protected override bool OnEnter()
	{
		return false;
	}

	protected override void OnFinish()
	{
	}

	public bool _003C_003EiFixBaseProxy_OnCheck()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_OnEnter()
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnFinish()
	{
	}
}
