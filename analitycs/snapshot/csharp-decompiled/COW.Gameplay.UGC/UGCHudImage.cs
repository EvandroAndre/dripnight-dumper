namespace COW.Gameplay.UGC;

public class UGCHudImage : UGCHudWidget
{
	protected UISprite m_Sprite;

	private UISpriteAnimation m_SpriteAnimation;

	private bool m_IsApplyAnimation;

	private int m_FrameRate;

	private bool m_Loop;

	private UIAtlas m_AnimationAtlas;

	public bool IsApplyAnimation => false;

	public UISprite Image => null;

	public override UGCHudWidgetType GetHudWidgetType()
	{
		return UGCHudWidgetType.Empty;
	}

	public override void RefreshSprite()
	{
	}

	public void SetIsApplyAnimation(bool value)
	{
	}

	public void SetAnimationAtlas(UIAtlas atlas)
	{
	}

	public void SetFrameRate(int rate)
	{
	}

	public void SetLoop(bool loop)
	{
	}

	private void ApplyAnimationAtlas()
	{
	}

	private void StartAnimation()
	{
	}

	private void StopAnimation()
	{
	}

	public UGCHudWidgetType _003C_003EiFixBaseProxy_GetHudWidgetType()
	{
		return UGCHudWidgetType.Empty;
	}

	public void _003C_003EiFixBaseProxy_RefreshSprite()
	{
	}
}
