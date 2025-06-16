using UnityEngine;

namespace TMKOC.LifeLessons
{
    public class GameManager : MonoBehaviour
    {
        private static GameManager instance;


        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }
            else
            {
                Destroy(instance);
            }
        }
        public static GameManager Instance { get { return instance; } }
    }
}
