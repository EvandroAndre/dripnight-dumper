using Spine;
using Spine.Unity;
using UnityEngine;

namespace GCommon;

public class SpineAlphaSync : MonoBehaviour, IAnimatedAlpha
{
	private SkeletonAnimation skeletonAnim;

	private Skeleton skeleton;

	public float alpha;

	public float Alpha
	{
		get
		{
			return 0f;
		}
		set
		{
		}
	}

	public void OnEnable()
	{
	}

	public void OnDisable()
	{
	}

	public void ResetSkeletonAnimation()
	{
	}

	public void LateUpdate()
	{
	}
}
