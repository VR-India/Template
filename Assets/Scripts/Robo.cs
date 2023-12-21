#region
/// copyright (c) iNucom. All rights reserved.
#endregion

using UnityEngine;
using System;
using VInspector;

namespace Inucom
{
    public class Robo : MonoBehaviour
    {

        [Tab("Marko")]        
        public Weapon weapon;

        [Tab("Rendering")]

        public Mesh mesh;
        public Material material;
        public bool shadows = true;

        [Tab("Shape")]

        [Variants("Sponge", "Cloud", "Snowflake")]
        public string type;
        [RangeResettable(1, 4)]
        public int steps = 3;

        [Space(4)]
        [Foldout("Modifications")]
        [RangeResettable(0, 1)]
        public float gaps = 0;
        [RangeResettable(0, 1)]
        public float jitter = 0;

    }
}