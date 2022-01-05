using UnityEngine;

public class Teleport : MonoBehaviour
{
    public void WarpToPosition()
    {
        RaycastHit hit;
        Vector3 pos = new Vector3(Screen.width / 2f, Screen.height / 2f);
        var ray = Camera.main.ScreenPointToRay(pos);
        if(Physics.Raycast(ray, out hit))
        {
            Vector3 newPos = new Vector3(hit.point.x, this.transform.position.y, hit.point.z);
            this.transform.position = newPos;
        }
    }
}
