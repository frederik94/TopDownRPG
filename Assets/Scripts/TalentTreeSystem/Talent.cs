using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Talent : MonoBehaviour
{
    public int Id;
    public List<int> requiredIds = new List<int>();
    public List<Transform> affectedLines = new List<Transform>();
    public bool activated = false;
}
