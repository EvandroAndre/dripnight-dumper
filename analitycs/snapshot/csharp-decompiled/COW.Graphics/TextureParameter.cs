using System;
using UnityEngine;

namespace COW.Graphics;

[Serializable]
public sealed class TextureParameter : ParameterOverride<Texture>
{
	public TextureParameterDefault defaultState;
}
