using UnityEngine;

public class SendTransform : MonoBehaviour
{
    public static System.Action<Transform> SendThisTransform;

    void Start()
    {
        SendThisTransform(this.transform);
    }
}
