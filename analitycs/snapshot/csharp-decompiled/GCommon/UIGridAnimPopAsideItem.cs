using UnityEngine;

namespace GCommon;

public class UIGridAnimPopAsideItem : MonoBehaviour
{
	public ItemAniamtionRef InAnimation;

	public ItemAniamtionRef OutAnimation;

	public float AnimationTotalTime;

	public float Delay;

	private bool m_Played;

	private float m_LastPlayTime;

	public void AnimationEnd()
	{
	}

	public void DisableAnim()
	{
	}

	private void PlayAnim()
	{
	}

	private void ResetToBegining()
	{
	}

	public void ResetToEnd()
	{
	}

	private void Update()
	{
	}

	private void OnEnable()
	{
	}

	public void SetShowIndex(int value)
	{
	}

	public void InitPlayedState()
	{
	}
}
