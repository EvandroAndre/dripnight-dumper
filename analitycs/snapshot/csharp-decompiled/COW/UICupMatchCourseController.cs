using System.Collections.Generic;
using GCommon;
using UnityEngine;

namespace COW;

public class UICupMatchCourseController : UIBaseController
{
	protected UICupMatchCourseView m_View;

	protected int m_CupMatchKey;

	protected UIModelCupMatch m_ModelCupMatch;

	private List<Transform> m_CourseTrans;

	protected List<CupMatchCourseItem> m_CourseItems;

	protected List<GameObject> m_LineEffects;

	private Dictionary<int, List<int>> m_RoundColumnIndexDict;

	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	protected override void OnUIInit()
	{
	}

	private void InitDict()
	{
	}

	private void InitCourseTrans()
	{
	}

	private void CreateCourseItem()
	{
	}

	public virtual void SetData(int cupMatchKey)
	{
	}

	public void PlayAnim()
	{
	}

	public void RefreshCourse()
	{
	}

	private void ShowLineEffect()
	{
	}

	private void ShowNextCourseInfo()
	{
	}

	protected bool NeedShowNextCourseInfo()
	{
		return false;
	}

	protected List<int> GetNextCourseIndexList()
	{
		return null;
	}

	protected virtual void OnRefreshCouse()
	{
	}

	protected bool IsSelfCouseIndex(int index)
	{
		return false;
	}

	private void RefreshCupMatchIcon()
	{
	}

	private bool IsRoundColumnItem(int round, int index)
	{
		return false;
	}

	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
