using GCommon;
using UnityEngine;
using message;

namespace COW;

public class UIHudItemGeneratorController : UIBaseController
{
	private UIHUDCSRoundItemGeneratorView m_View;

	private Vector3 m_LvlObjPos;

	public Vector3 LvlObjPos
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

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

	public void SetSprite(string spriteName)
	{
	}

	public void SetBgSprite(CFEGLKPANOP itemGeneratorType)
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
