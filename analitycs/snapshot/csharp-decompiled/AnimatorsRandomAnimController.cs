using System.Collections.Generic;
using UnityEngine;

public class AnimatorsRandomAnimController : MonoBehaviour
{
	public bool bEnableRamdomAnim;

	public string endAnimKey;

	public List<Animator> animators;

	private int animatorsCount;

	public List<string> keyNames;

	private int keyNamesCout;

	public List<float> animTimes;

	private List<float> animTimers;

	private bool isPlayingAnim;

	private int animIDPlaying;

	public float idleTimeMin;

	public float idleTimeMax;

	private List<float> idleTimes;

	private List<float> idleTimers;

	public bool foldAnims;

	private void Start()
	{
	}

	public void Update()
	{
	}
}
