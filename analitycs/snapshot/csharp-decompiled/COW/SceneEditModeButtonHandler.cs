using System.Collections.Generic;
using UnityEngine;

namespace COW;

public class SceneEditModeButtonHandler : AdjustButtonStateHandlerBase
{
	public override SceneEditItemAdjust.ButtonState ModeState => SceneEditItemAdjust.ButtonState.None;

	public override void Init(Dictionary<ulong, UIButton> buttonMaps, Dictionary<int, UISprite> iconMaps, UIGrid BtnGrid, GameObject btnRoot, GameObject containerCoordinate)
	{
	}

	public override void OnSelectedObjChanged()
	{
	}

	public override void RefreshResModeChanged(object[] data)
	{
	}

	public void _003C_003EiFixBaseProxy_Init(Dictionary<ulong, UIButton> P0, Dictionary<int, UISprite> P1, UIGrid P2, GameObject P3, GameObject P4)
	{
	}
}
