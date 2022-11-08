
using UnityEngine;

public class VectorMath : MonoBehaviour
{

    private void DrawBlueVector()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawLine(Vector3.zero, Vector3.left);
    }
    
    private void DrawVector(Vector3 vector, Color color)
    {
        Gizmos.color = color;
        Gizmos.DrawLine(Vector3.zero, vector);
    }
    
    private void OnDrawGizmos()
    {
        DrawVector(Vector3.forward, Color.blue);
        DrawVector(Vector3.up, Color.green);
        DrawVector(Vector3.right, Color.red);
    }
}
