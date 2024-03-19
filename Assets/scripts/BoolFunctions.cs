using UnityEngine;

public class BoolFunctions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        bool b1 = true;
        bool b2 = false;

        float a = 12, b = 33.5f;

        bool aIsHigherThanB = a > b; // f
        bool aIsLowerThanB = a < b; // t

        bool isEqual = a == b; // f
        bool isntEqual = a != b; // t

        a = 12;
        b = 12;

        aIsHigherThanB = a > b; // f
        aIsLowerThanB = a < b; // f

        bool isAHigherThanBOrEqual = a >= b; // t
        bool isALowerThanBOrEqual = a <= b; // t

        //--------------------------------------------------------

        int ammo = 16;
        bool haveGun = true;
        bool haveAmmo = ammo > 0;

        bool canWeShoot = haveGun && haveAmmo; // t

        //--------------------------------------------------------

        bool isOnGround = true;
        bool haveAirJump = false;

        bool canJump = isOnGround || haveAirJump; // t

        // milyen irl problemaban hasznos az es / vagy ? ---------

        bool isInTheAir = !isOnGround; // negálás





    }

}
