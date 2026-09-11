using System;
using System.Collections.Generic;
using GCommon;

namespace COW;

public class UIInGamePoolMgr : MonoSingleton<UIInGamePoolMgr>
{
	private Dictionary<Type, Queue<UIBaseController>> m_InGameUIPoolDic;

	private HashSet<Type> m_InGameUIByKillCam;

	public override void Init()
	{
	}

	public UIBaseController GetUIControllerNoCreate(Type uiType)
	{
		return null;
	}

	public void RecycleUIController(UIBaseController uicontroller, UIBaseController parentCtrl, bool recyleByKillCam, bool IsRootController)
	{
	}

	public void ClearKillCamCtrl()
	{
	}

	public void ClearPool()
	{
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}
}
