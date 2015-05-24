using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncButtonDemo.Caliburn
{
    public class MainViewModel
    {
        public void BadButtonOnClick()
        {
            BuggyCode();
        }

        public async Task AnotherBadButtonOnClick()
        {
            await BuggyCode();
        }

        public async void CorrectButtonOnClick()
        {
            await BuggyCode();
        }

        private async Task<bool> BuggyCode()
        {
            await Task.Factory.StartNew(() =>
            {
                Thread.Sleep(2000);
                throw new TimeoutException("Something bad happened.");
            });
            return false;
        }
    }
}
