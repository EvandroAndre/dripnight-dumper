using UnityEngine;

namespace GCommon;

public class PCHurtHint : MonoBehaviour
{
	public GameObject HintGo;

	public TweenAlpha HitGoAlpha;

	public TweenScale ArrowScale;

	public TweenColor ArrowColor;

	public TweenColor ArcColor;

	public int HintDurationTime;

	public float ArrowUpTime;

	public float ArrowDownTime;

	public Vector3 ArrowDelateScale;

	public int MaxHitLevel;

	public float[] LevelTime;

	public Color NormalColor;

	public Color DeepColor;
}
