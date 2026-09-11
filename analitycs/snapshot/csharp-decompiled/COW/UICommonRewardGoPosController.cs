using GCommon;

namespace COW;

internal class UICommonRewardGoPosController : UIBaseController
{
	protected UICommonRewardGoPosView m_View;

	private string m_GoParma;

	private uint m_GoPos;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	protected void RegisterGoPosData(uint gopos, string param)
	{
	}

	private void OnGoToClick()
	{
	}

	private void OnGoPos()
	{
	}

	protected virtual void SetGotoIcon()
	{
	}

	protected virtual void SetFullLabel()
	{
	}

	public virtual void RegisterGoPos(uint itemID)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
