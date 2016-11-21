using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public static class PartController
{
    public enum partTypes { CORE, STRUCTURAL, WHEEL, ROTOR, CAMERA };

    public static List<PartClass> robotCores = new List<PartClass>();
}
