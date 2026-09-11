using UnityEngine;

namespace GCommon;

public class UIListAnimQueueHelper : MonoBehaviour
{
	public float PlayInterval;

	public bool m_PlayItemInfiniteTime;

	private bool m_PlayItemAnim;

	private uint m_TotalItemCnt;

	private float m_LastPlayTime;

	private int m_LastPlayIndex;

	public bool PlayItemAnim => false;

	public void PlayItemAnimQueue(UIEasyListItemController[] itemCtrls, uint totalItemCnt, int realIndex)
	{
	}

	private void BeforeAnimReset(uint totalItemCnt, int realIndex)
	{
	}

	private void Update()
	{
	}

	public void PlayListItemAnimQueue(UIListAnimQueueItem[] itemCtrls, uint totalItemCnt, int realIndex)
	{
	}

	private int _003CPlayItemAnimQueue_003Eb__8_0()
	{
		return 0;
	}

	private int _003CPlayListItemAnimQueue_003Eb__11_0()
	{
		return 0;
	}
}
