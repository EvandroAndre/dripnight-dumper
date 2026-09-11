using System;
using GCommon;
using UnityEngine;

namespace COW;

public class IconTextData
{
	public enum IconSourceType
	{
		Controller,
		Sprite
	}

	public IconSourceType SourceType;

	public Type ControllerType;

	public object ControllerData;

	public ResourceID IconRes;

	public string SpriteName;

	public float IconScale;

	public Vector3 IconOffset;

	public string Text;
}
