using System.Collections.Generic;
using UnityEngine;

namespace GCommon;

public class UIWrapContentExtend : UIWrapContentBase
{
	public delegate void OnInitializeItem(GameObject go, int wrapIndex, int realIndex);

	public enum EItemShowState
	{
		NotVisible,
		WholeShow,
		PartialShow
	}

	public int m_columns;

	public int itemWidth;

	public int itemHeight;

	private bool m_ReverseItem;

	public bool cullContent;

	public int minIndex;

	public int maxIndex;

	public OnInitializeItem onInitializeItem;

	private Transform mTrans;

	public UIPanel mPanel;

	public UIScrollView mScroll;

	private bool mHorizontal;

	private bool mFirstTime;

	private List<Transform> mChildren;

	private Dictionary<Transform, int> mItemIndexs;

	private bool _003CForceResetScroll_003Ek__BackingField;

	public static bool EnableWrapContentProtection;

	public bool ForceResetScroll
	{
		get
		{
			return _003CForceResetScroll_003Ek__BackingField;
		}
		set
		{
			_003CForceResetScroll_003Ek__BackingField = value;
		}
	}

	public override UIScrollView.Movement ScrollViewMovement => UIScrollView.Movement.Horizontal;

	public override float CellHeight => 0f;

	public override float CellWidth => 0f;

	public void InitEasyList(UIScrollView scrollView, int columns, bool reverseItem = false)
	{
	}

	protected virtual void Start()
	{
	}

	public void ForceSetMoveDelegate()
	{
	}

	public virtual void ResetChilds(bool resetScroll = true, bool resortChildren = true)
	{
	}

	public virtual void Refresh()
	{
	}

	protected virtual void OnMove(UIPanel panel)
	{
	}

	public void ReplaceChild(Transform oldChild, Transform newChild)
	{
	}

	public void RemoveChildren(HashSet<Transform> children2Remove)
	{
	}

	private int ReverseSortHorizontal(Transform a, Transform b)
	{
		return 0;
	}

	public void SortBasedOnScrollMovement(bool resetScroll = true, bool resortChildren = true)
	{
	}

	public void SortAlphabetically()
	{
	}

	protected bool CacheScrollView()
	{
		return false;
	}

	private void ResetChildPositions(bool resetScroll = true)
	{
	}

	public void WrapContent()
	{
	}

	private void OnValidate()
	{
	}

	protected virtual void UpdateItem(Transform item, int index)
	{
	}

	protected int GetRealIndex(Vector2 itemLocalPosition, bool isNature = false)
	{
		return 0;
	}

	protected int GetFullFillChildrenSize()
	{
		return 0;
	}

	public Vector3 GetPositionAtIndex(int index)
	{
		return default(Vector3);
	}

	public int GetCurrentRealIndex(out float offset)
	{
		offset = default(float);
		return 0;
	}

	public EItemShowState GetItemShowState(int index)
	{
		return EItemShowState.NotVisible;
	}

	public bool IsItemWholeShow(int index)
	{
		return false;
	}

	public bool IsItemWholeShow(Vector3 itemLocalPosition, Vector2 itemSize)
	{
		return false;
	}
}
