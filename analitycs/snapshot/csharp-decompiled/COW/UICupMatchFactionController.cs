using GCommon;

namespace COW;

public class UICupMatchFactionController : UIPopupWindowController
{
	private sealed class _003C_003Ec__DisplayClass11_0
	{
		public float delayTime;

		public UICupMatchFactionController _003C_003E4__this;

		internal void _003CAnimationEventHandler_003Eb__1()
		{
		}
	}

	public UICupMatchFactionView m_View;

	private UIModelCupMatch m_ModelCupMatch;

	private uint m_CloseDelayCall;

	private uint m_CountDownDelayCall;

	private int m_CupMatchKey;

	private bool m_SetDataReady;

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

	private void OnEnable()
	{
	}

	private void AnimationEventHandler(object[] data)
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

	private void _003CAnimationEventHandler_003Eb__11_0()
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
