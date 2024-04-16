using UnityEngine;

namespace Assets.Scripts.Example
{
    public class Buttons : MonoBehaviour
    {
        [SerializeField] private ArcherFactory archerFactory;
        [SerializeField] private WarriorFactory warriorFactory;

        public void SpawnArcher()
        {
            archerFactory.GetNewInstance();
        }
        public void SpawnWarrior()
        {
            warriorFactory.GetNewInstance();
        }
    }
}
