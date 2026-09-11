using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UIInGameBasePopupController : UIPopupWindowController
{
	protected List<GameObject> PhaseList;

	protected int Phase;

	protected UIButton MaskBtn;

	private uint m_DelayCallID;

	private float m_DelayShowTime;

	protected override void OnUIDestory()
	{
	}

	protected void OnClickMaskBtn()
	{
	}

	protected void DelayShowMask()
	{
	}

	private void _003CDelayShowMask_003Eb__7_0()
	{
	}

	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
