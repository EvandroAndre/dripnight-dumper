using UnityEngine;

namespace GCommon;

public class UIMultiresolutionFit : MonoBehaviour
{
	public int sourceAspectWidth;

	public int sourceAspectHight;

	public bool showTop;

	private float sourceAspect;

	private bool baseOnWidth;

	private UIWidget widget;

	private bool init;

	private Vector2 screenSize;

	private Vector2 fullScreenNguiSize;

	private UIRoot uiRoot;

	private float lastScreenRatio;

	private int lastUIRootWidth;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Init()
	{
	}

	private void OnUIRootChange()
	{
	}

	private void CalcFullScreenNguiSize()
	{
	}

	private void LateUpdate()
	{
	}

	public void FitSize()
	{
	}
}
