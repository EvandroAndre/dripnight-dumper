using System.Collections.Generic;
using UnityEngine;

namespace COW;

public class DrawLineManager : MonoSingleton<DrawLineManager>
{
	public List<Rect> EditorUIRectList;

	public MapEditorType CurrentMapEditorType;

	public bool IsMapOpen;

	public bool OpenDrawFunction;

	private int MaxCtrlZCount;

	private int ZPostion;

	private Color CurrentColor;

	private LineRenderer lineRenderer;

	private Transform LinesTrans;

	private Camera Camera;

	private Vector3 position;

	private int index;

	private Vector3 m_StartPos;

	private int LengthOfLineRenderer;

	private LineRenderer m_CurrentlLine;

	public List<GameObject> LineList;

	public Stack<GameObject> LinesUndo;

	private int pointCount;

	private float angle;

	private List<Vector3> points;

	private LineRenderer m_HeadLineRendererLeft;

	private LineRenderer m_HeadLineRendererRight;

	public override void Init()
	{
	}

	private void Update()
	{
	}

	private void ResetLine()
	{
	}

	public void Undo()
	{
	}

	private void ResycleStack()
	{
	}

	private void InstantiateLine()
	{
	}

	private void ProcessDraw(bool MouseHoverOnButton = false)
	{
	}

	private void ProcessDrawArrowLine(bool MouseHoverOnButton = false)
	{
	}

	private void ProcessLine(bool MouseHoverOnButton = false)
	{
	}

	private void ProcessDrawCircle(bool MouseHoverOnButton = false)
	{
	}

	public void SetColor(Color color)
	{
	}

	public void Clear(bool resetstate = true)
	{
	}

	public void _003C_003EiFixBaseProxy_Init()
	{
	}
}
