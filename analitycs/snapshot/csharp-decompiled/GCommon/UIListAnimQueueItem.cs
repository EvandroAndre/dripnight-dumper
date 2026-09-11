using System;
using UnityEngine;

namespace GCommon;

public class UIListAnimQueueItem : MonoBehaviour
{
	public TweenAlpha TweenA;

	public TweenPosition TweenPos;

	public TweenRotation TweenRot;

	public TweenScale TweenS;

	public Animation Animation_;

	public Animator Animator_;

	private int m_LastIndex;

	private bool m_Played;

	private UIEasyListItemController m_EasyListItemCtrl;

	public Func<int> GetLastPlayIndex;

	private int m_ShowIndex;

	public bool IsSimpleItem;

	public void AutoFindAnim()
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

	public void SetShowIndex(int value)
	{
	}

	public void InitPlayedState()
	{
	}

	private int GetIndex()
	{
		return 0;
	}
}
