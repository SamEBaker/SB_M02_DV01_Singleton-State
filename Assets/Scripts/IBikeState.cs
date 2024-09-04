using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Chapter.State
{
    public interface IBikeState
    {
        void Handle(BikeController controller);
    }
}



