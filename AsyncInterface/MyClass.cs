using System.Threading.Tasks;

namespace AsyncInterface
{
    interface IMyInterface
    {
        Task TurnScreenOn();
    }

    class MyClass : IMyInterface
    {
        public static async Task Main()
        {
            IMyInterface myInterface = new MyClass();
            await myInterface.TurnScreenOn();
        }

        public async Task TurnScreenOn()
        {
            await Task.Run(() => MyMethod());
        }

        private void MyMethod()
        {
            // do something clever here
        }
    }
}
