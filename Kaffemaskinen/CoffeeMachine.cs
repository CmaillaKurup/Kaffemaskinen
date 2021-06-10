using Kaffemaskinen.Interfaces;

//This is my machine
namespace Kaffemaskinen
{
    public class CoffeeMachine : IFillBeans, IFillWater, IInsertFilter
    {
        public bool CheckForBeans()
        {
            throw new System.NotImplementedException();
        }

        public bool CheckForWater()
        {
            throw new System.NotImplementedException();
        }

        public bool CheckForFilter()
        {
            throw new System.NotImplementedException();
        }
    }
}