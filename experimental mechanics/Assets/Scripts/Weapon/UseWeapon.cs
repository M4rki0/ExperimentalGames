using UnityEngine;


    public class UseWeapon : MonoBehaviour
    {
        [SerializeField] private Animator animator;

        private void Start()
        {
            
        }

        public void Shoot()
        {
            Debug.Log("DHOOOOOOT");
            animator = GetComponentInChildren<Animator>();
            animator.SetTrigger("Shoot"); //TODO make generic 
        }
    }

