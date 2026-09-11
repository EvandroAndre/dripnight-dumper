namespace COW;

internal abstract class UIHudGetOnVehicleController : UIHudButtonBaseController
{
	private bool hudStatsCached;

	protected override void OnUIInit()
	{
	}

	protected override void OnUIDestory()
	{
	}

	protected override void OnVisibilityChanged()
	{
	}

	public virtual void OnActionEnter(object[] param)
	{
	}

	protected virtual bool ShouldShow(bool driverEmpty, bool passengerEmpty)
	{
		return false;
	}

	protected void OnActionEnd()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	public new void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
