using System;
using UnityEngine;
using UnityEngine.Events;

namespace COW;

[Serializable]
public class ColorChangedEvent : UnityEvent<Color>
{
}
