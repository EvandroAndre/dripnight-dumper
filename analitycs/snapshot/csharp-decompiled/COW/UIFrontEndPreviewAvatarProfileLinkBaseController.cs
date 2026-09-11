using UnityEngine;

namespace COW;

public abstract class UIFrontEndPreviewAvatarProfileLinkBaseController : UIFrontEndPreviewUIComponentTemplateBaseController<UIFrontEndPreviewAvatarProfileLinkBaseView>
{
	private uint avatarId;

	private uint itemId;

	private Vector3 m_UpPos;

	private GoPosType m_Type;

	protected override void InitView()
	{
	}

	public void SetType(GoPosType type)
	{
	}

	public void SetPos(bool showBtn)
	{
	}

	public void SetAvatarId(uint id)
	{
	}

	public void SetItemId(uint id)
	{
	}

	private void OnGotoBtnClick()
	{
	}

	public void SetMainPanelDepth(int depth)
	{
	}

	protected override void OnUIClose()
	{
	}

	public void _003C_003EiFixBaseProxy_InitView()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
