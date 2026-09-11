using GCommon;
using UnityEngine;
using message;

namespace COW;

public class UIHudLockBountyVehicleMapItem : UIBaseController
{
	private UIHudLockBountyVehicleMapItemView m_View;

	private int m_CurrentCountDown;

	private MutableString m_CountStr;

	private GOENNGGJIEH m_State;

	private uint m_ExpireTime;

	private Color m_TimeOutColor;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	public void SetData(GOENNGGJIEH _state, uint _expireTime)
	{
	}

	private void UpdateIcon()
	{
	}

	private void Update()
	{
	}

	protected override void OnUIDestory()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
