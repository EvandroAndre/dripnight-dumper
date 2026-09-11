using System.Text;
using GCommon;

namespace COW;

public abstract class UICommonBonusIconController : UIBaseController
{
	protected UICommonBonusIconView m_View;

	protected readonly StringBuilder m_StringBuilder;

	protected override void OnUIInit()
	{
	}

	private void AddEventDelegate()
	{
	}

	protected abstract void OnShowTipsBtnClick();

	protected abstract void RefreshVisibilityInternal();

	private void SetDepth(int depth)
	{
	}

	private void SetBonusIconColor(string colorStr)
	{
	}

	public void RefreshStatus()
	{
	}

	public void Init(float scale, int depth, string colorStr)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
