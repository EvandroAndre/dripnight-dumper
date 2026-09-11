using System;
using UnityEngine;

namespace COW.Gameplay.UGC;

[Serializable]
public class UGCTutorialGuideParam_SceneDragGuide
{
	public string hintTextLocKey;

	public string startPosKey;

	public string endPosKey;

	public string startWidgetKey;

	public string endWidgetKey;

	public Vector3 endPos;

	[NonSerialized]
	public bool hasEndPos;

	public string anchorSide;

	public string hintAnchorEndpoint;

	public string hintOffsetX;

	public string hintOffsetY;
}
