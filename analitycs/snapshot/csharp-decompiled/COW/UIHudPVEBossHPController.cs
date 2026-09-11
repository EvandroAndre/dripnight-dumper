using GCommon;

namespace COW;

internal class UIHudPVEBossHPController : UIBaseController
{
	private const int CONST_HPMaxLayerNum = 5;

	private int m_CurHPLayerIndex;

	private UIHudPVEBossHPView m_View;

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

	private void OnBossSpawn(object[] data)
	{
	}

	private void OnBossDead(object[] data)
	{
	}

	private void OnBossHPChanged(object[] data)
	{
	}

	private void CheckHPLayerChange(int preLayerIndex, int curLayerIndex)
	{
	}

	private void OnBossColorChanged(object[] data)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
