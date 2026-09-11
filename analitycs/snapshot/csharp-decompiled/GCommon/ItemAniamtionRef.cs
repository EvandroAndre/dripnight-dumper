using System;
using UnityEngine;

namespace GCommon;

[Serializable]
public class ItemAniamtionRef
{
	public TweenAlpha TweenA;

	public TweenPosition TweenPos;

	public TweenRotation TweenRot;

	public TweenScale TweenS;

	public Animation Animation_;

	public Animator Animator_;

	public TweenColor TweenC;

	public void DisableAnim()
	{
	}

	public void PlayAnim()
	{
	}

	public void ResetToBegining()
	{
	}

	public void ResetToEnd()
	{
	}
}
