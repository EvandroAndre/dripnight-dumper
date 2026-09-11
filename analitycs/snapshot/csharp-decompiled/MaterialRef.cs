using System;
using System.Collections.Generic;
using COW.Graphics;
using UnityEngine;

[Serializable]
public class MaterialRef : ScriptableObject
{
	[Serializable]
	public class TweenerRecorder
	{
		public UITweener.Method method;

		public UITweener.Style style;

		public AnimationCurve animationCurve;

		public bool ignoreTimeScale;

		public float delay;

		public float duration;

		public bool steeperCurves;

		public int tweenGroup;
	}

	[Serializable]
	public class RecorderBase
	{
		public string shaderName;

		public string textureName;
	}

	[Serializable]
	public class PositionRecorder
	{
	}

	[Serializable]
	public class UVPlayerRecorder : RecorderBase
	{
		public int[] columnRow;

		public float playVelocity;

		public float startIndex;

		public bool useInterval;

		public List<UVSeqPlayer.Interval> intervals;

		public List<string> propertyNames;

		public List<Vector2> propertyScale;

		public UVSeqPlayer.PlayType playType;
	}

	[Serializable]
	public class PropertyRecorder : RecorderBase
	{
		public int propertyIndex;

		public string propertyName;

		public TweenPropertyAlpha tweenPropertyAlpha;

		public int propType;

		public float fromFloat;

		public float toFloat;

		public int vec4Idx;

		public bool colorHDR;

		public Gradient fromToColor;

		public TweenerRecorder tweenerRecorder;
	}

	public class RotationRecorder
	{
	}

	public class ScaleRecorder
	{
	}

	public class TransformRecorder
	{
	}

	public List<PropertyRecorder> propertyRecorders;

	public List<UVPlayerRecorder> UVPlayerRecorders;

	private string _003CLogRecordForEditor_003Ek__BackingField;

	public string LogRecordForEditor
	{
		get
		{
			return _003CLogRecordForEditor_003Ek__BackingField;
		}
		private set
		{
			_003CLogRecordForEditor_003Ek__BackingField = value;
		}
	}

	public bool CopyPublicTweenerToRecorder(UITweener target, TweenerRecorder tr)
	{
		return false;
	}

	public bool CopyTargetToRecorder(UVSeqPlayer tar, UVPlayerRecorder recorder)
	{
		return false;
	}

	public bool CopyTargetToRecorder(TweenProperty tar, PropertyRecorder recorder)
	{
		return false;
	}

	public void UpdateComponents(GameObject root)
	{
	}
}
