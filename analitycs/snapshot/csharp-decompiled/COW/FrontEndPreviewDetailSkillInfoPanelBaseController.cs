namespace COW;

public abstract class FrontEndPreviewDetailSkillInfoPanelBaseController : UIFrontEndPreviewUIComponentTemplateBaseController<FrontEndPreviewDetailSkillInfoPanelBaseView>
{
	private AvatarSkillData m_AvatarSkillData;

	private uint m_DelayCallID;

	private const int BGPADDDING = 14;

	private bool m_IsScrollViewMoving;

	private float m_OriginalScrollViewYPosition;

	private float m_RealScrollViewHeight;

	private float m_OriginalScrollViewHeight;

	private const int m_OriginalPanelDepth = 50;

	protected override void InitView()
	{
	}

	private void OnScrollViewDragStarted()
	{
	}

	public void RefreshPetSkillInfo(uint skillID)
	{
	}

	public void RefreshAvatarSkillInfo(AvatarSkillData avatarSkillData)
	{
	}

	private void ResetOnRefresh()
	{
	}

	private void SetScrollViewMoving()
	{
	}

	private void OnScrollViewPositionFinish()
	{
	}

	private void SetBg()
	{
	}

	private void DescLabelCallBack(int lines)
	{
	}

	private void OnSkillBtnClick()
	{
	}

	public void Update()
	{
	}

	public void SetScrollViewPanelDepth(int depth)
	{
	}

	public void _003C_003EiFixBaseProxy_InitView()
	{
	}
}
