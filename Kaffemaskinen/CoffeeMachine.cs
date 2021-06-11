//This is my machine
namespace Kaffemaskinen
{
    public class CoffeeMachine
    {
        private bool beans;
        private bool water;
        private bool filter;
        private bool electricity;
        private bool button;

        //incapsulation
        public bool Beans
        {
            get => beans;
            set => beans = value;
        }
        public bool Water
        {
            get => water;
            set => water = value;
        }

        public bool Filter
        {
            get => filter;
            set => filter = value;
        }

        public bool Electricity
        {
            get => electricity;
            set => electricity = value;
        }

        public bool Button
        {
            get => button;
            set => button = value;
        }
    }
}