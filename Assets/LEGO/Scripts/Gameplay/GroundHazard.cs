using UnityEngine;
using UnityEngine.SceneManagement;

namespace Unity.LEGO.Gameplay
{
    public class GroundHazard : MonoBehaviour
    {
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        void Update(Collider other) 
        {
            if(other.gameObject.CompareTag("Player"))
            {
                SceneManager.LoadScene(nextSceneIndex);
            }
        }
    }
}