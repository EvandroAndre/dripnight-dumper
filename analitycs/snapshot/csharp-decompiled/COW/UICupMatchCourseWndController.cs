using GCommon;

namespace COW;

public class UICupMatchCourseWndController : UIPopupWindowController
{
	private sealed class _003C_003Ec__DisplayClass9_0
	{
		public float delayTime;

		public UICupMatchCourseWndController _003C_003E4__this;

		internal void _003CAnimationEventHandler_003Eb__1()
		{
		}
	}

	private UICupMatchCourseWndView m_View;

	private uint m_CloseDelayCall;

	private uint m_CountDownDelayCall;

	private UICupMatchCourseAnimController m_Ctrl;

	private UIModelCupMatch m_ModelCupMatch;

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

	public void SetData(int key)
	{
	}

	private void AnimationEventHandler(object[] data)
	{
	}

	private void HideAllUI()
	{
	}

	protected override bool UseCustomizedAnimation()
	{
		return false;
	}

	public override bool ClosedByEsc()
	{
		return false;
	}

	private void _003CAnimationEventHandler_003Eb__9_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return false;
	}

	public bool _003C_003EiFixBaseProxy_ClosedByEsc()
	{
		return false;
	}
}
