using System;
using GCommon;
using UnityEngine;

namespace COW;

public class ItemDelayCreateHelper : MonoBehaviour
{
	public int m_CreateFrameCnt;

	public Func<UIBaseController> m_OnCreate;

	public void DelayCreate(int createFrameCnt, Func<UIBaseController> onCreate)
	{
	}

	public void Reset()
	{
	}

	private void Update()
	{
	}
}
