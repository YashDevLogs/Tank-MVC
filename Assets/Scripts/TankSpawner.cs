using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    [System.Serializable]
    public class Tank
    {
        public TankTypes tankType;
        public float movementSpeed;
        public float rotationSpeed;
        public Material color;
    }
    public List<Tank> tankList;

    public TankView tankView;

    void Start()
    {
        CreateTank();
    }

    private void CreateTank()
    {
        TankModel tankModel = new TankModel(tankList[2].movementSpeed, tankList[2].rotationSpeed, tankList[2].tankType, tankList[2].color);
        TankController tankController = new TankController(tankView, tankModel);
    }

}
