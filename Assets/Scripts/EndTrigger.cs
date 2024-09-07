using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager Manager;
    void OnTriggerEnter()
    {
        Manager.Completelevel();
    }
}
