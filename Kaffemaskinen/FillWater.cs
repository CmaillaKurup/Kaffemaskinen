using Kaffemaskinen.Interfaces;

namespace Kaffemaskinen
{
    //This class will be responsible for filling water on the machine
    public class FillWater : IFillWater
    {
        private bool water = false;

        public void WaterOn()
        {
            throw new System.NotImplementedException();
        }
    }
}