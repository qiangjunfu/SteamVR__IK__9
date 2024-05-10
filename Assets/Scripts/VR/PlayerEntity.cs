using RootMotion.FinalIK;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class PlayerEntity : MonoBehaviour
{
    [SerializeField] private PlayerData data;
    [SerializeField] private VRIK vrik;
    [SerializeField] List<Solver_Track> solverTrackList = new List<Solver_Track>();
    [SerializeField] bool isBindTrackLeg = true;

    [SerializeField] IWeapon weapon;
    [SerializeField] Transform weaponParent;
    string weaponName;



    public List<Solver_Track> GetSolverTrackList()
    {
        return solverTrackList;
    }
    public void SetData(PlayerData playerData)
    {
        this.data = playerData;

        InitData();
    }


    float weight0 = 0.0f;
    float weight1 = 1f;
    public void InitData()
    {
        if (vrik != null) { vrik = GetComponent<VRIK>(); }
        if (solverTrackList.Count == 0)
        {
            solverTrackList = UnityTools.GetAllChildrenComponents<Solver_Track>(this.gameObject);
        }


        if (weapon == null)
        {
            weaponName = "Weapons/Gun/MP-40";
            weapon = AssetsLoadManager.Instance.LoadComponent<IWeapon>(weaponName, weaponParent);
            weapon.transform.localPosition = Vector3.zero;
            weapon.transform.localRotation = Quaternion.identity;
        }


        //if (isBindTrackLeg)
        //{
        //    vrik.solver.spine.pelvisPositionWeight = weight1;
        //    vrik.solver.spine.pelvisRotationWeight = weight1;

        //    vrik.solver.leftLeg.positionWeight = weight1;
        //    vrik.solver.leftLeg.rotationWeight = weight1;

        //    vrik.solver.rightLeg.positionWeight = weight1;
        //    vrik.solver.rightLeg.rotationWeight = weight1;
        //}
        //else
        //{
        //    vrik.solver.spine.pelvisPositionWeight = weight0;
        //    vrik.solver.spine.pelvisRotationWeight = weight0;

        //    vrik.solver.leftLeg.positionWeight = weight0;
        //    vrik.solver.leftLeg.rotationWeight = weight0;

        //    vrik.solver.rightLeg.positionWeight = weight0;
        //    vrik.solver.rightLeg.rotationWeight = weight0;
        //}
    }




    public void Shoot()
    {
        if (weapon != null && weapon.GetBulletCount() > 0 && weapon.IsCanShoot())
        {
            weapon.Shoot();
        }
    }

    public  void ContinueShoot()
    {

    }
}