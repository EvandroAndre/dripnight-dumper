using GCommon;

namespace COW;

public class UINewPlayerV3ExploreCampTaskItemController : UIBaseController
{
	private const string ANIM_CLIP_NAME_IN = "UIFX_UINewPlayerV3ExploreCampTaskItem_In";

	private const string ANIM_CLIP_NAME_OUT = "UIFX_UINewPlayerV3ExploreCampTaskItem_Out";

	private UINewPlayerV3ExploreCampTaskItemView m_View;

	private uint m_SectionID;

	private uint m_TaskID;

	private string m_TaskDes;

	private uint m_TaskMaxProgress;

	private string m_CDNPopWndPicUrl;

	private string m_CDNPopWndTitle;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void InitView(uint taskID)
	{
	}

	public void RefreshView()
	{
	}

	private void OnClick()
	{
	}

	public void ChangeFinishBg(bool isFinished)
	{
	}

	public void PlayAppearAnim()
	{
	}

	public float GetAppearAnimLength()
	{
		return 0f;
	}

	public void PlayDisappearAnim()
	{
	}

	public float GetDisappearAnimLength()
	{
		return 0f;
	}

	public void StopAllAnim()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
